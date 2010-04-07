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
                return String.Format("No se encuentra el fichero de configuraci�n en la ruta especificada [{0}]. ", ambis1.model.common.variables.configpath.GetFullPath());
            }
        }
        public static string INCORRECT_FORMAT_CONFIG_FILE
        {
            get
            {
                return String.Format("Formato incorrecto en el fichero de configuraci�n [{0}]. No se ajusta al esquema XSD. ", ambis1.model.common.variables.configpath.GetFullPath());
            }
        }
        public static string NOT_FOUND_USER(string login)
        {
            return String.Format("El usuario {0} no est� en la base de datos de la aplicaci�n.", login);
        }
        public static string NOT_ENABLED_USER(string login)
        {
            return String.Format("El usuario {0} est� deshabilitado y no tiene permisos en la aplicaci�n.", login);
        }


        public static readonly string NOTIFY_ADMINISTRATOR = "Contact with the administrator.";

        public static readonly string NOT_LOADED_CACHE = "Error en la inicializaci�n del programa.";
        public static readonly string NO_ACCESS_ALLOWED = "No tiene permisos para realizar esta acci�n {ni consultar ni editar estos datos}.";
    }
}
