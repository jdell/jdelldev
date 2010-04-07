using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._common.constants
{
    public abstract class mensaje
    {
        public static string CONFIGFILE_NOT_FOUND
        {
            get
            {
                return String.Format("No se encuentra el fichero de configuración en la ruta especificada [{0}]. ", ambis1.model.common.variables.configpath.GetFullPath());
            }
        }
        public static string INCORRECT_FORMAT_CONFIG_FILE
        {
            get
            {
                return String.Format("Formato incorrecto en el fichero de configuración [{0}]. No se ajusta al esquema XSD. ", ambis1.model.common.variables.configpath.GetFullPath());
            }
        }
        public static string NOT_FOUND_USER(string login)
        {
            return String.Format("El usuario {0} no está en la base de datos de la aplicación.", login);
        }
        public static string NOT_ENABLED_USER(string login)
        {
            return String.Format("El usuario {0} está deshabilitado y no tiene permisos en la aplicación.", login);
        }


        public static readonly string NOTIFY_ADMINISTRATOR = "Contact with the administrator.";

        public static readonly string NOT_LOADED_CACHE = "Error en la inicialización del programa.";
        public static readonly string NO_ACCESS_ALLOWED = "No tiene permisos para realizar esta acción {ni consultar ni editar estos datos}.";
    }
}
