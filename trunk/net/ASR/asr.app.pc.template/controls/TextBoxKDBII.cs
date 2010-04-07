using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.template.controls
{
    public class TextBoxKDBII:repsol.forms.controls.TextBoxColor
    {
        public TextBoxKDBII():base()
        {
            this.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
        }

        private object[] _dataSource = null;

        public object[] DataSource
        {
            get { return _dataSource; }
            set { _dataSource = value; setKDB(); }
        }

        private void setKDB()
        {
            this.AutoCompleteCustomSource.Clear();
            if (this.DataSource!=null) 
                foreach (object obj in DataSource) 
                    this.AutoCompleteCustomSource.Add(obj.ToString());
        }

        public object SelectedValue
        {
            get
            {
                object res = null;
                if (this.DataSource != null)
                {
                    foreach (object obj in this.DataSource)
                    {
                        if (obj.ToString().Trim().ToUpper() == this.Text.Trim().ToUpper())
                        {    
                            res = obj;
                            break;
                        }
                    }
                }   
                return res; 
            }
        }

    }
}
