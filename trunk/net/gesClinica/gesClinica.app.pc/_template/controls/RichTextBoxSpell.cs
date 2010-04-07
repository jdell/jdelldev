using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

#region "Profile"
//Name:Dipak Fatania
//Contact:dipakfatania@hotmail.com
//Modificado por MeMismo [jdelito@hotmail.com]
#endregion

namespace gesClinica.app.pc.template.controls
{
    public class RichTextBoxSpell: System.Windows.Forms.RichTextBox
    {

        #region "Variables"

        bool m_blnSpellCheck = false;
        Microsoft.Office.Interop.Word.Application m_app;
        Microsoft.Office.Interop.Word.Document m_doc;

        #endregion

        #region "Constructor"

        public RichTextBoxSpell()
            :
            base()
        {
            //m_app = new Microsoft.Office.Interop.Word.Application();
            //Object template = Missing.Value;
            //Object newTemplate = Missing.Value;
            //Object documentType = Microsoft.Office.Interop.Word.WdTemplateType.wdNormalTemplate;
            //Object documentVisible = false;

            //m_doc = m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);
            ////m_doc = ownAdd();
            ////m_doc = m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);

            //this.KeyUp += new KeyEventHandler(RichTextBoxSpell_KeyUp);
            //this.Leave += new EventHandler(RichTextBoxSpell_Leave);
            //this.MouseDown += new MouseEventHandler(RichTextBoxSpell_MouseDown);
        }




        #endregion

        #region "Public Property"

        public bool SpellCheck
        {
            get
            {
                return m_blnSpellCheck;
            }
            set
            {
                m_blnSpellCheck = value;
            }
        }

        #endregion

        #region "Eventos"

        private void ToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
        {

            ToolStripMenuItem m_item = (ToolStripMenuItem)sender;

            Int16[] m_pointArray = (Int16[])m_item.Tag;

            String m_strFirstPart = String.Empty;

            if (m_pointArray[0] > 0)
                m_strFirstPart = this.Text.Substring(0, m_pointArray[0]) + " ";

            String m_strMiddlePart = this.Text.Substring(m_pointArray[0] + 1, m_pointArray[1] - m_pointArray[0]);

            String m_strLastPart = this.Text.Substring(m_pointArray[1] + 1);

            this.SelectionStart = m_pointArray[0] + 1;

            this.SelectionLength = m_strMiddlePart.Length;

            this.SelectionFont = new Font(this.SelectionFont.FontFamily, this.SelectionFont.Size, FontStyle.Regular);

            this.SelectedText = m_item.Text + " ";

            this.Refresh();


        }

        void RichTextBoxSpell_Leave(object sender, EventArgs e)
        {
            UnderLineWrongWords();
            SpellChecking();
        }

        void RichTextBoxSpell_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.Text.Length == 0)
            {
                this.SelectionFont = new Font(this.SelectionFont.FontFamily, this.SelectionFont.Size, FontStyle.Regular);
                this.Refresh();
            }

