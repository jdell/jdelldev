using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Receta:IOldGesClinica<vo.RecetaDetalle>
    {
        public Receta()
        {
            _id = string.Empty;
            _numeroEnvases = 0;
            _posologia = string.Empty;
            _producto = null;
            _visita = null;
        }

        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Visita _visita;

        public Visita Visita
        {
            get { return _visita; }
            set { _visita = value; }
        }
        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
        private int _numeroEnvases;

        public int NumeroEnvases
        {
            get { return _numeroEnvases; }
            set { _numeroEnvases = value; }
        }
        private string _posologia;

        public string Posologia
        {
            get { return _posologia; }
            set { _posologia = value; }
        }

        #region Miembros de IOldGesClinica<Receta>

        public gesClinica.lib.vo.RecetaDetalle ToNewGesClinica()
        {

            vo.RecetaDetalle res = new RecetaDetalle();
            res.Cantidad = this.NumeroEnvases;
            res.Posologia = this.Posologia;
            res.Producto = this.Producto.ToNewGesClinica();
            
            return res;
        }

        #endregion
    }
}
