using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class TipoFestivo
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public System.Drawing.Color DrawColor
        {
            get
            {
                return System.Drawing.Color.FromName(this.Color);
            }
        }


        public TipoFestivo()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _color = System.Drawing.KnownColor.PaleGreen.ToString();
        }

        public override string ToString()
        {
            return this.Descripcion;
        }

        public static List<string> Colores()
        {
            List<string> res = new List<string>();
            res.AddRange(System.Enum.GetNames(typeof(System.Drawing.KnownColor)));
            
            //if (!res.Contains("Linen")) res.Add("Linen");
            //if (!res.Contains("OldLace")) res.Add("OldLace");
            //if (!res.Contains("Pink")) res.Add("Pink");
            //if (!res.Contains("LightPink")) res.Add("LightPink");
            //if (!res.Contains("LightYellow")) res.Add("LightYellow");
            //if (!res.Contains("LightBlue")) res.Add("LightBlue");
            //if (!res.Contains("LightGreen")) res.Add("LightGreen");
            //if (!res.Contains("LightGray")) res.Add("LightGray");
            //if (!res.Contains("DarkGray")) res.Add("DarkGray");
            //if (!res.Contains("WhiteSmoke")) res.Add("WhiteSmoke");
            //if (!res.Contains("PaleGreen")) res.Add("PaleGreen");
            
            //res.Sort();

            return res;
        }
    }
}
