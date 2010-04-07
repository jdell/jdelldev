using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.operacion
{
    internal class frmQueryRazonSocial:template.frm.consulta.QueryForm
    {
        internal System.Windows.Forms.ContextMenuStrip contextMenuCaja;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarEImprimirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFacturaAsocidadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anularFacturaToolStripMenuItem;
        internal gesClinica.app.pc.template.controls.MonthCalendar monthCalendar;
        //private System.ComponentModel.IContainer components;
    
        public frmQueryRazonSocial():base(true)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar = new gesClinica.app.pc.template.controls.MonthCalendar();
            this.contextMenuCaja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarEImprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.verFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFacturaAsocidadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.anularFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.contextMenuCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Location = new System.Drawing.Point(189, 50);
            this.panDetail.Size = new System.Drawing.Size(603, 523);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(189, 25);
            this.panInfo.Size = new System.Drawing.Size(603, 25);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.monthCalendar);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Left;
            this.panHead.Size = new System.Drawing.Size(189, 548);
            // 
            // labNRegistros
            // 
            this.labNRegistros.Size = new System.Drawing.Size(603, 25);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Date = new System.DateTime(2008, 7, 30, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(1u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 3;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 437;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(189, 548);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.Text = "monthCalendar1";
            this.monthCalendar.VisibleHeight = 437;
            this.monthCalendar.DateChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // contextMenuCaja
            // 
            this.contextMenuCaja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem});
            this.contextMenuCaja.Name = "contextMenuCaja";
            this.contextMenuCaja.Size = new System.Drawing.Size(153, 48);
            this.contextMenuCaja.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCaja_Opening);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem,
            this.generarEImprimirFacturaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.verFacturaToolStripMenuItem,
            this.modificarFacturaAsocidadaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.anularFacturaToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generarFacturaToolStripMenuItem.Text = "Generar Factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // generarEImprimirFacturaToolStripMenuItem
            // 
            this.generarEImprimirFacturaToolStripMenuItem.Name = "generarEImprimirFacturaToolStripMenuItem";
            this.generarEImprimirFacturaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generarEImprimirFacturaToolStripMenuItem.Text = "Imprimir Factura Asociada";
            this.generarEImprimirFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarEImprimirFacturaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // verFacturaToolStripMenuItem
            // 
            this.verFacturaToolStripMenuItem.Name = "verFacturaToolStripMenuItem";
            this.verFacturaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.verFacturaToolStripMenuItem.Text = "Ver Factura Asociada";
            this.verFacturaToolStripMenuItem.Click += new System.EventHandler(this.verFacturaToolStripMenuItem_Click);
            // 
            // modificarFacturaAsocidadaToolStripMenuItem
            // 
            this.modificarFacturaAsocidadaToolStripMenuItem.Name = "modificarFacturaAsocidadaToolStripMenuItem";
            this.modificarFacturaAsocidadaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.modificarFacturaAsocidadaToolStripMenuItem.Text = "Modificar Factura Asociada";
            this.modificarFacturaAsocidadaToolStripMenuItem.Click += new System.EventHandler(this.modificarFacturaAsocidadaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // anularFacturaToolStripMenuItem
            // 
            this.anularFacturaToolStripMenuItem.Name = "anularFacturaToolStripMenuItem";
            this.anularFacturaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.anularFacturaToolStripMenuItem.Text = "Anular Factura";
            this.anularFacturaToolStripMenuItem.Click += new System.EventHandler(this.anularFacturaToolStripMenuItem_Click);
            // 
            // frmQueryRazonSocial
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQueryRazonSocial";
            this.Text = "Operaciones por Razón Social";
            this.Load += new System.EventHandler(this.frmoperacionQry_Load);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
            this.contextMenuCaja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void btNuevo_record()
        {
            try
            {
                throw new Exception("No implementado");
                //frmEdit vVen = new frmEdit();
                //vVen.ShowDialog();
                //btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btModificar_record()
        {
            try
            {

                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Operacion)ctrl.getRegistroSeleccionado(ref frm), false);
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btConsulta_record()
        {
            try
            {

                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Operacion)ctrl.getRegistroSeleccionado(ref frm), true);
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btDuplicar_record()
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Operacion)ctrl.getRegistroSeleccionado(ref frm));
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        protected override void btBorrar_record()
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if ((bool)ctrl.BorrarRegistro(ref frm))
                        btRefresh_record();
                    else
                        template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        public override void btRefresh_record()
        {
            //try
            //{
            //    this.setError(string.Empty);

            //    ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
            //    repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
            //    ctrl.saveSelectedRow(frm);
            //    ctrl.ConsultaRegistros(ref frm);
            //    ctrl.loadSelectedRow(frm);
            //}
            //catch (Exception ex)
            //{
            //    //template._common.messages.ShowError(ex);
            //    this.setError(ex.Message);
            //}

        }
        protected override void btSeleccionar_record()
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                this.SetSeletectedVO(ctrl.getRegistroSeleccionado(ref frm));

                base.btSeleccionar_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmoperacionQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void filtrar_Handler(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;

                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit((Operacion)ctrl.getRegistroSeleccionado(ref frm));
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void generarEImprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;

                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmPrint vVen = new gesClinica.app.pc.frm.factura.frmPrint(ctrl.obtenerFacturaAsociada((Operacion)ctrl.getRegistroSeleccionado(ref frm)));
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;

                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit(ctrl.obtenerFacturaAsociada((Operacion)ctrl.getRegistroSeleccionado(ref frm)), true);
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void modificarFacturaAsocidadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;

                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit(ctrl.obtenerFacturaAsociada((Operacion)ctrl.getRegistroSeleccionado(ref frm)), false);
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;

                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Seguro que desea anular esta factura? El número de factura no será recuperado.", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    ctrl.anularFactura((Operacion)ctrl.getRegistroSeleccionado(ref frm));
                    RefreshData();
                }

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void RefreshData()
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void contextMenuCaja_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ctrl.ctrlQueryRazonSocial ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlQueryRazonSocial();
                frmQueryRazonSocial frm = (frmQueryRazonSocial)this;
                this.generarFacturaToolStripMenuItem.Enabled = ctrl.puedeFacturar(frm);
                this.generarEImprimirFacturaToolStripMenuItem.Enabled = !this.generarFacturaToolStripMenuItem.Enabled;
                this.anularFacturaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;
                this.verFacturaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;
                this.modificarFacturaAsocidadaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
