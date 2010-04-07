using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.lts.frm._splash
{
    class frmSplash: repsol.forms.SplashScreen
    {
        public frmSplash()
        {
            InitializeComponent();
            ctrl.ctrlSplash ctrl = new asr.app.pc.lts.frm._splash.ctrl.ctrlSplash();
            frmSplash frm = this;
            ctrl.inicializar(ref frm);
        }

        public void Avanza(lib.bl._events.ProgressEventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();

            this.Current = this.Max * e.CurrentProcess / e.TotalProcess;
            this.StatusDetails = e.InfoProcess;
            this.Refresh();
        }
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            ((System.ComponentModel.ISupportInitialize)(this.iconoEspera)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Size = new System.Drawing.Size(481, 170);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // frmSplash
            // 
            this.ClientSize = new System.Drawing.Size(499, 471);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoEspera)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
