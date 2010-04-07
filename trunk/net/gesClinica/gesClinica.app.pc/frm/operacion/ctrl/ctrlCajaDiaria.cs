using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion.ctrl
{
    class ctrlCajaDiaria: template.frm.BaseCtrl
    {
        private frmCajaDiaria _vista = null;

        public override void inicializarForm(ref repsol.forms.template.BaseForm frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                _vista.dgOperaciones.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(dgOperaciones_CellPainting);

                _vista.monthCalendar.Date = DateTime.Now.Date;
                refreshData(ref _vista);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void dgOperaciones_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                    frmCajaDiaria frm = (frmCajaDiaria)dgv.FindForm();
                    if (frm!=null)
                    {
                        lib.vo.Operacion operacion = (lib.vo.Operacion)dgv.Rows[e.RowIndex].DataBoundItem;
                        if (operacion.Tipo == gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                        {
                            if ((operacion.Cita!=null) && (operacion.Cita.Empleado!=null))
                            {
                                lib.vo.Empleado empleado = operacion.Cita.Empleado;
                                dgv["Descripcion", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                                dgv["Adeudado", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                                if (operacion.Ingresos > 0)
                                    dgv["Ingresos", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color1);
                                if (operacion.Facturado) 
                                    dgv["FacturaAntigua", e.RowIndex].Style.BackColor = System.Drawing.Color.FromName(empleado.Color2);
                                System.Diagnostics.Debug.WriteLine(string.Format("[{0}, {1}]", e.RowIndex, e.ColumnIndex));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        public lib.bl._common.custom.ResumenFacturacion getResumenSeleccionado(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                if (_vista.dgFacturacionDetalle.CurrentRow == null)
                    return null;

                return (lib.bl._common.custom.ResumenFacturacion)_vista.dgFacturacionDetalle.CurrentRow.DataBoundItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public lib.vo.Operacion getOperacionSeleccionada(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                if (_vista.dgOperaciones.CurrentRow == null)
                    return null;

                return (lib.vo.Operacion)_vista.dgOperaciones.CurrentRow.DataBoundItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public lib.vo.Cita getCitaSeleccionada(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                if (_vista.dgCitasPendientes.CurrentRow == null)
                    return null;

                return (lib.vo.Cita)_vista.dgCitasPendientes.CurrentRow.DataBoundItem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool cajaAbierta(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                lib.bl.operacion.doCheckIfExists lnOperacion = new gesClinica.lib.bl.operacion.doCheckIfExists(gesClinica.lib.vo.tTIPOOPERACION.CAJA_INICIAL, _vista.monthCalendar.Date);
                return lnOperacion.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool puedeFacturar(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                return lib.bl._common.cache.EMPLEADO.Gerente && (this.getOperacionSeleccionada(frm)!=null) && this.getOperacionSeleccionada(frm).Tipo == gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE && !this.getOperacionSeleccionada(frm).Facturado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void refreshData(ref frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                #region Caja Diaria
                lib.bl.operacion.doGetAllPorFecha lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFecha(this._vista.monthCalendar.Date);
                List<lib.vo.Operacion> listOperacion = lnOperacion.execute();
                _vista.dgOperaciones.DataSource = listOperacion;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgOperaciones.Columns)
                    col.Visible = false;

                _vista.dgOperaciones.Columns["Descripcion"].Visible = true;
                _vista.dgOperaciones.Columns["Descripcion"].DisplayIndex = 0;
                _vista.dgOperaciones.Columns["Descripcion"].HeaderText= "Descripción";
                _vista.dgOperaciones.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgOperaciones.Columns["Descripcion"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgOperaciones.Columns["Adeudado"].Visible = true;
                _vista.dgOperaciones.Columns["Adeudado"].DisplayIndex = 1;
                _vista.dgOperaciones.Columns["Adeudado"].HeaderText = "Adeudado";
                _vista.dgOperaciones.Columns["Adeudado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperaciones.Columns["Adeudado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgOperaciones.Columns["Ingresos"].Visible = true;
                _vista.dgOperaciones.Columns["Ingresos"].DisplayIndex = 2;
                _vista.dgOperaciones.Columns["Ingresos"].HeaderText = "Ingresos";
                _vista.dgOperaciones.Columns["Ingresos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperaciones.Columns["Ingresos"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgOperaciones.Columns["Gastos"].Visible = true;
                _vista.dgOperaciones.Columns["Gastos"].DisplayIndex = 3;
                _vista.dgOperaciones.Columns["Gastos"].HeaderText = "Gastos";
                _vista.dgOperaciones.Columns["Gastos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgOperaciones.Columns["Gastos"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                if (lib.bl._common.cache.EMPLEADO.Gerente)
                {
                    _vista.dgOperaciones.Columns["FacturaAntigua"].Visible = true;
                    _vista.dgOperaciones.Columns["FacturaAntigua"].DisplayIndex = 4;
                    _vista.dgOperaciones.Columns["FacturaAntigua"].HeaderText = "Factura";
                    _vista.dgOperaciones.Columns["FacturaAntigua"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgOperaciones.Columns["FacturaAntigua"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                }

                _vista.dgOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgOperaciones.AllowUserToResizeRows = false;
                _vista.dgOperaciones.AllowUserToResizeColumns = false;
                _vista.dgOperaciones.RowHeadersVisible = false;
                _vista.dgOperaciones.AllowUserToAddRows = false;
                _vista.dgOperaciones.AllowUserToDeleteRows = false;
                _vista.dgOperaciones.AllowUserToOrderColumns = false;
                _vista.dgOperaciones.ReadOnly = true;
                _vista.dgOperaciones.MultiSelect = false;
                _vista.dgOperaciones.Select();
                #endregion

                #region Totales

                this._vista.dgTotales.Rows.Clear();
                this._vista.dgTotales.Columns.Clear();

                System.Windows.Forms.DataGridViewTextBoxColumn colText;

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.Name = "Descripcion";
                colText.HeaderText = "Descripción";
                colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                _vista.dgTotales.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 1;
                colText.HeaderText = "Adeudado";
                colText.Name= "Adeudado";
                colText.Width = _vista.dgOperaciones.Columns["Adeudado"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotales.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 2;
                colText.HeaderText = "Ingresos";
                colText.Name= "Ingresos";
                colText.Width = _vista.dgOperaciones.Columns["Ingresos"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotales.Columns.Add(colText);

                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = true;
                colText.DisplayIndex = 3;
                colText.HeaderText = "Gastos";
                colText.Name= "Gastos";
                colText.Width = _vista.dgOperaciones.Columns["Gastos"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotales.Columns.Add(colText);
                
                //System.Windows.Forms.DataGridViewCheckBoxColumn colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colText.Visible = (lib.bl._common.cache.EMPLEADO.Gerente);
                colText.HeaderText = "Factura";
                colText.Name = "FacturaAntigua";
                colText.Width = _vista.dgOperaciones.Columns["FacturaAntigua"].Width;
                //colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colText.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotales.Columns.Add(colText);

                float totalAdeudado = 0;
                float totalIngresos = 0;
                float totalGastos = 0;
                foreach (lib.vo.Operacion operacion in listOperacion)
                {
                    totalAdeudado += operacion.Adeudado;
                    totalIngresos += operacion.Ingresos;
                    totalGastos += operacion.Gastos;
                }
                this._vista.dgTotales.Rows.Add("Totales", totalAdeudado, totalIngresos, totalGastos, string.Empty);

                _vista.dgTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                _vista.dgTotales.AllowUserToResizeRows = false;
                _vista.dgTotales.AllowUserToResizeColumns = false;
                _vista.dgTotales.RowHeadersVisible = false;
                _vista.dgTotales.AllowUserToAddRows = false;
                _vista.dgTotales.AllowUserToDeleteRows = false;
                _vista.dgTotales.AllowUserToOrderColumns = false;
                _vista.dgTotales.ReadOnly = true;
                _vista.dgTotales.MultiSelect = false;
                _vista.dgTotales.TabStop = false;
                _vista.dgTotales.Enabled= false;
                _vista.dgTotales.CurrentCell = null;
                #endregion
                
                #region dgCitas


                lib.bl.cita.doGetAllPorFechaYNoFacturada lnCita = new gesClinica.lib.bl.cita.doGetAllPorFechaYNoFacturada(this._vista.monthCalendar.Date);
                List<lib.vo.Cita> listCita = lnCita.execute();

                _vista.dgCitasPendientes.DataSource = listCita;
                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgCitasPendientes.Columns)
                    col.Visible = false;

                _vista.dgCitasPendientes.Columns["Paciente"].Visible = true;
                _vista.dgCitasPendientes.Columns["Paciente"].DisplayIndex = 0;
                _vista.dgCitasPendientes.Columns["Paciente"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgCitasPendientes.Columns["Paciente"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgCitasPendientes.Columns["Terapia"].Visible = true;
                _vista.dgCitasPendientes.Columns["Terapia"].DisplayIndex = 1;
                _vista.dgCitasPendientes.Columns["Terapia"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgCitasPendientes.Columns["Terapia"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgCitasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgCitasPendientes.AllowUserToResizeRows = false;
                _vista.dgCitasPendientes.AllowUserToResizeColumns = false;
                _vista.dgCitasPendientes.RowHeadersVisible = false;
                _vista.dgCitasPendientes.AllowUserToAddRows = false;
                _vista.dgCitasPendientes.AllowUserToDeleteRows = false;
                _vista.dgCitasPendientes.AllowUserToOrderColumns = false;
                _vista.dgCitasPendientes.ReadOnly = true;
                _vista.dgCitasPendientes.MultiSelect = false;
                _vista.dgCitasPendientes.Refresh();
                _vista.dgCitasPendientes.Select();

                #endregion
                
                #region Facturacion


                    #region Facturacion. Detalle
                    lib.bl.operacion.doGetAllResumen lnResumen = new gesClinica.lib.bl.operacion.doGetAllResumen(this._vista.monthCalendar.Date);
                    List<lib.bl._common.custom.ResumenFacturacion> listResumen = lnResumen.execute();
                    _vista.dgFacturacionDetalle.DataSource = listResumen;

                    foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgFacturacionDetalle.Columns)
                        col.Visible = false;

                    _vista.dgFacturacionDetalle.Columns["Empleado"].Visible = true;
                    _vista.dgFacturacionDetalle.Columns["Empleado"].DisplayIndex = 0;
                    _vista.dgFacturacionDetalle.Columns["Empleado"].HeaderText = "Terapeuta";
                    _vista.dgFacturacionDetalle.Columns["Empleado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    _vista.dgFacturacionDetalle.Columns["Empleado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                    _vista.dgFacturacionDetalle.Columns["Generado"].Visible = true;
                    _vista.dgFacturacionDetalle.Columns["Generado"].DisplayIndex = 1;
                    _vista.dgFacturacionDetalle.Columns["Generado"].HeaderText = "Operaciones";
                    _vista.dgFacturacionDetalle.Columns["Generado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgFacturacionDetalle.Columns["Generado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionDetalle.Columns["Generado"].CellTemplate.Style.Format = "c";


                    _vista.dgFacturacionDetalle.Columns["Facturado"].Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    _vista.dgFacturacionDetalle.Columns["Facturado"].DisplayIndex = 2;
                    _vista.dgFacturacionDetalle.Columns["Facturado"].HeaderText = "Facturado";
                    _vista.dgFacturacionDetalle.Columns["Facturado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgFacturacionDetalle.Columns["Facturado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionDetalle.Columns["Facturado"].CellTemplate.Style.Format = "c";

                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].DisplayIndex = 3;
                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].HeaderText = "No Facturado";
                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionDetalle.Columns["NoFacturado"].CellTemplate.Style.Format = "c";

                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].DisplayIndex = 4;
                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].HeaderText = "Porcentaje";
                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionDetalle.Columns["Porcentaje"].CellTemplate.Style.Format = "p";

                    _vista.dgFacturacionDetalle.Columns["Comision"].Visible = true;
                    _vista.dgFacturacionDetalle.Columns["Comision"].DisplayIndex = 5;
                    _vista.dgFacturacionDetalle.Columns["Comision"].HeaderText = "Comisión";
                    _vista.dgFacturacionDetalle.Columns["Comision"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                    _vista.dgFacturacionDetalle.Columns["Comision"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionDetalle.Columns["Comision"].CellTemplate.Style.Format = "c";

                    _vista.dgFacturacionDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    _vista.dgFacturacionDetalle.AllowUserToResizeRows = false;
                    _vista.dgFacturacionDetalle.AllowUserToResizeColumns = false;
                    _vista.dgFacturacionDetalle.RowHeadersVisible = false;
                    _vista.dgFacturacionDetalle.AllowUserToAddRows = false;
                    _vista.dgFacturacionDetalle.AllowUserToDeleteRows = false;
                    _vista.dgFacturacionDetalle.AllowUserToOrderColumns = false;
                    _vista.dgFacturacionDetalle.ReadOnly = true;
                    _vista.dgFacturacionDetalle.MultiSelect = false;
                    _vista.dgFacturacionDetalle.Select();

                    #endregion

                    #region Facturacion. Total

                    this._vista.dgFacturacionTotal.Rows.Clear();
                    this._vista.dgFacturacionTotal.Columns.Clear();

                    System.Windows.Forms.DataGridViewTextBoxColumn colTextFactura;

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = true;
                    colTextFactura.Name = "Empleado";
                    colTextFactura.HeaderText = "Terapeuta";
                    colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = true;
                    colTextFactura.DisplayIndex = 1;
                    colTextFactura.HeaderText = "Operaciones";
                    colTextFactura.Name = "Generado";
                    colTextFactura.Width = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].Width;
                    colTextFactura.CellTemplate.Style.Format = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].CellTemplate.Style.Format;
                    //colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    colTextFactura.DisplayIndex = 2;
                    colTextFactura.HeaderText = "Facturado";
                    colTextFactura.Name = "Facturado";
                    colTextFactura.Width = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].Width;
                    colTextFactura.CellTemplate.Style.Format = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].CellTemplate.Style.Format;
                    //colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    colTextFactura.DisplayIndex = 3;
                    colTextFactura.HeaderText = "No Facturado";
                    colTextFactura.Name = "NoFacturado";
                    colTextFactura.Width = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].Width;
                    colTextFactura.CellTemplate.Style.Format = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].CellTemplate.Style.Format;
                    //colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = lib.bl._common.cache.EMPLEADO.Gerente;
                    colTextFactura.DisplayIndex = 4;
                    colTextFactura.HeaderText = "Porcentaje";
                    colTextFactura.Name = "Porcentaje";
                    colTextFactura.Width = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].Width;
                    colTextFactura.CellTemplate.Style.Format = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].CellTemplate.Style.Format;
                    //colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    colTextFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    colTextFactura.Visible = true;
                    colTextFactura.DisplayIndex = 5;
                    colTextFactura.HeaderText = "Comisión";
                    colTextFactura.Name = "Comision";
                    colTextFactura.Width = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].Width;
                    colTextFactura.CellTemplate.Style.Format = _vista.dgFacturacionDetalle.Columns[colTextFactura.Name].CellTemplate.Style.Format;
                    //colTextFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                    colTextFactura.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                    _vista.dgFacturacionTotal.Columns.Add(colTextFactura);

                    float totalFacturado = 0;
                    float totalGenerado = 0;
                    float totalComision = 0;
                    foreach (lib.bl._common.custom.ResumenFacturacion resumen in listResumen)
                    {
                        totalFacturado += resumen.Facturado;
                        totalGenerado += resumen.Generado;
                        totalComision += resumen.Comision;
                    }
                    this._vista.dgFacturacionTotal.Rows.Add("Total", totalGenerado, totalFacturado, totalGenerado - totalFacturado, totalGenerado != 0 ? totalFacturado / totalGenerado : 0, totalComision);

                    _vista.dgFacturacionTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                    _vista.dgFacturacionTotal.AllowUserToResizeRows = false;
                    _vista.dgFacturacionTotal.AllowUserToResizeColumns = false;
                    _vista.dgFacturacionTotal.RowHeadersVisible = false;
                    _vista.dgFacturacionTotal.AllowUserToAddRows = false;
                    _vista.dgFacturacionTotal.AllowUserToDeleteRows = false;
                    _vista.dgFacturacionTotal.AllowUserToOrderColumns = false;
                    _vista.dgFacturacionTotal.ReadOnly = true;
                    _vista.dgFacturacionTotal.MultiSelect = false;
                    _vista.dgFacturacionTotal.TabStop = false;
                    _vista.dgFacturacionTotal.Enabled = false;
                    _vista.dgFacturacionTotal.CurrentCell = null;

                    #endregion

                #endregion

                #region Liquidacion - Total por Tipo de Operacion

                #region Detalle
                //TODO: Aqui
                //lib.bl.operacion.doGetAllPorFecha lnOperacion = new gesClinica.lib.bl.operacion.doGetAllPorFecha(this._vista.monthCalendar.Date);
                List<lib.vo.Operacion> listTipoOperacion = getLiquidacionPorTipo(new List<lib.vo.Operacion>(listOperacion));
                _vista.dgTotalTipoOperacionDetalle.DataSource = listTipoOperacion;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgTotalTipoOperacionDetalle.Columns)
                    col.Visible = false;

                _vista.dgTotalTipoOperacionDetalle.Columns["Descripcion"].Visible = true;
                _vista.dgTotalTipoOperacionDetalle.Columns["Descripcion"].DisplayIndex = 0;
                _vista.dgTotalTipoOperacionDetalle.Columns["Descripcion"].HeaderText = "Descripción";
                _vista.dgTotalTipoOperacionDetalle.Columns["Descripcion"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgTotalTipoOperacionDetalle.Columns["Descripcion"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].Visible = true;
                _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].DisplayIndex = 1;
                _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].HeaderText = "Ingresos";
                _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].Visible = true;
                _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].DisplayIndex = 2;
                _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].HeaderText = "Gastos";
                _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].Visible = true;
                _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].DisplayIndex = 3;
                _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].HeaderText = "Saldo";
                _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgTotalTipoOperacionDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgTotalTipoOperacionDetalle.AllowUserToResizeRows = false;
                _vista.dgTotalTipoOperacionDetalle.AllowUserToResizeColumns = false;
                _vista.dgTotalTipoOperacionDetalle.RowHeadersVisible = false;
                _vista.dgTotalTipoOperacionDetalle.AllowUserToAddRows = false;
                _vista.dgTotalTipoOperacionDetalle.AllowUserToDeleteRows = false;
                _vista.dgTotalTipoOperacionDetalle.AllowUserToOrderColumns = false;
                _vista.dgTotalTipoOperacionDetalle.ReadOnly = true;
                _vista.dgTotalTipoOperacionDetalle.MultiSelect = false;
                _vista.dgTotalTipoOperacionDetalle.Select();
                #endregion

                #region Total

                this._vista.dgTotalTipoOperacionTotal.Rows.Clear();
                this._vista.dgTotalTipoOperacionTotal.Columns.Clear();

                System.Windows.Forms.DataGridViewTextBoxColumn colTextTotalTipoOperacion;

                colTextTotalTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalTipoOperacion.Visible = true;
                colTextTotalTipoOperacion.Name = "Descripcion";
                colTextTotalTipoOperacion.HeaderText = "Descripción";
                colTextTotalTipoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                colTextTotalTipoOperacion.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                _vista.dgTotalTipoOperacionTotal.Columns.Add(colTextTotalTipoOperacion);

                colTextTotalTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalTipoOperacion.Visible = true;
                colTextTotalTipoOperacion.DisplayIndex = 2;
                colTextTotalTipoOperacion.HeaderText = "Ingresos";
                colTextTotalTipoOperacion.Name = "Ingresos";
                colTextTotalTipoOperacion.Width = _vista.dgTotalTipoOperacionDetalle.Columns["Ingresos"].Width;
                //colTextTotalTipoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colTextTotalTipoOperacion.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotalTipoOperacionTotal.Columns.Add(colTextTotalTipoOperacion);

                colTextTotalTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalTipoOperacion.Visible = true;
                colTextTotalTipoOperacion.DisplayIndex = 3;
                colTextTotalTipoOperacion.HeaderText = "Gastos";
                colTextTotalTipoOperacion.Name = "Gastos";
                colTextTotalTipoOperacion.Width = _vista.dgTotalTipoOperacionDetalle.Columns["Gastos"].Width;
                //colTextTotalTipoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colTextTotalTipoOperacion.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotalTipoOperacionTotal.Columns.Add(colTextTotalTipoOperacion);

                colTextTotalTipoOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalTipoOperacion.Visible = true;
                colTextTotalTipoOperacion.DisplayIndex = 3;
                colTextTotalTipoOperacion.HeaderText = "Saldo";
                colTextTotalTipoOperacion.Name = "Saldo";
                colTextTotalTipoOperacion.Width = _vista.dgTotalTipoOperacionDetalle.Columns["Saldo"].Width;
                //colTextTotalTipoOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colTextTotalTipoOperacion.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotalTipoOperacionTotal.Columns.Add(colTextTotalTipoOperacion);

                float totalIngresosTotalTipoOperacionTotal = 0;
                float totalGastosTotalTipoOperacionTotal = 0;
                float totalSaldoTotalTipoOperacionTotal = 0;
                foreach (lib.vo.Operacion operacion in listTipoOperacion)
                {
                    totalIngresosTotalTipoOperacionTotal += operacion.Ingresos;
                    totalGastosTotalTipoOperacionTotal += operacion.Gastos;
                    totalSaldoTotalTipoOperacionTotal += operacion.Saldo;
                }
                this._vista.dgTotalTipoOperacionTotal.Rows.Add("Totales", totalIngresosTotalTipoOperacionTotal, totalGastosTotalTipoOperacionTotal, totalSaldoTotalTipoOperacionTotal);

                _vista.dgTotalTipoOperacionTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                _vista.dgTotalTipoOperacionTotal.AllowUserToResizeRows = false;
                _vista.dgTotalTipoOperacionTotal.AllowUserToResizeColumns = false;
                _vista.dgTotalTipoOperacionTotal.RowHeadersVisible = false;
                _vista.dgTotalTipoOperacionTotal.AllowUserToAddRows = false;
                _vista.dgTotalTipoOperacionTotal.AllowUserToDeleteRows = false;
                _vista.dgTotalTipoOperacionTotal.AllowUserToOrderColumns = false;
                _vista.dgTotalTipoOperacionTotal.ReadOnly = true;
                _vista.dgTotalTipoOperacionTotal.MultiSelect = false;
                _vista.dgTotalTipoOperacionTotal.TabStop = false;
                _vista.dgTotalTipoOperacionTotal.Enabled = false;
                _vista.dgTotalTipoOperacionTotal.CurrentCell = null;

                #endregion

                #endregion

                #region Liquidacion - Total por Forma Pago

                #region Detalle

                lib.bl.pago.doGetAllPorFecha lnPago = new gesClinica.lib.bl.pago.doGetAllPorFecha(this._vista.monthCalendar.Date);
                List<lib.vo.Pago> listFormaPago = getLiquidacionPorFormaPago(lnPago.execute());
                _vista.dgTotalFormaPagoDetalle.DataSource = listFormaPago;

                foreach (System.Windows.Forms.DataGridViewColumn col in _vista.dgTotalFormaPagoDetalle.Columns)
                    col.Visible = false;

                _vista.dgTotalFormaPagoDetalle.Columns["DescripcionPago"].Visible = true;
                _vista.dgTotalFormaPagoDetalle.Columns["DescripcionPago"].DisplayIndex = 0;
                _vista.dgTotalFormaPagoDetalle.Columns["DescripcionPago"].HeaderText = "Forma de Pago";
                _vista.dgTotalFormaPagoDetalle.Columns["DescripcionPago"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                _vista.dgTotalFormaPagoDetalle.Columns["DescripcionPago"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

                _vista.dgTotalFormaPagoDetalle.Columns["Importe"].Visible = true;
                _vista.dgTotalFormaPagoDetalle.Columns["Importe"].DisplayIndex = 1;
                _vista.dgTotalFormaPagoDetalle.Columns["Importe"].HeaderText = "Importe";
                _vista.dgTotalFormaPagoDetalle.Columns["Importe"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
                _vista.dgTotalFormaPagoDetalle.Columns["Importe"].CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

                _vista.dgTotalFormaPagoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                _vista.dgTotalFormaPagoDetalle.AllowUserToResizeRows = false;
                _vista.dgTotalFormaPagoDetalle.AllowUserToResizeColumns = false;
                _vista.dgTotalFormaPagoDetalle.RowHeadersVisible = false;
                _vista.dgTotalFormaPagoDetalle.AllowUserToAddRows = false;
                _vista.dgTotalFormaPagoDetalle.AllowUserToDeleteRows = false;
                _vista.dgTotalFormaPagoDetalle.AllowUserToOrderColumns = false;
                _vista.dgTotalFormaPagoDetalle.ReadOnly = true;
                _vista.dgTotalFormaPagoDetalle.MultiSelect = false;
                _vista.dgTotalFormaPagoDetalle.Select();
                #endregion

                #region Total

                this._vista.dgTotalFormaPagoTotal.Rows.Clear();
                this._vista.dgTotalFormaPagoTotal.Columns.Clear();

                System.Windows.Forms.DataGridViewTextBoxColumn colTextTotalFormaPago;

                colTextTotalFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalFormaPago.Visible = true;
                colTextTotalFormaPago.Name = "DescripcionPago";
                colTextTotalFormaPago.HeaderText = "Forma de Pago";
                colTextTotalFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                colTextTotalFormaPago.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                _vista.dgTotalFormaPagoTotal.Columns.Add(colTextTotalFormaPago);

                colTextTotalFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
                colTextTotalFormaPago.Visible = true;
                colTextTotalFormaPago.DisplayIndex = 1;
                colTextTotalFormaPago.HeaderText = "Importe";
                colTextTotalFormaPago.Name = "Importe";
                colTextTotalFormaPago.Width = _vista.dgTotalFormaPagoDetalle.Columns["Importe"].Width;
                //colTextTotalFormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
                colTextTotalFormaPago.CellTemplate.Style.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
                _vista.dgTotalFormaPagoTotal.Columns.Add(colTextTotalFormaPago);

                float totalIngresosTotalFormaPagoTotal = 0;
                foreach (lib.vo.Pago pago in listFormaPago)
                {
                    totalIngresosTotalFormaPagoTotal += pago.Importe;
                }
                this._vista.dgTotalFormaPagoTotal.Rows.Add("Totales", totalIngresosTotalFormaPagoTotal);

                _vista.dgTotalFormaPagoTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                _vista.dgTotalFormaPagoTotal.AllowUserToResizeRows = false;
                _vista.dgTotalFormaPagoTotal.AllowUserToResizeColumns = false;
                _vista.dgTotalFormaPagoTotal.RowHeadersVisible = false;
                _vista.dgTotalFormaPagoTotal.AllowUserToAddRows = false;
                _vista.dgTotalFormaPagoTotal.AllowUserToDeleteRows = false;
                _vista.dgTotalFormaPagoTotal.AllowUserToOrderColumns = false;
                _vista.dgTotalFormaPagoTotal.ReadOnly = true;
                _vista.dgTotalFormaPagoTotal.MultiSelect = false;
                _vista.dgTotalFormaPagoTotal.TabStop = false;
                _vista.dgTotalFormaPagoTotal.Enabled = false;
                _vista.dgTotalFormaPagoTotal.CurrentCell = null;

                #endregion

                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Calculo de la liquidacion

        private List<lib.vo.Operacion> getLiquidacionPorTipo(List<lib.vo.Operacion> listOperacion)
        {
            List<lib.vo.Operacion> res = new List<gesClinica.lib.vo.Operacion>();

            listOperacion.Sort(sortOperacionByTipo);
            if (listOperacion.Count > 0)
            {
                lib.vo.Operacion tmp = new gesClinica.lib.vo.Operacion(); ;
                tmp.Tipo = listOperacion[0].Tipo;
                lib.vo.tTIPOOPERACION tipo = tmp.Tipo;

                foreach (lib.vo.Operacion operacion in listOperacion)
                {
                    if (operacion.Tipo != tipo)
                    {
                        tipo = operacion.Tipo;
                        res.Add(tmp);
                        
                        tmp = new gesClinica.lib.vo.Operacion();
                        tmp.Tipo = tipo;
                        tmp.Debe = operacion.Debe;
                        tmp.Haber = operacion.Haber;
                    }
                    else
                    {
                        tmp.Debe += operacion.Debe;
                        tmp.Haber += operacion.Haber;
                    }
                }
                res.Add(tmp);
            }

            return res;
        }

        private int sortOperacionByTipo(lib.vo.Operacion one, lib.vo.Operacion two)
        {
            return one.Tipo.CompareTo(two.Tipo);
        }

        private List<lib.vo.Pago> getLiquidacionPorFormaPago(List<lib.vo.Pago> listPago)
        {
            List<lib.vo.Pago> res = new List<gesClinica.lib.vo.Pago>();

            listPago.Sort(sortPagoByFormaPago);
            if (listPago.Count > 0)
            {
                lib.vo.Pago tmp = new gesClinica.lib.vo.Pago(); ;
                tmp.FormaPago = listPago[0].FormaPago;
                tmp.Operacion = listPago[0].Operacion;
                lib.vo.FormaPago formaPago = tmp.FormaPago;
                lib.vo.Operacion operacion = tmp.Operacion;

                string descripcionPago = tmp.DescripcionPago;

                foreach (lib.vo.Pago pago in listPago)
                {
                    //if (pago.FormaPago.ID != formaPago.ID)
                    if (pago.DescripcionPago != descripcionPago)
                    {
                        formaPago = pago.FormaPago;
                        operacion = pago.Operacion;

                        descripcionPago = pago.DescripcionPago;
                        res.Add(tmp);

                        tmp = new gesClinica.lib.vo.Pago();
                        tmp.FormaPago = formaPago;
                        tmp.Operacion = operacion;
                        tmp.Importe = pago.Importe;
                    }
                    else
                    {
                        tmp.Importe += pago.Importe;
                    }
                }
                res.Add(tmp);
            }

            return res;
        }

        private int sortPagoByFormaPago(lib.vo.Pago one, lib.vo.Pago two)
        {
            return one.DescripcionPago.CompareTo(two.DescripcionPago);
            //return one.FormaPago.ID.CompareTo(two.FormaPago.ID);
        }

        #endregion

        public void generarRecibo(lib.vo.Cita cita)
        {
            try
            {
                lib.bl.operacion.doGenerate lnOperacionGenerate = new gesClinica.lib.bl.operacion.doGenerate(cita);
                lib.bl.operacion.doAdd lnOperacionAdd = new gesClinica.lib.bl.operacion.doAdd(lnOperacionGenerate.execute());
                lnOperacionAdd.execute();
                //template._common.messages.ShowInfo("Recibo generado", "Recibos");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void anularFactura(lib.vo.Operacion operacion)
        {
            try
            {
                lib.bl.factura.doAnular lnFactura = new gesClinica.lib.bl.factura.doAnular(operacion);
                lnFactura.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public lib.vo.Factura obtenerFacturaAsociada(lib.vo.Operacion operacion)
        {
            try
            {
                lib.bl.factura.doGetPorOperacion lnFactura = new gesClinica.lib.bl.factura.doGetPorOperacion(operacion);
                return lnFactura.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool BorrarRegistro(ref frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;
                lib.vo.Operacion objVO = (lib.vo.Operacion)this.getOperacionSeleccionada(frm);
                lib.bl.operacion.doDelete lnOperacion = new gesClinica.lib.bl.operacion.doDelete(objVO);
                lnOperacion.execute();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public lib.vo.tTIPOOPERACION getTipoOperacionSeleccionada(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                return ((lib.vo.Operacion)this.getOperacionSeleccionada(frm)).Tipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DateTime _fechaOperacion;
        private bool filterPagosByFecha(lib.vo.Pago pago)
        {
            return _fechaOperacion.Date.CompareTo(pago.Fecha.Date)==0;
        }
        public lib.vo.Pago getPagoOperacionSeleccionada(frmCajaDiaria frm)
        {
            try
            {
                _vista = (frmCajaDiaria)frm;

                lib.vo.Pago res = null;

                lib.vo.Operacion operacion = (lib.vo.Operacion)this.getOperacionSeleccionada(frm);
                if (operacion.Debe != 0)
                {
                    lib.bl.pago.doGetAllPorOperacion lnPago = new gesClinica.lib.bl.pago.doGetAllPorOperacion(operacion);
                    List<lib.vo.Pago> pagos = lnPago.execute();
                    _fechaOperacion = operacion.Fecha;
                    pagos = pagos.FindAll(filterPagosByFecha);
                    if (pagos.Count > 0)
                        res = pagos[0];
                }

                return res;
                //return ((lib.vo.Operacion)this.getOperacionSeleccionada(frm)).Tipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public lib.vo.Paciente getPaciente(lib.vo.Operacion operacion)
        {
            try
            {
                lib.bl.paciente.doGet lnPaciente = new gesClinica.lib.bl.paciente.doGet(operacion.Cita.Paciente);
                return lnPaciente.execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void VerCajas(lib.bl._common.custom.ResumenFacturacion resumenSeleccionado)
        {
            try
            {
                List<lib.bl._common.custom.ResumenFacturacion> listResumen = (List<lib.bl._common.custom.ResumenFacturacion>)_vista.dgFacturacionDetalle.DataSource;
                float cajaA = 0;
                float cajaB = 0;
                foreach (lib.bl._common.custom.ResumenFacturacion resumen in listResumen)
                {
                    if (resumen.Empleado.ID == resumenSeleccionado.Empleado.ID)
                    {
                        cajaA += resumen.Facturado;
                        cajaB += resumen.Generado - resumen.Facturado;
                    }
                    else
                    {
                        cajaA += 0;
                        cajaB += resumen.Generado - resumen.Comision;
                    }
                }
                StringBuilder strB = new StringBuilder();
                strB.AppendLine(string.Format("Caja A:\t{0:c}", cajaA));
                strB.AppendLine();
                strB.AppendLine(string.Format("Caja B:\t{0:c}", cajaB));
                System.Windows.Forms.MessageBox.Show(strB.ToString(), string.Format("Resumen de Cajas - {0}",resumenSeleccionado.Empleado.ToString()), System.Windows.Forms.MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
