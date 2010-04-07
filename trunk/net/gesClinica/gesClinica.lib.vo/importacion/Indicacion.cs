using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Indicacion:IOldGesClinica<vo.Indicacion>
    {
        public Indicacion()
        {
            _id = string.Empty;
            _descripcion = string.Empty;
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

        public override string ToString()
        {
            return this.Descripcion;
        }




        #region Miembros de IOldGesClinica<Indicacion>

        public gesClinica.lib.vo.Indicacion ToNewGesClinica()
        {
            vo.Indicacion res = new gesClinica.lib.vo.Indicacion();

            //res.ID
            res.Descripcion = this.Descripcion;

            return res;
        }

        #endregion
    }
}