            if (e.KeyValue == 32)
            {
                String m_strRecentWord = String.Empty;
                int m_intLastIndex = this.Text.Substring(0, this.SelectionStart - 1).LastIndexOf(" ");
                int m_intLength = this.SelectionStart - m_intLastIndex - 2;
                m_strRecentWord = this.Text.Substring(m_intLastIndex + 1, m_intLength);
                m_strRecentWord = m_strRecentWord.Trim();

                if (m_strRecentWord.Length > 0 && IsWrongWord(m_strRecentWord) == true)
                {
                    this.SelectionStart = m_intLastIndex + 1;
                    this.SelectionLength = m_intLength;
                    this.SelectionFont = new Font(this.SelectionFont.FontFamily, this.SelectionFont.Size, FontStyle.Underline);
                    this.SelectionStart = this.SelectionStart + this.SelectionLength + 1;
                    this.Refresh();
                }

            }
        }

        private Microsoft.Office.Interop.Word.SpellingSuggestions ownGetSpellingSuggestions(string word)
        {

            Object CustomDictionary = Missing.Value;
            Object IgnoreUppercase = true;
            Object MainDictionary = Missing.Value;
            Object SuggestionMode = Microsoft.Office.Interop.Word.WdSpellingWordType.wdSpellword;
            Object CustomDictionary2 = Missing.Value;
            Object CustomDictionary3 = Missing.Value;
            Object CustomDictionary4 = Missing.Value;
            Object CustomDictionary5 = Missing.Value;
            Object CustomDictionary6 = Missing.Value;
            Object CustomDictionary7 = Missing.Value;
            Object CustomDictionary8 = Missing.Value;
            Object CustomDictionary9 = Missing.Value;
            Object CustomDictionary10 = Missing.Value;

             return m_app.GetSpellingSuggestions
                 (word, 
                 ref CustomDictionary, 
                 ref IgnoreUppercase,
                 ref MainDictionary, 
                 ref SuggestionMode, 
                 ref CustomDictionary2, 
                 ref CustomDictionary3, 
                 ref CustomDictionary4, 
                 ref CustomDictionary5, 
                 ref CustomDictionary6, 
                 ref CustomDictionary7, 
                 ref CustomDictionary8, 
                 ref CustomDictionary9, 
                 ref CustomDictionary10
                 );

        }

        private Microsoft.Office.Interop.Word.Document ownAdd()
        {
            Object template = Missing.Value;
            Object newTemplate = Missing.Value;
            Object documentType = Missing.Value;
            Object documentVisible = false;

            return m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);
        }

        void RichTextBoxSpell_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.SpellCheck == false)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ContextMenuStrip m_objContextMenuStrip = new ContextMenuStrip();

                    //get string from starting to clicked position
                    Int16 m_intClickIndex = Convert.ToInt16(this.GetCharIndexFromPosition(new Point(e.X, e.Y)));

                    //index of clicked char
                    String m_strInitialString = this.Text.Substring(0, m_intClickIndex);

                    //initialise index upto total lengh in case we are clicking on last word
                    Int16 m_intStartIndex = Convert.ToInt16(this.Text.Length - 1);

                    //if clicked word is not last word
                    if (this.Text.IndexOf(" ", m_intClickIndex) != -1)
                    {
                        m_intStartIndex = Convert.ToInt16(this.Text.IndexOf(" ", m_intClickIndex));
                    }

                    //moving towords starting of string from clicked position
                    Int16 m_intLastIndex = Convert.ToInt16(m_strInitialString.LastIndexOf(" "));

                    //original clicked word
                    String m_strWord = this.Text.Substring(m_intLastIndex + 1, m_intStartIndex - m_intLastIndex);

                    if (m_strWord.Length > 0)
                    {
                        Object template = Missing.Value;
                        Object newTemplate = Missing.Value;
                        Object documentType = Missing.Value;
                        Object documentVisible = false;

                        m_doc= m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);
                        //Microsoft.Office.Interop.Word.Document m_doc =  ownAdd();


                        Microsoft.Office.Interop.Word.SpellingSuggestions m_listOfAlternateWords = ownGetSpellingSuggestions(m_strWord);
                           
                        if (m_listOfAlternateWords.Count > 0)
                        {
                            m_objContextMenuStrip.Items.Clear();

                            int m_word;
                            for (m_word = 0; m_word < m_listOfAlternateWords.Count; m_word++)
                            {
                                ToolStripMenuItem Item = new ToolStripMenuItem();
                                Item.Name = m_listOfAlternateWords[m_word].Name;
                                Item.Text = Item.Name;

                                Item.Tag = new Int16[] { m_intLastIndex, m_intStartIndex };

                                Item.Click += new EventHandler(ToolStripMenuItem_Click);

                                m_objContextMenuStrip.Items.Add(Item);
                            }


                            if (m_objContextMenuStrip.Items.Count > 0)
                            {
                                m_objContextMenuStrip.Show(this, new Point(e.X, e.Y));
                            }
                        }

                    }

                    m_objContextMenuStrip = null;

                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (m_app != null)
                {
                    Object m_saveChanges = false;
                    Object m_originalFormat = Missing.Value;
                    Object m_routeDocument = Missing.Value;
                    m_app.Quit(ref m_saveChanges, ref m_originalFormat, ref m_routeDocument);
                    m_app = null;
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region "Methods"

        private void InitiatVariable()
        {
            if (m_app == null)
            {
                m_app = new Microsoft.Office.Interop.Word.Application();
                Object template = Missing.Value;
                Object newTemplate = Missing.Value;
                Object documentType = Missing.Value;
                Object documentVisible = false;

                m_doc= m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);
                //m_doc = ownAdd(); //m_app.Documents.Add();
            }
        }


        private bool IsWrongWord(String m_strWord)
        {
            Microsoft.Office.Interop.Word.SpellingSuggestions m_listOfAlternateWords = ownGetSpellingSuggestions(m_strWord);
            if (m_listOfAlternateWords.Count > 0)
                return true;
            else
                return false;
        }

        private void UnderLineWrongWords()
        {
            this.SelectionStart = 0;
            Microsoft.Office.Interop.Word.Range m_range;
                
            Object m_first = 0;
            Object m_last = m_app.ActiveDocument.Characters.Count - 1;

            m_range = m_app.ActiveDocument.Range(ref m_first, ref m_last);
            m_range.InsertAfter(this.Text);

            Microsoft.Office.Interop.Word.ProofreadingErrors m_spellCollection = m_range.SpellingErrors;
            int m_intWord;
            Font m_font = this.SelectionFont;
            Int16 m_strIndex = 0;
            for (m_intWord = 0; m_intWord < m_spellCollection.Count; m_intWord++)
            {
                this.Find(m_spellCollection[m_intWord].Text, m_strIndex, RichTextBoxFinds.WholeWord);
                m_strIndex = Convert.ToInt16(this.Text.IndexOf(m_spellCollection[m_intWord].Text, m_strIndex));
                this.SelectionFont = new Font(m_font.FontFamily, m_font.Size, FontStyle.Underline);

            }

            this.SelectionStart = this.SelectionStart + this.SelectionLength + 1;

            this.Refresh();
        }
        private void SpellChecking()
        {
            if (this.Text.Length > 0)
            {

                m_app.Visible = false;

                m_app.WindowState = 0;

                Object m_template = Missing.Value;
                Object m_newTemplate = Missing.Value;
                Object m_documentType = Missing.Value;
                Object m_visible = false;
                Object m_optional = Missing.Value;

                m_doc = m_app.Documents.Add(ref m_template, ref m_newTemplate, ref m_documentType, ref m_visible);

                m_doc.Words.First.InsertBefore(this.Text);
                Microsoft.Office.Interop.Word.ProofreadingErrors m_we = m_doc.SpellingErrors;

                m_doc.CheckSpelling(ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional, ref m_optional);


                Object m_first = 0;
                Object m_last = m_doc.Characters.Count - 1;

                this.Text = m_doc.Range(ref m_first, ref m_last).Text;

                Object m_saveChanges = false;
                Object m_originalFormat = Missing.Value;
                Object m_routeDocument = Missing.Value;
                m_app.Quit(ref m_saveChanges, ref m_originalFormat, ref m_routeDocument);

                this.SelectionStart = 0;
                this.SelectionLength = this.Text.Length;
                this.SelectionFont = new Font(this.SelectionFont.FontFamily, this.SelectionFont.Size, FontStyle.Regular);
                this.Refresh();
                this.SelectionStart = this.Text.Length;
                m_app = new Microsoft.Office.Interop.Word.Application();
                Object template = Missing.Value;
                Object newTemplate = Missing.Value;
                Object documentType = Missing.Value;
                Object documentVisible = false;

                m_doc= m_app.Documents.Add(ref template, ref newTemplate, ref documentType, ref documentVisible);
                //m_doc = ownAdd(); //m_app.Documents.Add();

            }
        }

        #endregion
    }
}
