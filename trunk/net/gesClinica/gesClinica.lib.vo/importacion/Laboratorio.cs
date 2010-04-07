using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class Laboratorio: IOldGesClinica<vo.Laboratorio>
    {
        public Laboratorio()
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

        #region Miembros de IOldGesClinica<Laboratorio>

        public gesClinica.lib.vo.Laboratorio ToNewGesClinica()
        {
            vo.Laboratorio res = new gesClinica.lib.vo.Laboratorio();

            //res.ID = this.ID;
            res.Nombre = this.Descripcion;

            return res;
        }

        #endregion
    }
}
