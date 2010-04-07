using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.cita
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEmpleado;
        internal System.Windows.Forms.DateTimePicker dateFecha;
    
        public frmQuery()
        {
            InitializeComponent();

            ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
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
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.cmbEmpleado);
            this.panHead.Controls.Add(this.label5);
            this.panHead.Controls.Add(this.cmbSala);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.dateFecha);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "dd/MM/yyyy";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFecha.Location = new System.Drawing.Point(233, 31);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(136, 20);
            this.dateFecha.TabIndex = 20;
            this.dateFecha.ValueChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 14);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sala";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(432, 31);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(177, 22);
            this.cmbSala.TabIndex = 30;
            this.cmbSala.SelectedIndexChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Terapeuta";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(233, 59);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpleado.TabIndex = 32;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.filtrar_Handler);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQueryCita";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.frmcitaQry_Load);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Cita)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Cita)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Cita)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
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

        private void frmcitaQry_Load(object sender, EventArgs e)
        {
            try
            {

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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.ConsultaRegistros(ref frm);
                //ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        #region UserSetting

        protected override repsol.util.setting.userpreferences getUserPreferences()
        {
            _settings.QuerySetting res = new gesClinica.app.pc.frm.cita._settings.QuerySetting(base.getUserPreferences());

            
            ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
            repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
            res.FiltroCita = ctrl.getFiltroCita(ref frm);

            return res;
        }

        protected override void setUserPreferences(repsol.util.setting.userpreferences setting)
        {
            base.setUserPreferences(setting);

            _settings.QuerySetting res = (_settings.QuerySetting)setting;

            ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.cita.ctrl.ctrlQuery();
            repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
            ctrl.setFiltroCita(ref frm, res.FiltroCita);
        }

        #endregion
    }
}
