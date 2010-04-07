using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.gui.pc._template.frm
{
    public class BaseForm:System.Windows.Forms.Form
    {
        public BaseForm()
        {
            InitializeComponent();
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
