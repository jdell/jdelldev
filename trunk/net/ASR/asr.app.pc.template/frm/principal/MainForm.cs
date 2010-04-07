using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.frm.principal
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c.GetType().FullName == typeof(System.Windows.Forms.MdiClient).FullName)
                {
                    String path = System.IO.Path.GetFullPath(@"_template\_images\background.png");
                    if (System.IO.File.Exists(path))
                    {
                        c.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                        c.BackgroundImage = new System.Drawing.Bitmap(path);
                    }
                    else
                        c.BackColor = System.Drawing.Color.LightSteelBlue;
                    break;
                }
            }
        }
    }
}
