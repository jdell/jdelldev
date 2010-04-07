using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public class TipoCaja:IOldGesClinica<vo.tTIPOOPERACION>
    {
        public TipoCaja()
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

        #region Miembros de IOldGesClinica<tTIPOOPERACION>

        public tTIPOOPERACION ToNewGesClinica()
        {
            vo.tTIPOOPERACION res = tTIPOOPERACION.OPERACION_PACIENTE;

            foreach (KeyValuePair<Enum,string> tipo in common.funciones.EnumHelper.ToList(typeof(vo.tTIPOOPERACION)))
            {
                if (tipo.Value == this.Descripcion)
                {
                    res = (vo.tTIPOOPERACION)tipo.Key;
                    break;
                }
            }

            return res;
        }

        #endregion
    }
}
