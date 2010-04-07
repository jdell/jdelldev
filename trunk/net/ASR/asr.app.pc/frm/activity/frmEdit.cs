using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.app.pc.frm.activity
{
    class frmEdit: template.frm.edicion.EditForm
    {
        internal repsol.forms.controls.TextBoxColor txtDescription;
        protected internal System.Windows.Forms.RadioButton rbOutgoing;
        protected internal System.Windows.Forms.RadioButton rbIncoming;
        private System.Windows.Forms.Label label2;
        internal repsol.forms.controls.TextBoxColor txtClient;
        private System.Windows.Forms.Label label4;

        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public frmEdit(Client client)
        {
            InitializeComponent();

            this.Client = client;


            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.activity.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, new Activity());
        }
        public frmEdit(Activity objVO)
        {
            InitializeComponent();

            this.Client = objVO.Client;


            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.activity.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }
        public frmEdit(Activity objVO, bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();

            this.Client = objVO.Client;


            ctrl.ctrlEdit ctrl = new asr.app.pc.frm.activity.ctrl.ctrlEdit();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
            repsol.forms.template.edicion.EditForm edit = (repsol.forms.template.edicion.EditForm)this;
            ctrl.cargarDatos(ref edit, objVO);
        }

        protected override void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEdit ctrl = new asr.app.pc.frm.activity.ctrl.ctrlEdit();
                repsol.forms.template.edicion.EditForm frm = (repsol.forms.template.edicion.EditForm)this;
                ctrl.guardarDatos(ref frm,this.IsNewRecord);
                base.btAceptar_Click(sender, e);

                if (this.Client != null)
                {
                    this.txtClient.Tag = this.Client;
                    this.txtClient.Text = this.Client.FullName;
                }
                
            }
            catch (Exception ex)
            {                
                template._common.messages.ShowError(ex);
            }
        }

        private void InitializeComponent()
        {
            this.txtDescription = new repsol.forms.controls.TextBoxColor();
            this.label2 = new System.Windows.Forms.Label();
            this.rbOutgoing = new System.Windows.Forms.RadioButton();
            this.rbIncoming = new System.Windows.Forms.RadioButton();
            this.txtClient = new repsol.forms.controls.TextBoxColor();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(441, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(521, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 148);
            this.panFooter.Size = new System.Drawing.Size(516, 43);
            this.panFooter.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.ActivateStyle = true;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtDescription.ColorLeave = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(108, 64);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(362, 61);
            this.txtDescription.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // rbOutgoing
            // 
            this.rbOutgoing.AutoSize = true;
            this.rbOutgoing.Location = new System.Drawing.Point(399, 40);
            this.rbOutgoing.Name = "rbOutgoing";
            this.rbOutgoing.Size = new System.Drawing.Size(71, 18);
            this.rbOutgoing.TabIndex = 33;
            this.rbOutgoing.Text = "Expense";
            this.rbOutgoing.UseVisualStyleBackColor = true;
            // 
            // rbIncoming
            // 
            this.rbIncoming.AutoSize = true;
            this.rbIncoming.Checked = true;
            this.rbIncoming.Location = new System.Drawing.Point(307, 40);
            this.rbIncoming.Name = "rbIncoming";
            this.rbIncoming.Size = new System.Drawing.Size(66, 18);
            this.rbIncoming.TabIndex = 32;
            this.rbIncoming.TabStop = true;
            this.rbIncoming.Text = "Income";
            this.rbIncoming.UseVisualStyleBackColor = true;
            // 
            // txtClient
            // 
            this.txtClient.ActivateStyle = false;
            this.txtClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtClient.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtClient.ColorLeave = System.Drawing.Color.White;
            this.txtClient.Location = new System.Drawing.Point(108, 12);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(362, 22);
            this.txtClient.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "Client";
            // 
            // frmEdit
            // 
            this.ClientSize = new System.Drawing.Size(516, 191);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbOutgoing);
            this.Controls.Add(this.rbIncoming);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Name = "frmEdit";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDescription, 0);
            this.Controls.SetChildIndex(this.rbIncoming, 0);
            this.Controls.SetChildIndex(this.rbOutgoing, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtClient, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        bool closeOnAccept = false;
        public bool CloseOnAccept
        {
            get
            {
                return closeOnAccept;
            }
            set
            {
                closeOnAccept = value;
                this.chkCerrar.Checked = closeOnAccept;
            }
        }
        private void frmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Client != null)
                {
                    this.txtClient.Tag = this.Client;
                    this.txtClient.Text = this.Client.FullName;
                }
                if ((this.IsNewRecord) && (!closeOnAccept))
                {
                    // 
                    // chkCerrar
                    // 
                    this.chkCerrar.Checked = false;
                    this.chkCerrar.CheckState = System.Windows.Forms.CheckState.Unchecked;
                }
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
