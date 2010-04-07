using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._common.constantes
{
    public abstract class mensaje
    {
        public static string CONFIGFILE_NOT_FOUND
        {
            get
            {
                return String.Format("No se encuentra el fichero de configuración en la ruta especificada [{0}]. ", asr.lib.common.variables.configpath.GetFullPath());
            }
        }
        public static string INCORRECT_FORMAT_CONFIG_FILE
        {
            get
            {
                return String.Format("Formato incorrecto en el fichero de configuración [{0}]. No se ajusta al esquema XSD. ", asr.lib.common.variables.configpath.GetFullPath());
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
        public static readonly string NO_ACCESS_ALLOWED = "You are not allowed to execute this action.";
    }
}
