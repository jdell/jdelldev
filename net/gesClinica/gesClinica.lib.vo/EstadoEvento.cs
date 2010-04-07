using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class EstadoEvento
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

        
        public EstadoEvento()
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

            return res;
        }

    }
}
