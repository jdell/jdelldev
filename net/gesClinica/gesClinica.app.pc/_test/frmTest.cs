using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc._test
{
    internal class frmTest:template.frm.BaseForm
    {
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private template.controls.Agenda dataGridView1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    
        public frmTest():base()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.dataGridView1 = new gesClinica.app.pc.template.controls.Agenda();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.ClientSize = new System.Drawing.Size(587, 435);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }


        private string getText(System.Windows.Forms.TreeNodeCollection nodes)
        {
            StringBuilder res = new StringBuilder();
            foreach (System.Windows.Forms.TreeNode tnode in nodes)
            {
                if (tnode.Checked)
                    res.AppendLine(string.Format(" - {0}", tnode.Text));
                string tmp = getText(tnode.Nodes);
                if (!string.IsNullOrEmpty(tmp)) res.AppendLine(tmp);
            }
            return res.ToString();
        }
        private void checkAll(System.Windows.Forms.TreeNodeCollection nodes, bool check)
        {
            foreach (System.Windows.Forms.TreeNode tnode in nodes)
            {
                tnode.Checked = check;
                checkAll(tnode.Nodes, check);
            }
        }
        private void unCheckParent(System.Windows.Forms.TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Parent.Checked = false;
                unCheckParent(node.Parent);
            }
        }

        

        private void frmTest_Load(object sender, EventArgs e)
        {
            try
            {

                lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                this.dataGridView1.DataSourceColumns = lnSala.execute();

                this.dataGridView1.InicioHora = lib.bl._common.cache.WorkingHourStart;
                this.dataGridView1.InicioMinuto = lib.bl._common.cache.WorkingMinuteStart;
                this.dataGridView1.FinHora= lib.bl._common.cache.WorkingHourEnd;
                this.dataGridView1.FinMinuto= lib.bl._common.cache.WorkingMinuteEnd;

                this.dataGridView1.Load();
                //const int salto = 10;

                //const int inicioHora = 9;
                //const int inicioMinuto = 0;

                //const int finHora = 18;
                //const int finMinuto = 0;

                //DateTime inicioFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, inicioHora, inicioMinuto, 0);
                //DateTime finFecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, finHora, finMinuto, 0);


                //System.Windows.Forms.DataGridViewTextBoxColumn c;
                //c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                //c.HeaderText = "Hora";
                //c.Name = "horaIzq";
                //c.Frozen = true;
                //this.dataGridView1.Columns.Add(c);

                //lib.bl.sala.doGetAll lnSala = new gesClinica.lib.bl.sala.doGetAll();
                //foreach (lib.vo.Sala sala in lnSala.execute())
                //{
                //    c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                //    c.HeaderText = sala.Descripcion;
                //    c.Name = sala.ID.ToString();
                //    c.Tag = sala;
                //    this.dataGridView1.Columns.Add(c);
                //}

                //c = new System.Windows.Forms.DataGridViewTextBoxColumn();
                //c.HeaderText = "Hora";
                //c.Name = "horaDcha";
                ////c.Frozen = true;
                //this.dataGridView1.Columns.Add(c);

                //for (DateTime fechaTmp = inicioFecha; fechaTmp < finFecha; fechaTmp = fechaTmp.AddMinutes(salto))
                //{
                //    int index = this.dataGridView1.Rows.Add();
                //    System.Windows.Forms.DataGridViewRow r = this.dataGridView1.Rows[index];//new System.Windows.Forms.DataGridViewRow(
                //    r.Cells["horaIzq"].Value = fechaTmp.ToString("HH:mm");
                //    r.Cells["horaDcha"].Value = fechaTmp.ToString("HH:mm");
                //}
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

    }
}
