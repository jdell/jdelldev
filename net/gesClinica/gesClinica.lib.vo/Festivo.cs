using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Festivo : IComparable<Festivo>
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private TipoFestivo _tipoFestivo;

        public TipoFestivo TipoFestivo
        {
            get { return _tipoFestivo; }
            set { _tipoFestivo = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Festivo()
        {
            _id = common.constantes.vacio.ID;
            _tipoFestivo = null;
            _fecha = DateTime.Now;
        }

        #region Miembros de IComparable<Festivo>

        public int CompareTo(Festivo other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
