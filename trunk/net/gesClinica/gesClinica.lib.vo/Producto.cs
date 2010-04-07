using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Producto
    {
        private int _unidades;

        public int Unidades
        {
            get { return _unidades; }
            set { _unidades = value; }
        }

        private TipoUnidad _tipoUnidad;
        public TipoUnidad TipoUnidad
        {
            get { return _tipoUnidad; }
            set { _tipoUnidad = value; }
        }

        private float _precio;

        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        private bool _activo;

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
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

        public Producto()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _descripcion = string.Empty;
            this._laboratorio = null;
            this._posologia = string.Empty;
            this._documento = string.Empty;
            this._activo = true;

            this._tipoUnidad = null;

            this._detalle = new List<ProductoDetalle>();
        }

        public override string ToString()
        {
            if (this.Laboratorio != null)
                return string.Format("{0} ({1})", this.Descripcion, this.Laboratorio.ToString());
            else
                return this.Descripcion;
        }
        public string AllInfo()
        {
            StringBuilder strB = new StringBuilder();

            strB.AppendFormat("{0}- Laboratorio {1} - PVP {2:c}", this.Descripcion, this.Laboratorio.ToString(), this.Precio.ToString());
            strB.AppendLine(); 
            strB.AppendFormat("Posología: {0}", this.Posologia);
            strB.AppendLine();
            if (this.Detalle != null)
            {
                strB.AppendLine("Componentes:");
                foreach (ProductoDetalle productoDetalle in Detalle)
                    strB.AppendLine(productoDetalle.Componente.ToString());
            }
            if (this.Indicaciones != null)
            {
                strB.AppendLine("Indicaciones:");
                foreach (Indicacion indicacion in Indicaciones)
                    strB.AppendLine(indicacion.Descripcion);
            }
            if (this.Detalle != null)
            {
                strB.AppendLine("Notas:");
                foreach (Indicacion indicacion in ContraIndicaciones)
                    strB.AppendLine(indicacion.Descripcion);
            }

            return strB.ToString();
        }
        public string AllInfoRTF()
        {
            string temp;

            //string info = string.Format("{0} - Laboratorio {1} - PVP {2:c}", this.Descripcion, this.Laboratorio.ToString(), this.Precio.ToString());
            string info = string.Format("{0}", this.Descripcion);
            temp = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\b{\\pntext\\f1\\'B7\\tab}" + info + "\\ulnone\\b0\\par\r\n}\r\n\r\n" + "}";

            temp = temp.Substring(0, temp.Length - 10);
            temp += string.Format(" Laboratorio {0} - PVP {1} - {2} {3}",this.Laboratorio.ToString(), this.Precio.ToString("c"), this.Unidades.ToString(), this.TipoUnidad!=null?this.TipoUnidad.Descripcion:"") + "}";

            if (!string.IsNullOrEmpty(this.Posologia))
            {
                temp = temp.Substring(0, temp.Length - 1);
                temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Posología\\ulnone\\b0\\par\r\n}\r\n" + "}";

                temp = temp.Substring(0, temp.Length - 1);
                temp += this.Posologia + "}";
            }

            if (this.Detalle != null)
            {
                temp = temp.Substring(0, temp.Length - 1);
                temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Componentes\\ulnone\\b0\\par\r\n}\r\n" + "}";

                temp = temp.Substring(0, temp.Length - 1);
                StringBuilder strB = new StringBuilder();
                foreach (ProductoDetalle productoDetalle in Detalle)
                    strB.AppendLine(productoDetalle.Componente.ToString() + ". ");

                temp += strB.ToString() + "}";
            }
            if (this.Indicaciones != null)
            {
                temp = temp.Substring(0, temp.Length - 1);
                temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Indicaciones\\ulnone\\b0\\par\r\n}\r\n" + "}";

                temp = temp.Substring(0, temp.Length - 1);
                StringBuilder strB = new StringBuilder();
                foreach (Indicacion indicacion in Indicaciones)
                    strB.AppendLine(indicacion.Descripcion + ". ");

                temp += strB.ToString() + "}";
            }
            if (this.Indicaciones != null)
            {
                temp = temp.Substring(0, temp.Length - 1);
                temp += "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang3082{\\fonttbl{\\f0\\fnil\\fcharset0 Tahoma;}{\\f1\\fnil\\fcharset2 Symbol;}}\r\n\\viewkind4\\uc1\\pard{\\pntext\\f1\\'B7\\tab}{\\*\\pn\\pnlvlcont\\pnf1\\pnindent500{\\pntxtb\\'B7}}\\f0\\fs18\\par\r\n\\ul\\b{\\pntext\\f1\\'B7\\tab}Notas\\ulnone\\b0\\par\r\n}\r\n" + "}";

                temp = temp.Substring(0, temp.Length - 1);
                StringBuilder strB = new StringBuilder();
                foreach (Indicacion indicacion in ContraIndicaciones)
                    strB.AppendLine(indicacion.Descripcion + ". ");

                temp += strB.ToString() + "}";
            }
            return temp;
        }


        private Laboratorio _laboratorio;

        public Laboratorio Laboratorio
        {
            get { return _laboratorio; }
            set { _laboratorio = value; }
        }
        private string _posologia;

        public string Posologia
        {
            get { return _posologia; }
            set { _posologia = value; }
        }
        private string _documento;

        public string Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        List<ProductoDetalle> _detalle;
        public List<ProductoDetalle> Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }

        private List<Indicacion> _indicaciones = new List<Indicacion>();

        public List<Indicacion> Indicaciones
        {
            get { return _indicaciones; }
            set { _indicaciones = value; }
        }

        private List<Indicacion> _contraIndicaciones = new List<Indicacion>();

        public List<Indicacion> ContraIndicaciones
        {
            get { return _contraIndicaciones; }
            set { _contraIndicaciones = value; }
        }
    }
}
