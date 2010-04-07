using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita
{
    internal class frmAgendaGeneral:template.frm.BaseForm
    {
        internal gesClinica.app.pc.template.controls.MonthCalendar monthCalendar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.TableLayoutPanel tablePanel;
        internal System.Windows.Forms.ToolStrip tbarLeyenda;
        internal System.Windows.Forms.Timer timerRefresh;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.SplitContainer splitContainer;

        public frmAgendaGeneral()
        {
            InitializeComponent();

            ctrl.ctrlAgendaGeneral ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlAgendaGeneral();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);


        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.monthCalendar = new gesClinica.app.pc.template.controls.MonthCalendar();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbarLeyenda = new System.Windows.Forms.ToolStrip();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.monthCalendar);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.tablePanel);
            this.splitContainer.Size = new System.Drawing.Size(792, 541);
            this.splitContainer.SplitterDistance = 135;
            this.splitContainer.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Date = new System.DateTime(2008, 7, 13, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(1u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 3;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 437;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(135, 541);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Text = "monthCalendar1";
            this.monthCalendar.VisibleHeight = 437;
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 1;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 2;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Size = new System.Drawing.Size(653, 541);
            this.tablePanel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbAnterior,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.tsbSiguiente,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel2.Text = "Opciones:";
            this.toolStripLabel2.Visible = false;
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = global::gesClinica.app.pc.Properties.Resources.left;
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(23, 22);
            this.tsbAnterior.Text = "Anterior";
            this.tsbAnterior.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::gesClinica.app.pc.Properties.Resources.day;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton2.Text = "Dia";
            this.toolStripButton2.Visible = false;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::gesClinica.app.pc.Properties.Resources.week;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton3.Text = "Semana";
            this.toolStripButton3.Visible = false;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::gesClinica.app.pc.Properties.Resources.month;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton4.Text = "Mes";
            this.toolStripButton4.Visible = false;
            // 
            // tsbSiguiente
            // 
            this.tsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSiguiente.Image = global::gesClinica.app.pc.Properties.Resources.right;
            this.tsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiguiente.Name = "tsbSiguiente";
            this.tsbSiguiente.Size = new System.Drawing.Size(23, 22);
            this.tsbSiguiente.Text = "Siguiente";
            this.tsbSiguiente.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbarLeyenda
            // 
            this.tbarLeyenda.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbarLeyenda.Location = new System.Drawing.Point(0, 0);
            this.tbarLeyenda.Name = "tbarLeyenda";
            this.tbarLeyenda.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tbarLeyenda.Size = new System.Drawing.Size(792, 25);
            this.tbarLeyenda.TabIndex = 2;
            this.tbarLeyenda.Text = "toolStrip2";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 300000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // frmAgendaGeneral
            // 
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.tbarLeyenda);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAgendaGeneral";
            this.Text = "Agenda General";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void tscmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                refreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void refreshData()
        {
            try
            {
                ctrl.ctrlAgendaGeneral ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlAgendaGeneral();
                frmAgendaGeneral frm = (frmAgendaGeneral)this;
                ctrl.ConsultaRegistros(ref frm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void calendar_RefreshDayView(object sender, EventArgs e)
        {
            try
            {
                refreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((this.MdiParent.ActiveMdiChild != null) && (this.MdiParent.ActiveMdiChild==this))
                    this.refreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
