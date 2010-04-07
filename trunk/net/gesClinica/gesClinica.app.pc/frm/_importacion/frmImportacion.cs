using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._importacion
{
    class frmImportacion:template.frm.BaseForm
    {
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btImportarParte1;
        internal System.Windows.Forms.Button btImportarParte2;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cmbRazonSocial;
        internal System.Windows.Forms.Label labInfo;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.ProgressBar pBar;
        internal System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
    
        public frmImportacion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btImportarParte1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btImportarParte2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.labInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btImportarParte1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parte 1";
            // 
            // btImportarParte1
            // 
            this.btImportarParte1.Location = new System.Drawing.Point(166, 19);
            this.btImportarParte1.Name = "btImportarParte1";
            this.btImportarParte1.Size = new System.Drawing.Size(137, 36);
            this.btImportarParte1.TabIndex = 0;
            this.btImportarParte1.Text = "importar";
            this.btImportarParte1.UseVisualStyleBackColor = true;
            this.btImportarParte1.Click += new System.EventHandler(this.btImportarParte1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btImportarParte2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbRazonSocial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parte 2";
            // 
            // btImportarParte2
            // 
            this.btImportarParte2.Location = new System.Drawing.Point(166, 55);
            this.btImportarParte2.Name = "btImportarParte2";
            this.btImportarParte2.Size = new System.Drawing.Size(137, 36);
            this.btImportarParte2.TabIndex = 49;
            this.btImportarParte2.Text = "importar";
            this.btImportarParte2.UseVisualStyleBackColor = true;
            this.btImportarParte2.Click += new System.EventHandler(this.btImportarParte2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Razon Social";
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(110, 19);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(348, 21);
            this.cmbRazonSocial.TabIndex = 47;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labInfo.Location = new System.Drawing.Point(0, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(157, 16);
            this.labInfo.TabIndex = 2;
            this.labInfo.Text = "Estado de la importación";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "erase una vez...xD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(0, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrar TODO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "erase la segunda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pBar
            // 
            this.pBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBar.Location = new System.Drawing.Point(0, 16);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(489, 23);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 94);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parte 3 - Terceros";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 36);
            this.button4.TabIndex = 50;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 36);
            this.button3.TabIndex = 49;
            this.button3.Text = "importar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmImportacion
            // 
            this.ClientSize = new System.Drawing.Size(489, 405);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.labInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportacion";
            this.Text = "Importación";
            this.Load += new System.EventHandler(this.frmImportacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btImportarParte1_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea importar?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                    ctrl.importarParte1(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea borrar todo?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                    
                    ctrl.eraseALL(ref frm, true);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void btImportarParte2_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea importar?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                    ctrl.importarParte2(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void frmImportacion_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea borrar todo?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                    
                    ctrl.eraseALL(ref frm, false);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea importar terceros?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                    ctrl.importarParte3(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.Windows.Forms.MessageBox.Show("¿Desea borrar todo terceros?", this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    ctrl.ctrlImportacion ctrl = new gesClinica.app.pc.frm._importacion.ctrl.ctrlImportacion();
                    repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;

                    ctrl.eraseALLTerceros(ref frm);
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
