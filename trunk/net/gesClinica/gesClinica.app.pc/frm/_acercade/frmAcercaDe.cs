using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm._acercade
{
    class frmAcercaDe:template.frm.BaseForm
    {
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label labUltimaRevision;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label labVersion;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label labProduct;
        internal System.Windows.Forms.Label labCompany;
        internal System.Windows.Forms.Label labDeveloper;
        internal System.Windows.Forms.Button btAceptar;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label labTituloCompany;
        internal System.Windows.Forms.Label labTituloDescripcion;
        internal System.Windows.Forms.Label labTituloProducto;

        public frmAcercaDe()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.Panel2 = new System.Windows.Forms.Panel();
            this.labUltimaRevision = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.labVersion = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.labProduct = new System.Windows.Forms.Label();
            this.labCompany = new System.Windows.Forms.Label();
            this.labDeveloper = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.labTituloCompany = new System.Windows.Forms.Label();
            this.labTituloDescripcion = new System.Windows.Forms.Label();
            this.labTituloProducto = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.labUltimaRevision);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.labVersion);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.labProduct);
            this.Panel2.Controls.Add(this.labCompany);
            this.Panel2.Controls.Add(this.labDeveloper);
            this.Panel2.Location = new System.Drawing.Point(8, 78);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(384, 130);
            this.Panel2.TabIndex = 14;
            // 
            // labUltimaRevision
            // 
            this.labUltimaRevision.BackColor = System.Drawing.Color.Transparent;
            this.labUltimaRevision.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUltimaRevision.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labUltimaRevision.Location = new System.Drawing.Point(3, 111);
            this.labUltimaRevision.Name = "labUltimaRevision";
            this.labUltimaRevision.Size = new System.Drawing.Size(376, 14);
            this.labUltimaRevision.TabIndex = 12;
            this.labUltimaRevision.Text = "Última revisión 04/2009";
            this.labUltimaRevision.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(40, 48);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Producto :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(40, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Versión :";
            // 
            // labVersion
            // 
            this.labVersion.AutoSize = true;
            this.labVersion.BackColor = System.Drawing.Color.Transparent;
            this.labVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVersion.ForeColor = System.Drawing.Color.Black;
            this.labVersion.Location = new System.Drawing.Point(128, 72);
            this.labVersion.Name = "labVersion";
            this.labVersion.Size = new System.Drawing.Size(24, 13);
            this.labVersion.TabIndex = 6;
            this.labVersion.Text = "1.0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(40, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Empresa :";
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.BackColor = System.Drawing.Color.Transparent;
            this.labProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduct.ForeColor = System.Drawing.Color.Black;
            this.labProduct.Location = new System.Drawing.Point(128, 48);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(51, 13);
            this.labProduct.TabIndex = 5;
            this.labProduct.Text = "GesInef";
            // 
            // labCompany
            // 
            this.labCompany.AutoSize = true;
            this.labCompany.BackColor = System.Drawing.Color.Transparent;
            this.labCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCompany.ForeColor = System.Drawing.Color.Black;
            this.labCompany.Location = new System.Drawing.Point(128, 24);
            this.labCompany.Name = "labCompany";
            this.labCompany.Size = new System.Drawing.Size(68, 13);
            this.labCompany.TabIndex = 4;
            this.labCompany.Text = "Repsol YPF";
            // 
            // labDeveloper
            // 
            this.labDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.labDeveloper.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDeveloper.ForeColor = System.Drawing.Color.Black;
            this.labDeveloper.Location = new System.Drawing.Point(3, 96);
            this.labDeveloper.Name = "labDeveloper";
            this.labDeveloper.Size = new System.Drawing.Size(376, 13);
            this.labDeveloper.TabIndex = 7;
            this.labDeveloper.Text = "Desarrollado por Igasoft SL. 2008";
            this.labDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(320, 214);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 13;
            this.btAceptar.Text = "Cerrar";
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Panel1.Controls.Add(this.labTituloCompany);
            this.Panel1.Controls.Add(this.labTituloDescripcion);
            this.Panel1.Controls.Add(this.labTituloProducto);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(401, 72);
            this.Panel1.TabIndex = 12;
            // 
            // labTituloCompany
            // 
            this.labTituloCompany.AutoSize = true;
            this.labTituloCompany.BackColor = System.Drawing.Color.Transparent;
            this.labTituloCompany.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloCompany.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labTituloCompany.Location = new System.Drawing.Point(12, 8);
            this.labTituloCompany.Name = "labTituloCompany";
            this.labTituloCompany.Size = new System.Drawing.Size(60, 13);
            this.labTituloCompany.TabIndex = 2;
            this.labTituloCompany.Text = "Repsol YPF";
            // 
            // labTituloDescripcion
            // 
            this.labTituloDescripcion.AutoSize = true;
            this.labTituloDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.labTituloDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloDescripcion.ForeColor = System.Drawing.Color.White;
            this.labTituloDescripcion.Location = new System.Drawing.Point(12, 48);
            this.labTituloDescripcion.Name = "labTituloDescripcion";
            this.labTituloDescripcion.Size = new System.Drawing.Size(160, 16);
            this.labTituloDescripcion.TabIndex = 1;
            this.labTituloDescripcion.Text = "Gestión de Ineficiencias";
            // 
            // labTituloProducto
            // 
            this.labTituloProducto.AutoSize = true;
            this.labTituloProducto.BackColor = System.Drawing.Color.Transparent;
            this.labTituloProducto.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloProducto.ForeColor = System.Drawing.Color.White;
            this.labTituloProducto.Location = new System.Drawing.Point(4, 16);
            this.labTituloProducto.Name = "labTituloProducto";
            this.labTituloProducto.Size = new System.Drawing.Size(142, 39);
            this.labTituloProducto.TabIndex = 0;
            this.labTituloProducto.Text = "GesInef";
            // 
            // frmAcercaDe
            // 
            this.ClientSize = new System.Drawing.Size(401, 240);
            this.ControlBox = false;
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAcercaDe_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlAcercaDe ctrl = new gesClinica.app.pc.frm._acercade.ctrl.ctrlAcercaDe();
                repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
                ctrl.inicializarForm(ref frm);
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
