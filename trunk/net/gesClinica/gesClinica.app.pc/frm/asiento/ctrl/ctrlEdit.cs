using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;
                if (newRecord)
                {
                    objVO = new Asiento();
                }
                else
                {
                    objVO = (Asiento)_vista.InnerVO;
                }

                objVO.Observaciones= _vista.txtObservaciones.Text;
                objVO.Fecha = _vista.dateFecha.Value;


                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            try
            {
                _vista = (frmEdit)frm;
                Asiento objVO = (Asiento)obj;

                _vista.InnerVO = objVO;

                _vista.dateFecha.Value = objVO.Fecha;
                _vista.txtObservaciones.Text = objVO.Observaciones;

                lib.bl.apunte.doGetAll lnApunte = new gesClinica.lib.bl.apunte.doGetAll(objVO);
                objVO.Apuntes = lnApunte.execute();
                _vista.dgApuntes.DataSource = objVO.Apuntes;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgApuntes.Columns)
                    col.Visible = false;

                _vista.dgApuntes.Columns["Concepto"].Visible = true;
                _vista.dgApuntes.Columns["Concepto"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgApuntes.Columns["Concepto"].ReadOnly = true;

                _vista.dgApuntes.Columns["SubCuenta"].Visible = true;
                _vista.dgApuntes.Columns["SubCuenta"].HeaderText = "SubC.";
                _vista.dgApuntes.Columns["SubCuenta"].ReadOnly = true;

                _vista.dgApuntes.Columns["Debe"].Visible = true;
                _vista.dgApuntes.Columns["Debe"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgApuntes.Columns["Debe"].DefaultCellStyle.Format = "c";
                _vista.dgApuntes.Columns["Debe"].ReadOnly = false;

                _vista.dgApuntes.Columns["Haber"].Visible = true;
                _vista.dgApuntes.Columns["Haber"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgApuntes.Columns["Haber"].DefaultCellStyle.Format = "c";
                _vista.dgApuntes.Columns["Haber"].ReadOnly = false;

                _vista.dgApuntes.ReadOnly = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEdit)frm;
                Asiento objVO = (Asiento)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.asiento.doAdd lnAsiento = new gesClinica.lib.bl.asiento.doAdd(objVO, null);
                    lnAsiento.execute();
                }
                else
                {
                    lib.bl.asiento.doUpdate lnAsiento = new gesClinica.lib.bl.asiento.doUpdate(objVO);
                    lnAsiento.execute();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmEdit)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(349, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(429, 11);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool dataError(ref frmEdit frm, System.Windows.Forms.DataGridViewDataErrorEventArgs e, out string msg)
        {
            try
            {
                bool res = true;

                _vista = (frmEdit)frm;

                if (_vista.dgApuntes.Columns[e.ColumnIndex].Name.ToLower() == "SubCuenta".ToLower())
                {
                    string text = _vista.dgApuntes[e.ColumnIndex, e.RowIndex].EditedFormattedValue.ToString();
                    lib.vo.SubCuenta subcuenta = new SubCuenta(text);
                    lib.bl.subcuenta.doGet lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGet(subcuenta);
                    subcuenta = lnSubCuenta.execute();
                    if (subcuenta == null)
                        msg = "El numero de SubCuenta no existe.";
                    else
                    {
                        _vista.dgApuntes[e.ColumnIndex, e.RowIndex].Value = subcuenta;
                        msg = "";
                        res = false;
                    }
                }
                else
                    msg = "Formato incorrecto!";

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
