using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo
{
    [Serializable()]
    public class Terapia
    {
        private SubCuenta _subCuenta;

        public SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
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

        public Terapia()
        {
            _id = gesClinica.lib.common.constantes.vacio.ID;
            _descripcion = string.Empty;
            _duracion = 15;
            _precio = 0;
            _activo = true;
            _tipoTerapia = null;
        }

        private Int32 _duracion;
        public Int32 Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }

        private float _precio;
        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private TipoTerapia _tipoTerapia;

        public TipoTerapia TipoTerapia
        {
            get { return _tipoTerapia; }
            set { _tipoTerapia = value; }
        }
        
        public override string ToString()
        {
            return this.Descripcion;
        }


        private Terapia _terapiaDependiente = null;

        public Terapia TerapiaDependiente
        {
            get { return _terapiaDependiente; }
            set { _terapiaDependiente = value; }
        }

    }
}
