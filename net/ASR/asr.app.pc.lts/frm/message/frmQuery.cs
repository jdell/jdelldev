using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.lts.frm.message
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.RadioButton rbOnlyChecked;
        protected internal System.Windows.Forms.RadioButton rbOnlyUnchecked;
        protected internal System.Windows.Forms.ComboBox cmbStaff;
    
        public frmQuery()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.rbOnlyChecked = new System.Windows.Forms.RadioButton();
            this.rbOnlyUnchecked = new System.Windows.Forms.RadioButton();
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
            this.panHead.Controls.Add(this.rbOnlyChecked);
            this.panHead.Controls.Add(this.rbOnlyUnchecked);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.cmbStaff);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "To";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(239, 31);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(362, 22);
            this.cmbStaff.TabIndex = 22;
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // rbOnlyChecked
            // 
            this.rbOnlyChecked.AutoSize = true;
            this.rbOnlyChecked.Location = new System.Drawing.Point(509, 59);
            this.rbOnlyChecked.Name = "rbOnlyChecked";
            this.rbOnlyChecked.Size = new System.Drawing.Size(92, 18);
            this.rbOnlyChecked.TabIndex = 33;
            this.rbOnlyChecked.Text = "Only Checked";
            this.rbOnlyChecked.UseVisualStyleBackColor = true;
            this.rbOnlyChecked.CheckedChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // rbOnlyUnchecked
            // 
            this.rbOnlyUnchecked.AutoSize = true;
            this.rbOnlyUnchecked.Checked = true;
            this.rbOnlyUnchecked.Location = new System.Drawing.Point(383, 59);
            this.rbOnlyUnchecked.Name = "rbOnlyUnchecked";
            this.rbOnlyUnchecked.Size = new System.Drawing.Size(104, 18);
            this.rbOnlyUnchecked.TabIndex = 32;
            this.rbOnlyUnchecked.TabStop = true;
            this.rbOnlyUnchecked.Text = "Only Unchecked";
            this.rbOnlyUnchecked.UseVisualStyleBackColor = true;
            this.rbOnlyUnchecked.CheckedChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.frmmessageQry_Load);
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Message)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Message)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Message)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
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

                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
                template._common.extend.Translate((repsol.forms.template.consulta.QueryForm)this);
                this.cmbStaff.Focus();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
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

        private void frmmessageQry_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
                this.cmbStaff.Focus();
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
                ctrl.ctrlQuery ctrl = new asr.app.pc.lts.frm.message.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
                template._common.extend.Translate((repsol.forms.template.consulta.QueryForm)this);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
