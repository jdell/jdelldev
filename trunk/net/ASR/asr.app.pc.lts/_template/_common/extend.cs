using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc._template._common
{
    public static class extend
    {
        public static void SelectOnEnter(ref repsol.forms.controls.TextBoxColor textBox)
        {
            try
            {
                textBox.Enter+= new EventHandler(SelectOnEnterHandler);
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
        private static void SelectOnEnterHandler(object sender, EventArgs e)
        {
            try
            {
                ((System.Windows.Forms.TextBox)sender).SelectAll();
            }
            catch (Exception ex)
            {
                template._common.messages.ShowError(ex);
            }
        }
    }
}
