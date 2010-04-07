using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento.ctrl
{
    internal class ctrlEditOperacionGasto : template.frm.edicion.ctrl.EditCtrl
    {
        frmEditOperacionGasto _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Asiento objVO = null;

                Apunte apunteProveedor = null;
                Apunte apunteGasto = null;

                if (newRecord)
                {
                    objVO = new Asiento();

                    objVO.Apuntes = new List<Apunte>();
                    objVO.Apuntes.Add(new Apunte());
                    objVO.Apuntes.Add(new Apunte());
                }
                else
                    objVO = (Asiento)_vista.InnerVO;

                objVO.Fecha = _vista.dateFecha.Value;
                objVO.Observaciones = _vista.txtConcepto.Text;
                objVO.TipoAsiento = tTIPOASIENTO.FACTURA_RECIBIDA;

                apunteProveedor = objVO.Apuntes[0];
                apunteGasto = objVO.Apuntes[1];

                apunteProveedor.Concepto = _vista.txtConcepto.Text;
                apunteGasto.Concepto = _vista.txtConcepto.Text;

                apunteProveedor.Haber = Convert.ToSingle(_vista.txtImporte.Text);
                apunteGasto.Debe = Convert.ToSingle(_vista.txtImporte.Text);

                apunteProveedor.SubCuenta = (SubCuenta)_vista.cmbSubcuentaHaber.SelectedItem;
                apunteGasto.SubCuenta = (SubCuenta)_vista.cmbSubcuentaDebe.SelectedItem;

                apunteProveedor.ContraPartida = apunteGasto.SubCuenta;
                apunteGasto.ContraPartida = apunteProveedor.SubCuenta;

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
                _vista = (frmEditOperacionGasto)frm;
                Asiento objVO = (Asiento)obj;

                _vista.InnerVO = objVO;

                //_vista.txtConcepto.Text = objVO.Concepto;

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
                _vista = (frmEditOperacionGasto)frm;
                Asiento objVO = (Asiento)getObject(ref frm, newRecord);
                Empresa empresa = (Empresa)_vista.cmbRazonSocial.SelectedItem;
                if (newRecord)
                {
                    lib.bl.asiento.doAdd lnAsiento = new gesClinica.lib.bl.asiento.doAdd(objVO, empresa);
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
                _vista = (frmEditOperacionGasto)frm;

                _vista.Aceptar.Location = new System.Drawing.Point(280, 11);
                _vista.Cancelar.Location = new System.Drawing.Point(360, 11);

                _vista.Text = "Operación Contable - Gasto";
                _vista.labLabelUno.Text = "Proveedor";
                _vista.labLabelDos.Text = "Gasto";
                _vista.txtConcepto.Text = "S/F nº ";

                gesClinica.lib.bl.subcuenta.doGetAllByTipo lnSubCuenta;

                // ********************* Proveedor *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.PROVEEDOR);
                _vista.cmbSubcuentaHaber.DataSource = lnSubCuenta.execute();
                _vista.cmbSubcuentaHaber.DisplayMember = "FullName";
                _vista.cmbSubcuentaHaber.ValueMember = "Codigo";
                _vista.cmbSubcuentaHaber.SelectedIndex = -1;

                // ********************* Gasto *********************
                lnSubCuenta = new gesClinica.lib.bl.subcuenta.doGetAllByTipo(gesClinica.lib.bl._common.custom.tSUBCUENTA.GASTO);
                _vista.cmbSubcuentaDebe.DataSource = lnSubCuenta.execute();
                _vista.cmbSubcuentaDebe.DisplayMember = "FullName";
                _vista.cmbSubcuentaDebe.ValueMember = "Codigo";
                _vista.cmbSubcuentaDebe.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
