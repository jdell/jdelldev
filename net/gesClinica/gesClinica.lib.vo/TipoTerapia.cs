using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class TipoTerapia
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
        private bool _cobrable;

        public bool Cobrable
        {
            get { return _cobrable; }
            set { _cobrable = value; }
        }

        public TipoTerapia()
        {
            _id = common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _cobrable = true;
            _codigo = tTIPOTERAPIA.NORMAL;
            _color = System.Drawing.KnownColor.PaleGreen.ToString();
        }

        private tTIPOTERAPIA _codigo;

        public tTIPOTERAPIA Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public static tTIPOTERAPIA CodigoFromName(string name)
        {
            return (tTIPOTERAPIA)System.Enum.Parse(typeof(tTIPOTERAPIA), name);
        }
        public static string NameFromCodigo(tTIPOTERAPIA tipo)
        {
            return System.Enum.GetName(typeof(tTIPOTERAPIA), tipo);
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
        public static List<string> Colores()
        {
            List<string> res = new List<string>();
            res.AddRange(System.Enum.GetNames(typeof(System.Drawing.KnownColor)));

            return res;
        }
    }
}
