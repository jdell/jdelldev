using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Actividad:IOldGesClinica<vo.Terapia>
    {
        public Actividad()
        {
            this._activa = true;
            this._descripcion = string.Empty;
            this._id = string.Empty;
            this._importe = 0;
            this._subCuenta = null;
            this._terapeuta = null;
            this._tiempo = DateTime.MinValue;
        }

        private string _id;

        public string ID
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
        private DateTime _tiempo;

        public DateTime Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }
        private float _importe;

        public float Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
        private Terapeuta _terapeuta;

        public Terapeuta Terapeuta
        {
            get { return _terapeuta; }
            set { _terapeuta = value; }
        }
        private SubCuenta _subCuenta;

        public SubCuenta SubCuenta
        {
            get { return _subCuenta; }
            set { _subCuenta = value; }
        }
        private bool _activa;

        public bool Activa
        {
            get { return _activa; }
            set { _activa = value; }
        }
              
        public int getDuracion(DateTime time)
        {
            return Convert.ToInt32((time.Hour*60) + time.Minute);
        }

        #region Miembros de IOldGesClinica<Terapia>

        public Terapia ToNewGesClinica()
        {
            vo.Terapia res = new Terapia();

            res.Activo = this.Activa;
            res.Descripcion = this.Descripcion;
            res.Duracion = Convert.ToInt32(this.getDuracion(this.Tiempo));
            //res.ID
            res.Precio = this.Importe;
            if (this.SubCuenta != null)
                res.SubCuenta = this.SubCuenta.ToNewGesClinica();

            return res;
        }

        #endregion
    }
}