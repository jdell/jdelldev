using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Evento
    {
        private Sala _sala;

        public Sala Sala
        {
            get { return _sala; }
            set { _sala = value; }
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
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private int _duracion;

        public int Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }
        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }
        private bool _publico;

        public bool Publico
        {
            get { return _publico; }
            set { _publico = value; }
        }

        public Evento()
        {
            _id = common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _fecha = DateTime.Now;
            _duracion = 10;
            _empleado = null;
            _publico = false;
            _sala = null;
            _estadoEvento = null;
        }

        private EstadoEvento _estadoEvento;

        public EstadoEvento EstadoEvento
        {
            get { return _estadoEvento; }
            set { _estadoEvento = value; }
        }

        public override string ToString()
        {
            StringBuilder strB = new StringBuilder();
            //if (this.Empleado != null)
            //{
            //    strB.Append(string.Format("{0}", this.Empleado.ToString()));
            //    strB.Append(" - ");
            //}
            strB.Append(string.Format("{0}", this.Descripcion));

            return strB.ToString();
        }

    }
}
