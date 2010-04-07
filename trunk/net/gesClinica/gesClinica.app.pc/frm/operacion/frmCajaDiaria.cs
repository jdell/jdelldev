using System;
using System.Collections.Generic;
using System.Text;


namespace gesClinica.app.pc.frm.operacion
{
    class frmCajaDiaria:template.frm.BaseForm
    {
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.TabControl tabCaja;
        private System.Windows.Forms.TabPage tpageOperacionesDia;
        internal System.Windows.Forms.TabPage tpageFacturacion;
        internal System.Windows.Forms.DataGridView dgOperaciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuCaja;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem generarOperacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator facturasSeparadortoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarEImprimirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem anularFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoTerapeutasToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        internal System.Windows.Forms.DataGridView dgTotales;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.TabPage tpageCitasPendientes;
        internal System.Windows.Forms.DataGridView dgCitasPendientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuCitasPendientes;
        private System.Windows.Forms.ToolStripMenuItem generarReciboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarFacturaAsocidadaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer3;
        internal System.Windows.Forms.DataGridView dgFacturacionDetalle;
        internal System.Windows.Forms.DataGridView dgFacturacionTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuFacturacion;
        private System.Windows.Forms.ToolStripMenuItem imprimirReciboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirDetalleFacturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroFueraDeCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem anularOperaciónToolStripMenuItem;
        private System.Windows.Forms.TabPage tpageLiquidacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        internal System.Windows.Forms.DataGridView dgTotalFormaPagoDetalle;
        internal System.Windows.Forms.DataGridView dgTotalFormaPagoTotal;
        private System.Windows.Forms.SplitContainer splitContainer4;
        internal System.Windows.Forms.DataGridView dgTotalTipoOperacionDetalle;
        internal System.Windows.Forms.DataGridView dgTotalTipoOperacionTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modificarImporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCalculadora;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem verFichaDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistorialClínicoToolStripMenuItem;
        private System.Windows.Forms.TabPage tpageLiquidacionReport;
        private Microsoft.Reporting.WinForms.ReportViewer viewerLiquidacion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem verCajasToolStripMenuItem;
        internal gesClinica.app.pc.template.controls.MonthCalendar monthCalendar;
    
