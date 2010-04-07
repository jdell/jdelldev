using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.edicion
{
    public class EditForm:repsol.forms.template.edicion.EditForm
    {
        public EditForm()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }
        public EditForm(bool soloconsulta)
            : base(soloconsulta)
        {
            InitializeComponent();
            this.newRecord = false;
            this.ShowIcon = false;           
        }


        public System.Windows.Forms.Button Aceptar
        {
            get
            {
                return this.btAceptar;
            }
        }
        public System.Windows.Forms.Button Cancelar
        {
            get
            {
                return this.btCancelar;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.PaleGreen;
            this.btAceptar.Location = new System.Drawing.Point(303, 11);
            this.btAceptar.Text = "Guardar";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCancelar.Location = new System.Drawing.Point(383, 11);
            this.btCancelar.Text = "Salir";
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 198);
            this.panFooter.Size = new System.Drawing.Size(470, 43);
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Edición - Nuevo registro";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Control de Excepciones

        protected void resetErrProvider()
        {
            try
            {
                this.errProvider.Clear();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        protected virtual void exceptionManagement(Exception ex)
        {
            template._common.messages.ShowError(ex);
        }

        #endregion

        public void txtImporte_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
                try
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                }
                catch (Exception ex)
                {
                    template._common.messages.ShowError(ex);
                }
        }
    }
}
