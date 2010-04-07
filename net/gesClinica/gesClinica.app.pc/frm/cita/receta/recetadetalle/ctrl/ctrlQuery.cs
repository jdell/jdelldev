﻿using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita.receta.recetadetalle.ctrl
{
    internal class ctrlQuery:template.frm.consulta.ctrl.QueryCtrl
    {
        frmQuery _vista = null;

        protected override System.Data.DataView ListVOToDataView(object listObj)
        {
            try
            {
                System.Data.DataView res = new System.Data.DataView();
                List<RecetaDetalle> listaVO = (List<RecetaDetalle>)listObj;

                if (listaVO == null)
                    listaVO = new List<RecetaDetalle>();

                System.Data.DataTable dt = new System.Data.DataTable(typeof(RecetaDetalle).FullName);
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Producto", typeof(gesClinica.lib.vo.Producto));
                dt.Columns.Add("Posologia", typeof(string));
                dt.Columns.Add("objVO", typeof(RecetaDetalle));

                foreach (RecetaDetalle obj in listaVO)
                {
                    System.Data.DataRow dr = dt.NewRow();
                    dr["ID"] = obj.ID;
                    dr["Cantidad"] = obj.Cantidad;
                    dr["Producto"] = obj.Producto;
                    dr["Posologia"] = obj.Posologia;
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
                RecetaDetalle objVO = (RecetaDetalle)this.getRegistroSeleccionado(ref frm);

                //Esta ventana sólo se abre desde la de receta.
                Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.ParentForm).InnerVO;

                receta.Detalle.Sort();
                int index = receta.Detalle.BinarySearch(objVO);
                if (index > -1) receta.Detalle.RemoveAt(index);

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
                //TODO: Docked!
                //lib.bl.recetadetalle.doGetAll lnRecetaDetalle = new gesClinica.lib.bl.recetadetalle.doGetAll();
                //List<RecetaDetalle> ds = lnRecetaDetalle.execute();

                //Esta ventana sólo se abre desde la de receta.
                Receta receta = (Receta)((gesClinica.app.pc.frm.cita.receta.frmEditEmitirReceta)_vista.ParentForm).InnerVO;
                List<RecetaDetalle> ds = receta.Detalle;
                if (ds == null) ds = new List<RecetaDetalle>();
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

                _vista.dgConsulta.Columns["Cantidad"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgConsulta.Columns["Producto"].Width = 400;
                _vista.dgConsulta.Columns["Posologia"].Width = 500;
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}