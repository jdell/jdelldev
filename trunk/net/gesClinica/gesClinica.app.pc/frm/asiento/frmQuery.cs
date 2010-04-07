using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.asiento
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        internal System.Windows.Forms.ComboBox cmbEjercicio;
    
        public frmQuery():base()
        {
            InitializeComponent();

            this.btNuevo.Enabled = false;
            this.NuevoToolStripMenuItem.Enabled = false;
            this.btDuplicar.Enabled = false;
            this.DuplicarToolStripMenuItem.Enabled = false;

            ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
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
            this.panHead.Controls.Add(this.cmbEmpresa);
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.cmbEjercicio);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ejercicio";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(245, 56);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(376, 22);
            this.cmbEjercicio.TabIndex = 34;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(245, 28);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpresa.TabIndex = 36;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Asientos";
            this.Load += new System.EventHandler(this.frmasientoQry_Load);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Asiento)ctrl.getRegistroSeleccionado(ref frm), false);
                vVen.ShowDialog();
                btRefresh_record();
                cmbEjercicio_SelectedIndexChanged(null, null);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Asiento)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Asiento)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    if ((bool)ctrl.BorrarRegistro(ref frm))
                        //btRefresh_record();
                        cmbEjercicio_SelectedIndexChanged(null, null);
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
            //try
            //{
            //    this.setError(string.Empty);

            //    ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
            //    repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
            //    ctrl.saveSelectedRow(frm);
            //    ctrl.ConsultaRegistros(ref frm);
            //    ctrl.loadSelectedRow(frm);
            //}
            //catch (Exception ex)
            //{
            //    //template._common.messages.ShowError(ex);
            //    this.setError(ex.Message);
            //}

        }
        protected override void btSeleccionar_record()
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
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

        private void frmasientoQry_Load(object sender, EventArgs e)
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.ConsultaRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.asiento.ctrl.ctrlQuery();
                frmQuery frm = (frmQuery)this;
                ctrl.loadEjercicio(ref frm);              
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }
        protected override void setUserPreferences(repsol.util.setting.userpreferences setting)
        {
            try
            {
                base.setUserPreferences(setting);
                _setting.settingQuery res = (_setting.settingQuery)setting;

                if (res.Empresa != null) this.cmbEmpresa.SelectedValue = res.Empresa.ID;
                if (res.Ejercicio != null) this.cmbEjercicio.SelectedValue = res.Ejercicio.ID;

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }

        }
        protected override repsol.util.setting.userpreferences getUserPreferences()
        {
            try
            {
                repsol.util.setting.userpreferences tmp = base.getUserPreferences();
                _setting.settingQuery res = new gesClinica.app.pc.frm.asiento._setting.settingQuery();

                res.Location = tmp.Location;
                res.Size = tmp.Size;
                res.WindowState = tmp.WindowState;
                res.Empresa = (lib.vo.Empresa)this.cmbEmpresa.SelectedItem;
                res.Ejercicio = (lib.vo.Ejercicio)this.cmbEjercicio.SelectedItem;

                return res;
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
                throw ex;
            }
        }
 
    }
}
