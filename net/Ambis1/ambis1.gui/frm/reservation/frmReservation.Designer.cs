namespace ambis1.gui.pc.frm.reservation
{
    partial class frmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.monthCalendar = new ambis1.gui.pc.template.controls.MonthCalendar();
            this.contextMenuHoliday = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setHolidayvacationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHolidayvactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.labFecha = new System.Windows.Forms.Label();
            this.agenda = new ambis1.gui.pc.template.controls.Agenda();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.contextMenuHoliday.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer.Size = new System.Drawing.Size(1016, 734);
            this.splitContainer.SplitterDistance = 135;
            this.splitContainer.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.ContextMenuStrip = this.contextMenuHoliday;
            this.monthCalendar.Date = new System.DateTime(2010, 1, 28, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(0u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 5;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 701;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(135, 734);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.Text = "Calendar";
            this.monthCalendar.VisibleHeight = 701;
            this.monthCalendar.DoubleClick += new System.EventHandler(this.monthCalendar_DoubleClick);
            this.monthCalendar.DateChanged += new System.EventHandler(this.monthCalendar_DateChanged);
            // 
            // contextMenuHoliday
            // 
            this.contextMenuHoliday.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHolidayvacationToolStripMenuItem,
            this.removeHolidayvactionToolStripMenuItem});
            this.contextMenuHoliday.Name = "contextMenuHoliday";
            this.contextMenuHoliday.Size = new System.Drawing.Size(207, 48);
            // 
            // setHolidayvacationToolStripMenuItem
            // 
            this.setHolidayvacationToolStripMenuItem.Name = "setHolidayvacationToolStripMenuItem";
            this.setHolidayvacationToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.setHolidayvacationToolStripMenuItem.Text = "Set holiday/vacation";
            // 
            // removeHolidayvactionToolStripMenuItem
            // 
            this.removeHolidayvactionToolStripMenuItem.Name = "removeHolidayvactionToolStripMenuItem";
            this.removeHolidayvactionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.removeHolidayvactionToolStripMenuItem.Text = "Remove holiday/vacation";
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 1;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Controls.Add(this.labFecha, 0, 0);
            this.tablePanel.Controls.Add(this.agenda, 0, 1);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 2;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel.Size = new System.Drawing.Size(877, 734);
            this.tablePanel.TabIndex = 0;
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labFecha.Location = new System.Drawing.Point(3, 0);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(871, 25);
            this.labFecha.TabIndex = 1;
            this.labFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agenda
            // 
            this.agenda.AllowUserToAddRows = false;
            this.agenda.AllowUserToDeleteRows = false;
            this.agenda.BackgroundColor = System.Drawing.Color.White;
            this.agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenda.DataSourceColumns = null;
            this.agenda.DataSourceReservations = null;
            this.agenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agenda.Fecha = new System.DateTime(((long)(0)));
            this.agenda.FinHora = 18;
            this.agenda.FinMinuto = 0;
            this.agenda.InicioHora = 9;
            this.agenda.InicioMinuto = 0;
            this.agenda.Location = new System.Drawing.Point(3, 28);
            this.agenda.MultiSelect = false;
            this.agenda.Name = "agenda";
            this.agenda.ReadOnly = true;
            this.agenda.RowTemplate.Height = 88;
            this.agenda.Salto = 10;
            this.agenda.Size = new System.Drawing.Size(871, 703);
            this.agenda.TabIndex = 2;
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReservation";
            this.Text = "Schedule - Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.contextMenuHoliday.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private ambis1.gui.pc.template.controls.MonthCalendar monthCalendar;
        internal System.Windows.Forms.TableLayoutPanel tablePanel;
        internal System.Windows.Forms.Label labFecha;
        private ambis1.gui.pc.template.controls.Agenda agenda;
        private System.Windows.Forms.ContextMenuStrip contextMenuHoliday;
        private System.Windows.Forms.ToolStripMenuItem setHolidayvacationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeHolidayvactionToolStripMenuItem;

    }
}