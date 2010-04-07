using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.paciente
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label1;
        internal repsol.forms.controls.TextBoxColor txtNIF;
        private System.Windows.Forms.Label label6;
        internal repsol.forms.controls.TextBoxColor txtNombre;
        internal repsol.forms.controls.TextBoxColor txtTelefonos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuAux;
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.ToolStripMenuItem verHistorialMédicoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator separadorHistorial;
        internal System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    
        public frmQuery()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNIF = new repsol.forms.controls.TextBoxColor();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonos = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuAux = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verHistorialMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorHistorial = new System.Windows.Forms.ToolStripSeparator();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.contextMenuAux.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Location = new System.Drawing.Point(0, 152);
            this.panDetail.Size = new System.Drawing.Size(792, 421);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 127);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.txtTelefonos);
            this.panHead.Controls.Add(this.label4);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.txtNIF);
            this.panHead.Controls.Add(this.label6);
            this.panHead.Controls.Add(this.txtNombre);
            this.panHead.Controls.Add(this.label2);
            // 
            // txtNIF
            // 
            this.txtNIF.ActivateStyle = true;
            this.txtNIF.BackColor = System.Drawing.Color.White;
            this.txtNIF.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNIF.ColorLeave = System.Drawing.Color.White;
            this.txtNIF.Location = new System.Drawing.Point(182, 30);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(124, 20);
            this.txtNIF.TabIndex = 1;
            this.txtNIF.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "NIF";
            // 
            // txtNombre
            // 
            this.txtNombre.ActivateStyle = true;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtNombre.ColorLeave = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(182, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.filtrar_Handler);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(180, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "Indique nombre, 1er o 2do apellido indistintamente";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.ActivateStyle = true;
            this.txtTelefonos.BackColor = System.Drawing.Color.White;
            this.txtTelefonos.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtTelefonos.ColorLeave = System.Drawing.Color.White;
            this.txtTelefonos.Location = new System.Drawing.Point(381, 27);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(125, 20);
            this.txtTelefonos.TabIndex = 2;
            this.txtTelefonos.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Telefono";
            // 
            // contextMenuAux
            // 
            this.contextMenuAux.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verHistorialMédicoToolStripMenuItem,
            this.separadorHistorial,
            this.verCitasToolStripMenuItem});
            this.contextMenuAux.Name = "contextMenuAux";
            this.contextMenuAux.Size = new System.Drawing.Size(179, 54);
            this.contextMenuAux.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuAux_Opening);
            // 
            // verHistorialMédicoToolStripMenuItem
            // 
            this.verHistorialMédicoToolStripMenuItem.Name = "verHistorialMédicoToolStripMenuItem";
            this.verHistorialMédicoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.verHistorialMédicoToolStripMenuItem.Text = "Ver Historial Médico";
            this.verHistorialMédicoToolStripMenuItem.Click += new System.EventHandler(this.verHistorialMédicoToolStripMenuItem_Click);
            // 
            // separadorHistorial
            // 
            this.separadorHistorial.Name = "separadorHistorial";
            this.separadorHistorial.Size = new System.Drawing.Size(175, 6);
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.verCitasToolStripMenuItem.Text = "Ver Citas";
            this.verCitasToolStripMenuItem.Click += new System.EventHandler(this.verCitasToolStripMenuItem_Click);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmpacienteQry_Load);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
            this.contextMenuAux.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        protected override void btNuevo_record()
        {
            try
            {
                frmEdit vVen = new frmEdit();
                vVen.ShowDialog();
                btRefresh_record();
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Paciente)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Paciente)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Paciente)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
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
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
                this.txtNombre.Focus();
            }
            catch (Exception ex)
            {
                //template._common.messages.ShowError(ex);
                this.setError(ex.Message);
            }

        }
        protected override void btSeleccionar_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
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

        private void frmpacienteQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                this.txtNombre.Focus();
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verHistorialMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                cita.frmEditDatosClinicos vVen = new gesClinica.app.pc.frm.cita.frmEditDatosClinicos((Paciente)ctrl.getRegistroSeleccionado(ref frm));
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.paciente.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                //cita.frmAgendaPorPaciente vVen = new gesClinica.app.pc.frm.cita.frmAgendaPorPaciente((Paciente)ctrl.getRegistroSeleccionado(ref frm));
                cita._nuevo.frmAgendaPorPaciente vVen = new gesClinica.app.pc.frm.cita._nuevo.frmAgendaPorPaciente((Paciente)ctrl.getRegistroSeleccionado(ref frm));
                vVen.MdiParent = this.MdiParent;
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void contextMenuAux_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtNombre_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                    if (this.Modal)
                        btSeleccionar_record();
                    else
                        btModificar_record();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
