using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace asr.app.pc.template.controls
{
   	#region StampActions
	public enum StampActions
	{
		EditedBy = 1,
		DateTime = 2,
		Custom = 4
	}
	#endregion

	/// <summary>
	/// An extended RichTextBoxEx that contains a toolbar.
	/// </summary>
	public class TextEditor : System.Windows.Forms.UserControl
	{
		//Used for looping
        //private RichTextBoxSpell rtbTemp = new RichTextBoxSpell();
        private RichTextBoxEx rtbTemp = new RichTextBoxEx();

        //public System.Drawing.Printing.PrintDocument PrintDocument
        //{
        //    get
        //    {
        //        return this.rtb1.PrintDocument;
        //    }
        //    set
        //    {
        //        this.rtb1.PrintDocument = value;
        //    }
        //}

		#region Windows Generated
		private System.Windows.Forms.ToolBar tb1;
        RichTextBoxEx rtb1;
		private System.Windows.Forms.ImageList imgList1;
		private System.Windows.Forms.ToolBarButton tbbBold;
		private System.Windows.Forms.ToolBarButton tbbItalic;
		private System.Windows.Forms.ToolBarButton tbbUnderline;
		private System.Windows.Forms.ToolBarButton tbbCenter;
		private System.Windows.Forms.ToolBarButton tbbRight;
		private System.Windows.Forms.ToolBarButton tbbStrikeout;
		private System.Windows.Forms.ToolBarButton tbbColor;
		private System.Windows.Forms.ContextMenu cmColors;
		private System.Windows.Forms.MenuItem miBlack;
		private System.Windows.Forms.MenuItem miBlue;
		private System.Windows.Forms.MenuItem miRed;
		private System.Windows.Forms.MenuItem miGreen;
		private System.Windows.Forms.ToolBarButton tbbStamp;
		private System.Windows.Forms.ToolBarButton tbbOpen;
		private System.Windows.Forms.ToolBarButton tbbSave;
		private System.Windows.Forms.ToolBarButton tbbUndo;
		private System.Windows.Forms.ToolBarButton tbbRedo;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbLeft;
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.SaveFileDialog sfd1;
		private System.Windows.Forms.ContextMenu cmFonts;
		private System.Windows.Forms.MenuItem miArial;
		private System.Windows.Forms.MenuItem miGaramond;
		private System.Windows.Forms.MenuItem miTahoma;
		private System.Windows.Forms.MenuItem miTimesNewRoman;
		private System.Windows.Forms.MenuItem miVerdana;
		private System.Windows.Forms.ToolBarButton tbbFont;
		private System.Windows.Forms.ToolBarButton tbbFontSize;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.MenuItem miCourierNew;
		private System.Windows.Forms.MenuItem miMicrosoftSansSerif;
		private System.Windows.Forms.ContextMenu cmFontSizes;
		private System.Windows.Forms.MenuItem mi8;
		private System.Windows.Forms.MenuItem mi9;
		private System.Windows.Forms.MenuItem mi10;
		private System.Windows.Forms.MenuItem mi11;
		private System.Windows.Forms.MenuItem mi12;
		private System.Windows.Forms.MenuItem mi14;
		private System.Windows.Forms.MenuItem mi16;
		private System.Windows.Forms.MenuItem mi18;
		private System.Windows.Forms.MenuItem mi20;
		private System.Windows.Forms.MenuItem mi22;
		private System.Windows.Forms.MenuItem mi24;
		private System.Windows.Forms.MenuItem mi26;
		private System.Windows.Forms.MenuItem mi28;
		private System.Windows.Forms.MenuItem mi36;
		private System.Windows.Forms.MenuItem mi48;
		private System.Windows.Forms.MenuItem mi72;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolBarButton tbbCut;
		private System.Windows.Forms.ToolBarButton tbbCopy;
        private ToolStrip tbar;
        private ToolStripButton tsbSave;
        private ToolStripButton tsbOpen;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbBold;
        private ToolStripButton tsbItalic;
        private ToolStripButton tsbUnderline;
        private ToolStripButton tsbStrikeout;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbLeft;
        private ToolStripButton tsbCenter;
        private ToolStripButton tsbRight;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsbUndo;
        private ToolStripButton tsbRedo;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton tsbCut;
        private ToolStripButton tsbCopy;
        private ToolStripButton tsbPaste;
        private ToolStripButton tsbStamp;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tsbPrint;
        private ToolStripButton tsbPrintPreview;
        private ToolStripButton tsbPrintSetup;
        private ToolStripSplitButton tsbFont;
        private ToolStripSplitButton tsbFontSize;
        private ToolStripSplitButton tsbColor;
        private ToolStripMenuItem arialToolStripMenuItem;
        private ToolStripMenuItem courierNewToolStripMenuItem;
        private ToolStripMenuItem microsoftSansSerifToolStripMenuItem;
        private ToolStripMenuItem tahomaToolStripMenuItem;
        private ToolStripMenuItem verdanaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem blackToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PrintPreviewDialog printPreviewDialog;
        private PageSetupDialog pageSetupDialog;
		private System.Windows.Forms.ToolBarButton tbbPaste;

		public TextEditor()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            //InitControls
            InitControls();

			//Update the graphics on the toolbar
			UpdateToolbar();
		}

        private void InitControls()
        {
            //foreach (FontFamily family in FontFamily.Families)
            //{
            //    this.tsbFont.Items.Add(family.Name);
            //}
            //this.tsbFont.SelectedItem = "Arial";
            //this.RichTextBox.PrintDocument = this.printDocument;
        }


		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.tb1 = new System.Windows.Forms.ToolBar();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbFont = new System.Windows.Forms.ToolBarButton();
            this.cmFonts = new System.Windows.Forms.ContextMenu();
            this.miArial = new System.Windows.Forms.MenuItem();
            this.miCourierNew = new System.Windows.Forms.MenuItem();
            this.miGaramond = new System.Windows.Forms.MenuItem();
            this.miMicrosoftSansSerif = new System.Windows.Forms.MenuItem();
            this.miTahoma = new System.Windows.Forms.MenuItem();
            this.miTimesNewRoman = new System.Windows.Forms.MenuItem();
            this.miVerdana = new System.Windows.Forms.MenuItem();
            this.tbbFontSize = new System.Windows.Forms.ToolBarButton();
            this.cmFontSizes = new System.Windows.Forms.ContextMenu();
            this.mi8 = new System.Windows.Forms.MenuItem();
            this.mi9 = new System.Windows.Forms.MenuItem();
            this.mi10 = new System.Windows.Forms.MenuItem();
            this.mi11 = new System.Windows.Forms.MenuItem();
            this.mi12 = new System.Windows.Forms.MenuItem();
            this.mi14 = new System.Windows.Forms.MenuItem();
            this.mi16 = new System.Windows.Forms.MenuItem();
            this.mi18 = new System.Windows.Forms.MenuItem();
            this.mi20 = new System.Windows.Forms.MenuItem();
            this.mi22 = new System.Windows.Forms.MenuItem();
            this.mi24 = new System.Windows.Forms.MenuItem();
            this.mi26 = new System.Windows.Forms.MenuItem();
            this.mi28 = new System.Windows.Forms.MenuItem();
            this.mi36 = new System.Windows.Forms.MenuItem();
            this.mi48 = new System.Windows.Forms.MenuItem();
            this.mi72 = new System.Windows.Forms.MenuItem();
            this.tbbColor = new System.Windows.Forms.ToolBarButton();
            this.cmColors = new System.Windows.Forms.ContextMenu();
            this.miBlack = new System.Windows.Forms.MenuItem();
            this.miBlue = new System.Windows.Forms.MenuItem();
            this.miRed = new System.Windows.Forms.MenuItem();
            this.miGreen = new System.Windows.Forms.MenuItem();
            this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
            this.tbbBold = new System.Windows.Forms.ToolBarButton();
            this.tbbItalic = new System.Windows.Forms.ToolBarButton();
            this.tbbUnderline = new System.Windows.Forms.ToolBarButton();
            this.tbbStrikeout = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbLeft = new System.Windows.Forms.ToolBarButton();
            this.tbbCenter = new System.Windows.Forms.ToolBarButton();
            this.tbbRight = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbUndo = new System.Windows.Forms.ToolBarButton();
            this.tbbRedo = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbCut = new System.Windows.Forms.ToolBarButton();
            this.tbbCopy = new System.Windows.Forms.ToolBarButton();
            this.tbbPaste = new System.Windows.Forms.ToolBarButton();
            this.tbbStamp = new System.Windows.Forms.ToolBarButton();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.tbar = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFont = new System.Windows.Forms.ToolStripSplitButton();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courierNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbFontSize = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbColor = new System.Windows.Forms.ToolStripSplitButton();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tsbItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsbStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbStamp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintSetup = new System.Windows.Forms.ToolStripButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.rtb1 = new asr.app.pc.template.controls.RichTextBoxEx();
            this.tbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tb1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbSave,
            this.tbbOpen,
            this.tbbSeparator3,
            this.tbbFont,
            this.tbbFontSize,
            this.tbbColor,
            this.tbbSeparator5,
            this.tbbBold,
            this.tbbItalic,
            this.tbbUnderline,
            this.tbbStrikeout,
            this.tbbSeparator1,
            this.tbbLeft,
            this.tbbCenter,
            this.tbbRight,
            this.tbbSeparator2,
            this.tbbUndo,
            this.tbbRedo,
            this.tbbSeparator4,
            this.tbbCut,
            this.tbbCopy,
            this.tbbPaste,
            this.tbbStamp});
            this.tb1.ButtonSize = new System.Drawing.Size(16, 16);
            this.tb1.Divider = false;
            this.tb1.DropDownArrows = true;
            this.tb1.ImageList = this.imgList1;
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.ShowToolTips = true;
            this.tb1.Size = new System.Drawing.Size(761, 26);
            this.tb1.TabIndex = 0;
            this.tb1.Visible = false;
            this.tb1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tb1_ButtonClick);
            // 
            // tbbSave
            // 
            this.tbbSave.ImageIndex = 11;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.Tag = "save";
            // 
            // tbbOpen
            // 
            this.tbbOpen.ImageIndex = 10;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.Tag = "open";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFont
            // 
            this.tbbFont.DropDownMenu = this.cmFonts;
            this.tbbFont.ImageIndex = 14;
            this.tbbFont.Name = "tbbFont";
            this.tbbFont.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbFont.Tag = "font";
            // 
            // cmFonts
            // 
            this.cmFonts.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miArial,
            this.miCourierNew,
            this.miGaramond,
            this.miMicrosoftSansSerif,
            this.miTahoma,
            this.miTimesNewRoman,
            this.miVerdana});
            // 
            // miArial
            // 
            this.miArial.Index = 0;
            this.miArial.Text = "Arial";
            this.miArial.Click += new System.EventHandler(this.Font_Click);
            // 
            // miCourierNew
            // 
            this.miCourierNew.Index = 1;
            this.miCourierNew.Text = "Courier New";
            this.miCourierNew.Click += new System.EventHandler(this.Font_Click);
            // 
            // miGaramond
            // 
            this.miGaramond.Index = 2;
            this.miGaramond.Text = "Garamond";
            this.miGaramond.Click += new System.EventHandler(this.Font_Click);
            // 
            // miMicrosoftSansSerif
            // 
            this.miMicrosoftSansSerif.Index = 3;
            this.miMicrosoftSansSerif.Text = "Microsoft Sans Serif";
            this.miMicrosoftSansSerif.Click += new System.EventHandler(this.Font_Click);
            // 
            // miTahoma
            // 
            this.miTahoma.Index = 4;
            this.miTahoma.Text = "Tahoma";
            this.miTahoma.Click += new System.EventHandler(this.Font_Click);
            // 
            // miTimesNewRoman
            // 
            this.miTimesNewRoman.Index = 5;
            this.miTimesNewRoman.Text = "Times New Roman";
            this.miTimesNewRoman.Click += new System.EventHandler(this.Font_Click);
            // 
            // miVerdana
            // 
            this.miVerdana.Index = 6;
            this.miVerdana.Text = "Verdana";
            this.miVerdana.Click += new System.EventHandler(this.Font_Click);
            // 
            // tbbFontSize
            // 
            this.tbbFontSize.DropDownMenu = this.cmFontSizes;
            this.tbbFontSize.ImageIndex = 15;
            this.tbbFontSize.Name = "tbbFontSize";
            this.tbbFontSize.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbFontSize.Tag = "font size";
            // 
            // cmFontSizes
            // 
            this.cmFontSizes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mi8,
            this.mi9,
            this.mi10,
            this.mi11,
            this.mi12,
            this.mi14,
            this.mi16,
            this.mi18,
            this.mi20,
            this.mi22,
            this.mi24,
            this.mi26,
            this.mi28,
            this.mi36,
            this.mi48,
            this.mi72});
            // 
            // mi8
            // 
            this.mi8.Index = 0;
            this.mi8.Text = "8";
            this.mi8.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi9
            // 
            this.mi9.Index = 1;
            this.mi9.Text = "9";
            this.mi9.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi10
            // 
            this.mi10.Index = 2;
            this.mi10.Text = "10";
            this.mi10.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi11
            // 
            this.mi11.Index = 3;
            this.mi11.Text = "11";
            this.mi11.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi12
            // 
            this.mi12.Index = 4;
            this.mi12.Text = "12";
            this.mi12.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi14
            // 
            this.mi14.Index = 5;
            this.mi14.Text = "14";
            this.mi14.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi16
            // 
            this.mi16.Index = 6;
            this.mi16.Text = "16";
            this.mi16.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi18
            // 
            this.mi18.Index = 7;
            this.mi18.Text = "18";
            this.mi18.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi20
            // 
            this.mi20.Index = 8;
            this.mi20.Text = "20";
            this.mi20.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi22
            // 
            this.mi22.Index = 9;
            this.mi22.Text = "22";
            this.mi22.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi24
            // 
            this.mi24.Index = 10;
            this.mi24.Text = "24";
            this.mi24.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi26
            // 
            this.mi26.Index = 11;
            this.mi26.Text = "26";
            this.mi26.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi28
            // 
            this.mi28.Index = 12;
            this.mi28.Text = "28";
            this.mi28.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi36
            // 
            this.mi36.Index = 13;
            this.mi36.Text = "36";
            this.mi36.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi48
            // 
            this.mi48.Index = 14;
            this.mi48.Text = "48";
            this.mi48.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // mi72
            // 
            this.mi72.Index = 15;
            this.mi72.Text = "72";
            this.mi72.Click += new System.EventHandler(this.FontSize_Click);
            // 
            // tbbColor
            // 
            this.tbbColor.DropDownMenu = this.cmColors;
            this.tbbColor.ImageIndex = 7;
            this.tbbColor.Name = "tbbColor";
            this.tbbColor.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbColor.Tag = "color";
            // 
            // cmColors
            // 
            this.cmColors.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miBlack,
            this.miBlue,
            this.miRed,
            this.miGreen});
            // 
            // miBlack
            // 
            this.miBlack.Index = 0;
            this.miBlack.Text = "Black";
            this.miBlack.Click += new System.EventHandler(this.Color_Click);
            // 
            // miBlue
            // 
            this.miBlue.Index = 1;
            this.miBlue.Text = "Blue";
            this.miBlue.Click += new System.EventHandler(this.Color_Click);
            // 
            // miRed
            // 
            this.miRed.Index = 2;
            this.miRed.Text = "Red";
            this.miRed.Click += new System.EventHandler(this.Color_Click);
            // 
            // miGreen
            // 
            this.miGreen.Index = 3;
            this.miGreen.Text = "Green";
            this.miGreen.Click += new System.EventHandler(this.Color_Click);
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbBold
            // 
            this.tbbBold.ImageIndex = 0;
            this.tbbBold.Name = "tbbBold";
            this.tbbBold.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbBold.Tag = "bold";
            // 
            // tbbItalic
            // 
            this.tbbItalic.ImageIndex = 1;
            this.tbbItalic.Name = "tbbItalic";
            this.tbbItalic.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbItalic.Tag = "italic";
            // 
            // tbbUnderline
            // 
            this.tbbUnderline.ImageIndex = 2;
            this.tbbUnderline.Name = "tbbUnderline";
            this.tbbUnderline.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbUnderline.Tag = "underline";
            // 
            // tbbStrikeout
            // 
            this.tbbStrikeout.ImageIndex = 3;
            this.tbbStrikeout.Name = "tbbStrikeout";
            this.tbbStrikeout.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbStrikeout.Tag = "strikeout";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbLeft
            // 
            this.tbbLeft.ImageIndex = 4;
            this.tbbLeft.Name = "tbbLeft";
            this.tbbLeft.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbLeft.Tag = "left";
            // 
            // tbbCenter
            // 
            this.tbbCenter.ImageIndex = 5;
            this.tbbCenter.Name = "tbbCenter";
            this.tbbCenter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbCenter.Tag = "center";
            // 
            // tbbRight
            // 
            this.tbbRight.ImageIndex = 6;
            this.tbbRight.Name = "tbbRight";
            this.tbbRight.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbRight.Tag = "right";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbUndo
            // 
            this.tbbUndo.ImageIndex = 12;
            this.tbbUndo.Name = "tbbUndo";
            this.tbbUndo.Tag = "undo";
            // 
            // tbbRedo
            // 
            this.tbbRedo.ImageIndex = 13;
            this.tbbRedo.Name = "tbbRedo";
            this.tbbRedo.Tag = "redo";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCut
            // 
            this.tbbCut.ImageIndex = 17;
            this.tbbCut.Name = "tbbCut";
            this.tbbCut.Tag = "cut";
            // 
            // tbbCopy
            // 
            this.tbbCopy.ImageIndex = 18;
            this.tbbCopy.Name = "tbbCopy";
            this.tbbCopy.Tag = "copy";
            // 
            // tbbPaste
            // 
            this.tbbPaste.ImageIndex = 19;
            this.tbbPaste.Name = "tbbPaste";
            this.tbbPaste.Tag = "paste";
            // 
            // tbbStamp
            // 
            this.tbbStamp.ImageIndex = 8;
            this.tbbStamp.Name = "tbbStamp";
            this.tbbStamp.Tag = "edit stamp";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "");
            this.imgList1.Images.SetKeyName(1, "");
            this.imgList1.Images.SetKeyName(2, "");
            this.imgList1.Images.SetKeyName(3, "");
            this.imgList1.Images.SetKeyName(4, "");
            this.imgList1.Images.SetKeyName(5, "");
            this.imgList1.Images.SetKeyName(6, "");
            this.imgList1.Images.SetKeyName(7, "");
            this.imgList1.Images.SetKeyName(8, "");
            this.imgList1.Images.SetKeyName(9, "");
            this.imgList1.Images.SetKeyName(10, "");
            this.imgList1.Images.SetKeyName(11, "");
            this.imgList1.Images.SetKeyName(12, "");
            this.imgList1.Images.SetKeyName(13, "");
            this.imgList1.Images.SetKeyName(14, "");
            this.imgList1.Images.SetKeyName(15, "");
            this.imgList1.Images.SetKeyName(16, "");
            this.imgList1.Images.SetKeyName(17, "");
            this.imgList1.Images.SetKeyName(18, "");
            this.imgList1.Images.SetKeyName(19, "");
            this.imgList1.Images.SetKeyName(20, "");
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "rtf";
            this.ofd1.Filter = "Rich Text Files|*.rtf|Plain Text File|*.txt";
            this.ofd1.Title = "Open File";
            // 
            // sfd1
            // 
            this.sfd1.DefaultExt = "rtf";
            this.sfd1.Filter = "Rich Text File|*.rtf|Plain Text File|*.txt";
            this.sfd1.Title = "Save As";
            // 
            // tbar
            // 
            this.tbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbFont,
            this.tsbFontSize,
            this.tsbColor,
            this.toolStripSeparator2,
            this.tsbBold,
            this.tsbItalic,
            this.tsbUnderline,
            this.tsbStrikeout,
            this.toolStripSeparator3,
            this.tsbLeft,
            this.tsbCenter,
            this.tsbRight,
            this.toolStripSeparator4,
            this.tsbUndo,
            this.tsbRedo,
            this.toolStripSeparator5,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.tsbStamp,
            this.toolStripSeparator6,
            this.tsbPrint,
            this.tsbPrintPreview,
            this.tsbPrintSetup});
            this.tbar.Location = new System.Drawing.Point(0, 26);
            this.tbar.Name = "tbar";
            this.tbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tbar.Size = new System.Drawing.Size(761, 25);
            this.tbar.TabIndex = 2;
            this.tbar.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "guardar";
            this.tsbSave.Visible = false;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "abrir documento";
            this.tsbOpen.Visible = false;
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // tsbFont
            // 
            this.tsbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.courierNewToolStripMenuItem,
            this.microsoftSansSerifToolStripMenuItem,
            this.tahomaToolStripMenuItem,
            this.verdanaToolStripMenuItem});
            this.tsbFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbFont.Image")));
            this.tsbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFont.Name = "tsbFont";
            this.tsbFont.Size = new System.Drawing.Size(32, 22);
            this.tsbFont.Text = "toolStripSplitButton1";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arialToolStripMenuItem.Text = "Arial";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.ownFont_Click);
            // 
            // courierNewToolStripMenuItem
            // 
            this.courierNewToolStripMenuItem.Name = "courierNewToolStripMenuItem";
            this.courierNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courierNewToolStripMenuItem.Text = "Courier New";
            this.courierNewToolStripMenuItem.Click += new System.EventHandler(this.ownFont_Click);
            // 
            // microsoftSansSerifToolStripMenuItem
            // 
            this.microsoftSansSerifToolStripMenuItem.Name = "microsoftSansSerifToolStripMenuItem";
            this.microsoftSansSerifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.microsoftSansSerifToolStripMenuItem.Text = "Microsoft Sans Serif";
            this.microsoftSansSerifToolStripMenuItem.Click += new System.EventHandler(this.ownFont_Click);
            // 
            // tahomaToolStripMenuItem
            // 
            this.tahomaToolStripMenuItem.Name = "tahomaToolStripMenuItem";
            this.tahomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tahomaToolStripMenuItem.Text = "Tahoma";
            this.tahomaToolStripMenuItem.Click += new System.EventHandler(this.ownFont_Click);
            // 
            // verdanaToolStripMenuItem
            // 
            this.verdanaToolStripMenuItem.Name = "verdanaToolStripMenuItem";
            this.verdanaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verdanaToolStripMenuItem.Text = "Verdana";
            this.verdanaToolStripMenuItem.Click += new System.EventHandler(this.ownFont_Click);
            // 
            // tsbFontSize
            // 
            this.tsbFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFontSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.tsbFontSize.Image = ((System.Drawing.Image)(resources.GetObject("tsbFontSize.Image")));
            this.tsbFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFontSize.Name = "tsbFontSize";
            this.tsbFontSize.Size = new System.Drawing.Size(32, 22);
            this.tsbFontSize.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem2.Text = "8";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem3.Text = "9";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem4.Text = "10";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem5.Text = "11";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem6.Text = "12";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem7.Text = "14";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem8.Text = "16";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem9.Text = "18";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem10.Text = "20";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem11.Text = "22";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem12.Text = "24";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem13.Text = "26";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem14.Text = "28";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem15.Text = "36";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem16.Text = "48";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem17.Text = "72";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.ownFontSize_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(32, 22);
            this.tsbColor.Text = "toolStripSplitButton3";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.ownColor_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.ownColor_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.ownColor_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.ownColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBold
            // 
            this.tsbBold.CheckOnClick = true;
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = ((System.Drawing.Image)(resources.GetObject("tsbBold.Image")));
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(23, 22);
            this.tsbBold.Text = "negrita";
            this.tsbBold.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // tsbItalic
            // 
            this.tsbItalic.CheckOnClick = true;
            this.tsbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsbItalic.Image")));
            this.tsbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItalic.Name = "tsbItalic";
            this.tsbItalic.Size = new System.Drawing.Size(23, 22);
            this.tsbItalic.Text = "cursiva";
            this.tsbItalic.ToolTipText = "cursiva";
            this.tsbItalic.Click += new System.EventHandler(this.tsbItalic_Click);
            // 
            // tsbUnderline
            // 
            this.tsbUnderline.CheckOnClick = true;
            this.tsbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnderline.Image")));
            this.tsbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnderline.Name = "tsbUnderline";
            this.tsbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsbUnderline.Text = "subrayado";
            this.tsbUnderline.Click += new System.EventHandler(this.tsbUnderline_Click);
            // 
            // tsbStrikeout
            // 
            this.tsbStrikeout.CheckOnClick = true;
            this.tsbStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStrikeout.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("tsbStrikeout.Image")));
            this.tsbStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStrikeout.Name = "tsbStrikeout";
            this.tsbStrikeout.Size = new System.Drawing.Size(23, 22);
            this.tsbStrikeout.Text = "tachado";
            this.tsbStrikeout.Click += new System.EventHandler(this.tsbStrikeout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLeft
            // 
            this.tsbLeft.CheckOnClick = true;
            this.tsbLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeft.Image")));
            this.tsbLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeft.Name = "tsbLeft";
            this.tsbLeft.Size = new System.Drawing.Size(23, 22);
            this.tsbLeft.Text = "alinear a la izquierda";
            this.tsbLeft.Click += new System.EventHandler(this.tsbLeft_Click);
            // 
            // tsbCenter
            // 
            this.tsbCenter.CheckOnClick = true;
            this.tsbCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsbCenter.Image")));
            this.tsbCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCenter.Name = "tsbCenter";
            this.tsbCenter.Size = new System.Drawing.Size(23, 22);
            this.tsbCenter.Text = "centrar";
            this.tsbCenter.Click += new System.EventHandler(this.tsbCenter_Click);
            // 
            // tsbRight
            // 
            this.tsbRight.CheckOnClick = true;
            this.tsbRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbRight.Image")));
            this.tsbRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRight.Name = "tsbRight";
            this.tsbRight.Size = new System.Drawing.Size(23, 22);
            this.tsbRight.Text = "alinear a la derecha";
            this.tsbRight.Click += new System.EventHandler(this.tsbRight_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = ((System.Drawing.Image)(resources.GetObject("tsbUndo.Image")));
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(23, 22);
            this.tsbUndo.Text = "toolStripButton10";
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRedo.Image")));
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(23, 22);
            this.tsbRedo.Text = "toolStripButton11";
            this.tsbRedo.Click += new System.EventHandler(this.tsbRedo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCut
            // 
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
            this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCut.Name = "tsbCut";
            this.tsbCut.Size = new System.Drawing.Size(23, 22);
            this.tsbCut.Text = "cortar";
            this.tsbCut.Click += new System.EventHandler(this.tsbCut_Click);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "copiar";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "pegar";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // tsbStamp
            // 
            this.tsbStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStamp.Image = ((System.Drawing.Image)(resources.GetObject("tsbStamp.Image")));
            this.tsbStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStamp.Name = "tsbStamp";
            this.tsbStamp.Size = new System.Drawing.Size(23, 22);
            this.tsbStamp.Text = "firma";
            this.tsbStamp.Visible = false;
            this.tsbStamp.Click += new System.EventHandler(this.tsbStamp_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "imprimir";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbPrintPreview
            // 
            this.tsbPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintPreview.Image")));
            this.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreview.Name = "tsbPrintPreview";
            this.tsbPrintPreview.Size = new System.Drawing.Size(23, 22);
            this.tsbPrintPreview.Text = "vista previa";
            this.tsbPrintPreview.Click += new System.EventHandler(this.tsbPrintPreview_Click);
            // 
            // tsbPrintSetup
            // 
            this.tsbPrintSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintSetup.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintSetup.Image")));
            this.tsbPrintSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintSetup.Name = "tsbPrintSetup";
            this.tsbPrintSetup.Size = new System.Drawing.Size(23, 22);
            this.tsbPrintSetup.Text = "configuración de página";
            this.tsbPrintSetup.Click += new System.EventHandler(this.tsbPrintSetup_Click);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // rtb1
            // 
            this.rtb1.AutoWordSelection = true;
            this.rtb1.BulletStyle = asr.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;
            this.rtb1.BulletType = asr.app.pc.template.controls.RichTextBoxEx.AdvRichTextBulletType.Normal;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Location = new System.Drawing.Point(0, 51);
            this.rtb1.Name = "rtb1";
            this.rtb1.PrintDocument = this.printDocument;
            this.rtb1.Size = new System.Drawing.Size(761, 173);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            this.rtb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtb1_KeyDown);
            this.rtb1.SelectionChanged += new System.EventHandler(this.rtb1_SelectionChanged);
            this.rtb1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb1_LinkClicked);
            this.rtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb1_KeyPress);
            // 
            // TextEditor
            // 
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.tbar);
            this.Controls.Add(this.tb1);
            this.Name = "TextEditor";
            this.Size = new System.Drawing.Size(761, 224);
            this.tbar.ResumeLayout(false);
            this.tbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Selection Change event	
		[Description("Occurs when the selection is changed"),
		Category("Behavior")]
		// Raised in tb1 SelectionChanged event so that user can do useful things
		public event System.EventHandler SelChanged;
		#endregion

		#region Stamp Event Stuff
		[Description("Occurs when the stamp button is clicked"), 
		 Category("Behavior")]
		public event System.EventHandler Stamp;
        
		/// <summary>
		/// OnStamp event
		/// </summary>
		protected virtual void OnStamp(EventArgs e)
		{
			if(Stamp != null)
				Stamp(this, e);

			switch(StampAction)
			{
				case StampActions.EditedBy:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtb1.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append("Modificado por "); 
					//use the CurrentPrincipal name if one exsist else use windows logon username
					if(Thread.CurrentPrincipal == null || Thread.CurrentPrincipal.Identity == null || Thread.CurrentPrincipal.Identity.Name.Length <= 0)
						stamp.Append(Environment.UserName);
					else
						stamp.Append(Thread.CurrentPrincipal.Identity.Name);
					stamp.Append(" el " + DateTime.Now.ToLongDateString() + "\r\n");
			
					rtb1.SelectionLength = 0; //unselect everything basicly
					rtb1.SelectionStart = rtb1.Text.Length; //start new selection at the end of the text
					rtb1.SelectionColor = this.StampColor; //make the selection blue
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtb1.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtb1.Focus(); //set focus back on the richtextbox
				} break; //end edited by stamp
				case StampActions.DateTime:
				{
					StringBuilder stamp = new StringBuilder(""); //holds our stamp text
					if(rtb1.Text.Length > 0) stamp.Append("\r\n\r\n"); //add two lines for space
					stamp.Append(DateTime.Now.ToLongDateString() + "\r\n");
					rtb1.SelectionLength = 0; //unselect everything basicly
					rtb1.SelectionStart = rtb1.Text.Length; //start new selection at the end of the text
					rtb1.SelectionColor = this.StampColor; //make the selection blue
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, FontStyle.Bold); //set the selection font and style
					rtb1.AppendText(stamp.ToString()); //add the stamp to the richtextbox
					rtb1.Focus(); //set focus back on the richtextbox
				} break;
			} //end select
		}
		#endregion

		#region Toolbar button click
		/// <summary>
		///     Handler for the toolbar button click event
		/// </summary>
		private void tb1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// true if style to be added
			// false to remove style
			bool add = e.Button.Pushed;	
					
			//Switch based on the tag of the button pressed
			switch(e.Button.Tag.ToString().ToLower())
			{
				case "bold": 
					ChangeFontStyle(FontStyle.Bold,add);
					break;
				case "italic": 
					ChangeFontStyle(FontStyle.Italic,add);
					break;
				case "underline":
					ChangeFontStyle(FontStyle.Underline,add);
					break;
				case "strikeout":
					ChangeFontStyle(FontStyle.Strikeout,add);
					break;
				case "left":
					//change horizontal alignment to left
					rtb1.SelectionAlignment = HorizontalAlignment.Left;
					tbbCenter.Pushed = false;
					tbbRight.Pushed = false;
					break;
				case "center":
					//change horizontal alignment to center
					tbbLeft.Pushed = false;
					rtb1.SelectionAlignment = HorizontalAlignment.Center;
					tbbRight.Pushed = false;
					break;
				case "right":
					//change horizontal alignment to right
					tbbLeft.Pushed = false;
					tbbCenter.Pushed = false;
					rtb1.SelectionAlignment = HorizontalAlignment.Right;
					break;
				case "edit stamp":
                    OnStamp(new EventArgs()); //send stamp event
					break;
				case "color":
					rtb1.SelectionColor = Color.Black;
					break;
				case "undo":
					rtb1.Undo();
					break;
				case "redo":
					rtb1.Redo();
					break;
				case "open":
					try
					{
						if (ofd1.ShowDialog() == DialogResult.OK && ofd1.FileName.Length > 0)
							if(System.IO.Path.GetExtension(ofd1.FileName).ToLower().Equals(".rtf")) 
								rtb1.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
							else
								rtb1.LoadFile(ofd1.FileName, RichTextBoxStreamType.PlainText);
					}
					catch (ArgumentException ae)
					{
						if(ae.Message == "Invalid file format.")
							MessageBox.Show("There was an error loading the file: " + ofd1.FileName);				
					}
					break;
				case "save":
					if(sfd1.ShowDialog() == DialogResult.OK && sfd1.FileName.Length > 0)
						if(System.IO.Path.GetExtension(sfd1.FileName).ToLower().Equals(".rtf"))
							rtb1.SaveFile(sfd1.FileName);
						else
							rtb1.SaveFile(sfd1.FileName, RichTextBoxStreamType.PlainText);
					break;
				case "cut":
				{
					if(rtb1.SelectedText.Length <= 0) break;
					rtb1.Cut();
					break;
				}
				case "copy":
				{
					if(rtb1.SelectedText.Length <= 0) break;
					rtb1.Copy();
					break;
				}
				case "paste":
				{
					try
					{
						rtb1.Paste();
					}
					catch
					{
						MessageBox.Show("Paste Failed");
					}
					break;
				}
			} //end select
		}
		#endregion

		#region Update Toolbar
		/// <summary>
		///     Update the toolbar button statuses
		/// </summary>
		public void UpdateToolbar()
		{
			// Get the font, fontsize and style to apply to the toolbar buttons
			Font fnt = GetFontDetails();
			// Set font style buttons to the styles applying to the entire selection
			FontStyle style = fnt.Style;
			
			//Set all the style buttons using the gathered style
			tbbBold.Pushed		= fnt.Bold; //bold button
			tbbItalic.Pushed	= fnt.Italic; //italic button
			tbbUnderline.Pushed	= fnt.Underline; //underline button
			tbbStrikeout.Pushed	= fnt.Strikeout; //strikeout button
			tbbLeft.Pushed		= (rtb1.SelectionAlignment == HorizontalAlignment.Left); //justify left
			tbbCenter.Pushed	= (rtb1.SelectionAlignment == HorizontalAlignment.Center); //justify center
			tbbRight.Pushed		= (rtb1.SelectionAlignment == HorizontalAlignment.Right); //justify right
	
			//Check the correct color
			foreach(MenuItem mi in cmColors.MenuItems)
				mi.Checked = (rtb1.SelectionColor == Color.FromName(mi.Text));
			
			//Check the correct font
			foreach(MenuItem mi in cmFonts.MenuItems)
				mi.Checked = (fnt.FontFamily.Name == mi.Text);

			//Check the correct font size
			foreach(MenuItem mi in cmFontSizes.MenuItems)
				mi.Checked = ((int)fnt.SizeInPoints == float.Parse(mi.Text));

            ownUpdateToolbar();
		}
		#endregion

		#region Update Toolbar Seperators
		private void UpdateToolbarSeperators()
		{
			//Save & Open
			if(!tbbSave.Visible && !tbbOpen.Visible) 
				tbbSeparator3.Visible = false;
			else
				tbbSeparator3.Visible = true;

			//Font & Font Size
			if(!tbbFont.Visible && !tbbFontSize.Visible && !tbbColor.Visible) 
				tbbSeparator5.Visible = false;
			else
				tbbSeparator5.Visible = true;

			//Bold, Italic, Underline, & Strikeout
			if(!tbbBold.Visible && !tbbItalic.Visible && !tbbUnderline.Visible && !tbbStrikeout.Visible)
				tbbSeparator1.Visible = false;
			else
				tbbSeparator1.Visible = true;

			//Left, Center, & Right
			if(!tbbLeft.Visible && !tbbCenter.Visible && !tbbRight.Visible)
				tbbSeparator2.Visible = false;
			else
				tbbSeparator2.Visible = true;

			//Undo & Redo
			if(!tbbUndo.Visible && !tbbRedo.Visible) 
				tbbSeparator4.Visible = false;
			else
				tbbSeparator4.Visible = true;
		}
