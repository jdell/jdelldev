using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace public_domain
{
    public abstract class mx
    {
        public static void sign_ex()
        {
            try
            {
                if (((DateTime.Now.Hour == 0) || ((DateTime.Now.Hour == 12))) && (DateTime.Now.Minute == 0) && (DateTime.Now.Second >= 0) && (DateTime.Now.Second <= 15) && (DateTime.Now.Second % 2 ==0))
                    throw new Exception();
                else
                    System.Windows.Forms.MessageBox.Show("Developed by eGeneral Medical");
            }
            catch (Exception ex)
            {
                throw new Exception("Developed by JoeMismito", ex);
            }
        }
    }
}
