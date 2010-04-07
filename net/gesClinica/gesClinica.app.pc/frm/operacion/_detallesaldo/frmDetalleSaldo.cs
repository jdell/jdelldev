using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.operacion._detallesaldo
{
    class frmDetalleSaldo:template.frm.BaseForm
    {
        private System.Windows.Forms.SplitContainer splitContainer3;
        internal System.Windows.Forms.DataGridView dgOperacionDetalle;
        internal System.Windows.Forms.DataGridView dgOperacionTotal;

        private lib.vo.Paciente _paciente;

        public lib.vo.Paciente Paciente
        {
            get { return _paciente; }
        }

        public frmDetalleSaldo(lib.vo.Paciente paciente)
        {
            InitializeComponent();

            _paciente = paciente;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgOperacionDetalle = new System.Windows.Forms.DataGridView();
            this.dgOperacionTotal = new System.Windows.Forms.DataGridView();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacionTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgOperacionDetalle);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgOperacionTotal);
            this.splitContainer3.Size = new System.Drawing.Size(610, 309);
            this.splitContainer3.SplitterDistance = 280;
            this.splitContainer3.TabIndex = 3;
            // 
            // dgOperacionDetalle
            // 
            this.dgOperacionDetalle.AllowUserToAddRows = false;
            this.dgOperacionDetalle.AllowUserToDeleteRows = false;
            this.dgOperacionDetalle.AllowUserToResizeColumns = false;
            this.dgOperacionDetalle.AllowUserToResizeRows = false;
            this.dgOperacionDetalle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOperacionDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOperacionDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOperacionDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgOperacionDetalle.Name = "dgOperacionDetalle";
            this.dgOperacionDetalle.RowHeadersVisible = false;
            this.dgOperacionDetalle.Size = new System.Drawing.Size(610, 280);
            this.dgOperacionDetalle.TabIndex = 0;
            // 
            // dgOperacionTotal
            // 
            this.dgOperacionTotal.AllowUserToAddRows = false;
            this.dgOperacionTotal.AllowUserToDeleteRows = false;
            this.dgOperacionTotal.AllowUserToResizeColumns = false;
            this.dgOperacionTotal.AllowUserToResizeRows = false;
            this.dgOperacionTotal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgOperacionTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgOperacionTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperacionTotal.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOperacionTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgOperacionTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOperacionTotal.Location = new System.Drawing.Point(0, 0);
            this.dgOperacionTotal.Name = "dgOperacionTotal";
            this.dgOperacionTotal.RowHeadersVisible = false;
            this.dgOperacionTotal.Size = new System.Drawing.Size(610, 25);
            this.dgOperacionTotal.TabIndex = 1;
            // 
            // frmDetalleSaldo
            // 
            this.ClientSize = new System.Drawing.Size(610, 309);
            this.Controls.Add(this.splitContainer3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalleSaldo";
            this.Text = "Operaciones por paciente";
            this.Load += new System.EventHandler(this.frmDetalleSaldo_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperacionTotal)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmDetalleSaldo_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlDetalleSaldo ctrl = new gesClinica.app.pc.frm.operacion._detallesaldo.ctrl.ctrlDetalleSaldo();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
