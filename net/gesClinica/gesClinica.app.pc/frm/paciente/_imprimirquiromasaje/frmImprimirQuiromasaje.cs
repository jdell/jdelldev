using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.paciente._imprimirquiromasaje
{
    internal class frmImprimirQuiromasaje:repsol.forms.template.BaseForm 
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.CheckBox chkQuiromasajesCuerpo;
        private System.Windows.Forms.CheckBox chkQuiromasajesSegundaHoja;
        private System.Windows.Forms.CheckBox chkHistoriaClinicaQuiromasajes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkQuiromasajesHojaBlanco;

        private lib.vo.Paciente _paciente = null;
        public lib.vo.Paciente Paciente
        {
            get
            {
                return _paciente;
            }
        }
        public frmImprimirQuiromasaje(lib.vo.Paciente paciente)
        {
            InitializeComponent();

            _paciente = paciente;
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkQuiromasajesCuerpo = new System.Windows.Forms.CheckBox();
            this.chkQuiromasajesSegundaHoja = new System.Windows.Forms.CheckBox();
            this.chkHistoriaClinicaQuiromasajes = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.chkQuiromasajesHojaBlanco = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkQuiromasajesHojaBlanco);
            this.groupBox1.Controls.Add(this.chkQuiromasajesCuerpo);
            this.groupBox1.Controls.Add(this.chkQuiromasajesSegundaHoja);
            this.groupBox1.Controls.Add(this.chkHistoriaClinicaQuiromasajes);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes";
            // 
            // chkQuiromasajesCuerpo
            // 
            this.chkQuiromasajesCuerpo.AutoSize = true;
            this.chkQuiromasajesCuerpo.Location = new System.Drawing.Point(79, 92);
            this.chkQuiromasajesCuerpo.Name = "chkQuiromasajesCuerpo";
            this.chkQuiromasajesCuerpo.Size = new System.Drawing.Size(145, 17);
            this.chkQuiromasajesCuerpo.TabIndex = 2;
            this.chkQuiromasajesCuerpo.Text = "Quiromasajes Cuerpo";
            this.chkQuiromasajesCuerpo.UseVisualStyleBackColor = true;
            // 
            // chkQuiromasajesSegundaHoja
            // 
            this.chkQuiromasajesSegundaHoja.AutoSize = true;
            this.chkQuiromasajesSegundaHoja.Location = new System.Drawing.Point(79, 69);
            this.chkQuiromasajesSegundaHoja.Name = "chkQuiromasajesSegundaHoja";
            this.chkQuiromasajesSegundaHoja.Size = new System.Drawing.Size(185, 17);
            this.chkQuiromasajesSegundaHoja.TabIndex = 1;
            this.chkQuiromasajesSegundaHoja.Text = "Quiromasajes Segunda Hoja";
            this.chkQuiromasajesSegundaHoja.UseVisualStyleBackColor = true;
            // 
            // chkHistoriaClinicaQuiromasajes
            // 
            this.chkHistoriaClinicaQuiromasajes.AutoSize = true;
            this.chkHistoriaClinicaQuiromasajes.Location = new System.Drawing.Point(79, 46);
            this.chkHistoriaClinicaQuiromasajes.Name = "chkHistoriaClinicaQuiromasajes";
            this.chkHistoriaClinicaQuiromasajes.Size = new System.Drawing.Size(192, 17);
            this.chkHistoriaClinicaQuiromasajes.TabIndex = 0;
            this.chkHistoriaClinicaQuiromasajes.Text = "Historia Clínica Quiromasajes";
            this.chkHistoriaClinicaQuiromasajes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btImprimir);
            this.groupBox2.Controls.Add(this.btSalir);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btImprimir.BackColor = System.Drawing.Color.LightYellow;
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(183, 16);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 0;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btSalir
            // 
            this.btSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalir.BackColor = System.Drawing.Color.Linen;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(264, 16);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkQuiromasajesHojaBlanco
            // 
            this.chkQuiromasajesHojaBlanco.AutoSize = true;
            this.chkQuiromasajesHojaBlanco.Location = new System.Drawing.Point(79, 115);
            this.chkQuiromasajesHojaBlanco.Name = "chkQuiromasajesHojaBlanco";
            this.chkQuiromasajesHojaBlanco.Size = new System.Drawing.Size(174, 17);
            this.chkQuiromasajesHojaBlanco.TabIndex = 3;
            this.chkQuiromasajesHojaBlanco.Text = "Quiromasajes Hoja Blanco";
            this.chkQuiromasajesHojaBlanco.UseVisualStyleBackColor = true;
            // 
            // frmImprimirQuiromasaje
            // 
            this.ClientSize = new System.Drawing.Size(351, 215);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImprimirQuiromasaje";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chkHistoriaClinicaQuiromasajes.Checked)
                {
                    frmPrint vVen = new frmPrint(this.Paciente, tTIPOIMPRESION.QUIROMASAJE1);
                    vVen.Show();
                }
                if (this.chkQuiromasajesSegundaHoja.Checked)
                {
                    frmPrint vVen = new frmPrint(this.Paciente, tTIPOIMPRESION.QUIROMASAJE2);
                    vVen.Show();
                }
                if (this.chkQuiromasajesCuerpo.Checked)
                {
                    frmPrint vVen = new frmPrint(this.Paciente, tTIPOIMPRESION.QUIROMASAJE3);
                    vVen.Show();
                }
                if (this.chkQuiromasajesHojaBlanco.Checked)
                {
                    frmPrint vVen = new frmPrint(this.Paciente, tTIPOIMPRESION.QUIROMASAJE4);
                    vVen.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
