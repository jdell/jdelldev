using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.template._common
{
    public abstract class messages
    {
        public static void ShowError(Exception ex)
        {
            repsol.util.messages.ShowError(ex.Message, ex.TargetSite.Name);
        }
        public static void ShowWarning(string msg, string title)
        {
            repsol.util.messages.ShowWarning(msg, title);
        }
        public static void ShowInfo(string msg, string title)
        {
            repsol.util.messages.ShowInfo(msg, title);
        }

    }
}
