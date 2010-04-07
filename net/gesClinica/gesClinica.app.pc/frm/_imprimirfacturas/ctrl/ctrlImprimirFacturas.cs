using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._imprimirfacturas.ctrl
{
    class ctrlImprimirFacturas:template.frm.edicion.ctrl.EditCtrl
    {
        frmImprimirFacturas _vista = null;
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
                _vista = (frmImprimirFacturas)frm;
                _vista.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                if (_vista.cmbEjercicio.SelectedItem != null)
                {
                    lib.bl.factura.doGetAllForPrint lnFactura = new gesClinica.lib.bl.factura.doGetAllForPrint((lib.vo.Ejercicio)_vista.cmbEjercicio.SelectedItem, Convert.ToInt32(_vista.txtNumeroDesde.Text), Convert.ToInt32(_vista.txtNumeroHasta.Text));
                    List<lib.vo.Factura> facturas = lnFactura.execute();

                    factura.frmPrint vVen = new gesClinica.app.pc.frm.factura.frmPrint(facturas, ((lib.vo.Empresa)_vista.cmbEmpresa.SelectedItem).FacturaFormato);
                    vVen.MdiParent = _vista.MdiParent;
                    vVen.Show();
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
                _vista = (frmImprimirFacturas)frm;

                // ********************* Raz�n Social *********************
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

        public void loadEjercicio(ref frmImprimirFacturas frm)
        {
            try
            {
                _vista = (frmImprimirFacturas)frm;

                if (_vista.cmbEmpresa.SelectedItem != null)
                {
                    // ********************* Ejercicio *********************
                    gesClinica.lib.bl.ejercicio.doGetAll lnEjercicio = new gesClinica.lib.bl.ejercicio.doGetAll((lib.vo.Empresa)_vista.cmbEmpresa.SelectedItem);
                    List<lib.vo.Ejercicio> listEjercicio = lnEjercicio.execute();
                    listEjercicio.Sort(sortEjercicio);
                    _vista.cmbEjercicio.DataSource = listEjercicio;
                    _vista.cmbEjercicio.DisplayMember = "Descripcion";
                    _vista.cmbEjercicio.ValueMember = "ID";
                    if (_vista.cmbEjercicio.Items.Count > 0)
                        _vista.cmbEjercicio.SelectedIndex = 0;
                }
                else
                    _vista.cmbEjercicio.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int sortEjercicio(lib.vo.Ejercicio one, lib.vo.Ejercicio two)
        {
            return -one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}