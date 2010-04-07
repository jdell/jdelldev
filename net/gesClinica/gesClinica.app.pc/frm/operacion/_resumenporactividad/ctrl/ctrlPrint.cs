using System;
using System.Collections.Generic;
using System.Text;

using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion._resumenporactividad.ctrl
{
    class ctrlPrint:template.frm.impresion.ctrl.PrintCtrl
    {
        private frmPrint _vista;

        public override void imprimir(ref repsol.forms.template.informe.ReportForm frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                _vista.viewer.Reset();
                Ejercicio ejercicio = (Ejercicio)_vista.cmbEjercicio.SelectedItem;
                Empleado empleado = (Empleado)_vista.cmbTerapeuta.SelectedItem;

                lib.bl._reports.resumenporactividad.rptResumenPorActividad informe = new gesClinica.lib.bl._reports.resumenporactividad.rptResumenPorActividad(ejercicio, empleado);
                Microsoft.Reporting.WinForms.ReportViewer viewer = _vista.viewer;
                informe.setInformeViewer(ref viewer);
                _vista.viewer.RefreshReport();
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

                // ********************* Razón Social *********************
                gesClinica.lib.bl.empresa.doGetAll lnEmpresa = new gesClinica.lib.bl.empresa.doGetAll();
                List<Empresa> listEmpresa = lnEmpresa.execute();
                //listEmpresa.Sort(sortEmpresa);
                _vista.cmbEmpresa.DataSource = listEmpresa;
                _vista.cmbEmpresa.DisplayMember = "RazonSocial";
                _vista.cmbEmpresa.ValueMember = "ID";
                if (_vista.cmbEmpresa.Items.Count > 0)
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

        public void loadTerapeuta(ref frmPrint frm)
        {
            try
            {
                _vista = (frmPrint)frm;

                if (_vista.cmbEmpresa.SelectedItem != null)
                {

                    // ********************* Terapeuta *********************
                    gesClinica.lib.bl.empleado.doGetAllPorEmpresa lnEmpleado = new gesClinica.lib.bl.empleado.doGetAllPorEmpresa((Empresa)_vista.cmbEmpresa.SelectedItem);
                    List<Empleado> listEmpleado = lnEmpleado.execute();
                    _vista.cmbTerapeuta.DataSource = listEmpleado;
                    _vista.cmbTerapeuta.DisplayMember = "FullName";
                    _vista.cmbTerapeuta.ValueMember = "ID";
                    if (_vista.cmbTerapeuta.Items.Count > 0)
                        _vista.cmbTerapeuta.SelectedIndex = 0;
                }
                else
                    _vista.cmbTerapeuta.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
