namespace asr.app.pc._template.controls
{
    partial class AddressBox
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox = new System.Windows.Forms.GroupBox();
            this.txtState = new repsol.forms.controls.TextBoxColor();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCity = new repsol.forms.controls.TextBoxColor();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAddress = new repsol.forms.controls.TextBoxColor();
            this.label21 = new System.Windows.Forms.Label();
            this.txtZipCode = new repsol.forms.controls.TextBoxColor();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.txtZipCode);
            this.gbox.Controls.Add(this.label1);
            this.gbox.Controls.Add(this.txtState);
            this.gbox.Controls.Add(this.label19);
            this.gbox.Controls.Add(this.txtCity);
            this.gbox.Controls.Add(this.label20);
            this.gbox.Controls.Add(this.txtAddress);
            this.gbox.Controls.Add(this.label21);
            this.gbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox.Location = new System.Drawing.Point(0, 0);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(519, 121);
            this.gbox.TabIndex = 0;
            this.gbox.TabStop = false;
            this.gbox.Text = "groupBox1";
            // 
            // txtState
            // 
            this.txtState.ActivateStyle = true;
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtState.ColorLeave = System.Drawing.Color.White;
            this.txtState.Location = new System.Drawing.Point(285, 62);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(75, 22);
            this.txtState.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(240, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 14);
            this.label19.TabIndex = 65;
            this.label19.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.ActivateStyle = true;
            this.txtCity.BackColor = System.Drawing.Color.White;
            this.txtCity.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtCity.ColorLeave = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(72, 62);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 22);
            this.txtCity.TabIndex = 62;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 14);
            this.label20.TabIndex = 63;
            this.label20.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.ActivateStyle = true;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAddress.ColorLeave = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(72, 32);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(439, 22);
            this.txtAddress.TabIndex = 60;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 14);
            this.label21.TabIndex = 61;
            this.label21.Text = "Address";
            // 
            // txtZipCode
            // 
            this.txtZipCode.ActivateStyle = true;
            this.txtZipCode.BackColor = System.Drawing.Color.White;
            this.txtZipCode.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtZipCode.ColorLeave = System.Drawing.Color.White;
            this.txtZipCode.Location = new System.Drawing.Point(439, 62);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(73, 22);
            this.txtZipCode.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 67;
            this.label1.Text = "Zip Code";
            // 
            // AddressBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddressBox";
            this.Size = new System.Drawing.Size(519, 121);
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.GroupBox gbox;
        public repsol.forms.controls.TextBoxColor txtZipCode;
        public repsol.forms.controls.TextBoxColor txtState;
        public repsol.forms.controls.TextBoxColor txtCity;
        public repsol.forms.controls.TextBoxColor txtAddress;
    }
}
