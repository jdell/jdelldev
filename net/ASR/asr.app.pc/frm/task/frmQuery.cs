using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.task
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescripcion;
        protected internal System.Windows.Forms.RadioButton rbOnlyCompleted;
        protected internal System.Windows.Forms.RadioButton rbOnlyUncompleted;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label2;
    
        public frmQuery()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtDescripcion = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.rbOnlyCompleted = new System.Windows.Forms.RadioButton();
            this.rbOnlyUncompleted = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
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
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.cmbStaff);
            this.panHead.Controls.Add(this.rbOnlyCompleted);
            this.panHead.Controls.Add(this.rbOnlyUncompleted);
            this.panHead.Controls.Add(this.txtDescripcion);
            this.panHead.Controls.Add(this.label2);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ActivateStyle = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescripcion.ColorLeave = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(207, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(362, 20);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Description";
            // 
            // rbOnlyCompleted
            // 
            this.rbOnlyCompleted.AutoSize = true;
            this.rbOnlyCompleted.Location = new System.Drawing.Point(494, 70);
            this.rbOnlyCompleted.Name = "rbOnlyCompleted";
            this.rbOnlyCompleted.Size = new System.Drawing.Size(75, 18);
            this.rbOnlyCompleted.TabIndex = 35;
            this.rbOnlyCompleted.Text = "Completed";
            this.rbOnlyCompleted.UseVisualStyleBackColor = true;
            this.rbOnlyCompleted.CheckedChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // rbOnlyUncompleted
            // 
            this.rbOnlyUncompleted.AutoSize = true;
            this.rbOnlyUncompleted.Checked = true;
            this.rbOnlyUncompleted.Location = new System.Drawing.Point(363, 70);
            this.rbOnlyUncompleted.Name = "rbOnlyUncompleted";
            this.rbOnlyUncompleted.Size = new System.Drawing.Size(93, 18);
            this.rbOnlyUncompleted.TabIndex = 34;
            this.rbOnlyUncompleted.TabStop = true;
            this.rbOnlyUncompleted.Text = "Not completed";
            this.rbOnlyUncompleted.UseVisualStyleBackColor = true;
            this.rbOnlyUncompleted.CheckedChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "To";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(207, 16);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(362, 22);
            this.cmbStaff.TabIndex = 36;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.frmtaskQry_Load);
            this.Controls.SetChildIndex(this.panHead, 0);
            this.Controls.SetChildIndex(this.panInfo, 0);
            this.Controls.SetChildIndex(this.panDetail, 0);
            this.panInfo.ResumeLayout(false);
            this.panInfo.PerformLayout();
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).EndInit();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Task)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Task)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Task)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
                this.txtDescripcion.Focus();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
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

        private void frmtaskQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                this.txtDescripcion.Focus();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.frm.task.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
