using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Producto: IOldGesClinica<vo.Producto>
    {

        public Producto()
        {
            _descripcion = string.Empty;
            _documento = string.Empty;
            _id = string.Empty;
            _laboratorio = null;
            _posologia = string.Empty;
            _retirado = false;
            _pvp = 0;
            _unidades = 0;
        }

        private int _unidades;

        public int Unidades
        {
            get { return _unidades; }
            set { _unidades = value; }
        }

        private float _pvp;

        public float PVP
        {
            get { return _pvp; }
            set { _pvp = value; }
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
        private bool _retirado;

        public bool Retirado
        {
            get { return _retirado; }
            set { _retirado = value; }
        }

        private List<Indicacion> _indicaciones;

        public List<Indicacion> Indicaciones
        {
            get { return _indicaciones; }
            set { _indicaciones = value; }
        }
        private List<Indicacion> _contraIndicaciones;

        public List<Indicacion> ContraIndicaciones
        {
            get { return _contraIndicaciones; }
            set { _contraIndicaciones = value; }
        }
        private List<RelProCom> _relProCom;

        public List<RelProCom> RelProCom
        {
            get { return _relProCom; }
            set { _relProCom = value; }
        }

        #region Miembros de IOldGesClinica<Producto>

        public gesClinica.lib.vo.Producto ToNewGesClinica()
        {
            vo.Producto res = new gesClinica.lib.vo.Producto();

            res.Activo = !this.Retirado;
            res.Descripcion = this.Descripcion;
            //res.Detalle
            res.Documento = this.Documento;
            //res.ID
            res.Precio = this.PVP;
            if (this.Laboratorio!=null) res.Laboratorio = this.Laboratorio.ToNewGesClinica();
            res.Posologia = this.Posologia;

            res.Unidades = this.Unidades;

            return res;
        }

        #endregion
    }
}
