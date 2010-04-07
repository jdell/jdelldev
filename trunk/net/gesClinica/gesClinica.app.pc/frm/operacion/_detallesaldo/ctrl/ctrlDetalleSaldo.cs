using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion._detallesaldo.ctrl
{
    class ctrlDetalleSaldo:template.frm.BaseCtrl
    {
        private frmDetalleSaldo _vista;
        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmDetalleSaldo)frm;

                #region Operacion
                //lib.bl.operacion.doGetAllPorPaciente lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorPaciente(this._vista.Paciente);
                //List<lib.vo.Operacion> listOperacion = lnOperacion.execute();
                List<lib.vo.Operacion> listOperacion = _vista.Paciente.Operaciones;
                listOperacion.Sort(sortOperacionFecha);
                _vista.dgOperacionDetalle.DataSource = listOperacion;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgOperacionDetalle.Columns)
                    col.Visible = false;

                _vista.dgOperacionDetalle.Columns["Fecha"].Visible = true;
                _vista.dgOperacionDetalle.Columns["Fecha"].DisplayIndex = 0;
                _vista.dgOperacionDetalle.Columns["Fecha"].HeaderText = "Fecha";
                _vista.dgOperacionDetalle.Columns["Fecha"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperacionDetalle.Columns["Fecha"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgOperacionDetalle.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

                _vista.dgOperacionDetalle.Columns["Descripcion"].Visible = true;
                _vista.dgOperacionDetalle.Columns["Descripcion"].DisplayIndex = 1;
                _vista.dgOperacionDetalle.Columns["Descripcion"].HeaderText = "Descripción";
                _vista.dgOperacionDetalle.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgOperacionDetalle.Columns["Descripcion"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgOperacionDetalle.Columns["Adeudado"].Visible = true;
                _vista.dgOperacionDetalle.Columns["Adeudado"].DisplayIndex = 2;
                _vista.dgOperacionDetalle.Columns["Adeudado"].HeaderText = "Adeudado";
                _vista.dgOperacionDetalle.Columns["Adeudado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperacionDetalle.Columns["Adeudado"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgOperacionDetalle.Columns["Ingresos"].Visible = true;
                _vista.dgOperacionDetalle.Columns["Ingresos"].DisplayIndex = 3;
                _vista.dgOperacionDetalle.Columns["Ingresos"].HeaderText = "Ingresos";
                _vista.dgOperacionDetalle.Columns["Ingresos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperacionDetalle.Columns["Ingresos"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgOperacionDetalle.Columns["Deuda"].Visible = true;
                _vista.dgOperacionDetalle.Columns["Deuda"].DisplayIndex = 4;
                _vista.dgOperacionDetalle.Columns["Deuda"].HeaderText = "Saldo";
                _vista.dgOperacionDetalle.Columns["Deuda"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperacionDetalle.Columns["Deuda"].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgOperacionDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgOperacionDetalle.AllowUserToResizeRows = false;
                _vista.dgOperacionDetalle.AllowUserToResizeColumns = false;
                _vista.dgOperacionDetalle.RowHeadersVisible = false;
                _vista.dgOperacionDetalle.AllowUserToAddRows = false;
                _vista.dgOperacionDetalle.AllowUserToDeleteRows = false;
                _vista.dgOperacionDetalle.AllowUserToOrderColumns = false;
                _vista.dgOperacionDetalle.ReadOnly = true;
                _vista.dgOperacionDetalle.MultiSelect = false;
                _vista.dgOperacionDetalle.Select();
                #endregion

                #region Totales

                this._vista.dgOperacionTotal.Rows.Clear();
                this._vista.dgOperacionTotal.Columns.Clear();

                System.Windows.Forms.DataGridViewTextBoxColumn colText;

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.Name = "Descripcion";
                colText.HeaderText = "Descripción";
                colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                _vista.dgOperacionTotal.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 1;
                colText.HeaderText = "Adeudado";
                colText.Name = "Adeudado";
                colText.Width = _vista.dgOperacionDetalle.Columns["Adeudado"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgOperacionTotal.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 2;
                colText.HeaderText = "Ingresos";
                colText.Name = "Ingresos";
                colText.Width = _vista.dgOperacionDetalle.Columns["Ingresos"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgOperacionTotal.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 3;
                colText.HeaderText = "Saldo";
                colText.Name = "Deuda";
                colText.Width = _vista.dgOperacionDetalle.Columns["Deuda"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgOperacionTotal.Columns.Add(colText);

                float totalAdeudado = 0;
                float totalIngresos = 0;
                float totalGastos = 0;
                foreach (lib.vo.Operacion operacion in listOperacion)
                {
                    totalAdeudado += operacion.Adeudado;
                    totalIngresos += operacion.Ingresos;
                    totalGastos += -operacion.Deuda;
                }
                this._vista.dgOperacionTotal.Rows.Add("Totales", totalAdeudado, totalIngresos, totalGastos, false);

                _vista.dgOperacionTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                _vista.dgOperacionTotal.AllowUserToResizeRows = false;
                _vista.dgOperacionTotal.AllowUserToResizeColumns = false;
                _vista.dgOperacionTotal.RowHeadersVisible = false;
                _vista.dgOperacionTotal.AllowUserToAddRows = false;
                _vista.dgOperacionTotal.AllowUserToDeleteRows = false;
                _vista.dgOperacionTotal.AllowUserToOrderColumns = false;
                _vista.dgOperacionTotal.ReadOnly = true;
                _vista.dgOperacionTotal.MultiSelect = false;
                _vista.dgOperacionTotal.TabStop = false;
                _vista.dgOperacionTotal.Enabled = false;
                _vista.dgOperacionTotal.CurrentCell = null;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int sortOperacionFecha(lib.vo.Operacion one, lib.vo.Operacion two)
        {
            return -one.Fecha.CompareTo(two.Fecha);
        }
    }
}
