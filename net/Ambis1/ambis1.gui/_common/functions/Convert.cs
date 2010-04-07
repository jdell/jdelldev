using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace asr.app.pc._common.funciones
{
    abstract class Convert
    {
        public static System.Windows.Forms.CheckState ToCheckState(bool? obj)
        {
            return (!obj.HasValue?CheckState.Indeterminate:(obj.Value?CheckState.Checked:CheckState.Unchecked));
        }
    }
}
