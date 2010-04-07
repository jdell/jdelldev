using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class TipoDocumento: IOldGesClinica<vo.TipoDocumento>
    {
        public TipoDocumento()
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

        #region Miembros de IOldGesClinica<TipoDocumento>

        public gesClinica.lib.vo.TipoDocumento ToNewGesClinica()
        {
            vo.TipoDocumento res = new gesClinica.lib.vo.TipoDocumento();

            //res.ID
            res.Descripcion = this.Descripcion;

            return res;
        }

        #endregion
    }
}
