using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.template.frm
{
    public class BaseForm:repsol.forms.template.BaseForm
    {
        public BaseForm()
        {
            InitializeComponent();
            this.RememberUserPreferences = true;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }
    }
}
