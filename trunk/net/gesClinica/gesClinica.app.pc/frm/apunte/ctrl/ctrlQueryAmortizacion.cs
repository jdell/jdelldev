using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.apunte.ctrl
{
    internal class ctrlQueryAmortizacion:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQueryAmortizacion _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Apunte> listaVO = (List<Apunte>)listObj;

                if (listaVO == null)
                    listaVO = new List<Apunte>();

                listaVO.Sort(sortApunteByFecha);

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Apunte).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns.Add("Subcuenta", typeof(SubCuenta));
                dt.Columns.Add("Concepto", typeof(string));
                dt.Columns.Add("Importe", typeof(float));
                //dt.Columns.Add("Haber", typeof(float));
                dt.Columns.Add("Saldo", typeof(float));
                dt.Columns.Add("objVO", typeof(Apunte));

                float acumulado = 0;

                foreach (Apunte obj in listaVO)
                {
                    acumulado += obj.Debe;

                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Fecha"] = obj.Fecha;
                    dr["Subcuenta"] = obj.SubCuenta;
                    dr["Concepto"] = obj.Concepto;
                    dr["Importe"] = obj.Debe;
                    //dr["Haber"] = obj.Haber;
                    dr["Saldo"] = acumulado;
                    dr["objVO"] = obj;

                    dt.Rows.Add(dr);
                }

                res.Table = dt;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortApunteByFecha(Apunte one, Apunte two)
        {
            return one.Fecha.CompareTo(two.Fecha);
        }

        public override object BorrarRegistro(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;
                Apunte objVO = (Apunte)this.getRegistroSeleccionado(ref frm);
                lib.bl.apunte.doDelete lnApunte = new gesClinica.lib.bl.apunte.doDelete(objVO);
                lnApunte.execute();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void ConsultaRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;
                List<Apunte> ds = null;
                if (_vista.cmbEjercicio.SelectedItem != null)
                {
                    lib.bl.apunte.doGetAllAmortizaciones lnApunte = new gesClinica.lib.bl.apunte.doGetAllAmortizaciones((Ejercicio)_vista.cmbEjercicio.SelectedItem);
                    ds = lnApunte.execute();
                }
                if (ds == null) ds = new List<Apunte>();
                this._vista.dgConsulta.DataSource = this.ListVOToDataView(ds);

                this._vista.dgConsulta.Select();
                this.setEstiloGridRegistros(ref frm);
                this.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override object DataGridViewRowToVO(System.Windows.Forms.DataGridViewRow dr)
        {
            try
            {
                return dr.Cells["objVO"].Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void filtrarRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;
                string filtro = "(1=1)";
                
                //***************************

                //***************************
                
                this.filtrarDV(frm, filtro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override object getRegistroSeleccionado(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;

                if (_vista.dgConsulta.CurrentRow == null)
                    return null;

                return this.DataGridViewRowToVO(_vista.dgConsulta.CurrentRow);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void setEstiloGridRegistros(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;

                _vista.dgConsulta.Columns["Subcuenta"].HeaderText = "SubC.";

                _vista.dgConsulta.Columns["Importe"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Importe"].DefaultCellStyle.Format = "c";

                _vista.dgConsulta.Columns["Saldo"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgConsulta.Columns["Saldo"].DefaultCellStyle.Format = "c";

                _vista.dgConsulta.Columns["Concepto"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
                _vista = (frmQueryAmortizacion)frm;

                _vista.menuFiltrar.Enabled = true;
                _vista.chkVerFiltro.Checked = true;
                _vista.menuFiltrar.Checked = true;

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
        public void loadEjercicio(ref frmQueryAmortizacion frm)
        {
            try
            {
                _vista = (frmQueryAmortizacion)frm;

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
                    else
                    {
                        repsol.forms.template.consulta.QueryForm qry = (repsol.forms.template.consulta.QueryForm)frm;
                        ConsultaRegistros(ref qry);
                    }
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
