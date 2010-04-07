using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.gui.pc._template.frm
{
    public class EditForm:BaseForm
    {
        private System.Windows.Forms.GroupBox groupBox1;

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditForm";
            this.ResumeLayout(false);

        }
    }
}
