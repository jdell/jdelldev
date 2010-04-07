using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._contabilizar.ctrl
{
    class ctrlContabilizar:template.frm.edicion.ctrl.EditCtrl
    {
        frmContabilizar _vista = null;
        public override object getObject(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void cargarDatos(ref repsol.forms.template.edicion.EditForm frm, object obj)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public override void guardarDatos(ref repsol.forms.template.edicion.EditForm frm, bool newRecord)
        {
            try
            {
                _vista = (frmContabilizar)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                if (_vista.rbContabilizar.Checked)
                {
                    lib.bl.factura.doContabilizar lnFactura = new gesClinica.lib.bl.factura.doContabilizar(_vista.dateFechaDesde.Value, _vista.dateFechaHasta.Value, (lib.vo.Empresa)this._vista.cmbEmpresa.SelectedItem);
                    int nFacturas = lnFactura.execute();
                    template._common.messages.ShowInfo(string.Format("{0} {1}", nFacturas, nFacturas == 1 ? "factura contabilizada" : "facturas contabilizadas"), _vista.Text);
                }
                else
                {
                    lib.bl.factura.doDesContabilizar lnFactura = new gesClinica.lib.bl.factura.doDesContabilizar(_vista.dateFechaDesde.Value, _vista.dateFechaHasta.Value, (lib.vo.Empresa)this._vista.cmbEmpresa.SelectedItem);
                    int nFacturas = lnFactura.execute();
                    template._common.messages.ShowInfo(string.Format("{0} {1}", nFacturas, nFacturas == 1 ? "factura descontabilizada" : "facturas descontabilizadas"), _vista.Text);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _vista.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmContabilizar)frm;

                // ********************* Razón Social *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                List<lib.vo.Empresa> listEmpresa = lnEmpresa.execute();
                //listEmpresa.Sort(sortEmpresa);
                _vista.cmbEmpresa.DataSource = listEmpresa;
                _vista.cmbEmpresa.DisplayMember = "RazonSocial";
                _vista.cmbEmpresa.ValueMember = "ID";
                _vista.cmbEmpresa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
