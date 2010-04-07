using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.empresa.ctrl
{
    internal class ctrlEdit: template.frm.edicion.ctrl.EditCtrl
    {
        frmEdit _vista = null;

        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                Empresa objVO = null;
                if (newRecord)
                {
                    objVO = new Empresa();
                }
                else
                {
                    objVO = (Empresa)_vista.InnerVO;
                }

                objVO.RazonSocial = _vista.txtRazonSocial.Text;

                objVO.FacturaFormato = (lib.vo.tFORMATOFACTURA)_vista.cmbFacturaFormato.SelectedValue;
                objVO.FacturaConcepto = _vista.txtFacturaConcepto.Text;
                objVO.FacturaCliente= _vista.txtFacturaCliente.Text;
                objVO.FacturaIva= Convert.ToInt32(_vista.txtFacturaIVA.Text);
                
                objVO.CIF= _vista.txtCIF.Text;
                objVO.Direccion= _vista.txtDireccion.Text;
                objVO.OtrosDatos= _vista.txtOtrosDatos.Text;

                objVO.ContabilizarFactura = _vista.chkcontabilizarFactura.Checked;

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
                Empresa objVO = (Empresa)obj;

                _vista.InnerVO = objVO;

                _vista.txtRazonSocial.Text = objVO.RazonSocial;

                _vista.txtFacturaCliente.Text = objVO.FacturaCliente;
                _vista.txtFacturaConcepto.Text = objVO.FacturaConcepto;
                _vista.txtFacturaIVA.Text = objVO.FacturaIva.ToString();
                _vista.cmbFacturaFormato.SelectedValue = objVO.FacturaFormato;

                _vista.txtCIF.Text = objVO.CIF;
                _vista.txtDireccion.Text = objVO.Direccion;
                _vista.txtOtrosDatos.Text = objVO.OtrosDatos;

                _vista.chkcontabilizarFactura.Checked = objVO.ContabilizarFactura;

                #region Ejercicioes
                lib.bl.ejercicio.doGetAll lnEjercicio = new gesClinica.lib.bl.ejercicio.doGetAll(objVO);
                List<lib.vo.Ejercicio> listEjercicio = lnEjercicio.execute();
                listEjercicio.Sort(sortEjercicio);
                _vista.dgEjercicio.DataSource = listEjercicio;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgEjercicio.Columns)
                    col.Visible = false;

                _vista.dgEjercicio.Columns["Descripcion"].Visible = true;
                _vista.dgEjercicio.Columns["Descripcion"].DisplayIndex = 0;
                _vista.dgEjercicio.Columns["Descripcion"].HeaderText = "Ejercicio";
                //_vista.dgEjercicio.Columns["Año"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode;
                _vista.dgEjercicio.Columns["Descripcion"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

                _vista.dgEjercicio.Columns["UltimaFacturaEmitida"].Visible = true;
                _vista.dgEjercicio.Columns["UltimaFacturaEmitida"].DisplayIndex = 1;
                _vista.dgEjercicio.Columns["UltimaFacturaEmitida"].HeaderText = "Facturas Emitidas";
                //_vista.dgEjercicio.Columns["UltimaFacturaEmitida"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgEjercicio.Columns["UltimaFacturaEmitida"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                
                _vista.dgEjercicio.Columns["UltimaFacturaRecibida"].Visible = true;
                _vista.dgEjercicio.Columns["UltimaFacturaRecibida"].DisplayIndex = 2;
                _vista.dgEjercicio.Columns["UltimaFacturaRecibida"].HeaderText = "Facturas Recibidas";
                //_vista.dgEjercicio.Columns["Numero"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgEjercicio.Columns["UltimaFacturaRecibida"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgEjercicio.Columns["UltimoAsiento"].Visible = true;
                _vista.dgEjercicio.Columns["UltimoAsiento"].DisplayIndex = 3;
                _vista.dgEjercicio.Columns["UltimoAsiento"].HeaderText = "Asientos";
                //_vista.dgEjercicio.Columns["UltimoAsiento"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgEjercicio.Columns["UltimoAsiento"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgEjercicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                _vista.dgEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgEjercicio.AllowUserToResizeRows = false;
                _vista.dgEjercicio.AllowUserToResizeColumns = false;
                _vista.dgEjercicio.RowHeadersVisible = false;
                _vista.dgEjercicio.AllowUserToAddRows = false;
                _vista.dgEjercicio.AllowUserToDeleteRows = false;
                _vista.dgEjercicio.AllowUserToOrderColumns = false;
                _vista.dgEjercicio.ReadOnly = true;
                _vista.dgEjercicio.MultiSelect = false;
                _vista.dgEjercicio.Enabled = true;
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortEjercicio(lib.vo.Ejercicio one, lib.vo.Ejercicio other)
        {
            return one.Descripcion.CompareTo(other.Descripcion);
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmEdit)frm;
                Empresa objVO = (Empresa)getObject(ref frm, newRecord);
                if (newRecord)
                {
                    lib.bl.empresa.doAdd lnEmpresa = new gesClinica.lib.bl.empresa.doAdd(objVO);
                    lnEmpresa.execute();
                }
                else
                {
                    lib.bl.empresa.doUpdate lnEmpresa = new gesClinica.lib.bl.empresa.doUpdate(objVO);
                    lnEmpresa.execute();
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

                _vista.cmbFacturaFormato.DataSource = lib.common.funciones.EnumHelper.ToList(typeof(lib.vo.tFORMATOFACTURA));
                _vista.cmbFacturaFormato.DisplayMember = "Value";
                _vista.cmbFacturaFormato.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
