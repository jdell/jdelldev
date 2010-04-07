using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Receta : IComparable<Receta>
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private Cita _cita;

        public Cita Cita
        {
            get { return _cita; }
            set { _cita = value; }
        }
        private string _observaciones;

        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        public Receta()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _observaciones = string.Empty;
            _cita = null;

            _detalle = new List<RecetaDetalle>();
        }
        public Receta(Cita cita)
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _observaciones = string.Empty;
            _cita = cita;

            _detalle = new List<RecetaDetalle>();
        }

        List<RecetaDetalle> _detalle;
        public List<RecetaDetalle> Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }

        public override string ToString()
        {
            return this.Observaciones;
        }

        public string Prescrito
        {
            get
            {
                StringBuilder strB = new StringBuilder();

                strB.AppendLine("\\b{\\pntext\\f1\\'B7\\tab}  \\b0 " + this.Observaciones + " \\par\\par");

                //strB.AppendLine(string.Format("{0}{1}",this.Observaciones, Environment.NewLine));
                if ((Detalle != null) && (Detalle.Count>0))
                {
                    foreach (RecetaDetalle detalle in this.Detalle)
                        //strB.AppendLine(string.Format("{0}: {1}{2}", detalle.Producto.ToString(), detalle.Posologia, Environment.NewLine));
                        strB.AppendLine("\\b{\\pntext\\f1\\'B7\\tab} - " + detalle.Producto.ToString() + " \\b0.- " + detalle.Posologia + "\\par\\par");

                    return strB.ToString();
                }
                else
                    return string.Empty;
            }
        }


        #region Miembros de IComparable<Receta>

        public int CompareTo(Receta other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
