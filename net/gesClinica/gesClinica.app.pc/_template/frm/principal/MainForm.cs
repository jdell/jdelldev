using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.template.frm.principal
{
    public class MainForm: repsol.forms.template.principal.MainForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.RememberUserPreferences = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(538, 441);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }
    }
}
