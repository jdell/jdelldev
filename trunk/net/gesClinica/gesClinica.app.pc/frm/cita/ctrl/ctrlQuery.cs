using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Cita> listaVO = (List<Cita>)listObj;

                if (listaVO == null)
                    listaVO = new List<Cita>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Cita).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Fecha", typeof(DateTime));
                dt.Columns.Add("Terapia", typeof(string));
                dt.Columns.Add("Paciente", typeof(string));
                dt.Columns.Add("Empleado", typeof(string));
                dt.Columns.Add("Sala", typeof(string));
                dt.Columns.Add("EstadoCita", typeof(EstadoCita));
                dt.Columns.Add("objVO", typeof(Cita));

                foreach (Cita obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Fecha"] = obj.Fecha;
                    dr["Terapia"] = obj.Terapia;
                    dr["Paciente"] = obj.Paciente;
                    dr["Empleado"] = obj.Empleado;
                    dr["Sala"] = obj.Sala;
                    dr["EstadoCita"] = obj.EstadoCita;
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

        public override object BorrarRegistro(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                Cita objVO = (Cita)this.getRegistroSeleccionado(ref frm);
                lib.bl.cita.doDelete lnCita = new gesClinica.lib.bl.cita.doDelete(objVO);
                lnCita.execute();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public lib.vo.filtro.FiltroCita getFiltroCita(ref repsol.forms.template.consulta.QueryForm frm)
        {
            try
            {
                _vista = (frmQuery)frm;
                return new gesClinica.lib.vo.filtro.FiltroCita((lib.vo.Sala)_vista.cmbSala.SelectedItem, (lib.vo.Empleado)_vista.cmbEmpleado.SelectedItem, _vista.dateFecha.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setFiltroCita(ref repsol.forms.template.consulta.QueryForm frm, lib.vo.filtro.FiltroCita filtroCita)
        {
            try
            {
                _vista = (frmQuery)frm;

                //_vista.dateFecha.Value = filtroCita.Fecha;
                if (filtroCita.Empleado != null)
                    _vista.cmbEmpleado.SelectedValue = filtroCita.Empleado.ID;
                if (filtroCita.Sala != null)
                    _vista.cmbSala.SelectedValue = filtroCita.Sala.ID;
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
                _vista = (frmQuery)frm;
                lib.bl.cita.doGetAll lnCita = new gesClinica.lib.bl.cita.doGetAll(this.getFiltroCita(ref frm));
                List<Cita> ds = lnCita.execute();
                if (ds == null) ds = new List<Cita>();
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
                _vista = (frmQuery)frm;
                string filtro = "(1=1)";

                ////***************************
                ////******* SALA ********
                //if (_vista.cmbSala.SelectedItem != null)
                //{
                //    string sala = _vista.cmbSala.SelectedItem.ToString();
                //    filtro += string.Format(" AND ((sala like '%{0}%') or (''='{0}')) ", sala);
                //}
                ////******* EMPLEADO ********
                //if (_vista.cmbEmpleado.SelectedItem != null)
                //{
                //    string empleado = _vista.cmbEmpleado.SelectedItem.ToString();
                //    filtro += string.Format(" AND ((empleado like '%{0}%') or (''='{0}')) ", empleado);
                //}

                //DateTime fecha = _vista.dateFecha.Value;
                //filtro += string.Format(" AND ((fecha>='{0}') and (fecha <'{1}')) ", fecha.Date, fecha.Date.AddDays(1));
                
                ////***************************
                
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
                _vista = (frmQuery)frm;

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
                _vista = (frmQuery)frm;
                _vista.dgConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;

                _vista.dgConsulta.Columns["objVO"].Visible = false;
                _vista.dgConsulta.Columns["ID"].Visible = false;

                _vista.dgConsulta.Columns["EstadoCita"].HeaderText = "Estado";
                _vista.dgConsulta.Columns["Empleado"].HeaderText = "Terapeuta";

                _vista.dgConsulta.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Terapia"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Paciente"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Empleado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Sala"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["EstadoCita"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
                _vista = (frmQuery)frm;
                _vista.menuFiltrar.Enabled = true;
                _vista.chkVerFiltro.Checked = true;//_vista.Modal;
                _vista.menuFiltrar.Checked = true;

                // ********************* Empleado *********************
                gesClinica.lib.bl.empleado.doGetAllTerapeutas lnEmpleado = new gesClinica.lib.bl.empleado.doGetAllTerapeutas();
                List<Empleado> listEmpleado = lnEmpleado.execute();
                listEmpleado.Insert(0, new Empleado());
                _vista.cmbEmpleado.DataSource = listEmpleado;
                _vista.cmbEmpleado.DisplayMember = "FullName";
                _vista.cmbEmpleado.ValueMember = "ID";
                _vista.cmbEmpleado.SelectedIndex = 0;

                // ********************* Sala *********************
                gesClinica.lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                List<Sala> listSala = lnSala.execute();
                listSala.Insert(0, new Sala());
                _vista.cmbSala.DataSource = listSala;
                _vista.cmbSala.DisplayMember = "Descripcion";
                _vista.cmbSala.ValueMember = "ID";
                _vista.cmbSala.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
