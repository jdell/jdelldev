using System;
using System.Collections.Generic;
using System.Text;
using gesClinica.lib.vo;

namespace gesClinica.app.pc.frm.apunte
{
    internal class frmQuerySubCuenta:template.frm.consulta.QueryForm
    {
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cmbSubCuenta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparadorAsiento;
        private System.Windows.Forms.ToolStripMenuItem asientoAsociadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAsientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarAsientoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.ToolStripMenuItem puntearDespuntearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntearDespuntearHastaSeleccionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despuntearHastaSeleccionadoToolStripMenuItem;
        internal System.Windows.Forms.ComboBox cmbEjercicio;
    
        public frmQuerySubCuenta()
            : base(true)
        {
            InitializeComponent();

            this.btImprimir.Visible = true;

            ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSubCuenta = new System.Windows.Forms.ComboBox();
            this.toolStripSeparadorAsiento = new System.Windows.Forms.ToolStripSeparator();
            this.asientoAsociadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAsientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarAsientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.puntearDespuntearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntearDespuntearHastaSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despuntearHastaSeleccionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panInfo.SuspendLayout();
            this.panHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panDetail
            // 
            this.panDetail.Location = new System.Drawing.Point(0, 177);
            this.panDetail.Size = new System.Drawing.Size(792, 396);
            // 
            // panInfo
            // 
            this.panInfo.Location = new System.Drawing.Point(0, 152);
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.label5);
            this.panHead.Controls.Add(this.dateFechaHasta);
            this.panHead.Controls.Add(this.label4);
            this.panHead.Controls.Add(this.dateFechaDesde);
            this.panHead.Controls.Add(this.label2);
            this.panHead.Controls.Add(this.cmbSubCuenta);
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.cmbEmpresa);
            this.panHead.Controls.Add(this.label3);
            this.panHead.Controls.Add(this.cmbEjercicio);
            this.panHead.Size = new System.Drawing.Size(792, 127);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(245, 3);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(376, 22);
            this.cmbEmpresa.TabIndex = 0;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ejercicio";
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(245, 31);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(376, 22);
            this.cmbEjercicio.TabIndex = 1;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "SubCuenta";
            // 
            // cmbSubCuenta
            // 
            this.cmbSubCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCuenta.FormattingEnabled = true;
            this.cmbSubCuenta.Location = new System.Drawing.Point(245, 59);
            this.cmbSubCuenta.Name = "cmbSubCuenta";
            this.cmbSubCuenta.Size = new System.Drawing.Size(376, 22);
            this.cmbSubCuenta.TabIndex = 2;
            this.cmbSubCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbSubCuenta_SelectedIndexChanged);
            // 
            // toolStripSeparadorAsiento
            // 
            this.toolStripSeparadorAsiento.Name = "toolStripSeparadorAsiento";
            this.toolStripSeparadorAsiento.Size = new System.Drawing.Size(164, 6);
            // 
            // asientoAsociadoToolStripMenuItem
            // 
            this.asientoAsociadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarAsientoToolStripMenuItem,
            this.borrarAsientoToolStripMenuItem});
            this.asientoAsociadoToolStripMenuItem.Name = "asientoAsociadoToolStripMenuItem";
            this.asientoAsociadoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.asientoAsociadoToolStripMenuItem.Text = "Asiento Asociado";
            // 
            // modificarAsientoToolStripMenuItem
            // 
            this.modificarAsientoToolStripMenuItem.Name = "modificarAsientoToolStripMenuItem";
            this.modificarAsientoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modificarAsientoToolStripMenuItem.Text = "Modificar Asiento";
            this.modificarAsientoToolStripMenuItem.Click += new System.EventHandler(this.modificarAsientoToolStripMenuItem_Click);
            // 
            // borrarAsientoToolStripMenuItem
            // 
            this.borrarAsientoToolStripMenuItem.Name = "borrarAsientoToolStripMenuItem";
            this.borrarAsientoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.borrarAsientoToolStripMenuItem.Text = "Borrar Asiento";
            this.borrarAsientoToolStripMenuItem.Click += new System.EventHandler(this.borrarAsientoToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "Fecha desde";
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaDesde.Location = new System.Drawing.Point(245, 87);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.Size = new System.Drawing.Size(136, 20);
            this.dateFechaDesde.TabIndex = 3;
            this.dateFechaDesde.ValueChanged += new System.EventHandler(this.dateFecha_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha hasta";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaHasta.Location = new System.Drawing.Point(485, 88);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.Size = new System.Drawing.Size(136, 20);
            this.dateFechaHasta.TabIndex = 4;
            this.dateFechaHasta.ValueChanged += new System.EventHandler(this.dateFecha_ValueChanged);
            // 
            // puntearDespuntearToolStripMenuItem
            // 
            this.puntearDespuntearToolStripMenuItem.Name = "puntearDespuntearToolStripMenuItem";
            this.puntearDespuntearToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.puntearDespuntearToolStripMenuItem.Text = "Puntear/Despuntear";
            this.puntearDespuntearToolStripMenuItem.Click += new System.EventHandler(this.puntearDespuntearToolStripMenuItem_Click);
            // 
            // puntearDespuntearHastaSeleccionadoToolStripMenuItem
            // 
            this.puntearDespuntearHastaSeleccionadoToolStripMenuItem.Name = "puntearDespuntearHastaSeleccionadoToolStripMenuItem";
            this.puntearDespuntearHastaSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.puntearDespuntearHastaSeleccionadoToolStripMenuItem.Text = "Puntear hasta seleccionado";
            this.puntearDespuntearHastaSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.puntearDespuntearHastaSeleccionadoToolStripMenuItem_Click);
            // 
            // despuntearHastaSeleccionadoToolStripMenuItem
            // 
            this.despuntearHastaSeleccionadoToolStripMenuItem.Name = "despuntearHastaSeleccionadoToolStripMenuItem";
            this.despuntearHastaSeleccionadoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.despuntearHastaSeleccionadoToolStripMenuItem.Text = "Despuntear hasta seleccionado";
            this.despuntearHastaSeleccionadoToolStripMenuItem.Click += new System.EventHandler(this.despuntearHastaSeleccionadoToolStripMenuItem_Click);
            // 
            // frmQuerySubCuenta
            // 
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Name = "frmQuerySubCuenta";
            this.Text = "SubCuentas : Resumen de Movimientos";
            this.Load += new System.EventHandler(this.frmapunteQry_Load);
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

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Apunte)ctrl.getRegistroSeleccionado(ref frm), false);
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

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Apunte)ctrl.getRegistroSeleccionado(ref frm), true);
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
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                frmEdit vVen = new frmEdit((Apunte)ctrl.getRegistroSeleccionado(ref frm));
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
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
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

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
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
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
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

        private void frmapunteQry_Load(object sender, EventArgs e)
        {
            try
            {

                this.contextMenu2.Items.Add(this.toolStripSeparadorAsiento);
                this.contextMenu2.Items.Add(this.asientoAsociadoToolStripMenuItem);
                this.contextMenu2.Items.Add(this.puntearDespuntearToolStripMenuItem);
                this.contextMenu2.Items.Add(this.puntearDespuntearHastaSeleccionadoToolStripMenuItem);
                this.contextMenu2.Items.Add(this.despuntearHastaSeleccionadoToolStripMenuItem);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void filtrar_Handler(object sender, EventArgs e)
        {

        }
        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
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
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                frmQuerySubCuenta frm = (frmQuerySubCuenta)this;
                ctrl.loadEjercicio(ref frm);
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void cmbSubCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
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

        private void modificarAsientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                Apunte apunte = (Apunte)ctrl.getRegistroSeleccionado(ref frm);
                lib.bl.asiento.doGet lnAsiento = new gesClinica.lib.bl.asiento.doGet(apunte.Asiento);
                apunte.Asiento = lnAsiento.execute();
                asiento.frmEdit vVen = new asiento.frmEdit(apunte.Asiento, false);
                vVen.ShowDialog();
                btRefresh_record();
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void borrarAsientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                if (System.Windows.Forms.DialogResult.Yes == System.Windows.Forms.MessageBox.Show(_common.constantes.messages.WANT_DELETE_RECORD, this.Text, System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question))
                {
                    Apunte apunte = (Apunte)ctrl.getRegistroSeleccionado(ref frm);
                    lib.bl.asiento.doDelete lnAsiento = new gesClinica.lib.bl.asiento.doDelete(apunte.Asiento);
                    lnAsiento.execute();
                    btRefresh_record();
                }
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.setError(string.Empty);

                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                ctrl.saveSelectedRow(frm);
                ctrl.filtrarRegistros(ref frm);
                ctrl.loadSelectedRow(frm);
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void puntearDespuntearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }
                Apunte apunte = (lib.vo.Apunte)ctrl.getRegistroSeleccionado(ref frm);
                ctrl.Puntear(apunte, !apunte.Punteado);
                btRefresh_record();
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void puntearDespuntearHastaSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                ctrl.PuntearHastaSeleccionado(ref frm, true);
                btRefresh_record();
            }
            catch (Exception ex)
            {
                this.setError(ex.Message);
            }
        }

        private void despuntearHastaSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlQuerySubCuenta ctrl = new gesClinica.app.pc.frm.apunte.ctrl.ctrlQuerySubCuenta();
                repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this;
                if (ctrl.getRegistroSeleccionado(ref frm) == null)
                {
                    template._common.messages.ShowWarning(_common.constantes.messages.NO_RECORD_SELECTED, this.Text);
                    return;
                }

                ctrl.PuntearHastaSeleccionado(ref frm, false);
                btRefresh_record();
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
                _setting.settingQuerySubCuenta res = (_setting.settingQuerySubCuenta)setting;

                if (res.Empresa != null) this.cmbEmpresa.SelectedValue = res.Empresa.ID;
                if (res.Ejercicio != null) this.cmbEjercicio.SelectedValue = res.Ejercicio.ID;
                if (res.SubCuenta != null) this.cmbSubCuenta.SelectedValue = res.SubCuenta.Codigo;
                this.dateFechaDesde.Value = res.FechaDesde;
                this.dateFechaHasta.Value = res.FechaHasta;
               
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
                _setting.settingQuerySubCuenta res = new gesClinica.app.pc.frm.apunte._setting.settingQuerySubCuenta();

                res.Location = tmp.Location;
                res.Size = tmp.Size;
                res.WindowState = tmp.WindowState;
                res.Empresa = (lib.vo.Empresa)this.cmbEmpresa.SelectedItem;
                res.Ejercicio = (lib.vo.Ejercicio)this.cmbEjercicio.SelectedItem;
                res.SubCuenta = (lib.vo.SubCuenta)this.cmbSubCuenta.SelectedItem;
                res.FechaDesde = this.dateFechaDesde.Value;
                res.FechaHasta = this.dateFechaHasta.Value;

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
