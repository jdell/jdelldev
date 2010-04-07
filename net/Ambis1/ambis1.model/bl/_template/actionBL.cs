using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._template
{
    public abstract class actionBL
    {
        public delegate void ProcessingHandler(_events.ProgressEventArgs e);
        public event ProcessingHandler Processing;

        protected void OnProcessing(_events.ProgressEventArgs e)
        {
            if (Processing != null) 
                Processing(e);
        }

        bool _systemAction = false;

        internal bool SystemAction
        {
            get
            {
                return _systemAction;
            }
            set
            {
                _systemAction = value;
            }
        }

        public object execute()
        {

            if ((!SystemAction) && (_common.cache.MAINTENANCE != null) && (_common.cache.MAINTENANCE.EnMantenimiento))
                throw new _exceptions.common.OutOfServiceException("Aplicación fuera de servicio en estos momentos. Inténtelo más tarde.");

            if (!IsAllowed)
                throw new _exceptions.common.AccessNotAllowedException();

            return accion();
        }
        protected abstract object accion();


        private bool IsAllowed
        {
            get
            {
                bool res = false;

                res = true;
                //if (_common.cache.EMPLEADO != null)
                //{
                //    if (!res) res = ((Permiso & tPERMISO.GERENTE) != 0) && _common.cache.EMPLEADO.Gerente;
                //    if (!res) res = ((Permiso & tPERMISO.ADMINISTRATIVO) != 0) && _common.cache.EMPLEADO.Administrativo;
                //    if (!res) res = ((Permiso & tPERMISO.TERAPEUTA) != 0) && _common.cache.EMPLEADO.Terapeuta;
                //    if (!res) res = ((Permiso & tPERMISO.MASTERUSER) != 0) && ((_common.cache.IsMasterUser) || (_common.cache.IsSystemUser));
                //    if (!res) res = ((Permiso & tPERMISO.NINGUNO) != 0) && false;
                //    if (!res) res = SystemAction;
                //}
                //else
                //    res = SystemAction;

                return res;
            }
        }

        private tPERMISO _permiso = tPERMISO.NINGUNO;
        protected tPERMISO Permiso
        {
            get { return _permiso; }
            set { _permiso = value; }
        }

        public enum tPERMISO
        {
            MASTERUSER = 1,
            ADMINISTRATIVO = 2,
            TERAPEUTA = 4,
            GERENTE = 8,
            NINGUNO = 16
        }
    }
}
