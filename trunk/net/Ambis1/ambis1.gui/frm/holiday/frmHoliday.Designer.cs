namespace ambis1.gui.pc.frm.holiday
{
    partial class frmHoliday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoliday));
            this.monthCalendar = new ambis1.gui.pc.template.controls.MonthCalendar();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Date = new System.DateTime(2010, 1, 28, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(0u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 4;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 569;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(218, 572);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.Text = "Calendar";
            this.monthCalendar.VisibleHeight = 569;
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 572);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoliday";
            this.Text = "Holidays/Vacations";
            this.ResumeLayout(false);

        }

        #endregion

        private ambis1.gui.pc.template.controls.MonthCalendar monthCalendar;


    }
}