using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.paciente.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Paciente> listaVO = (List<Paciente>)listObj;

                if (listaVO == null)
                    listaVO = new List<Paciente>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Paciente).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("NIF", typeof(string));
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Telefonos", typeof(string));
                dt.Columns.Add("Tarifa", typeof(string));
                dt.Columns.Add("Aviones", typeof(string));
                dt.Columns.Add("objVO", typeof(Paciente));

                foreach (Paciente obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["NIF"] = obj.NIF;
                    dr["FullName"] = obj.FullName;
                    dr["Sexo"] = obj.Sexo;
                    dr["Telefonos"] = obj.Telefonos;
                    dr["Tarifa"] = obj.Tarifa;
                    dr["Aviones"] = obj.Aviones;
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
                Paciente objVO = (Paciente)this.getRegistroSeleccionado(ref frm);
                lib.bl.paciente.doDelete lnPaciente = new gesClinica.lib.bl.paciente.doDelete(objVO);
                lnPaciente.execute();

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
                _vista = (frmQuery)frm;
                lib.bl.paciente.doGetAll lnPaciente = new gesClinica.lib.bl.paciente.doGetAll();
                List<Paciente> ds = lnPaciente.execute();
                if (ds == null) ds = new List<Paciente>();
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
                
                //***************************

                //******* NIF ********
                string nif = gesClinica.lib.common.funciones.filter.parseString(_vista.txtNIF.Text);
                filtro += string.Format(" AND ((nif like '%{0}%') or (''='{0}')) ", nif);

                //******* Nombre ********
                string nombre = gesClinica.lib.common.funciones.filter.parseString(_vista.txtNombre.Text);
                foreach (string cad in nombre.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((fullname like '%{0}%') or (''='{0}')) ", cad);

                //******* Telefonos ********
                string telefonos = gesClinica.lib.common.funciones.filter.parseString(_vista.txtTelefonos.Text);
                foreach (string cad in telefonos.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                    filtro += string.Format(" AND ((telefonos like '%{0}%') or (''='{0}')) ", cad);

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
                _vista.dgConsulta.Columns["Aviones"].Visible = false;

                _vista.dgConsulta.Columns["FullName"].HeaderText = "Paciente";

                _vista.dgConsulta.Columns["NIF"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["FullName"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Sexo"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Telefonos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Tarifa"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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

                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.separadorHistorial);
                if (lib.bl._common.cache.EMPLEADO.Terapeuta)
                    _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.verHistorialMédicoToolStripMenuItem);
                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.verCitasToolStripMenuItem);

                _vista.dgConsulta.CellPainting +=new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgConsulta_CellPainting);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgConsulta_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                    repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)dgv.FindForm();
                    if (frm != null)
                    {
                        lib.vo.Paciente paciente = (lib.vo.Paciente)this.getRegistroSeleccionado(ref frm);
                        if (paciente.Aviones!=0)
                        {
                            //foreach (System.Windows.Forms.DataGridViewColumn c in dgv.Columns)
                            //{
                            //    dgv[c.Name, e.RowIndex].Style.BackColor = System.Drawing.Color.SeaShell;
                            //}
//                            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.SeaShell;

                            dgv[e.ColumnIndex, e.RowIndex].Style.BackColor = System.Drawing.Color.SeaShell;

                            //if ((operacion.Cita != null) && (operacion.Cita.Empleado != null))
                            //{
                            //    lib.vo.Empleado empleado = operacion.Cita.Empleado;
                            //    dgv["Descripcion", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                            //    dgv["Adeudado", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                            //    if (operacion.Ingresos > 0)
                            //        dgv["Ingresos", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                            //    if (operacion.Facturado)
                            //        dgv["FacturaAntigua", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color2);
                            //    System.Diagnostics.Debug.WriteLine(string.Format("[{0}, {1}]", e.RowIndex, e.ColumnIndex));
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
