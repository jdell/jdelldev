using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common.constantes
{
    public abstract class mensaje
    {
        public static string CONFIGFILE_NOT_FOUND
        {
            get
            {
                return String.Format("No se encuentra el fichero de configuración en la ruta especificada [{0}]. ", gesClinica.lib.common.variables.configpath.GetFullPath());
            }
        }
        public static string INCORRECT_FORMAT_CONFIG_FILE
        {
            get
            {
                return String.Format("Formato incorrecto en el fichero de configuración [{0}]. No se ajusta al esquema XSD. ", gesClinica.lib.common.variables.configpath.GetFullPath());
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


        public static readonly string NOTIFY_ADMINISTRATOR = "Contacte con su administrador.";

        public static readonly string NOT_LOADED_CACHE = "Error en la inicialización del programa.";
        public static readonly string NO_ACCESS_ALLOWED = "No tiene permisos para realizar esta acción {ni consultar ni editar estos datos}.";
    }
    /*
    Namespace _common.constantes
    Public MustInherit Class mensaje

        'Public Shared ReadOnly NO_RECORD_SELECTED As String = "No hay ningún registro seleccionado."
        Public Shared ReadOnly NO_ACCESS_ALLOWED As String = "No tiene permisos para realizar esta acción."
        Public Shared ReadOnly NOTIFY_ADMINISTRATOR As String = "Contacte con su administrador."
        Public Shared ReadOnly OPERATION_CANCELED As String = "Operación cancelada."
        'Public Shared ReadOnly OPTION_DISABLED As String = "Opción deshabilitada."

        'Public Shared ReadOnly OUT_OF_SERVICE As String = "Aplicación fuera de servicio."

        Public Shared Function NOT_FOUND_CONFIGFILE() As String
            Return String.Format("No se encuentra el fichero de configuración en la ruta especificada [{0}]. ", saiiUTIL.variables.configpath.GetFullPath)
        End Function
        Public Shared Function NOT_FOUND_USER() As String
            Return String.Format("El usuario {0} no está en la base de datos de la aplicación.", cache.USUARIO.Codigo)
        End Function
        Public Shared Function NOT_ENABLED_USER() As String
            Return String.Format("El usuario {0} está deshabilitado y no tiene permisos en la aplicación.", cache.USUARIO.Codigo)
        End Function



        'Public Shared ReadOnly AVISO_PRUEBAS_ASUNTO As String = "-CORREO DE PRUEBAS NUEVO SAII- "
        'Public Shared ReadOnly AVISO_PRUEBAS_DESCRIPCION As String = "ESTO ES UNA PRUEBA DE LA NUEVA VERSIÓN DEL SAII. NO CONTESTE A ESTE MAIL." & vbCrLf & vbCrLf & vbCrLf
        Public Shared ReadOnly AVISO_PRUEBAS_ASUNTO As String = ""
        Public Shared ReadOnly AVISO_PRUEBAS_DESCRIPCION As String = ""

    End Class
End Namespace


*/
}
