using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc.template.controls
{
    public partial class AddressBox : UserControl
    {
        public AddressBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            get
            {
                return gbox.Text;
            }
            set
            {
                gbox.Text = value;
            }
        }
    }
}
