using System;
using System.Collections.Generic;
using System.Text;

using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm._resumenfiscal.ctrl
{
    class ctrlPrint:template.frm.impresion.ctrl.PrintCtrl
    {
        private frmPrint _vista;

        public override void imprimir(ref repsol.forms.template.informe.ReportForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;
                
                if (_vista.cmbEjercicio.SelectedItem != null)
                {
                    _vista.viewer.Reset();
                    //TODO: Ejercicio + Trimestre
                    lib.bl._reports.resumenfiscal.rptModelo130 informe = new gesClinica.lib.bl._reports.resumenfiscal.rptModelo130((Ejercicio)_vista.cmbEjercicio.SelectedItem, (gesClinica.lib.bl._common.custom.tTRIMESTRE)_vista.cmbTrimestre.SelectedValue);
                    Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                    informe.setInformeViewer(ref viewer);
                    _vista.viewer.RefreshReport();
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
                _vista = (frmPrint)frm;

                _vista.cmbTrimestre.DataSource = lib.common.funciones.EnumHelper.ToList(typeof(lib.bl._common.custom.tTRIMESTRE));
                _vista.cmbTrimestre.DisplayMember = "Value";
                _vista.cmbTrimestre.ValueMember = "Key";

                // ********************* Razón Social *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                List<Empresa> listEmpresa = lnEmpresa.execute();
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
        public void loadEjercicio(ref frmPrint frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                if (_vista.cmbEmpresa.SelectedItem != null)
                {
                    // ********************* Ejercicio *********************
                    gesClinica.lib.bl.ejercicio.doGetAll lnEjercicio = new gesClinica.lib.bl.ejercicio.doGetAll((Empresa)_vista.cmbEmpresa.SelectedItem);
                    List<Ejercicio> listEjercicio = lnEjercicio.execute();
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
        private int sortEjercicio(Ejercicio one, Ejercicio two)
        {
            return -one.Descripcion.CompareTo(two.Descripcion);
        }
    }
}
