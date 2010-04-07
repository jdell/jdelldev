using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc.template.controls
{
    public partial class SuperToolTip : UserControl
    {
        public SuperToolTip()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public void setControl(Control c)
        {
            this.Controls.Clear();
            this.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }


    }
}
