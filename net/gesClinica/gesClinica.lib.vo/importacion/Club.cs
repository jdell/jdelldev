using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Club : IOldGesClinica<vo.Tarifa>
    {
        public Club()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
            _descuento = 0;
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
        private Int32 _descuento;

        public Int32 Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        #region Miembros de IOldGesClinica<Tarifa>

        public Tarifa ToNewGesClinica()
        {
            vo.Tarifa res = new gesClinica.lib.vo.Tarifa();

            //res.ID = this.ID;
            res.Descripcion = this.Descripcion;
            res.Descuento = this.Descuento;

            return res;
        }

        #endregion
    }
}