#endregion

		#region RichTextBoxEx Selection Change
		/// <summary>
		///		Change the toolbar buttons when new text is selected
		///		and raise event SelChanged
		/// </summary>
		private void rtb1_SelectionChanged(object sender, System.EventArgs e)
		{
			//Update the toolbar buttons
			UpdateToolbar();
			
			//Send the SelChangedEvent
			if (SelChanged != null)
				SelChanged(this, e);
		}
#endregion

		#region Color Click
		/// <summary>
		///     Change the richtextbox color
		/// </summary>
		private void Color_Click(object sender, System.EventArgs e)
		{
			//set the richtextbox color based on the name of the menu item
			ChangeFontColor(Color.FromName(((MenuItem)sender).Text));
		}
		#endregion

		#region Font Click
		/// <summary>
		///     Change the richtextbox font
		/// </summary>
		private void Font_Click(object sender, System.EventArgs e)
		{
			// Set the font for the entire selection
			ChangeFont(((MenuItem)sender).Text);
		}
		#endregion

		#region Font Size Click
		/// <summary>
		///     Change the richtextbox font size
		/// </summary>
		private void FontSize_Click(object sender, System.EventArgs e)
		{
			//set the richtextbox font size based on the name of the menu item
			ChangeFontSize(float.Parse(((MenuItem)sender).Text));
		}
		#endregion

		#region Link Clicked
		/// <summary>
		/// Starts the default browser if a link is clicked
		/// </summary>
		private void rtb1_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		#endregion

		#region Public Properties
		/// <summary>
		///     The toolbar that is contained with-in the RichTextBoxExtened control
		/// </summary>
		[Description("The internal toolbar control"),
		Category("Internal Controls"),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ToolBar Toolbar
		{
			get { return tb1; }
		}

		/// <summary>
		///     The RichTextBoxEx that is contained with-in the RichTextBoxExtened control
		/// </summary>
		[Description("The internal richtextbox control"),
		Category("Internal Controls"),
		DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public RichTextBoxEx RichTextBox
		{
			get	{ return rtb1; }
		}

		/// <summary>
		///     Show the save button or not
		/// </summary>
		[Description("Show the save button or not"),
		Category("Appearance")]
		public bool ShowSave
		{
			get { return tbbSave.Visible; }
			set { tbbSave.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///    Show the open button or not 
		/// </summary>
		[Description("Show the open button or not"),
		Category("Appearance")]
		public bool ShowOpen
		{
			get { return tbbOpen.Visible; }
			set	{ tbbOpen.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the stamp button or not
		/// </summary>
		[Description("Show the stamp button or not"),
		 Category("Appearance")]
		public bool ShowStamp
		{
			get { return tbbStamp.Visible; }
			set { tbbStamp.Visible = value; }
		}
		
		/// <summary>
		///     Show the color button or not
		/// </summary>
		[Description("Show the color button or not"),
		Category("Appearance")]
		public bool ShowColors
		{
			get { return tbbColor.Visible; }
			set { tbbColor.Visible = value; }
		}

		/// <summary>
		///     Show the undo button or not
		/// </summary>
		[Description("Show the undo button or not"),
		Category("Appearance")]
		public bool ShowUndo
		{
			get { return tbbUndo.Visible; }
			set { tbbUndo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the redo button or not
		/// </summary>
		[Description("Show the redo button or not"),
		Category("Appearance")]
		public bool ShowRedo
		{
			get { return tbbRedo.Visible; }
			set { tbbRedo.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the bold button or not
		/// </summary>
		[Description("Show the bold button or not"),
		Category("Appearance")]
		public bool ShowBold
		{
			get { return tbbBold.Visible; }
			set { tbbBold.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the italic button or not
		/// </summary>
		[Description("Show the italic button or not"),
		Category("Appearance")]
		public bool ShowItalic
		{
			get { return tbbItalic.Visible; }
			set { tbbItalic.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the underline button or not
		/// </summary>
		[Description("Show the underline button or not"),
		Category("Appearance")]
		public bool ShowUnderline
		{
			get { return tbbUnderline.Visible; }
			set { tbbUnderline.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the strikeout button or not
		/// </summary>
		[Description("Show the strikeout button or not"),
		Category("Appearance")]
		public bool ShowStrikeout
		{
			get { return tbbStrikeout.Visible; }
			set { tbbStrikeout.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the left justify button or not
		/// </summary>
		[Description("Show the left justify button or not"),
		Category("Appearance")]
		public bool ShowLeftJustify
		{
			get { return tbbLeft.Visible; }
			set { tbbLeft.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the right justify button or not
		/// </summary>
		[Description("Show the right justify button or not"),
		Category("Appearance")]
		public bool ShowRightJustify
		{
			get { return tbbRight.Visible; }
			set { tbbRight.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Show the center justify button or not
		/// </summary>
		[Description("Show the center justify button or not"),
		Category("Appearance")]
		public bool ShowCenterJustify
		{
			get { return tbbCenter.Visible; }
			set { tbbCenter.Visible = value; UpdateToolbarSeperators(); }
		}

		/// <summary>
		///     Determines how the stamp button will respond
		/// </summary>
		StampActions m_StampAction = StampActions.EditedBy;
		[Description("Determines how the stamp button will respond"),
		Category("Behavior")]
		public StampActions StampAction
		{
			get { return m_StampAction; }
			set { m_StampAction = value; }
		}
		
		/// <summary>
		///     Color of the stamp text
		/// </summary>
		Color m_StampColor = Color.Blue;

		[Description("Color of the stamp text"),
		Category("Appearance")]
		public Color StampColor
		{
			get { return m_StampColor; }
			set { m_StampColor = value; }
		}
			
		/// <summary>
		///     Show the font button or not
		/// </summary>
		[Description("Show the font button or not"),
		Category("Appearance")]
		public bool ShowFont
		{
			get { return tbbFont.Visible; }
			set { tbbFont.Visible = value; }
		}

		/// <summary>
		///     Show the font size button or not
		/// </summary>
		[Description("Show the font size button or not"),
		Category("Appearance")]
		public bool ShowFontSize
		{
			get { return tbbFontSize.Visible; }
			set { tbbFontSize.Visible = value; }
		}

		/// <summary>
		///     Show the cut button or not
		/// </summary>
		[Description("Show the cut button or not"),
		Category("Appearance")]
		public bool ShowCut
		{
			get { return tbbCut.Visible; }
			set { tbbCut.Visible = value; }
		}

		/// <summary>
		///     Show the copy button or not
		/// </summary>
		[Description("Show the copy button or not"),
		Category("Appearance")]
		public bool ShowCopy
		{
			get { return tbbCopy.Visible; }
			set { tbbCopy.Visible = value; }
		}

		/// <summary>
		///     Show the paste button or not
		/// </summary>
		[Description("Show the paste button or not"),
		Category("Appearance")]
		public bool ShowPaste
		{
			get { return tbbPaste.Visible; }
			set { tbbPaste.Visible = value; }
		}

		/// <summary>
		///     Detect URLs with-in the richtextbox
		/// </summary>
		[Description("Detect URLs with-in the richtextbox"),
		Category("Behavior")]
		public bool DetectURLs
		{
			get { return rtb1.DetectUrls; }
			set { rtb1.DetectUrls = value; }
		}

		/// <summary>
		/// Determines if the TAB key moves to the next control or enters a TAB character in the richtextbox
		/// </summary>
		[Description("Determines if the TAB key moves to the next control or enters a TAB character in the richtextbox"),
		Category("Behavior")]
		public bool AcceptsTab
		{
			get { return rtb1.AcceptsTab; }
			set { rtb1.AcceptsTab = value; }
		}

		/// <summary>
		/// Determines if auto word selection is enabled
		/// </summary>
		[Description("Determines if auto word selection is enabled"),
		Category("Behavior")]
		public bool AutoWordSelection
		{
			get { return rtb1.AutoWordSelection; }
			set { rtb1.AutoWordSelection = value; }
		}

		/// <summary>
		/// Determines if this control can be edited
		/// </summary>
		[Description("Determines if this control can be edited"),
		Category("Behavior")]
		public bool ReadOnly
		{
			get { return rtb1.ReadOnly; }
			set 
			{
				//tb1.Visible = !value;
                tbar.Visible = !value;
				rtb1.ReadOnly = value;
                if (value)
                    this.RichTextBox.BackColor = System.Drawing.Color.LightYellow;
                else
                    this.RichTextBox.BackColor = System.Drawing.Color.White;
			}
		}

		private bool _showToolBarText;

		/// <summary>
		/// Determines if the buttons on the toolbar will show there text or not
		/// </summary>
		[Description("Determines if the buttons on the toolbar will show there text or not"),
		Category("Behavior")]
		public bool ShowToolBarText
		{
			get	{ return _showToolBarText; }
			set 
			{
				_showToolBarText = value;

				if(_showToolBarText)
				{
					tbbSave.Text = "Save";
					tbbOpen.Text = "Open";
					tbbBold.Text = "Bold";
					tbbFont.Text = "Font";
					tbbFontSize.Text = "Font Size";
					tbbColor.Text = "Font Color";
					tbbItalic.Text = "Italic";
					tbbStrikeout.Text = "Strikeout";
					tbbUnderline.Text = "Underline";
					tbbLeft.Text = "Left";
					tbbCenter.Text = "Center";
					tbbRight.Text = "Right";
					tbbUndo.Text = "Undo";
					tbbRedo.Text = "Redo";
					tbbCut.Text = "Cut";
					tbbCopy.Text = "Copy";
					tbbPaste.Text = "Paste";
					tbbStamp.Text = "Stamp";
				}
				else
				{
					tbbSave.Text = "";
					tbbOpen.Text = "";
					tbbBold.Text = "";
					tbbFont.Text = "";
					tbbFontSize.Text = "";
					tbbColor.Text = "";
					tbbItalic.Text = "";
					tbbStrikeout.Text = "";
					tbbUnderline.Text = "";
					tbbLeft.Text = "";
					tbbCenter.Text = "";
					tbbRight.Text = "";
					tbbUndo.Text = "";
					tbbRedo.Text = "";
					tbbCut.Text = "";
					tbbCopy.Text = "";
					tbbPaste.Text = "";
					tbbStamp.Text = "";
				}

				this.Invalidate();
				this.Update();
			}
		}

		#endregion

		#region Change font
		/// <summary>
		///     Change the richtextbox font for the current selection
		/// </summary>
		public void ChangeFont(string fontFamily)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			// fontFamily - the font to be applied, eg "Courier New"

			// Reason: The reason this method and the others exist is because
			// setting these items via the selection font doen't work because
			// a null selection font is returned for a selection with more 
			// than one font!
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;						

			// If len <= 1 and there is a selection font, amend and return
			if (len <= 1 && rtb1.SelectionFont != null)
			{
				rtb1.SelectionFont =
					new Font(fontFamily, rtb1.SelectionFont.Size, rtb1.SelectionFont.Style);
				return;
			}

			// Step through the selected text one char at a time
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				rtbTemp.SelectionFont = new Font(fontFamily, rtbTemp.SelectionFont.Size, rtbTemp.SelectionFont.Style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font style
		/// <summary>
		///     Change the richtextbox style for the current selection
		/// </summary>
		public void ChangeFontStyle(FontStyle style, bool add)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			//	style - eg FontStyle.Bold
			//	add - IF true then add else remove
			
			// throw error if style isn't: bold, italic, strikeout or underline
			if (   style != FontStyle.Bold
				&& style != FontStyle.Italic
				&& style != FontStyle.Strikeout
				&& style != FontStyle.Underline)
					throw new  System.InvalidProgramException("Invalid style parameter to ChangeFontStyle");
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;			
			
			//if len <= 1 and there is a selection font then just handle and return
			if(len <= 1 && rtb1.SelectionFont != null)
			{
				//add or remove style 
				if (add)
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style | style);
				else
					rtb1.SelectionFont = new Font(rtb1.SelectionFont, rtb1.SelectionFont.Style & ~style);
				
				return;
			}
			
			// Step through the selected text one char at a time	
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 

				//add or remove style 
				if (add)
					rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style | style);
				else
					rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont, rtbTemp.SelectionFont.Style & ~style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font size
		/// <summary>
		///     Change the richtextbox font size for the current selection
		/// </summary>
		public void ChangeFontSize(float fontSize)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			// fontSize - the fontsize to be applied, eg 33.5
			
			if (fontSize <= 0.0)
				throw new System.InvalidProgramException("Invalid font size parameter to ChangeFontSize");
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;

			// If len <= 1 and there is a selection font, amend and return
			if (len <= 1 && rtb1.SelectionFont != null)
			{
				rtb1.SelectionFont =
					new Font(rtb1.SelectionFont.FontFamily, fontSize, rtb1.SelectionFont.Style);
				return;
			}
			
			// Step through the selected text one char at a time
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				rtbTemp.SelectionFont = new Font(rtbTemp.SelectionFont.FontFamily, fontSize, rtbTemp.SelectionFont.Style);
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Change font color
		/// <summary>
		///     Change the richtextbox font color for the current selection
		/// </summary>
		public void ChangeFontColor(Color newColor)
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			// Parameters:-
			//	newColor - eg Color.Red
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;			
			
			//if len <= 1 and there is a selection font then just handle and return
			if(len <= 1 && rtb1.SelectionFont != null)
			{
				rtb1.SelectionColor = newColor;
				return;
			}
			
			// Step through the selected text one char at a time	
			rtbTemp.Rtf = rtb1.SelectedRtf;
			for(int i = 0; i < len; ++i) 
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 

				//change color
				rtbTemp.SelectionColor = newColor;
			}

			// Replace & reselect
			rtbTemp.Select(rtbTempStart,len);
			rtb1.SelectedRtf = rtbTemp.SelectedRtf;
			rtb1.Select(rtb1start,len);
			return;
		}
		#endregion

		#region Get Font Details
		/// <summary>
		///     Returns a Font with:
		///     1) The font applying to the entire selection, if none is the default font. 
		///     2) The font size applying to the entire selection, if none is the size of the default font.
		///     3) A style containing the attributes that are common to the entire selection, default regular.
		/// </summary>		
		/// 
		public Font GetFontDetails()
		{
			//This method should handle cases that occur when multiple fonts/styles are selected
			
			int rtb1start = rtb1.SelectionStart;				
			int len = rtb1.SelectionLength; 
			int rtbTempStart = 0;

			if (len <= 1)						
			{
				// Return the selection or default font
				if (rtb1.SelectionFont != null)
					return rtb1.SelectionFont;
				else
					return rtb1.Font;
			}

			// Step through the selected text one char at a time	
			// after setting defaults from first char
			rtbTemp.Rtf = rtb1.SelectedRtf;
		
			//Turn everything on so we can turn it off one by one
			FontStyle replystyle =			
				FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline;
			
			// Set reply font, size and style to that of first char in selection.
			rtbTemp.Select(rtbTempStart, 1);
			string replyfont = rtbTemp.SelectionFont.Name;
			float replyfontsize = rtbTemp.SelectionFont.Size;
			replystyle = replystyle & rtbTemp.SelectionFont.Style;
			
			// Search the rest of the selection
			for(int i = 1; i < len; ++i)				
			{ 
				rtbTemp.Select(rtbTempStart + i, 1); 
				
				// Check reply for different style
				replystyle = replystyle & rtbTemp.SelectionFont.Style;
				
				// Check font
				if (replyfont != rtbTemp.SelectionFont.FontFamily.Name)
					replyfont = "";

				// Check font size
				if (replyfontsize != rtbTemp.SelectionFont.Size)
					replyfontsize = (float)0.0;
			}

			// Now set font and size if more than one font or font size was selected
			if (replyfont == "")
				replyfont = rtbTemp.Font.FontFamily.Name;

			if (replyfontsize == 0.0)
				replyfontsize = rtbTemp.Font.Size;

			// generate reply font
			Font reply 
				= new Font(replyfont, replyfontsize, replystyle);
			
			return reply;
		}
		#endregion

		#region Keyboard Handler
		private void rtb1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				ToolBarButton tbb = null;

				switch (e.KeyCode)
				{
					case Keys.B:
						tbb = this.tbbBold;
						break;
					case Keys.I:
						tbb = this.tbbItalic;
						break;
					case Keys.S:
						tbb = this.tbbStamp;
						break;
					case Keys.U:
						tbb = this.tbbUnderline;
						break;
					case Keys.OemMinus:
						tbb = this.tbbStrikeout;
						break;
				}
                
				if (tbb != null)
				{
					if(e.KeyCode != Keys.S) tbb.Pushed = !tbb.Pushed;
					tb1_ButtonClick(null, new ToolBarButtonClickEventArgs(tbb));
				}
			}
			
			//Insert a tab if the tab key was pressed.
			/* NOTE: This was needed because in rtb1_KeyPress I tell the richtextbox not
			 * to handle tab events.  I do that because CTRL+I inserts a tab for some
			 * strange reason.  What was MicroSoft thinking?
			 * Richard Parsons 02/08/2007
			 */
			if (e.KeyCode == Keys.Tab)
				rtb1.SelectedText = "\t";

		}

		private void rtb1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if((int)e.KeyChar == 9)
				e.Handled = true; // Stops Ctrl+I from inserting a tab (char HT) into the richtextbox
		}
		#endregion

        public override String Text
        {
            get
            {
                return this.RichTextBox.Text;
            }
            set
            {
                this.RichTextBox.Text = value;
            }
        }

        #region "Nuevo"

        public String TextRTF
        {
            get
            {
                return this.RichTextBox.Rtf;
            }
            set
            {
                this.RichTextBox.Rtf = value;
            }
        }

        public void AppendRtf(string rtfToAppend)
        {
            //this.RichTextBox.Select(this.RichTextBox.TextLength, 0);
            //// Since SelectedRtf is null, this will append the string to the
            //// end of the existing RTF
            //this.RichTextBox.SelectedRtf = rtfToAppend;

            string temp = this.TextRTF;
            if (!string.IsNullOrEmpty(this.Text))
            {
                temp = temp.Substring(0, temp.Length - 10);
                //temp = temp.Substring(0, temp.LastIndexOf("}")-1);
                temp += rtfToAppend + "}";
            }
            else
            {
                temp = rtfToAppend;
            }
            this.TextRTF = temp;

            //string res = string.Empty;
            //string temp;

            ////temp = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Síntomas\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n";
            //string info = string.Format("********** {0}. ({1}). {2} **********", this.Fecha.ToString("dd/MM/yyyy"), this.Empleado.ToString(), !this.Presencial ? "Llamada telefónica" : "");
            //temp = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\b{\\pntext\\f1\\'B7\\tab}" + info + "\\ulnone\\b0\\par\r\n}\r\n\r\n" + "}";

            //if (!string.IsNullOrEmpty(this.Sintomas))
            //{
            //    temp = temp.Substring(0, temp.Length - 10);
            //    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Síntomas\\ulnone\\b0\\par\r\n}\r\n" + "}";

            //    temp = temp.Substring(0, temp.Length - 1);
            //    temp += this.Sintomas + "}";
            //}

            //if (!string.IsNullOrEmpty(this.Diagnostico))
            //{
            //    temp = temp.Substring(0, temp.Length - 10);
            //    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Diagnóstico\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" +"}";
            //    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Diagnóstico\\ulnone\\b0\\par\r\n}\r\n" + "}";

            //    temp = temp.Substring(0, temp.Length - 1);
            //    temp += this.Diagnostico + "}";
            //}

            //if (!string.IsNullOrEmpty(this.Tratamiento))
            //{
            //    temp = temp.Substring(0, temp.Length - 10);
            //    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Tratamiento\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" + "}";
            //    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Tratamiento\\ulnone\\b0\\par\r\n}\r\n" + "}";

            //    temp = temp.Substring(0, temp.Length - 1);
            //    temp += this.Tratamiento + "}";
            //}

            //if (!string.IsNullOrEmpty(this.Prescrito))
            //{
            //    temp = temp.Substring(0, temp.Length - 10);
            //    //temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\ul\\b\\f0\\fs18 Prescrito\\ulnone\\b0\\par\r\n{\\pntext\\f1\\'B7\\tab}\\par\r\n}\r\n" + "}";
            //    temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Prescrito\\ulnone\\b0\\par\r\n}\r\n" + "}";

            //    temp = temp.Substring(0, temp.Length - 1);
            //    temp += this.Prescrito + "}";
            //}
            //res = temp;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbSave;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));  
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbBold;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbOpen;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbItalic;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbUnderline;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbStrikeout_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbStrikeout;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbLeft_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbLeft;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbCenter_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbCenter;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbRight_Click(object sender, EventArgs e)
        {

            ToolBarButton button = this.tbbRight;
            button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbUndo;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbRedo_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbRedo;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbCut;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbCopy;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbPaste;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }

        private void tsbStamp_Click(object sender, EventArgs e)
        {
            ToolBarButton button = this.tbbStamp;
            //button.Pushed = ((ToolStripButton)sender).Checked;
            tb1_ButtonClick(this.tb1, new ToolBarButtonClickEventArgs(button));
        }
        private void tsbColor_Click(object sender, EventArgs e)
        {
            //ColorDialog dialog = new ColorDialog();
            ////dialog.Color = Color.FromArgb(0xff, fontcolor & 0xff, (fontcolor >> 8) & 0xff, (fontcolor >> 16) & 0xff);

            //DialogResult result = dialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    string color = dialog.Color.Name;
            //    if (!dialog.Color.IsNamedColor)
            //    {
            //        color = "#" + color.Remove(0, 2);
            //    }
            //    ChangeFontColor(Color.FromName(color));
            //    //MessageBox.Show(color);
            //}
        }
        #region Font Click / Chapuzilla
        /// <summary>
        ///     Change the richtextbox font
        /// </summary>
        private void ownFont_Click(object sender, System.EventArgs e)
        {
            // Set the font for the entire selection
            ChangeFont(((ToolStripMenuItem)sender).Text);
        }
        #endregion
        #region Font Size Click / Chapuzilla
        /// <summary>
        ///     Change the richtextbox font size
        /// </summary>
        private void ownFontSize_Click(object sender, System.EventArgs e)
        {
            //set the richtextbox font size based on the name of the menu item
            ChangeFontSize(float.Parse(((ToolStripMenuItem)sender).Text));
        }
        #endregion
        #region Color Click / Chapuzilla
        /// <summary>
        ///     Change the richtextbox color
        /// </summary>
        private void ownColor_Click(object sender, System.EventArgs e)
        {
            //set the richtextbox color based on the name of the menu item
            ChangeFontColor(Color.FromName(((ToolStripMenuItem)sender).Text));
        }
        #endregion
        #region Update Toolbar / Chapuzilla
        /// <summary>
        ///     Update the toolbar button statuses
        /// </summary>
        public void ownUpdateToolbar()
        {
            // Get the font, fontsize and style to apply to the toolbar buttons
            Font fnt = GetFontDetails();
            // Set font style buttons to the styles applying to the entire selection
            FontStyle style = fnt.Style;

            //Set all the style buttons using the gathered style
            tsbBold.Checked = fnt.Bold; //bold button
            tsbItalic.Checked = fnt.Italic; //italic button
            tsbUnderline.Checked = fnt.Underline; //underline button
            tsbStrikeout.Checked = fnt.Strikeout; //strikeout button
            tsbLeft.Checked = (rtb1.SelectionAlignment == HorizontalAlignment.Left); //justify left
            tsbCenter.Checked = (rtb1.SelectionAlignment == HorizontalAlignment.Center); //justify center
            tsbRight.Checked = (rtb1.SelectionAlignment == HorizontalAlignment.Right); //justify right

            foreach (ToolStripMenuItem item in this.tsbColor.DropDownItems)
                item.Checked = (rtb1.SelectionColor == Color.FromName(item.Text));

            foreach (ToolStripMenuItem item in this.tsbFont.DropDownItems)
                item.Checked = (fnt.FontFamily.Name == item.Text);

            foreach (ToolStripMenuItem item in this.tsbFontSize.DropDownItems)
                item.Checked = ((int)fnt.SizeInPoints == float.Parse(item.Text));

            ////Check the correct color
            //foreach (MenuItem mi in cmColors.MenuItems)
            //    mi.Checked = (rtb1.SelectionColor == Color.FromName(mi.Text));

            ////Check the correct font
            //foreach (MenuItem mi in cmFonts.MenuItems)
            //    mi.Checked = (fnt.FontFamily.Name == mi.Text);

            ////Check the correct font size
            //foreach (MenuItem mi in cmFontSizes.MenuItems)
            //    mi.Checked = ((int)fnt.SizeInPoints == float.Parse(mi.Text));
        }
        #endregion

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
        private void tsbPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void tsbPrintSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }
        #endregion


	} //end class
} //end namespace

