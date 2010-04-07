using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.template.controls
{
    internal class PictureBox: System.Windows.Forms.UserControl
    {
        private int _maxHeight = 25;
        private int _minHeight = 5;

        private string _filter = " Fotos (JPG, JPEG, GIF, BMP, TIFF,PNG) |*.jpg;*.jpeg;*.bmp;*.gif;*.tiff;*.png";

        private System.Windows.Forms.PictureBox pBox ;
        private System.Windows.Forms.ToolStrip tStrip;
        private System.Windows.Forms.ToolStripButton tsbBuscarImagen;
        private System.Windows.Forms.ToolStripButton tsbBorrarImagen;

        public PictureBox()
        {
            InitializeComponent();

            tStrip.BringToFront();
            pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            setToolStripHeight(_minHeight);

            pBox.MouseEnter += new EventHandler(setMaxHeightToStrip);
            tStrip.MouseEnter += new EventHandler(setMaxHeightToStrip);
            this.MouseEnter +=new EventHandler(setMaxHeightToStrip);

            pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(pBox_MouseMove);

            pBox.MouseLeave +=new EventHandler(setMinHeightToStrip);
            tStrip.MouseLeave +=new EventHandler(setMinHeightToStrip);
            this.MouseLeave +=new EventHandler(setMinHeightToStrip);
        }

        void pBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            System.Drawing.Point p = this.PointToClient(System.Windows.Forms.Cursor.Position);
            if (this.ClientRectangle.Contains(p))
                setToolStripHeight(_maxHeight);
        }

        private void InitializeComponent()
         {
             System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureBox));
             this.tStrip = new System.Windows.Forms.ToolStrip();
             this.tsbBuscarImagen = new System.Windows.Forms.ToolStripButton();
             this.tsbBorrarImagen = new System.Windows.Forms.ToolStripButton();
             this.pBox = new System.Windows.Forms.PictureBox();
             this.tStrip.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
             this.SuspendLayout();
             // 
             // tStrip
             // 
             this.tStrip.AutoSize = false;
             this.tStrip.BackColor = System.Drawing.SystemColors.Control;
             this.tStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
             this.tStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscarImagen,
            this.tsbBorrarImagen});
             this.tStrip.Location = new System.Drawing.Point(0, 0);
             this.tStrip.Name = "tStrip";
             this.tStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
             this.tStrip.Size = new System.Drawing.Size(197, 25);
             this.tStrip.TabIndex = 1;
             this.tStrip.Text = "ToolStrip1";
             // 
             // tsbBuscarImagen
             // 
             this.tsbBuscarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
             this.tsbBuscarImagen.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscarImagen.Image")));
             this.tsbBuscarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
             this.tsbBuscarImagen.Name = "tsbBuscarImagen";
             this.tsbBuscarImagen.Size = new System.Drawing.Size(23, 22);
             this.tsbBuscarImagen.Text = "...";
             this.tsbBuscarImagen.ToolTipText = "Buscar imagen";
             this.tsbBuscarImagen.Click += new System.EventHandler(this.tsbBuscarImagen_Click);
             // 
             // tsbBorrarImagen
             // 
             this.tsbBorrarImagen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
             this.tsbBorrarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
             this.tsbBorrarImagen.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrarImagen.Image")));
             this.tsbBorrarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
             this.tsbBorrarImagen.Name = "tsbBorrarImagen";
             this.tsbBorrarImagen.Size = new System.Drawing.Size(23, 22);
             this.tsbBorrarImagen.Text = "Borrar imagen";
             this.tsbBorrarImagen.Click += new System.EventHandler(this.tsbBorrarImagen_Click);
             // 
             // pBox
             // 
             this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
             this.pBox.Location = new System.Drawing.Point(0, 25);
             this.pBox.Name = "pBox";
             this.pBox.Size = new System.Drawing.Size(197, 179);
             this.pBox.TabIndex = 0;
             this.pBox.TabStop = false;
             // 
             // PictureBox
             // 
             this.Controls.Add(this.pBox);
             this.Controls.Add(this.tStrip);
             this.Name = "PictureBox";
             this.Size = new System.Drawing.Size(197, 204);
             this.tStrip.ResumeLayout(false);
             this.tStrip.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
             this.ResumeLayout(false);

        }

        private void setMaxHeightToStrip(object sender, EventArgs e)
        {
            setToolStripHeight(_maxHeight);
        }
        
        private void setToolStripHeight(int h)
        {
            this.tStrip.Height = h;
        }
        private void setMinHeightToStrip(object sender, EventArgs e)
        {
            System.Drawing.Point p = this.PointToClient(System.Windows.Forms.Cursor.Position);
            if (!this.ClientRectangle.Contains(p))
                setToolStripHeight(_minHeight);
        }

        public string Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                _filter = value;
            }
        }

        public int MaxHeight
        {
            get
            {
                return _maxHeight;
            }
            set
            {
                _maxHeight = value;
            }
        }

        public int MinHeight
        {
            get
            {
                return _minHeight;
            }
            set
            {
                _minHeight = value;
            }
        }

        public System.Drawing.Image Image
        {
            get
            {
                return pBox.Image;
            }
            set
            {
                pBox.Image = value;
            }
        }

        public System.Windows.Forms.PictureBoxSizeMode SizeMode
        {
            get
            {
                return pBox.SizeMode;
            }
            set
            {
                pBox.SizeMode = value;
            }
        }
     
         private void tsbBuscarImagen_Click(object sender, System.EventArgs e)
         {
            try
            {
                System.Windows.Forms.OpenFileDialog f = new System.Windows.Forms.OpenFileDialog();
                f.Filter = this.Filter;
                f.RestoreDirectory = true;
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.pBox.ImageLocation = f.FileName;
                    setMinHeightToStrip(null, null);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tsbBorrarImagen_Click(System.Object sender, System.EventArgs e) 
        {
            try
            {
                this.pBox.Image = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}