using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace public_domain
{
    public abstract class log
    {
        /// <summary>
        /// Log File's Path
        /// </summary>
        public static string LOGFILE = string.Format("{0}/{1}", Environment.CurrentDirectory, string.Format("LOG_eGMApp_{0:MMddyyyy}.txt", DateTime.Now));

        public static void WriteLine(string line)
        {
            System.IO.FileStream file = new System.IO.FileStream(LOGFILE, System.IO.FileMode.Append);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(file);

            try
            {
                writer.WriteLine(line);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
                file.Close();
            }
        }
    }
}
