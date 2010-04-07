using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._principal
{
    public class frmPrincipal: template.frm.principal.MainForm
    {
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip tstripEstado;
        private System.Windows.Forms.ToolStripMenuItem ayudaOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem estadoCivilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem calendarioFestivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFestivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem documentosTematicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem sintomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeSintomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónYContabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesDiariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        internal System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosAtípicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosMensualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosMesActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosPagosEtcToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem resúmenesFiscalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem saldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldosYSalariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razonSocialToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem importacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem facturasRecibidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeUnidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasEmitidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosConPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amortizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amortizacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resumenDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilizarFacturasPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem imprimirFacturasPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renumerarAsientosFacturasRecibidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesPorRazónSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem16;
        internal System.Windows.Forms.ToolStripMenuItem agendaGeneralotraFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem impresiónDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionDeFacturasRecibidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem cierreAperturaDeEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mstripPrincipal;

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.mstripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaGeneralotraFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosTematicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.estadoCivilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.razonSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeUnidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.calendarioFestivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeFestivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.sintomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasDeSintomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónYContabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesDiariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesPorRazónSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilizarFacturasPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirFacturasPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.ingresosAtípicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosMensualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosMesActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosPagosEtcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosConPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amortizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.resúmenesFiscalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresiónDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionDeFacturasRecibidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tercerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.saldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldosYSalariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasRecibidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasEmitidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amortizacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripSeparator();
            this.cierreAperturaDeEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripEstado = new System.Windows.Forms.ToolStrip();
            this.mstripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnLineHelp1
            // 
            this.OnLineHelp1.Location = new System.Drawing.Point(0, 588);
            this.OnLineHelp1.Size = new System.Drawing.Size(1016, 121);
            this.OnLineHelp1.Visible = false;
            // 
            // mstripPrincipal
            // 
            this.mstripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.gestiónYContabilidadToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mstripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstripPrincipal.Name = "mstripPrincipal";
            this.mstripPrincipal.Size = new System.Drawing.Size(1016, 24);
            this.mstripPrincipal.TabIndex = 3;
            this.mstripPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaGeneralotraFormaToolStripMenuItem,
            this.toolStripMenuItem17,
            this.agendaToolStripMenuItem1,
            this.agendaToolStripMenuItem,
            this.toolStripMenuItem4,
            this.citasToolStripMenuItem,
            this.eventosTareasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.archivoToolStripMenuItem.Text = "General";
            // 
            // agendaToolStripMenuItem1
            // 
            this.agendaToolStripMenuItem1.Name = "agendaToolStripMenuItem1";
            this.agendaToolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.agendaToolStripMenuItem1.Text = "Agenda General (antigua agenda)";
            this.agendaToolStripMenuItem1.Click += new System.EventHandler(this.agendaToolStripMenuItem1_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.agendaToolStripMenuItem.Text = "Agenda por Sala (antigua agenda)";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(247, 6);
            // 
            // agendaGeneralotraFormaToolStripMenuItem
            // 
            this.agendaGeneralotraFormaToolStripMenuItem.Name = "agendaGeneralotraFormaToolStripMenuItem";
            this.agendaGeneralotraFormaToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.agendaGeneralotraFormaToolStripMenuItem.Text = "Agenda General";
            this.agendaGeneralotraFormaToolStripMenuItem.Click += new System.EventHandler(this.agendaGeneralotraFormaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(247, 6);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.citasToolStripMenuItem.Text = "Lista de Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // eventosTareasToolStripMenuItem
            // 
            this.eventosTareasToolStripMenuItem.Name = "eventosTareasToolStripMenuItem";
            this.eventosTareasToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.eventosTareasToolStripMenuItem.Text = "Eventos/Tareas";
            this.eventosTareasToolStripMenuItem.Click += new System.EventHandler(this.eventosTareasToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(247, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.toolStripMenuItem16,
            this.salasToolStripMenuItem,
            this.estadoCitaToolStripMenuItem,
            this.estadoEventoToolStripMenuItem,
            this.toolStripMenuItem8,
            this.actividadesToolStripMenuItem,
            this.tiposDeActividadesToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem,
            this.documentosTematicosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.estadoCivilToolStripMenuItem,
            this.tarifasToolStripMenuItem,
            this.formaDePagoToolStripMenuItem,
            this.toolStripMenuItem5,
            this.razonSocialToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.toolStripMenuItem6,
            this.componentesToolStripMenuItem,
            this.laboratoriosToolStripMenuItem,
            this.indicacionesToolStripMenuItem,
            this.tiposDeUnidadToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.toolStripMenuItem7,
            this.calendarioFestivosToolStripMenuItem,
            this.tipoDeFestivoToolStripMenuItem,
            this.toolStripMenuItem9,
            this.sintomasToolStripMenuItem,
            this.categoriasDeSintomasToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaToolStripMenuItem,
            this.citaToolStripMenuItem,
            this.pagosDePacientesToolStripMenuItem,
            this.contabilidadToolStripMenuItem1});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.citaToolStripMenuItem.Text = "Cita";
            this.citaToolStripMenuItem.Click += new System.EventHandler(this.citaToolStripMenuItem_Click);
            // 
            // pagosDePacientesToolStripMenuItem
            // 
            this.pagosDePacientesToolStripMenuItem.Name = "pagosDePacientesToolStripMenuItem";
            this.pagosDePacientesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pagosDePacientesToolStripMenuItem.Text = "Pagos de Pacientes";
            this.pagosDePacientesToolStripMenuItem.Click += new System.EventHandler(this.pagosDePacientesToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem1
            // 
            this.contabilidadToolStripMenuItem1.Name = "contabilidadToolStripMenuItem1";
            this.contabilidadToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.contabilidadToolStripMenuItem1.Text = "Contabilidad";
            this.contabilidadToolStripMenuItem1.Click += new System.EventHandler(this.contabilidadToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(243, 6);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // estadoCitaToolStripMenuItem
            // 
            this.estadoCitaToolStripMenuItem.Name = "estadoCitaToolStripMenuItem";
            this.estadoCitaToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.estadoCitaToolStripMenuItem.Text = "Estado Cita";
            this.estadoCitaToolStripMenuItem.Click += new System.EventHandler(this.estadoCitaToolStripMenuItem_Click);
            // 
            // estadoEventoToolStripMenuItem
            // 
            this.estadoEventoToolStripMenuItem.Name = "estadoEventoToolStripMenuItem";
            this.estadoEventoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.estadoEventoToolStripMenuItem.Text = "Estado Evento";
            this.estadoEventoToolStripMenuItem.Click += new System.EventHandler(this.estadoEventoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(243, 6);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            this.actividadesToolStripMenuItem.Click += new System.EventHandler(this.actividadesToolStripMenuItem_Click);
            // 
            // tiposDeActividadesToolStripMenuItem
            // 
            this.tiposDeActividadesToolStripMenuItem.Name = "tiposDeActividadesToolStripMenuItem";
            this.tiposDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tiposDeActividadesToolStripMenuItem.Text = "Tipos de Actividades";
            this.tiposDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeActividadesToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de Documentos";
            this.tiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosToolStripMenuItem_Click);
            // 
            // documentosTematicosToolStripMenuItem
            // 
            this.documentosTematicosToolStripMenuItem.Name = "documentosTematicosToolStripMenuItem";
            this.documentosTematicosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.documentosTematicosToolStripMenuItem.Text = "Documentos Tematicos";
            this.documentosTematicosToolStripMenuItem.Click += new System.EventHandler(this.documentosTematicosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 6);
            // 
            // estadoCivilToolStripMenuItem
            // 
            this.estadoCivilToolStripMenuItem.Name = "estadoCivilToolStripMenuItem";
            this.estadoCivilToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.estadoCivilToolStripMenuItem.Text = "Estado Civil";
            this.estadoCivilToolStripMenuItem.Click += new System.EventHandler(this.estadoCivilToolStripMenuItem_Click);
            // 
            // tarifasToolStripMenuItem
            // 
            this.tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            this.tarifasToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tarifasToolStripMenuItem.Text = "Tarifas";
            this.tarifasToolStripMenuItem.Click += new System.EventHandler(this.tarifasToolStripMenuItem_Click);
            // 
            // formaDePagoToolStripMenuItem
            // 
            this.formaDePagoToolStripMenuItem.Name = "formaDePagoToolStripMenuItem";
            this.formaDePagoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.formaDePagoToolStripMenuItem.Text = "Formas de Pago";
            this.formaDePagoToolStripMenuItem.Click += new System.EventHandler(this.formaDePagoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(243, 6);
            // 
            // razonSocialToolStripMenuItem
            // 
            this.razonSocialToolStripMenuItem.Name = "razonSocialToolStripMenuItem";
            this.razonSocialToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.razonSocialToolStripMenuItem.Text = "Razon Social";
            this.razonSocialToolStripMenuItem.Click += new System.EventHandler(this.razonSocialToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.empleadosToolStripMenuItem.Text = "Terapeutas";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(243, 6);
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.componentesToolStripMenuItem_Click);
            // 
            // laboratoriosToolStripMenuItem
            // 
            this.laboratoriosToolStripMenuItem.Name = "laboratoriosToolStripMenuItem";
            this.laboratoriosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.laboratoriosToolStripMenuItem.Text = "Laboratorios";
            this.laboratoriosToolStripMenuItem.Click += new System.EventHandler(this.laboratoriosToolStripMenuItem_Click);
            // 
            // indicacionesToolStripMenuItem
            // 
            this.indicacionesToolStripMenuItem.Name = "indicacionesToolStripMenuItem";
            this.indicacionesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.indicacionesToolStripMenuItem.Text = "Indicaciones y Contraindicaciones";
            this.indicacionesToolStripMenuItem.Click += new System.EventHandler(this.indicacionesToolStripMenuItem_Click);
            // 
            // tiposDeUnidadToolStripMenuItem
            // 
            this.tiposDeUnidadToolStripMenuItem.Name = "tiposDeUnidadToolStripMenuItem";
            this.tiposDeUnidadToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tiposDeUnidadToolStripMenuItem.Text = "Tipos de Unidades";
            this.tiposDeUnidadToolStripMenuItem.Click += new System.EventHandler(this.tiposDeUnidadToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(243, 6);
            // 
            // calendarioFestivosToolStripMenuItem
            // 
            this.calendarioFestivosToolStripMenuItem.Name = "calendarioFestivosToolStripMenuItem";
            this.calendarioFestivosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.calendarioFestivosToolStripMenuItem.Text = "Calendario Festivos";
            this.calendarioFestivosToolStripMenuItem.Click += new System.EventHandler(this.calendarioFestivosToolStripMenuItem_Click);
            // 
            // tipoDeFestivoToolStripMenuItem
            // 
            this.tipoDeFestivoToolStripMenuItem.Name = "tipoDeFestivoToolStripMenuItem";
            this.tipoDeFestivoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.tipoDeFestivoToolStripMenuItem.Text = "Tipo de Festivo";
            this.tipoDeFestivoToolStripMenuItem.Click += new System.EventHandler(this.tipoDeFestivoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(243, 6);
            // 
            // sintomasToolStripMenuItem
            // 
            this.sintomasToolStripMenuItem.Name = "sintomasToolStripMenuItem";
            this.sintomasToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.sintomasToolStripMenuItem.Text = "Sintomas";
            this.sintomasToolStripMenuItem.Click += new System.EventHandler(this.sintomasToolStripMenuItem_Click);
            // 
            // categoriasDeSintomasToolStripMenuItem
            // 
            this.categoriasDeSintomasToolStripMenuItem.Name = "categoriasDeSintomasToolStripMenuItem";
            this.categoriasDeSintomasToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.categoriasDeSintomasToolStripMenuItem.Text = "Categorias de Sintomas";
            this.categoriasDeSintomasToolStripMenuItem.Click += new System.EventHandler(this.categoriasDeSintomasToolStripMenuItem_Click);
            // 
            // gestiónYContabilidadToolStripMenuItem
            // 
            this.gestiónYContabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesDiariasToolStripMenuItem,
            this.operacionesPorRazónSocialToolStripMenuItem,
            this.toolStripMenuItem10,
            this.facturasToolStripMenuItem,
            this.contabilidadToolStripMenuItem});
            this.gestiónYContabilidadToolStripMenuItem.Name = "gestiónYContabilidadToolStripMenuItem";
            this.gestiónYContabilidadToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestiónYContabilidadToolStripMenuItem.Text = "Gestión y Contabilidad";
            // 
            // operacionesDiariasToolStripMenuItem
            // 
            this.operacionesDiariasToolStripMenuItem.Name = "operacionesDiariasToolStripMenuItem";
            this.operacionesDiariasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.operacionesDiariasToolStripMenuItem.Text = "Caja diaria";
            this.operacionesDiariasToolStripMenuItem.Click += new System.EventHandler(this.operacionesDiariasToolStripMenuItem_Click);
            // 
            // operacionesPorRazónSocialToolStripMenuItem
            // 
            this.operacionesPorRazónSocialToolStripMenuItem.Name = "operacionesPorRazónSocialToolStripMenuItem";
            this.operacionesPorRazónSocialToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.operacionesPorRazónSocialToolStripMenuItem.Text = "Operaciones por Razón Social";
            this.operacionesPorRazónSocialToolStripMenuItem.Click += new System.EventHandler(this.operacionesPorRazónSocialToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(224, 6);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.facturasToolStripMenuItem.Text = "Facturas de Pacientes";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contabilizarFacturasPacientesToolStripMenuItem,
            this.imprimirFacturasPacientesToolStripMenuItem,
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem,
            this.toolStripMenuItem15,
            this.ingresosAtípicosToolStripMenuItem,
            this.ingresosMensualesToolStripMenuItem,
            this.ingresosMesActividadToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.gastosPagosEtcToolStripMenuItem,
            this.toolStripMenuItem11,
            this.resúmenesFiscalesToolStripMenuItem,
            this.impresiónDeFacturasToolStripMenuItem,
            this.impresionDeFacturasRecibidasToolStripMenuItem,
            this.subCuentasToolStripMenuItem,
            this.tercerosToolStripMenuItem,
            this.resumenDeMovimientosToolStripMenuItem,
            this.toolStripMenuItem12,
            this.saldosToolStripMenuItem,
            this.sueldosYSalariosToolStripMenuItem,
            this.toolStripMenuItem13,
            this.ejerciciosToolStripMenuItem,
            this.asientosToolStripMenuItem,
            this.toolStripMenuItem14,
            this.facturasRecibidasToolStripMenuItem,
            this.facturasEmitidasToolStripMenuItem,
            this.amortizacionesToolStripMenuItem1,
            this.toolStripMenuItem18,
            this.cierreAperturaDeEjercicioToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // contabilizarFacturasPacientesToolStripMenuItem
            // 
            this.contabilizarFacturasPacientesToolStripMenuItem.Name = "contabilizarFacturasPacientesToolStripMenuItem";
            this.contabilizarFacturasPacientesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.contabilizarFacturasPacientesToolStripMenuItem.Text = "Contabilizar/Descont. Facturas Pacientes";
            this.contabilizarFacturasPacientesToolStripMenuItem.Click += new System.EventHandler(this.contabilizarFacturasPacientesToolStripMenuItem_Click);
            // 
            // imprimirFacturasPacientesToolStripMenuItem
            // 
            this.imprimirFacturasPacientesToolStripMenuItem.Name = "imprimirFacturasPacientesToolStripMenuItem";
            this.imprimirFacturasPacientesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.imprimirFacturasPacientesToolStripMenuItem.Text = "Imprimir Facturas Pacientes";
            this.imprimirFacturasPacientesToolStripMenuItem.Click += new System.EventHandler(this.imprimirFacturasPacientesToolStripMenuItem_Click);
            // 
            // renumerarAsientosFacturasRecibidasToolStripMenuItem
            // 
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem.Name = "renumerarAsientosFacturasRecibidasToolStripMenuItem";
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem.Text = "Renumerar Asientos/Facturas Recibidas";
            this.renumerarAsientosFacturasRecibidasToolStripMenuItem.Click += new System.EventHandler(this.renumerarAsientosFacturasRecibidasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(273, 6);
            // 
            // ingresosAtípicosToolStripMenuItem
            // 
            this.ingresosAtípicosToolStripMenuItem.Name = "ingresosAtípicosToolStripMenuItem";
            this.ingresosAtípicosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ingresosAtípicosToolStripMenuItem.Text = "Ingresos atípicos";
            this.ingresosAtípicosToolStripMenuItem.Click += new System.EventHandler(this.ingresosAtípicosToolStripMenuItem_Click);
            // 
            // ingresosMensualesToolStripMenuItem
            // 
            this.ingresosMensualesToolStripMenuItem.Name = "ingresosMensualesToolStripMenuItem";
            this.ingresosMensualesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ingresosMensualesToolStripMenuItem.Text = "Ingresos mensuales";
            this.ingresosMensualesToolStripMenuItem.Click += new System.EventHandler(this.ingresosMensualesToolStripMenuItem_Click);
            // 
            // ingresosMesActividadToolStripMenuItem
            // 
            this.ingresosMesActividadToolStripMenuItem.Name = "ingresosMesActividadToolStripMenuItem";
            this.ingresosMesActividadToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ingresosMesActividadToolStripMenuItem.Text = "Ingresos Mes/Actividad";
            this.ingresosMesActividadToolStripMenuItem.Click += new System.EventHandler(this.ingresosMesActividadToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            this.préstamosToolStripMenuItem.Click += new System.EventHandler(this.préstamosToolStripMenuItem_Click);
            // 
            // gastosPagosEtcToolStripMenuItem
            // 
            this.gastosPagosEtcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.gastosConPagosToolStripMenuItem,
            this.transferenciasToolStripMenuItem,
            this.amortizacionesToolStripMenuItem});
            this.gastosPagosEtcToolStripMenuItem.Name = "gastosPagosEtcToolStripMenuItem";
            this.gastosPagosEtcToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.gastosPagosEtcToolStripMenuItem.Text = "Gastos , Pagos, etc.";
            this.gastosPagosEtcToolStripMenuItem.Click += new System.EventHandler(this.gastosPagosEtcToolStripMenuItem_Click);
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gastosToolStripMenuItem.Text = "Gastos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // gastosConPagosToolStripMenuItem
            // 
            this.gastosConPagosToolStripMenuItem.Name = "gastosConPagosToolStripMenuItem";
            this.gastosConPagosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gastosConPagosToolStripMenuItem.Text = "Gastos con Pagos";
            this.gastosConPagosToolStripMenuItem.Click += new System.EventHandler(this.gastosConPagosToolStripMenuItem_Click);
            // 
            // transferenciasToolStripMenuItem
            // 
            this.transferenciasToolStripMenuItem.Name = "transferenciasToolStripMenuItem";
            this.transferenciasToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.transferenciasToolStripMenuItem.Text = "Transferencias";
            this.transferenciasToolStripMenuItem.Click += new System.EventHandler(this.transferenciasToolStripMenuItem_Click);
            // 
            // amortizacionesToolStripMenuItem
            // 
            this.amortizacionesToolStripMenuItem.Name = "amortizacionesToolStripMenuItem";
            this.amortizacionesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.amortizacionesToolStripMenuItem.Text = "Amortizaciones";
            this.amortizacionesToolStripMenuItem.Click += new System.EventHandler(this.amortizacionesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(273, 6);
            // 
            // resúmenesFiscalesToolStripMenuItem
            // 
            this.resúmenesFiscalesToolStripMenuItem.Name = "resúmenesFiscalesToolStripMenuItem";
            this.resúmenesFiscalesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.resúmenesFiscalesToolStripMenuItem.Text = "Resúmenes Fiscales";
            this.resúmenesFiscalesToolStripMenuItem.Click += new System.EventHandler(this.resúmenesFiscalesToolStripMenuItem_Click);
            // 
            // impresiónDeFacturasToolStripMenuItem
            // 
            this.impresiónDeFacturasToolStripMenuItem.Name = "impresiónDeFacturasToolStripMenuItem";
            this.impresiónDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.impresiónDeFacturasToolStripMenuItem.Text = "Impresión de Facturas Emitidas";
            this.impresiónDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.impresiónDeFacturasToolStripMenuItem_Click);
            // 
            // impresionDeFacturasRecibidasToolStripMenuItem
            // 
            this.impresionDeFacturasRecibidasToolStripMenuItem.Name = "impresionDeFacturasRecibidasToolStripMenuItem";
            this.impresionDeFacturasRecibidasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.impresionDeFacturasRecibidasToolStripMenuItem.Text = "Impresion de Facturas Recibidas";
            this.impresionDeFacturasRecibidasToolStripMenuItem.Click += new System.EventHandler(this.impresionDeFacturasRecibidasToolStripMenuItem_Click);
            // 
            // subCuentasToolStripMenuItem
            // 
            this.subCuentasToolStripMenuItem.Name = "subCuentasToolStripMenuItem";
            this.subCuentasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.subCuentasToolStripMenuItem.Text = "SubCuentas";
            this.subCuentasToolStripMenuItem.Click += new System.EventHandler(this.subCuentasToolStripMenuItem_Click);
            // 
            // tercerosToolStripMenuItem
            // 
            this.tercerosToolStripMenuItem.Name = "tercerosToolStripMenuItem";
            this.tercerosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.tercerosToolStripMenuItem.Text = "Terceros";
            this.tercerosToolStripMenuItem.Click += new System.EventHandler(this.tercerosToolStripMenuItem_Click);
            // 
            // resumenDeMovimientosToolStripMenuItem
            // 
            this.resumenDeMovimientosToolStripMenuItem.Name = "resumenDeMovimientosToolStripMenuItem";
            this.resumenDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.resumenDeMovimientosToolStripMenuItem.Text = "Resumen de Movimientos";
            this.resumenDeMovimientosToolStripMenuItem.Click += new System.EventHandler(this.resumenDeMovimientosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(273, 6);
            // 
            // saldosToolStripMenuItem
            // 
            this.saldosToolStripMenuItem.Name = "saldosToolStripMenuItem";
            this.saldosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.saldosToolStripMenuItem.Text = "Saldos";
            this.saldosToolStripMenuItem.Click += new System.EventHandler(this.saldosToolStripMenuItem_Click);
            // 
            // sueldosYSalariosToolStripMenuItem
            // 
            this.sueldosYSalariosToolStripMenuItem.Name = "sueldosYSalariosToolStripMenuItem";
            this.sueldosYSalariosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.sueldosYSalariosToolStripMenuItem.Text = "Sueldos y Salarios";
            this.sueldosYSalariosToolStripMenuItem.Click += new System.EventHandler(this.sueldosYSalariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(273, 6);
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            this.ejerciciosToolStripMenuItem.Click += new System.EventHandler(this.ejerciciosToolStripMenuItem_Click);
            // 
            // asientosToolStripMenuItem
            // 
            this.asientosToolStripMenuItem.Name = "asientosToolStripMenuItem";
            this.asientosToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.asientosToolStripMenuItem.Text = "Asientos";
            this.asientosToolStripMenuItem.Click += new System.EventHandler(this.asientosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(273, 6);
            // 
            // facturasRecibidasToolStripMenuItem
            // 
            this.facturasRecibidasToolStripMenuItem.Name = "facturasRecibidasToolStripMenuItem";
            this.facturasRecibidasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.facturasRecibidasToolStripMenuItem.Text = "Facturas Recibidas";
            this.facturasRecibidasToolStripMenuItem.Click += new System.EventHandler(this.facturasRecibidasToolStripMenuItem_Click);
            // 
            // facturasEmitidasToolStripMenuItem
            // 
            this.facturasEmitidasToolStripMenuItem.Name = "facturasEmitidasToolStripMenuItem";
            this.facturasEmitidasToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.facturasEmitidasToolStripMenuItem.Text = "Facturas Emitidas";
            this.facturasEmitidasToolStripMenuItem.Click += new System.EventHandler(this.facturasEmitidasToolStripMenuItem_Click);
            // 
            // amortizacionesToolStripMenuItem1
            // 
            this.amortizacionesToolStripMenuItem1.Name = "amortizacionesToolStripMenuItem1";
            this.amortizacionesToolStripMenuItem1.Size = new System.Drawing.Size(276, 22);
            this.amortizacionesToolStripMenuItem1.Text = "Amortizaciones";
            this.amortizacionesToolStripMenuItem1.Click += new System.EventHandler(this.amortizacionesToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(273, 6);
            // 
            // cierreAperturaDeEjercicioToolStripMenuItem
            // 
            this.cierreAperturaDeEjercicioToolStripMenuItem.Name = "cierreAperturaDeEjercicioToolStripMenuItem";
            this.cierreAperturaDeEjercicioToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.cierreAperturaDeEjercicioToolStripMenuItem.Text = "Cierre/Apertura de Ejercicio";
            this.cierreAperturaDeEjercicioToolStripMenuItem.Click += new System.EventHandler(this.cierreAperturaDeEjercicioToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importacionToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // importacionToolStripMenuItem
            // 
            this.importacionToolStripMenuItem.Name = "importacionToolStripMenuItem";
            this.importacionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.importacionToolStripMenuItem.Text = "Importacion";
            this.importacionToolStripMenuItem.Click += new System.EventHandler(this.importacionToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            this.cascadaToolStripMenuItem.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaOnlineToolStripMenuItem,
            this.toolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaOnlineToolStripMenuItem
            // 
            this.ayudaOnlineToolStripMenuItem.Name = "ayudaOnlineToolStripMenuItem";
            this.ayudaOnlineToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ayudaOnlineToolStripMenuItem.Text = "Ayuda online";
            this.ayudaOnlineToolStripMenuItem.Visible = false;
            this.ayudaOnlineToolStripMenuItem.Click += new System.EventHandler(this.ayudaOnlineToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            this.toolStripMenuItem1.Visible = false;
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tstripEstado
            // 
            this.tstripEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstripEstado.Location = new System.Drawing.Point(0, 709);
            this.tstripEstado.Name = "tstripEstado";
            this.tstripEstado.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstripEstado.Size = new System.Drawing.Size(1016, 25);
            this.tstripEstado.TabIndex = 4;
            this.tstripEstado.Text = "toolStrip1";
            // 
            // frmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.tstripEstado);
            this.Controls.Add(this.mstripPrincipal);
            this.MainMenuStrip = this.mstripPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "gesClinica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Controls.SetChildIndex(this.mstripPrincipal, 0);
            this.Controls.SetChildIndex(this.tstripEstado, 0);
            this.Controls.SetChildIndex(this.OnLineHelp1, 0);
            this.mstripPrincipal.ResumeLayout(false);
            this.mstripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _acercade.frmAcercaDe vVen = new gesClinica.app.pc.frm._acercade.frmAcercaDe();
                vVen.ShowDialog();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlPrincipal ctrl = new gesClinica.app.pc.frm._principal.ctrl.ctrlPrincipal();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void ayudaOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.OnLineHelp1.Visible = !this.OnLineHelp1.Visible;
                if (this.OnLineHelp1.Visible) this.RefreshOnLineHelp();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sala.frmQuery vVen = new gesClinica.app.pc.frm.sala.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                terapia.frmQuery vVen = new gesClinica.app.pc.frm.terapia.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void estadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                estadocivil.frmQuery vVen = new gesClinica.app.pc.frm.estadocivil.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tarifa.frmQuery vVen = new gesClinica.app.pc.frm.tarifa.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                empleado.frmQuery vVen = new gesClinica.app.pc.frm.empleado.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.frmQuery vVen = new gesClinica.app.pc.frm.paciente.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void estadoCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                estadocita.frmQuery vVen = new gesClinica.app.pc.frm.estadocita.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cita.frmQuery vVen = new gesClinica.app.pc.frm.cita.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cita.frmAgendaPorSala vVen = new gesClinica.app.pc.frm.cita.frmAgendaPorSala();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                cita.frmAgendaGeneral vVen = new gesClinica.app.pc.frm.cita.frmAgendaGeneral();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                componente.frmQuery vVen = new gesClinica.app.pc.frm.componente.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                laboratorio.frmQuery vVen = new gesClinica.app.pc.frm.laboratorio.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                producto.frmQuery vVen = new gesClinica.app.pc.frm.producto.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tipoDeFestivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tipofestivo.frmQuery vVen = new gesClinica.app.pc.frm.tipofestivo.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void calendarioFestivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                festivo.frmEdit vVen = new gesClinica.app.pc.frm.festivo.frmEdit();
                //vVen.MdiParent = this;
                vVen.ShowDialog(this);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void eventosTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                evento.frmQuery vVen = new gesClinica.app.pc.frm.evento.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void documentosTematicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                documento.frmQuery vVen = new gesClinica.app.pc.frm.documento.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sintoma.frmQuery vVen = new gesClinica.app.pc.frm.sintoma.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void categoriasDeSintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tiposintoma.frmQuery vVen = new gesClinica.app.pc.frm.tiposintoma.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void operacionesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                operacion.frmCajaDiaria vVen = new gesClinica.app.pc.frm.operacion.frmCajaDiaria();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                factura.frmQuery vVen = new gesClinica.app.pc.frm.factura.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void subCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                subcuenta.frmQuery vVen = new gesClinica.app.pc.frm.subcuenta.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void indicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                indicacion.frmQuery vVen = new gesClinica.app.pc.frm.indicacion.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tipodocumento.frmQuery vVen = new gesClinica.app.pc.frm.tipodocumento.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void razonSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                empresa.frmQuery vVen = new gesClinica.app.pc.frm.empresa.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void importacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _importacion.frmImportacion vVen = new gesClinica.app.pc.frm._importacion.frmImportacion();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void formaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formapago.frmQuery vVen = new gesClinica.app.pc.frm.formapago.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ejercicio.frmQuery vVen = new gesClinica.app.pc.frm.ejercicio.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void asientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmQuery vVen = new gesClinica.app.pc.frm.asiento.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void ingresosAtípicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditIngresosAtipicos vVen = new gesClinica.app.pc.frm.asiento.frmEditIngresosAtipicos();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tiposDeUnidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tipounidad.frmQuery vVen = new gesClinica.app.pc.frm.tipounidad.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void gastosPagosEtcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditOperacionPago vVen = new gesClinica.app.pc.frm.asiento.frmEditOperacionPago();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditOperacionGasto vVen = new gesClinica.app.pc.frm.asiento.frmEditOperacionGasto();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void gastosConPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditOperacionGastoConPago vVen = new gesClinica.app.pc.frm.asiento.frmEditOperacionGastoConPago();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void transferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditOperacionTransferencia vVen = new gesClinica.app.pc.frm.asiento.frmEditOperacionTransferencia();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void amortizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditOperacionAmortizacion vVen = new gesClinica.app.pc.frm.asiento.frmEditOperacionAmortizacion();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void facturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                apunte.frmQueryFacturaRecibida vVen = new gesClinica.app.pc.frm.apunte.frmQueryFacturaRecibida();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void facturasEmitidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                apunte.frmQueryFacturaEmitida vVen = new gesClinica.app.pc.frm.apunte.frmQueryFacturaEmitida();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void amortizacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                apunte.frmQueryAmortizacion vVen = new gesClinica.app.pc.frm.apunte.frmQueryAmortizacion();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditPrestamo vVen = new gesClinica.app.pc.frm.asiento.frmEditPrestamo();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void resumenDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                apunte.frmQuerySubCuenta vVen = new gesClinica.app.pc.frm.apunte.frmQuerySubCuenta();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void ingresosMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                operacion._resumenporterapeuta.frmPrint vVen = new gesClinica.app.pc.frm.operacion._resumenporterapeuta.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void sueldosYSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                asiento.frmEditSueldosYSalarios vVen = new gesClinica.app.pc.frm.asiento.frmEditSueldosYSalarios();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void ingresosMesActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                operacion._resumenporactividad.frmPrint vVen = new gesClinica.app.pc.frm.operacion._resumenporactividad.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void contabilizarFacturasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _contabilizar.frmContabilizar vVen = new gesClinica.app.pc.frm._contabilizar.frmContabilizar();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void imprimirFacturasPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _imprimirfacturas.frmImprimirFacturas vVen = new gesClinica.app.pc.frm._imprimirfacturas.frmImprimirFacturas();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void resúmenesFiscalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _resumenfiscal.frmPrint vVen = new gesClinica.app.pc.frm._resumenfiscal.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _saldo.frmPrint vVen = new gesClinica.app.pc.frm._saldo.frmPrint();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void renumerarAsientosFacturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _renumerar.frmRenumerar vVen = new gesClinica.app.pc.frm._renumerar.frmRenumerar();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void operacionesPorRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                operacion.frmQueryRazonSocial vVen = new gesClinica.app.pc.frm.operacion.frmQueryRazonSocial();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
	        {	    
                _configuracion.frmEditConfiguracionSala vVen = new gesClinica.app.pc.frm._configuracion.frmEditConfiguracionSala();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _configuracion.frmEditConfiguracionCita vVen = new gesClinica.app.pc.frm._configuracion.frmEditConfiguracionCita();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void pagosDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _configuracion.frmEditConfiguracionPago vVen = new gesClinica.app.pc.frm._configuracion.frmEditConfiguracionPago();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////Variable declaration
            //System.Collections.Specialized.StringCollection stringCollection;
            //System.IO.MemoryStream memoryStream;
            //System.IO.BinaryWriter binaryWriter;
            //System.Drawing.Image image;
            //Byte[] buf1;
            //Byte[] buf2;
            //Byte[] buf3;
            ////Variable declaration

            //stringCollection = a_StringCollection_containing_images;

            ////Response.ContentType = "Image/gif";
            //memoryStream = new System.IO.MemoryStream();
            //buf2 = new Byte[19];
            //buf3 = new Byte[8];
            //buf2[0] = 33;  //extension introducer
            //buf2[1] = 255; //application extension
            //buf2[2] = 11;  //size of block
            //buf2[3] = 78;  //N
            //buf2[4] = 69;  //E
            //buf2[5] = 84;  //T
            //buf2[6] = 83;  //S
            //buf2[7] = 67;  //C
            //buf2[8] = 65;  //A
            //buf2[9] = 80;  //P
            //buf2[10] = 69; //E
            //buf2[11] = 50; //2
            //buf2[12] = 46; //.
            //buf2[13] = 48; //0
            //buf2[14] = 3;  //Size of block
            //buf2[15] = 1;  //
            //buf2[16] = 0;  //
            //buf2[17] = 0;  //
            //buf2[18] = 0;  //Block terminator
            //buf3[0] = 33;  //Extension introducer
            //buf3[1] = 249; //Graphic control extension
            //buf3[2] = 4;   //Size of block
            //buf3[3] = 9;   //Flags: reserved, disposal method, user input, transparent color
            //buf3[4] = 10;  //Delay time low byte
            //buf3[5] = 3;   //Delay time high byte
            //buf3[6] = 255; //Transparent color index
            //buf3[7] = 0;   //Block terminator
            //binaryWriter = new BinaryWriter(Response.OutputStream);
            //for (int picCount = 0; picCount < stringCollection.Count; picCount++)
            //{
            //    image = Bitmap.FromFile(stringCollection[picCount]);
            //    image.Save(memoryStream, ImageFormat.Gif);
            //    buf1 = memoryStream.ToArray();

            //    if (picCount == 0)
            //    {
            //        //only write these the first time....
            //        binaryWriter.Write(buf1, 0, 781); //Header & global color table
            //        binaryWriter.Write(buf2, 0, 19); //Application extension
            //    }

            //    binaryWriter.Write(buf3, 0, 8); //Graphic extension
            //    binaryWriter.Write(buf1, 789, buf1.Length - 790); //Image data

            //    if (picCount == stringCollection.Count - 1)
            //    {
            //        //only write this one the last time....
            //        binaryWriter.Write(";"); //Image terminator
            //    }

            //    memoryStream.SetLength(0);
            //}
            //binaryWriter.Close();
            //Response.End();
        }

        private void agendaGeneralotraFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cita._nuevo.frmAgendaGeneral vVen = new gesClinica.app.pc.frm.cita._nuevo.frmAgendaGeneral();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void contabilidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _configuracion.frmEditConfiguracionContabilidad vVen = new gesClinica.app.pc.frm._configuracion.frmEditConfiguracionContabilidad();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void impresiónDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _facturas.frmPrintEmitidas vVen = new gesClinica.app.pc.frm._facturas.frmPrintEmitidas();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void impresionDeFacturasRecibidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _facturas.frmPrintRecibidas vVen = new gesClinica.app.pc.frm._facturas.frmPrintRecibidas();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tercero.frmQuery vVen = new gesClinica.app.pc.frm.tercero.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cierreAperturaDeEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _aperturacierre.frmAperturaCierre vVen = new gesClinica.app.pc.frm._aperturacierre.frmAperturaCierre();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void estadoEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                estadoevento.frmQuery vVen = new gesClinica.app.pc.frm.estadoevento.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void tiposDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tipoterapia.frmQuery vVen = new gesClinica.app.pc.frm.tipoterapia.frmQuery();
                vVen.MdiParent = this;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void asignaciónDeTiposDeTerapiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Aqui . TipoTerapia
        }



    }
}
