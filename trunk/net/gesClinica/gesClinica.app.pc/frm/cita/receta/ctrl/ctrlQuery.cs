using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<Receta> listaVO = (List<Receta>)listObj;

                if (listaVO == null)
                    listaVO = new List<Receta>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(Receta).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Observaciones", typeof(string));
                dt.Columns.Add("Cita", typeof(gesClinica.lib.vo.Cita));
                dt.Columns.Add("objVO", typeof(Receta));

                foreach (Receta obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Observaciones"] = obj.Observaciones;
                    dr["Cita"] = obj.Cita;
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
                //Receta objVO = (Receta)this.getRegistroSeleccionado(ref frm);
                //lib.bl.receta.doDelete lnReceta = new gesClinica.lib.bl.receta.doDelete(objVO);
                //lnReceta.execute();

                Receta objVO = (Receta)this.getRegistroSeleccionado(ref frm);

                //Esta ventana sólo se abre desde la de producto.
                Cita cita = (Cita)((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.ParentForm).InnerVO;

                cita.Receta.Sort();
                int index = cita.Receta.BinarySearch(objVO);
                if (index > -1) cita.Receta.RemoveAt(index);

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
                //lib.bl.receta.doGetAll lnReceta = new gesClinica.lib.bl.receta.doGetAll();
                //List<Receta> ds = lnReceta.execute();

                Cita cita = (Cita)((gesClinica.app.pc.frm.cita.frmEditDatosClinicos)_vista.ParentForm).InnerVO;
                List<Receta> ds = cita.Receta;

                if (ds == null) ds = new List<Receta>();
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
                _vista.dgConsulta.Columns["Cita"].Visible = false;

                _vista.dgConsulta.Columns["Observaciones"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgConsulta.Columns["Cita"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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

                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.toolStripMenuSeparadorImprimir);
                _vista.dgConsulta.ContextMenuStrip.Items.Add(_vista.imprimirRecetaToolStripMenuItem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
