using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.festivo
{
    class frmEdit: template.frm.edicion.EditForm
    {
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem tipoDeFestivoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox picColorSample;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbTipoFestivo;
        internal gesClinica.app.pc.template.controls.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource festivoBindingSource;

        public frmEdit()
        {
            InitializeComponent();

            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.festivo.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, null);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tipoDeFestivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picColorSample = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoFestivo = new System.Windows.Forms.ComboBox();
            this.festivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthCalendar = new gesClinica.app.pc.template.controls.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(496, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(577, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 427);
            this.panFooter.Size = new System.Drawing.Size(664, 43);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeFestivoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 26);
            // 
            // tipoDeFestivoToolStripMenuItem
            // 
            this.tipoDeFestivoToolStripMenuItem.Name = "tipoDeFestivoToolStripMenuItem";
            this.tipoDeFestivoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tipoDeFestivoToolStripMenuItem.Text = "Tipo de festivo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picColorSample);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbTipoFestivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 427);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 143);
            this.label1.TabIndex = 32;
            this.label1.Text = "Seleccione el tipo de festivo y haga doble click en las fechas que desee asignarl" +
                "e dicha festividad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picColorSample
            // 
            this.picColorSample.Location = new System.Drawing.Point(381, 13);
            this.picColorSample.Name = "picColorSample";
            this.picColorSample.Size = new System.Drawing.Size(51, 22);
            this.picColorSample.TabIndex = 31;
            this.picColorSample.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo Festivo";
            // 
            // cmbTipoFestivo
            // 
            this.cmbTipoFestivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoFestivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFestivo.FormattingEnabled = true;
            this.cmbTipoFestivo.Location = new System.Drawing.Point(142, 12);
            this.cmbTipoFestivo.Name = "cmbTipoFestivo";
            this.cmbTipoFestivo.Size = new System.Drawing.Size(233, 23);
            this.cmbTipoFestivo.TabIndex = 29;
            this.cmbTipoFestivo.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbColor_DrawItem);
            this.cmbTipoFestivo.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // festivoBindingSource
            // 
            this.festivoBindingSource.DataSource = typeof(gesClinica.lib.vo.Festivo);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Date = new System.DateTime(2008, 7, 23, 0, 0, 0, 0);
            this.monthCalendar.DaysByWeek = 7;
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.monthCalendar.FestivoForeColor = System.Drawing.Color.White;
            this.monthCalendar.FirstDayOfWeek = ((uint)(1u));
            this.monthCalendar.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar.MonthsViewed = 3;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.OldHeight = 437;
            this.monthCalendar.ShowNavigationButton = true;
            this.monthCalendar.Size = new System.Drawing.Size(150, 427);
            this.monthCalendar.Sizing = false;
            this.monthCalendar.Style = MonoCalendar.MonthCalendar.MonthCalendarStyle.Day;
            this.monthCalendar.TabIndex = 11;
            this.monthCalendar.Text = "monthCalendar1";
            this.monthCalendar.VisibleHeight = 437;
            this.monthCalendar.DoubleClick += new System.EventHandler(this.monthCalendar_DoubleClick);
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(664, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar);
            this.Name = "frmEdit";
            this.Text = "Calendario de Festivos";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.monthCalendar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.festivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.festivo.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm, this.IsNewRecord);
                base.btAceptar_Click(sender, e);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void monthCalendar_DoubleClick(object sender, EventArgs e)
        {
            ctrl.ctrlEdit ctrl = new gesClinica.app.pc.frm.festivo.ctrl.ctrlEdit();
            frmEdit edit = this;

            if (!Festivos.ContainsKey(this.monthCalendar.Date))
                ctrl.AddFestivo(ref edit);
            else
                ctrl.RemoveFestivo(ref edit);            
        }

        private Dictionary<DateTime, lib.vo.Festivo> _festivos = new Dictionary<DateTime, gesClinica.lib.vo.Festivo>();
        public Dictionary<DateTime, lib.vo.Festivo> Festivos
        {
            get { return _festivos; }
            set { _festivos = value; }
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
                if (cmb.SelectedItem != null)
                    this.picColorSample.Image = repsol.util.image.CreateImage(this.picColorSample.Width, this.picColorSample.Height, System.Drawing.Color.FromName(((lib.vo.TipoFestivo)cmb.SelectedItem).Color));
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbColor_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;

                e.Graphics.DrawImage(repsol.util.image.CreateImage(16, e.Bounds.Height - 2, System.Drawing.Color.FromName(((lib.vo.TipoFestivo)cmb.Items[e.Index]).Color)), e.Bounds.Left, e.Bounds.Top + 1);

                bool estado =
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect))
                    ||
                    (e.State == (System.Windows.Forms.DrawItemState.Selected | System.Windows.Forms.DrawItemState.Focus | System.Windows.Forms.DrawItemState.NoAccelerator | System.Windows.Forms.DrawItemState.NoFocusRect | System.Windows.Forms.DrawItemState.ComboBoxEdit));
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(), cmb.Font, new System.Drawing.SolidBrush(estado ? cmb.BackColor : cmb.ForeColor), e.Bounds.Left + 16, e.Bounds.Top);
            }
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            this.monthCalendar.Date = DateTime.Now;
            this.Text = "Calendario laboral";
        }
    }
}
