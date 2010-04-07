using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Componente: IOldGesClinica<vo.Componente>
    {
        public Componente()
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

        #region Miembros de IOldGesClinica<Componente>

        public gesClinica.lib.vo.Componente ToNewGesClinica()
        {
            vo.Componente res = new gesClinica.lib.vo.Componente();

            //res.ID = this.ID;
            res.Descripcion = this.Descripcion;

            return res;
        }

        #endregion
    }
}
