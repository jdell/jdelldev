using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita
{
    internal class frmAgendaPorSala:template.frm.BaseForm
    {
        internal gesClinica.app.pc.template.controls.MonthCalendar monthCalendar;
        internal System.Windows.Forms.ToolStrip tbarLeyenda;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbSiguiente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.ToolStripComboBox tscmbSala;
        internal gesClinica.app.pc.template.controls.DayView calendar;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.SplitContainer splitContainer1;

        public frmAgendaPorSala()
        {
            InitializeComponent();

            ctrl.ctrlAgendaPorSala ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlAgendaPorSala();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            refreshData();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Calendar.DrawTool drawTool2 = new Calendar.DrawTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaPorSala));
            this.calendar = new gesClinica.app.pc.template.controls.DayView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar = new gesClinica.app.pc.template.controls.MonthCalendar();
            this.tbarLeyenda = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbSala = new System.Windows.Forms.ToolStripComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tbarLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            drawTool2.DayView = this.calendar;
            this.calendar.ActiveTool = drawTool2;
            this.calendar.AllowInplaceEditing = false;
            this.calendar.AllowNew = false;
            this.calendar.Appointments = ((System.Collections.Generic.List<Calendar.Appointment>)(resources.GetObject("calendar.Appointments")));
            this.calendar.DaysToShow = 5;
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.calendar.HalfHourHeight = 27;
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.Name = "calendar";
            this.calendar.Rooms = ((System.Collections.Generic.List<object>)(resources.GetObject("calendar.Rooms")));
            this.calendar.SelectionEnd = new System.DateTime(((long)(0)));
            this.calendar.SelectionStart = new System.DateTime(((long)(0)));
            this.calendar.Size = new System.Drawing.Size(653, 541);
            this.calendar.StartDate = new System.DateTime(((long)(0)));
            this.calendar.StartHour = 9;
            this.calendar.Style = Calendar.DayView.tStyle.ShowByDay;
            this.calendar.TabIndex = 0;
            this.calendar.Text = "Agenda";
            this.calendar.WorkingHourEnd = 20;
            this.calendar.WorkingHourStart = 7;
            this.calendar.WorkingMinuteEnd = 0;
            this.calendar.WorkingMinuteStart = 0;
            this.calendar.RefreshDayView += new System.EventHandler(this.calendar_RefreshDayView);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(792, 541);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
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
            this.monthCalendar.DateChanged += new System.EventHandler(this.monthCalendar_DateChanged);
            // 
            // toolStrip1
            // 
            this.tbarLeyenda.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbarLeyenda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbAnterior,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.tsbSiguiente,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tscmbSala});
            this.tbarLeyenda.Location = new System.Drawing.Point(0, 0);
            this.tbarLeyenda.Name = "toolStrip1";
            this.tbarLeyenda.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tbarLeyenda.Size = new System.Drawing.Size(792, 25);
            this.tbarLeyenda.TabIndex = 1;
            this.tbarLeyenda.Text = "toolStrip1";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Sala:";
            // 
            // tscmbSala
            // 
            this.tscmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbSala.Name = "tscmbSala";
            this.tscmbSala.Size = new System.Drawing.Size(121, 25);
            this.tscmbSala.SelectedIndexChanged += new System.EventHandler(this.tscmbSala_SelectedIndexChanged);
            // 
            // frmAgendaPorSala
            // 
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbarLeyenda);
            this.Name = "frmAgendaPorSala";
            this.Text = "Agenda por Sala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tbarLeyenda.ResumeLayout(false);
            this.tbarLeyenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void calendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
                this.monthCalendar.Date = this.calendar.StartDate;
                refreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void monthCalendar_DateChanged(object sender, EventArgs e)
        {
            try
            {
                this.calendar.StartDate = this.monthCalendar.Date;
                refreshData();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }


        private void tscmbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.calendar.Tag = this.tscmbSala.SelectedItem;
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
                ctrl.ctrlAgendaPorSala ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlAgendaPorSala();
                frmAgendaPorSala frm = (frmAgendaPorSala)this;
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
    }
}
