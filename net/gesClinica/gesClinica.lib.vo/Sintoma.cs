using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Sintoma : IComparable<Sintoma>
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private TipoSintoma _tipoSintoma;

        public TipoSintoma TipoSintoma
        {
            get { return _tipoSintoma; }
            set { _tipoSintoma = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Sintoma()
        {
            _id = common.constantes.vacio.ID;
            _tipoSintoma = null;
            _descripcion = string.Empty;
        }

        public override string ToString()
        {
            return Descripcion;
        }

        #region Miembros de IComparable<Sintoma>

        public int CompareTo(Sintoma other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