        public frmCajaDiaria()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajaDiaria));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar = new gesClinica.app.pc.template.controls.MonthCalendar();
            this.tabCaja = new System.Windows.Forms.TabControl();
            this.tpageOperacionesDia = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgOperaciones = new System.Windows.Forms.DataGridView();
            this.contextMenuCaja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generarOperacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoTerapeutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroFueraDeCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.anularOperaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarImporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasSeparadortoolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarEImprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.verFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFacturaAsocidadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.anularFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.verFichaDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialClínicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgTotales = new System.Windows.Forms.DataGridView();
            this.tpageCitasPendientes = new System.Windows.Forms.TabPage();
            this.dgCitasPendientes = new System.Windows.Forms.DataGridView();
            this.contextMenuCitasPendientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generarReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpageFacturacion = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgFacturacionDetalle = new System.Windows.Forms.DataGridView();
            this.contextMenuFacturacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimirReciboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirDetalleFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgFacturacionTotal = new System.Windows.Forms.DataGridView();
            this.tpageLiquidacion = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dgTotalFormaPagoDetalle = new System.Windows.Forms.DataGridView();
            this.dgTotalFormaPagoTotal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dgTotalTipoOperacionDetalle = new System.Windows.Forms.DataGridView();
            this.dgTotalTipoOperacionTotal = new System.Windows.Forms.DataGridView();
            this.tpageLiquidacionReport = new System.Windows.Forms.TabPage();
            this.viewerLiquidacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCalculadora = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.verCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCaja.SuspendLayout();
            this.tpageOperacionesDia.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperaciones)).BeginInit();
            this.contextMenuCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotales)).BeginInit();
            this.tpageCitasPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCitasPendientes)).BeginInit();
            this.contextMenuCitasPendientes.SuspendLayout();
            this.tpageFacturacion.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacionDetalle)).BeginInit();
            this.contextMenuFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacionTotal)).BeginInit();
            this.tpageLiquidacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalFormaPagoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalFormaPagoTotal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalTipoOperacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalTipoOperacionTotal)).BeginInit();
            this.tpageLiquidacionReport.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabCaja);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(846, 581);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Date = new System.DateTime(2008, 7, 30, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(1u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 4;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 569;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(172, 581);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Text = "monthCalendar1";
            this.monthCalendar.VisibleHeight = 569;
            this.monthCalendar.DateChanged += new System.EventHandler(this.monthCalendar_DateChanged);
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.tpageOperacionesDia);
            this.tabCaja.Controls.Add(this.tpageCitasPendientes);
            this.tabCaja.Controls.Add(this.tpageFacturacion);
            this.tabCaja.Controls.Add(this.tpageLiquidacion);
            this.tabCaja.Controls.Add(this.tpageLiquidacionReport);
            this.tabCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCaja.Location = new System.Drawing.Point(0, 25);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.SelectedIndex = 0;
            this.tabCaja.Size = new System.Drawing.Size(670, 556);
            this.tabCaja.TabIndex = 0;
            this.tabCaja.SelectedIndexChanged += new System.EventHandler(this.tabCaja_SelectedIndexChanged);
            // 
            // tpageOperacionesDia
            // 
            this.tpageOperacionesDia.Controls.Add(this.splitContainer2);
            this.tpageOperacionesDia.Location = new System.Drawing.Point(4, 22);
            this.tpageOperacionesDia.Name = "tpageOperacionesDia";
            this.tpageOperacionesDia.Padding = new System.Windows.Forms.Padding(3);
            this.tpageOperacionesDia.Size = new System.Drawing.Size(662, 530);
            this.tpageOperacionesDia.TabIndex = 0;
            this.tpageOperacionesDia.Text = "Operaciones del dia";
            this.tpageOperacionesDia.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgOperaciones);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgTotales);
            this.splitContainer2.Size = new System.Drawing.Size(656, 524);
            this.splitContainer2.SplitterDistance = 495;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgOperaciones
            // 
            this.dgOperaciones.AllowUserToAddRows = false;
            this.dgOperaciones.AllowUserToDeleteRows = false;
            this.dgOperaciones.AllowUserToResizeColumns = false;
            this.dgOperaciones.AllowUserToResizeRows = false;
            this.dgOperaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOperaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperaciones.ContextMenuStrip = this.contextMenuCaja;
            this.dgOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOperaciones.Location = new System.Drawing.Point(0, 0);
            this.dgOperaciones.Name = "dgOperaciones";
            this.dgOperaciones.RowHeadersVisible = false;
            this.dgOperaciones.Size = new System.Drawing.Size(656, 495);
            this.dgOperaciones.TabIndex = 0;
            this.dgOperaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            this.dgOperaciones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgOperaciones_MouseDoubleClick);
            // 
            // contextMenuCaja
            // 
            this.contextMenuCaja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarOperacionToolStripMenuItem,
            this.facturasSeparadortoolStripMenuItem1,
            this.pagosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.toolStripMenuItem5,
            this.verFichaDelPacienteToolStripMenuItem,
            this.verHistorialClínicoToolStripMenuItem});
            this.contextMenuCaja.Name = "contextMenuCaja";
            this.contextMenuCaja.Size = new System.Drawing.Size(191, 126);
            this.contextMenuCaja.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuCaja_Opening);
            // 
            // generarOperacionToolStripMenuItem
            // 
            this.generarOperacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCajaToolStripMenuItem,
            this.pagoTerapeutasToolStripMenuItem,
            this.otrosPagosToolStripMenuItem,
            this.cobroFueraDeCitaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.anularOperaciónToolStripMenuItem,
            this.toolStripMenuItem4,
            this.modificarImporteToolStripMenuItem});
            this.generarOperacionToolStripMenuItem.Name = "generarOperacionToolStripMenuItem";
            this.generarOperacionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.generarOperacionToolStripMenuItem.Text = "Generar operacion";
            // 
            // abrirCajaToolStripMenuItem
            // 
            this.abrirCajaToolStripMenuItem.Name = "abrirCajaToolStripMenuItem";
            this.abrirCajaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.abrirCajaToolStripMenuItem.Text = "Abrir Caja";
            this.abrirCajaToolStripMenuItem.Click += new System.EventHandler(this.abrirCajaToolStripMenuItem_Click);
            // 
            // pagoTerapeutasToolStripMenuItem
            // 
            this.pagoTerapeutasToolStripMenuItem.Name = "pagoTerapeutasToolStripMenuItem";
            this.pagoTerapeutasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pagoTerapeutasToolStripMenuItem.Text = "Pago Terapeutas";
            this.pagoTerapeutasToolStripMenuItem.Click += new System.EventHandler(this.pagoTerapeutasToolStripMenuItem_Click);
            // 
            // otrosPagosToolStripMenuItem
            // 
            this.otrosPagosToolStripMenuItem.Name = "otrosPagosToolStripMenuItem";
            this.otrosPagosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.otrosPagosToolStripMenuItem.Text = "Otros Pagos";
            this.otrosPagosToolStripMenuItem.Click += new System.EventHandler(this.otrosPagosToolStripMenuItem_Click);
            // 
            // cobroFueraDeCitaToolStripMenuItem
            // 
            this.cobroFueraDeCitaToolStripMenuItem.Name = "cobroFueraDeCitaToolStripMenuItem";
            this.cobroFueraDeCitaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cobroFueraDeCitaToolStripMenuItem.Text = "Cobro Fuera de Cita";
            this.cobroFueraDeCitaToolStripMenuItem.Click += new System.EventHandler(this.cobroFueraDeCitaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(179, 6);
            // 
            // anularOperaciónToolStripMenuItem
            // 
            this.anularOperaciónToolStripMenuItem.Name = "anularOperaciónToolStripMenuItem";
            this.anularOperaciónToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.anularOperaciónToolStripMenuItem.Text = "Anular Operación";
            this.anularOperaciónToolStripMenuItem.Click += new System.EventHandler(this.anularOperaciónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
            // 
            // modificarImporteToolStripMenuItem
            // 
            this.modificarImporteToolStripMenuItem.Name = "modificarImporteToolStripMenuItem";
            this.modificarImporteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificarImporteToolStripMenuItem.Text = "Modificar Importe";
            this.modificarImporteToolStripMenuItem.Click += new System.EventHandler(this.modificarImporteToolStripMenuItem_Click);
            // 
            // facturasSeparadortoolStripMenuItem1
            // 
            this.facturasSeparadortoolStripMenuItem1.Name = "facturasSeparadortoolStripMenuItem1";
            this.facturasSeparadortoolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPagoToolStripMenuItem,
            this.verPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pagosToolStripMenuItem.Text = "Pagos de Pacientes";
            // 
            // nuevoPagoToolStripMenuItem
            // 
            this.nuevoPagoToolStripMenuItem.Name = "nuevoPagoToolStripMenuItem";
            this.nuevoPagoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nuevoPagoToolStripMenuItem.Text = "Nuevo Pago";
            this.nuevoPagoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPagoToolStripMenuItem_Click);
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.verPagosToolStripMenuItem.Text = "Ver Pagos";
            this.verPagosToolStripMenuItem.Click += new System.EventHandler(this.verPagosToolStripMenuItem_Click);
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
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(187, 6);
            // 
            // verFichaDelPacienteToolStripMenuItem
            // 
            this.verFichaDelPacienteToolStripMenuItem.Name = "verFichaDelPacienteToolStripMenuItem";
            this.verFichaDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.verFichaDelPacienteToolStripMenuItem.Text = "Ver Ficha del Paciente";
            this.verFichaDelPacienteToolStripMenuItem.Click += new System.EventHandler(this.verFichaDelPacienteToolStripMenuItem_Click);
            // 
            // verHistorialClínicoToolStripMenuItem
            // 
            this.verHistorialClínicoToolStripMenuItem.Name = "verHistorialClínicoToolStripMenuItem";
            this.verHistorialClínicoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.verHistorialClínicoToolStripMenuItem.Text = "Ver Historial Clínico";
            this.verHistorialClínicoToolStripMenuItem.Click += new System.EventHandler(this.verHistorialClínicoToolStripMenuItem_Click);
            // 
            // dgTotales
            // 
            this.dgTotales.AllowUserToAddRows = false;
            this.dgTotales.AllowUserToDeleteRows = false;
            this.dgTotales.AllowUserToResizeColumns = false;
            this.dgTotales.AllowUserToResizeRows = false;
            this.dgTotales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotales.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTotales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTotales.Location = new System.Drawing.Point(0, 0);
            this.dgTotales.Name = "dgTotales";
            this.dgTotales.RowHeadersVisible = false;
            this.dgTotales.Size = new System.Drawing.Size(656, 25);
            this.dgTotales.TabIndex = 1;
            // 
            // tpageCitasPendientes
            // 
            this.tpageCitasPendientes.Controls.Add(this.dgCitasPendientes);
            this.tpageCitasPendientes.Location = new System.Drawing.Point(4, 22);
            this.tpageCitasPendientes.Name = "tpageCitasPendientes";
            this.tpageCitasPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpageCitasPendientes.Size = new System.Drawing.Size(662, 530);
            this.tpageCitasPendientes.TabIndex = 2;
            this.tpageCitasPendientes.Text = "Citas pendientes de cobro";
            this.tpageCitasPendientes.UseVisualStyleBackColor = true;
            // 
            // dgCitasPendientes
            // 
            this.dgCitasPendientes.AllowUserToAddRows = false;
            this.dgCitasPendientes.AllowUserToDeleteRows = false;
            this.dgCitasPendientes.AllowUserToResizeColumns = false;
            this.dgCitasPendientes.AllowUserToResizeRows = false;
            this.dgCitasPendientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCitasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCitasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCitasPendientes.ContextMenuStrip = this.contextMenuCitasPendientes;
            this.dgCitasPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCitasPendientes.Location = new System.Drawing.Point(3, 3);
            this.dgCitasPendientes.Name = "dgCitasPendientes";
            this.dgCitasPendientes.RowHeadersVisible = false;
            this.dgCitasPendientes.Size = new System.Drawing.Size(656, 524);
            this.dgCitasPendientes.TabIndex = 1;
            this.dgCitasPendientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // contextMenuCitasPendientes
            // 
            this.contextMenuCitasPendientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarReciboToolStripMenuItem});
            this.contextMenuCitasPendientes.Name = "contextMenuCitasPendientes";
            this.contextMenuCitasPendientes.Size = new System.Drawing.Size(160, 26);
            // 
            // generarReciboToolStripMenuItem
            // 
            this.generarReciboToolStripMenuItem.Name = "generarReciboToolStripMenuItem";
            this.generarReciboToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generarReciboToolStripMenuItem.Text = "Generar Recibo";
            this.generarReciboToolStripMenuItem.Click += new System.EventHandler(this.generarReciboToolStripMenuItem_Click);
            // 
            // tpageFacturacion
            // 
            this.tpageFacturacion.Controls.Add(this.splitContainer3);
            this.tpageFacturacion.Location = new System.Drawing.Point(4, 22);
            this.tpageFacturacion.Name = "tpageFacturacion";
            this.tpageFacturacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpageFacturacion.Size = new System.Drawing.Size(662, 530);
            this.tpageFacturacion.TabIndex = 1;
            this.tpageFacturacion.Text = "Facturación";
            this.tpageFacturacion.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgFacturacionDetalle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgFacturacionTotal);
            this.splitContainer3.Size = new System.Drawing.Size(656, 524);
            this.splitContainer3.SplitterDistance = 495;
            this.splitContainer3.TabIndex = 2;
            // 
            // dgFacturacionDetalle
            // 
            this.dgFacturacionDetalle.AllowUserToAddRows = false;
            this.dgFacturacionDetalle.AllowUserToDeleteRows = false;
            this.dgFacturacionDetalle.AllowUserToResizeColumns = false;
            this.dgFacturacionDetalle.AllowUserToResizeRows = false;
            this.dgFacturacionDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgFacturacionDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgFacturacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturacionDetalle.ContextMenuStrip = this.contextMenuFacturacion;
            this.dgFacturacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFacturacionDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgFacturacionDetalle.Name = "dgFacturacionDetalle";
            this.dgFacturacionDetalle.RowHeadersVisible = false;
            this.dgFacturacionDetalle.Size = new System.Drawing.Size(656, 495);
            this.dgFacturacionDetalle.TabIndex = 0;
            this.dgFacturacionDetalle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // contextMenuFacturacion
            // 
            this.contextMenuFacturacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirReciboToolStripMenuItem,
            this.imprimirDetalleFacturaciónToolStripMenuItem,
            this.toolStripMenuItem6,
            this.verCajasToolStripMenuItem});
            this.contextMenuFacturacion.Name = "contextMenuFacturacion";
            this.contextMenuFacturacion.Size = new System.Drawing.Size(216, 98);
            // 
            // imprimirReciboToolStripMenuItem
            // 
            this.imprimirReciboToolStripMenuItem.Name = "imprimirReciboToolStripMenuItem";
            this.imprimirReciboToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.imprimirReciboToolStripMenuItem.Text = "Imprimir Recibo";
            this.imprimirReciboToolStripMenuItem.Click += new System.EventHandler(this.imprimirReciboToolStripMenuItem_Click);
            // 
            // imprimirDetalleFacturaciónToolStripMenuItem
            // 
            this.imprimirDetalleFacturaciónToolStripMenuItem.Name = "imprimirDetalleFacturaciónToolStripMenuItem";
            this.imprimirDetalleFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.imprimirDetalleFacturaciónToolStripMenuItem.Text = "Imprimir detalle facturación";
            this.imprimirDetalleFacturaciónToolStripMenuItem.Click += new System.EventHandler(this.imprimirDetalleFacturaciónToolStripMenuItem_Click);
            // 
            // dgFacturacionTotal
            // 
            this.dgFacturacionTotal.AllowUserToAddRows = false;
            this.dgFacturacionTotal.AllowUserToDeleteRows = false;
            this.dgFacturacionTotal.AllowUserToResizeColumns = false;
            this.dgFacturacionTotal.AllowUserToResizeRows = false;
            this.dgFacturacionTotal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgFacturacionTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgFacturacionTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturacionTotal.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFacturacionTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFacturacionTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgFacturacionTotal.Location = new System.Drawing.Point(0, 0);
            this.dgFacturacionTotal.Name = "dgFacturacionTotal";
            this.dgFacturacionTotal.RowHeadersVisible = false;
            this.dgFacturacionTotal.Size = new System.Drawing.Size(656, 25);
            this.dgFacturacionTotal.TabIndex = 1;
            // 
            // tpageLiquidacion
            // 
            this.tpageLiquidacion.Controls.Add(this.groupBox2);
            this.tpageLiquidacion.Controls.Add(this.groupBox1);
            this.tpageLiquidacion.Location = new System.Drawing.Point(4, 22);
            this.tpageLiquidacion.Name = "tpageLiquidacion";
            this.tpageLiquidacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLiquidacion.Size = new System.Drawing.Size(662, 530);
            this.tpageLiquidacion.TabIndex = 3;
            this.tpageLiquidacion.Text = "Liquidación del dia";
            this.tpageLiquidacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones con paciente - Total por forma de pago";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(3, 16);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dgTotalFormaPagoDetalle);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dgTotalFormaPagoTotal);
            this.splitContainer5.Size = new System.Drawing.Size(650, 240);
            this.splitContainer5.SplitterDistance = 211;
            this.splitContainer5.TabIndex = 2;
            // 
            // dgTotalFormaPagoDetalle
            // 
            this.dgTotalFormaPagoDetalle.AllowUserToAddRows = false;
            this.dgTotalFormaPagoDetalle.AllowUserToDeleteRows = false;
            this.dgTotalFormaPagoDetalle.AllowUserToResizeColumns = false;
            this.dgTotalFormaPagoDetalle.AllowUserToResizeRows = false;
            this.dgTotalFormaPagoDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTotalFormaPagoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTotalFormaPagoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalFormaPagoDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTotalFormaPagoDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgTotalFormaPagoDetalle.Name = "dgTotalFormaPagoDetalle";
            this.dgTotalFormaPagoDetalle.RowHeadersVisible = false;
            this.dgTotalFormaPagoDetalle.Size = new System.Drawing.Size(650, 211);
            this.dgTotalFormaPagoDetalle.TabIndex = 0;
            // 
            // dgTotalFormaPagoTotal
            // 
            this.dgTotalFormaPagoTotal.AllowUserToAddRows = false;
            this.dgTotalFormaPagoTotal.AllowUserToDeleteRows = false;
            this.dgTotalFormaPagoTotal.AllowUserToResizeColumns = false;
            this.dgTotalFormaPagoTotal.AllowUserToResizeRows = false;
            this.dgTotalFormaPagoTotal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTotalFormaPagoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTotalFormaPagoTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalFormaPagoTotal.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTotalFormaPagoTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTotalFormaPagoTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTotalFormaPagoTotal.Location = new System.Drawing.Point(0, 0);
            this.dgTotalFormaPagoTotal.Name = "dgTotalFormaPagoTotal";
            this.dgTotalFormaPagoTotal.RowHeadersVisible = false;
            this.dgTotalFormaPagoTotal.Size = new System.Drawing.Size(650, 25);
            this.dgTotalFormaPagoTotal.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones del dia - Total por tipo de operación";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(3, 16);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dgTotalTipoOperacionDetalle);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgTotalTipoOperacionTotal);
            this.splitContainer4.Size = new System.Drawing.Size(650, 246);
            this.splitContainer4.SplitterDistance = 217;
            this.splitContainer4.TabIndex = 2;
            // 
            // dgTotalTipoOperacionDetalle
            // 
            this.dgTotalTipoOperacionDetalle.AllowUserToAddRows = false;
            this.dgTotalTipoOperacionDetalle.AllowUserToDeleteRows = false;
            this.dgTotalTipoOperacionDetalle.AllowUserToResizeColumns = false;
            this.dgTotalTipoOperacionDetalle.AllowUserToResizeRows = false;
            this.dgTotalTipoOperacionDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTotalTipoOperacionDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTotalTipoOperacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalTipoOperacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTotalTipoOperacionDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgTotalTipoOperacionDetalle.Name = "dgTotalTipoOperacionDetalle";
            this.dgTotalTipoOperacionDetalle.RowHeadersVisible = false;
            this.dgTotalTipoOperacionDetalle.Size = new System.Drawing.Size(650, 217);
            this.dgTotalTipoOperacionDetalle.TabIndex = 0;
            // 
            // dgTotalTipoOperacionTotal
            // 
            this.dgTotalTipoOperacionTotal.AllowUserToAddRows = false;
            this.dgTotalTipoOperacionTotal.AllowUserToDeleteRows = false;
            this.dgTotalTipoOperacionTotal.AllowUserToResizeColumns = false;
            this.dgTotalTipoOperacionTotal.AllowUserToResizeRows = false;
            this.dgTotalTipoOperacionTotal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgTotalTipoOperacionTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTotalTipoOperacionTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalTipoOperacionTotal.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTotalTipoOperacionTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgTotalTipoOperacionTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTotalTipoOperacionTotal.Location = new System.Drawing.Point(0, 0);
            this.dgTotalTipoOperacionTotal.Name = "dgTotalTipoOperacionTotal";
            this.dgTotalTipoOperacionTotal.RowHeadersVisible = false;
            this.dgTotalTipoOperacionTotal.Size = new System.Drawing.Size(650, 25);
            this.dgTotalTipoOperacionTotal.TabIndex = 1;
            // 
            // tpageLiquidacionReport
            // 
            this.tpageLiquidacionReport.Controls.Add(this.viewerLiquidacion);
            this.tpageLiquidacionReport.Location = new System.Drawing.Point(4, 22);
            this.tpageLiquidacionReport.Name = "tpageLiquidacionReport";
            this.tpageLiquidacionReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpageLiquidacionReport.Size = new System.Drawing.Size(662, 530);
            this.tpageLiquidacionReport.TabIndex = 4;
            this.tpageLiquidacionReport.Text = "Liquidación del día (otra forma)";
            this.tpageLiquidacionReport.UseVisualStyleBackColor = true;
            // 
            // viewerLiquidacion
            // 
            this.viewerLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerLiquidacion.Location = new System.Drawing.Point(3, 3);
            this.viewerLiquidacion.Name = "viewerLiquidacion";
            this.viewerLiquidacion.ShowToolBar = false;
            this.viewerLiquidacion.Size = new System.Drawing.Size(656, 524);
            this.viewerLiquidacion.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbCalculadora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Opciones :";
            // 
            // tsbCalculadora
            // 
            this.tsbCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculadora.Image")));
            this.tsbCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculadora.Name = "tsbCalculadora";
            this.tsbCalculadora.Size = new System.Drawing.Size(83, 22);
            this.tsbCalculadora.Text = "Calculadora";
            this.tsbCalculadora.Click += new System.EventHandler(this.tsbCalculadora_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(212, 6);
            // 
            // verCajasToolStripMenuItem
            // 
            this.verCajasToolStripMenuItem.Name = "verCajasToolStripMenuItem";
            this.verCajasToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.verCajasToolStripMenuItem.Text = "Ver Cajas";
            this.verCajasToolStripMenuItem.Click += new System.EventHandler(this.verCajasToolStripMenuItem_Click);
            // 
            // frmCajaDiaria
            // 
            this.ClientSize = new System.Drawing.Size(846, 581);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCajaDiaria";
            this.Text = "Caja diaria";
            this.Load += new System.EventHandler(this.frmCajaDiaria_Load);
            this.Activated += new System.EventHandler(this.frmCajaDiaria_Activated);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabCaja.ResumeLayout(false);
            this.tpageOperacionesDia.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperaciones)).EndInit();
            this.contextMenuCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTotales)).EndInit();
            this.tpageCitasPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCitasPendientes)).EndInit();
            this.contextMenuCitasPendientes.ResumeLayout(false);
            this.tpageFacturacion.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacionDetalle)).EndInit();
            this.contextMenuFacturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturacionTotal)).EndInit();
            this.tpageLiquidacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalFormaPagoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalFormaPagoTotal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalTipoOperacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalTipoOperacionTotal)).EndInit();
            this.tpageLiquidacionReport.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmCajaDiaria_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);

                frmCajaDiaria frmCaja = (frmCajaDiaria)this;
                if (!ctrl.cajaAbierta(frmCaja))
                {
                    abrirCajaToolStripMenuItem_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            this.viewerLiquidacion.RefreshReport();
        }

        private void monthCalendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                ctrl.refreshData(ref frm);
                tabCaja_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEdit vVen = new frmEdit(gesClinica.lib.vo.tTIPOOPERACION.CAJA_INICIAL, this.monthCalendar.Date);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgOperaciones_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {                
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                switch (ctrl.getTipoOperacionSeleccionada(frm))
                {
                    case gesClinica.lib.vo.tTIPOOPERACION.CAJA_INICIAL:
                        frmEdit vVenCaja = new frmEdit(ctrl.getOperacionSeleccionada(frm), false);
                        if (vVenCaja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            RefreshData();
                        break;
                    case gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE:
                        object obj = ctrl.getPagoOperacionSeleccionada(frm);
                        if ( obj== null)
                            nuevoPagoToolStripMenuItem_Click(null, null);
                        else
                        {
                            pago.frmEdit vVenOperacionPago = new gesClinica.app.pc.frm.pago.frmEdit((lib.vo.Pago)obj, false);
                            if (vVenOperacionPago.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                                RefreshData();
                        }
                        //_operacionpaciente.frmOperacionPacienteOpcion vVenOpcion = new gesClinica.app.pc.frm.operacion._operacionpaciente.frmOperacionPacienteOpcion();
                        //if (vVenOpcion.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        //{
                        //    if (vVenOpcion.rbNuevoPago.Checked)
                        //        nuevoPagoToolStripMenuItem_Click(null, null);
                        //    else
                        //        verPagosToolStripMenuItem_Click(null, null);
                        //}
                        break;
                    case gesClinica.lib.vo.tTIPOOPERACION.PAGO_TERAPEUTA:
                        frmEditPagoTerapeuta vVenPago = new frmEditPagoTerapeuta(ctrl.getOperacionSeleccionada(frm), false);
                        if (vVenPago.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            RefreshData();
                        break;
                    case gesClinica.lib.vo.tTIPOOPERACION.OTROS_PAGOS:
                        frmEdit vVenOtros = new frmEdit(ctrl.getOperacionSeleccionada(frm), false);
                        if (vVenOtros.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            RefreshData();
                        break;
                    case gesClinica.lib.vo.tTIPOOPERACION.COBRO_FUERA_CITA:
                        frmEditCobroFueraCita vVenCobro = new frmEditCobroFueraCita(ctrl.getOperacionSeleccionada(frm), false);
                        if (vVenCobro.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            RefreshData();
                        break;
                    default:
                        frmEdit vVen = new frmEdit(ctrl.getOperacionSeleccionada(frm),false);
                        if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            RefreshData();
                        break;
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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                ctrl.refreshData(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void contextMenuCaja_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                this.abrirCajaToolStripMenuItem.Enabled = !ctrl.cajaAbierta(frm);
                this.facturasToolStripMenuItem.Enabled = lib.bl._common.cache.EMPLEADO.Gerente;
                this.facturasSeparadortoolStripMenuItem1.Enabled = this.facturasToolStripMenuItem.Enabled;
                this.modificarImporteToolStripMenuItem.Enabled = this.facturasToolStripMenuItem.Enabled;

                this.generarFacturaToolStripMenuItem.Enabled = ctrl.puedeFacturar(frm);
                this.generarEImprimirFacturaToolStripMenuItem.Enabled = !this.generarFacturaToolStripMenuItem.Enabled && (ctrl.getOperacionSeleccionada(frm) != null) && ctrl.getOperacionSeleccionada(frm).Tipo == gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE;
                this.anularFacturaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;
                this.verFacturaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;
                this.modificarFacturaAsocidadaToolStripMenuItem.Enabled = this.generarEImprimirFacturaToolStripMenuItem.Enabled;

                this.verHistorialClínicoToolStripMenuItem.Enabled = lib.bl._common.cache.EMPLEADO.Terapeuta;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void pagoTerapeutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEditPagoTerapeuta vVen = new frmEditPagoTerapeuta(gesClinica.lib.vo.tTIPOOPERACION.PAGO_TERAPEUTA, this.monthCalendar.Date);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmCajaDiaria_Activated(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void generarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                if (ctrl.getCitaSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(gesClinica.app.pc._common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //gesClinica.app.pc.frm.operacion.frmEdit vVen = new gesClinica.app.pc.frm.operacion.frmEdit(ctrl.getCitaSeleccionada(frm));
                //vVen.ShowDialog();

                ctrl.generarRecibo(ctrl.getCitaSeleccionada(frm));
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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit(ctrl.getOperacionSeleccionada(frm));
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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show("¿Seguro que desea anular esta factura? El número de factura no será recuperado.", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    ctrl.anularFactura(ctrl.getOperacionSeleccionada(frm));
                    RefreshData();
                }

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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit(ctrl.obtenerFacturaAsociada(ctrl.getOperacionSeleccionada(frm)),true);
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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmEdit vVen = new gesClinica.app.pc.frm.factura.frmEdit(ctrl.obtenerFacturaAsociada(ctrl.getOperacionSeleccionada(frm)), false);
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
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.factura.frmPrint vVen = new gesClinica.app.pc.frm.factura.frmPrint(ctrl.obtenerFacturaAsociada(ctrl.getOperacionSeleccionada(frm)));
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void imprimirReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getResumenSeleccionado(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.operacion._reciboterapeuta.frmPrint vVen = new gesClinica.app.pc.frm.operacion._reciboterapeuta.frmPrint(ctrl.getResumenSeleccionado(frm));
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void imprimirDetalleFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getResumenSeleccionado(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                gesClinica.app.pc.frm.operacion._detallefacturacion.frmPrint vVen = new gesClinica.app.pc.frm.operacion._detallefacturacion.frmPrint(ctrl.getResumenSeleccionado(frm),this.monthCalendar.Date);
                vVen.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void otrosPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEdit vVen = new frmEdit(gesClinica.lib.vo.tTIPOOPERACION.OTROS_PAGOS, this.monthCalendar.Date);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cobroFueraDeCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEditCobroFueraCita vVen = new frmEditCobroFueraCita(gesClinica.lib.vo.tTIPOOPERACION.COBRO_FUERA_CITA, this.monthCalendar.Date);
                if (vVen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void anularOperaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if ((bool)ctrl.BorrarRegistro(ref frm))
                        RefreshData();
                    else
                        template._common.messages.ShowWarning(_common.constantes.messages.IMCOMPLETED_OPERATION, this.Text);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void nuevoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (ctrl.getTipoOperacionSeleccionada(frm) != gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                {
                    template._common.messages.ShowWarning("Debe seleccionar un recibo de paciente.", this.Text);
                    return;
                }

                pago.frmEdit vVen = new gesClinica.app.pc.frm.pago.frmEdit(ctrl.getOperacionSeleccionada(frm));
                if (vVen.ShowDialog(this)== System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (ctrl.getTipoOperacionSeleccionada(frm) != gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                {
                    template._common.messages.ShowWarning("Debe seleccionar recibo de paciente.", this.Text);
                    return;
                }

                pago.frmQuery vVen = new gesClinica.app.pc.frm.pago.frmQuery(ctrl.getOperacionSeleccionada(frm));
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void modificarImporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (ctrl.getTipoOperacionSeleccionada(frm) != gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                {
                    template._common.messages.ShowWarning("Debe seleccionar un recibo de paciente.", this.Text);
                    return;
                }

                frmEditOperacionPaciente vVen = new frmEditOperacionPaciente(ctrl.getOperacionSeleccionada(frm),false);
                if (vVen.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    RefreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tsbCalculadora_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc");
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verFichaDelPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (ctrl.getTipoOperacionSeleccionada(frm) != gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                {
                    template._common.messages.ShowWarning("Debe seleccionar un recibo de paciente.", this.Text);
                    return;
                }

                paciente.frmEdit vVen = new gesClinica.app.pc.frm.paciente.frmEdit(ctrl.getPaciente(ctrl.getOperacionSeleccionada(frm)), false);
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verHistorialClínicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;
                if (ctrl.getOperacionSeleccionada(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                if (ctrl.getTipoOperacionSeleccionada(frm) != gesClinica.lib.vo.tTIPOOPERACION.OPERACION_PACIENTE)
                {
                    template._common.messages.ShowWarning("Debe seleccionar un recibo de paciente.", this.Text);
                    return;
                }

                cita.frmEditDatosClinicos vVen = new gesClinica.app.pc.frm.cita.frmEditDatosClinicos(ctrl.getPaciente(ctrl.getOperacionSeleccionada(frm)));
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void dgv_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                System.Windows.Forms.DataGridView dgv = (System.Windows.Forms.DataGridView)sender;
                System.Windows.Forms.DataGridView.HitTestInfo hitTest = dgv.HitTest(e.X, e.Y);
                if ((hitTest.RowIndex != -1) && (hitTest.ColumnIndex != -1))
                    dgv.CurrentCell = dgv[hitTest.ColumnIndex, hitTest.RowIndex];
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private bool _onceLiq = true;
        private bool _onceFac = true;
        private void tabCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                if (tabCaja.SelectedTab == this.tpageLiquidacionReport)
                {
                    #region Liquidacion - Report

                    this.viewerLiquidacion.Reset();
                    lib.bl._reports.resumencaja.rptResumenCaja informe = new gesClinica.lib.bl._reports.resumencaja.rptResumenCaja((List<lib.vo.Operacion>)this.dgOperaciones.DataSource, (List<lib.vo.Pago>)this.dgTotalFormaPagoDetalle.DataSource);
                    Microsoft.Reporting.WinForms.ReportViewer viewer = this.viewerLiquidacion;
                    informe.setInformeViewer(ref viewer);
                    this.viewerLiquidacion.RefreshReport();

                    #endregion
                }
                else if (((_onceLiq) && (tabCaja.SelectedTab == this.tpageLiquidacion)) || ((_onceFac) && (tabCaja.SelectedTab == this.tpageFacturacion)))
                {
                    ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                    frmCajaDiaria frm = (frmCajaDiaria)this;
                    ctrl.refreshData(ref frm);

                    if (tabCaja.SelectedTab == this.tpageLiquidacion)
                        _onceLiq = false;
                    else
                        _onceFac = false;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void verCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlCajaDiaria ctrl = new gesClinica.app.pc.frm.operacion.ctrl.ctrlCajaDiaria();
                frmCajaDiaria frm = (frmCajaDiaria)this;

                if (ctrl.getResumenSeleccionado(frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                ctrl.VerCajas((lib.bl._common.custom.ResumenFacturacion)ctrl.getResumenSeleccionado(frm));
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
