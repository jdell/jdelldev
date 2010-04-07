using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.factura
{
    internal class frmQuery:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.ContextMenuStrip contextMenuAux;
        private System.ComponentModel.IContainer components;
        internal System.Windows.Forms.ToolStripSeparator toolStripMenuSeparadorImprimir;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmbEjercicio;
        internal System.Windows.Forms.ToolStripMenuItem imprimirFacturaToolStripMenuItem;
    
        public frmQuery()
        {
            InitializeComponent();

            this.NuevoToolStripMenuItem.Visible = false;
            this.btNuevo.Visible = false;
            this.DuplicarToolStripMenuItem.Visible = false;
            this.btDuplicar.Visible = false;

            ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuAux = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSeparadorImprimir = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
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
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.cmbEmpresa);
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.cmbEjercicio);
            // 
            // contextMenuAux
            // 
            this.contextMenuAux.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSeparadorImprimir,
            this.imprimirFacturaToolStripMenuItem});
            this.contextMenuAux.Name = "contextMenuStrip1";
            this.contextMenuAux.Size = new System.Drawing.Size(162, 32);
            // 
            // toolStripMenuSeparadorImprimir
            // 
            this.toolStripMenuSeparadorImprimir.Name = "toolStripMenuSeparadorImprimir";
            this.toolStripMenuSeparadorImprimir.Size = new System.Drawing.Size(158, 6);
            // 
            // imprimirFacturaToolStripMenuItem
            // 
            this.imprimirFacturaToolStripMenuItem.Name = "imprimirFacturaToolStripMenuItem";
            this.imprimirFacturaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.imprimirFacturaToolStripMenuItem.Text = "Imprimir factura";
            this.imprimirFacturaToolStripMenuItem.Click += new System.EventHandler(this.imprimirFacturaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(245, 26);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpresa.TabIndex = 40;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ejercicio";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(245, 54);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(376, 22);
            this.cmbEjercicio.TabIndex = 38;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // frmQuery
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuery";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmfacturaQry_Load);
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
                throw new Exception("No implementado");
                //frmEdit vVen = new frmEdit();
                //vVen.ShowDialog();
                //btRefresh_record();
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Factura)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Factura)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Factura)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
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
            //try
            //{
            //    this.setError(string.Empty);

            //    ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
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

        private void frmfacturaQry_Load(object sender, EventArgs e)
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
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.filtrarRegistros(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void imprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmPrint vVen = new frmPrint((lib.vo.Factura)ctrl.getRegistroSeleccionado(ref frm));
                vVen.Show();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
                frmQuery frm = (frmQuery)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuery ctrl = new gesClinica.app.pc.frm.factura.ctrl.ctrlQuery();
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
                _setting.settingQuery res = new gesClinica.app.pc.frm.factura._setting.settingQuery();

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
