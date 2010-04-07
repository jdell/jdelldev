using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc._template.controls
{
    class SuperToolTipClient: SuperToolTip
    {
        public System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label labLastName;

        private lib.vo.Client _client = null;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Label labHomePhone;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labCellPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private bool _active = false;

        [System.ComponentModel.DefaultValue(false)]
        public bool Active
        {
            get { return _active; }
            set 
            { 
                _active = value;
                if (!_active) this.Visible = false;
            }
        }

        public lib.vo.Client Client
        {
            get { return _client; }
            set 
            {
                _client = value;
                if (_client != null)
                {
                    if (_client.Photo != null) 
                        this.PictureBox.Image = _client.Photo;
                    else
                        this.PictureBox.Image = null;
                    this.labCellPhone.Text = string.Format(": {0}",_client.CellPhoneNumber);
                    this.labCity.Text = string.Format(": {0}", _client.HomeCity.ToUpper());
                    this.labFirstName.Text = string.Format(": {0}",_client.FirstName);
                    this.labHomePhone.Text = string.Format(": {0}",_client.HomePhoneNumber);
                    this.labLastName.Text = string.Format(": {0}",_client.LastName.ToUpper());
                }
                else
                {
                    this.PictureBox.Image = null;
                    this.labCellPhone.Text = 
                    this.labCity.Text = 
                    this.labFirstName.Text = 
                    this.labHomePhone.Text = this.labLastName.Text = ":";
                }
            }
        }

        private string _columnName = "objVO";

        [System.ComponentModel.DefaultValue("objVO")]
        public string ColumnName
        {
            get { return _columnName; }
            set { _columnName = value; }
        }

        private System.Windows.Forms.DataGridView _dataGridView = null;

        public System.Windows.Forms.DataGridView DataGridView
        {
            get { return _dataGridView; }
            set { 
                if (_dataGridView!=null)
                {
                    _dataGridView.MouseMove -= new System.Windows.Forms.MouseEventHandler(_dataGridView_MouseMove);
                    _dataGridView.MouseLeave -= new EventHandler(_dataGridView_MouseLeave);
                }
                _dataGridView = value;
                if (_dataGridView != null)
                {
                    _dataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(_dataGridView_MouseMove);
                    _dataGridView.MouseLeave += new EventHandler(_dataGridView_MouseLeave);
                }
            }
        }

        void _dataGridView_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        void _dataGridView_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if (_active)
                {
                    System.Windows.Forms.DataGridView.HitTestInfo hinfo = this.DataGridView.HitTest(e.X, e.Y);
                    if ((hinfo.ColumnIndex != -1) && (hinfo.RowIndex != -1))
                    {
                        System.Windows.Forms.PictureBox pic = new System.Windows.Forms.PictureBox();
                        repsol.forms.template.consulta.QueryForm frm = (repsol.forms.template.consulta.QueryForm)this.DataGridView.FindForm();

                        this.Client = (lib.vo.Client)this.DataGridView.Rows[hinfo.RowIndex].Cells[this.ColumnName].Value;

                        this.Visible = true;
                        this.Location = new System.Drawing.Point(e.Location.X + 20, e.Location.Y + 20);
                        this.BringToFront();
                    }
                    else
                        this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public SuperToolTipClient()
            : base()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.labHomePhone = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.labCellPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(148, 181);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLastName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labLastName.Location = new System.Drawing.Point(242, 33);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(67, 13);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Last Name";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labFirstName.Location = new System.Drawing.Point(242, 60);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(67, 13);
            this.labFirstName.TabIndex = 2;
            this.labFirstName.Text = "First Name";
            // 
            // labHomePhone
            // 
            this.labHomePhone.AutoSize = true;
            this.labHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHomePhone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labHomePhone.Location = new System.Drawing.Point(242, 87);
            this.labHomePhone.Name = "labHomePhone";
            this.labHomePhone.Size = new System.Drawing.Size(75, 13);
            this.labHomePhone.TabIndex = 3;
            this.labHomePhone.Text = "HomePhone";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCity.Location = new System.Drawing.Point(242, 141);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(28, 13);
            this.labCity.TabIndex = 5;
            this.labCity.Text = "City";
            // 
            // labCellPhone
            // 
            this.labCellPhone.AutoSize = true;
            this.labCellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCellPhone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labCellPhone.Location = new System.Drawing.Point(242, 114);
            this.labCellPhone.Name = "labCellPhone";
            this.labCellPhone.Size = new System.Drawing.Size(64, 13);
            this.labCellPhone.TabIndex = 6;
            this.labCellPhone.Text = "CellPhone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(157, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cell Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(157, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(157, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Home Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(157, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(157, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // SuperToolTipClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labCellPhone);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.labHomePhone);
            this.Controls.Add(this.labFirstName);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.PictureBox);
            this.Name = "SuperToolTipClient";
            this.Size = new System.Drawing.Size(442, 187);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
