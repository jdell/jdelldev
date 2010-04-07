using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita._sintoma
{
    public class frmEditASintoma:template.frm.edicion.EditForm
    {
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TreeView tvSintomas;
        private System.Windows.Forms.GroupBox groupBox3;
        internal repsol.forms.controls.TextBoxColor txtAcudePor;
        internal gesClinica.app.pc.template.controls.TextEditor txtSintomas;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.GroupBox groupBox2;
    
        public frmEditASintoma()
        {
            InitializeComponent();

            ctrl.ctrlEditASintoma ctrl = new gesClinica.app.pc.frm.cita._sintoma.ctrl.ctrlEditASintoma();
            repsol.forms.template.BaseForm frm = (repsol.forms.template.BaseForm)this;
            ctrl.inicializarForm(ref frm);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo8");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nodo9");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo7", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditASintoma));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvSintomas = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAcudePor = new repsol.forms.controls.TextBoxColor();
            this.txtSintomas = new gesClinica.app.pc.template.controls.TextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.panFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(633, 11);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(713, 11);
            // 
            // panFooter
            // 
            this.panFooter.Location = new System.Drawing.Point(0, 529);
            this.panFooter.Size = new System.Drawing.Size(800, 43);
            this.panFooter.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvSintomas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Síntomas";
            // 
            // tvSintomas
            // 
            this.tvSintomas.CheckBoxes = true;
            this.tvSintomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSintomas.FullRowSelect = true;
            this.tvSintomas.Location = new System.Drawing.Point(3, 18);
            this.tvSintomas.Name = "tvSintomas";
            treeNode1.Name = "Nodo3";
            treeNode1.Text = "Nodo3";
            treeNode2.Name = "Nodo4";
            treeNode2.Text = "Nodo4";
            treeNode3.Name = "Nodo5";
            treeNode3.Text = "Nodo5";
            treeNode4.Name = "Nodo6";
            treeNode4.Text = "Nodo6";
            treeNode5.Name = "Nodo0";
            treeNode5.Text = "Nodo0";
            treeNode6.Name = "Nodo8";
            treeNode6.Text = "Nodo8";
            treeNode7.Name = "Nodo9";
            treeNode7.Text = "Nodo9";
            treeNode8.Name = "Nodo7";
            treeNode8.Text = "Nodo7";
            this.tvSintomas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8});
            this.tvSintomas.Size = new System.Drawing.Size(794, 194);
            this.tvSintomas.TabIndex = 0;
            this.tvSintomas.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvSintomas_AfterCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSintomas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista Previa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAcudePor);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 70);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acude por";
            // 
            // txtAcudePor
            // 
            this.txtAcudePor.ActivateStyle = true;
            this.txtAcudePor.BackColor = System.Drawing.Color.White;
            this.txtAcudePor.ColorEnter = System.Drawing.Color.LightYellow;
            this.txtAcudePor.ColorLeave = System.Drawing.Color.White;
            this.txtAcudePor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAcudePor.Location = new System.Drawing.Point(3, 18);
            this.txtAcudePor.Multiline = true;
            this.txtAcudePor.Name = "txtAcudePor";
            this.txtAcudePor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAcudePor.Size = new System.Drawing.Size(794, 49);
            this.txtAcudePor.TabIndex = 0;
            this.txtAcudePor.Leave += new System.EventHandler(this.txtAcudePor_Leave);
            // 
            // txtSintomas
            // 
            this.txtSintomas.AcceptsTab = false;
            this.txtSintomas.AutoWordSelection = true;
            this.txtSintomas.BackColor = System.Drawing.SystemColors.Control;
            this.txtSintomas.DetectURLs = true;
            this.txtSintomas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSintomas.Location = new System.Drawing.Point(3, 18);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.ReadOnly = true;
            // 
            // 
            // 
            this.txtSintomas.RichTextBox.AutoWordSelection = true;
            this.txtSintomas.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
            this.txtSintomas.RichTextBox.BulletStyle = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.txtSintomas.RichTextBox.BulletType = gesClinica.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.txtSintomas.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSintomas.RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.txtSintomas.RichTextBox.Name = "rtb1";
            this.txtSintomas.RichTextBox.PrintDocument = null;
            this.txtSintomas.RichTextBox.ReadOnly = true;
            this.txtSintomas.RichTextBox.Size = new System.Drawing.Size(794, 223);
            this.txtSintomas.RichTextBox.TabIndex = 1;
            this.txtSintomas.ShowBold = true;
            this.txtSintomas.ShowCenterJustify = true;
            this.txtSintomas.ShowColors = true;
            this.txtSintomas.ShowCopy = true;
            this.txtSintomas.ShowCut = true;
            this.txtSintomas.ShowFont = true;
            this.txtSintomas.ShowFontSize = true;
            this.txtSintomas.ShowItalic = true;
            this.txtSintomas.ShowLeftJustify = true;
            this.txtSintomas.ShowOpen = false;
            this.txtSintomas.ShowPaste = true;
            this.txtSintomas.ShowRedo = true;
            this.txtSintomas.ShowRightJustify = true;
            this.txtSintomas.ShowSave = false;
            this.txtSintomas.ShowStamp = true;
            this.txtSintomas.ShowStrikeout = true;
            this.txtSintomas.ShowToolBarText = false;
            this.txtSintomas.ShowUnderline = true;
            this.txtSintomas.ShowUndo = true;
            this.txtSintomas.Size = new System.Drawing.Size(794, 223);
            this.txtSintomas.StampAction = gesClinica.app.pc.template.controls.StampActions.EditedBy;
            this.txtSintomas.StampColor = System.Drawing.Color.Blue;
            this.txtSintomas.TabIndex = 2;
            this.txtSintomas.TextRTF = resources.GetString("txtSintomas.TextRTF");
            // 
            // 
            // 
            this.txtSintomas.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.txtSintomas.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
            this.txtSintomas.Toolbar.Divider = false;
            this.txtSintomas.Toolbar.DropDownArrows = true;
            this.txtSintomas.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.txtSintomas.Toolbar.Name = "tb1";
            this.txtSintomas.Toolbar.ShowToolTips = true;
            this.txtSintomas.Toolbar.Size = new System.Drawing.Size(784, 20);
            this.txtSintomas.Toolbar.TabIndex = 0;
            this.txtSintomas.Toolbar.Visible = false;
            // 
            // frmEditASintoma
            // 
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmEditASintoma";
            this.Text = "Sintomas - Asistente";
            this.Controls.SetChildIndex(this.panFooter, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tvSintomas_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            try
            {
                ctrl.ctrlEditASintoma ctrl = new gesClinica.app.pc.frm.cita._sintoma.ctrl.ctrlEditASintoma();
                frmEditASintoma edit = (frmEditASintoma)this;
                ctrl.updateSintomas(ref edit);                
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }

        private void txtAcudePor_Leave(object sender, EventArgs e)
        {
            try
            {
                ctrl.ctrlEditASintoma ctrl = new gesClinica.app.pc.frm.cita._sintoma.ctrl.ctrlEditASintoma();
                frmEditASintoma edit = (frmEditASintoma)this;
                ctrl.updateSintomas(ref edit);
                //string text = ctrl.getText(this.tvSintomas.Nodes);
                //this.txtSintomas.Text = !string.IsNullOrEmpty(this.txtAcudePor.Text) ? string.Format("Acude por: {0}{1}{0}", Environment.NewLine, this.txtAcudePor.Text) : this.txtAcudePor.Text;
                //this.txtSintomas.Text += !string.IsNullOrEmpty(text) ? string.Format("Síntomas : {0}{1}", Environment.NewLine, text) : text;

            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
