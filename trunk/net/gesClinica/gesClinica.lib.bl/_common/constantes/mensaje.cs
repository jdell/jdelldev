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
                return String.Format("No se encuentra el fichero de configuraci�n en la ruta especificada [{0}]. ", gesClinica.lib.common.variables.configpath.GetFullPath());
            }
        }
        public static string INCORRECT_FORMAT_CONFIG_FILE
        {
            get
            {
                return String.Format("Formato incorrecto en el fichero de configuraci�n [{0}]. No se ajusta al esquema XSD. ", gesClinica.lib.common.variables.configpath.GetFullPath());
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


        public static readonly string NOTIFY_ADMINISTRATOR = "Contacte con su administrador.";

        public static readonly string NOT_LOADED_CACHE = "Error en la inicializaci�n del programa.";
        public static readonly string NO_ACCESS_ALLOWED = "No tiene permisos para realizar esta acci�n {ni consultar ni editar estos datos}.";
    }
    /*
    Namespace _common.constantes
    Public MustInherit Class mensaje

        'Public Shared ReadOnly NO_RECORD_SELECTED As String = "No hay ning�n registro seleccionado."
        Public Shared ReadOnly NO_ACCESS_ALLOWED As String = "No tiene permisos para realizar esta acci�n."
        Public Shared ReadOnly NOTIFY_ADMINISTRATOR As String = "Contacte con su administrador."
        Public Shared ReadOnly OPERATION_CANCELED As String = "Operaci�n cancelada."
        'Public Shared ReadOnly OPTION_DISABLED As String = "Opci�n deshabilitada."

        'Public Shared ReadOnly OUT_OF_SERVICE As String = "Aplicaci�n fuera de servicio."

        Public Shared Function NOT_FOUND_CONFIGFILE() As String
            Return String.Format("No se encuentra el fichero de configuraci�n en la ruta especificada [{0}]. ", saiiUTIL.variables.configpath.GetFullPath)
        End Function
        Public Shared Function NOT_FOUND_USER() As String
            Return String.Format("El usuario {0} no est� en la base de datos de la aplicaci�n.", cache.USUARIO.Codigo)
        End Function
        Public Shared Function NOT_ENABLED_USER() As String
            Return String.Format("El usuario {0} est� deshabilitado y no tiene permisos en la aplicaci�n.", cache.USUARIO.Codigo)
        End Function



        'Public Shared ReadOnly AVISO_PRUEBAS_ASUNTO As String = "-CORREO DE PRUEBAS NUEVO SAII- "
        'Public Shared ReadOnly AVISO_PRUEBAS_DESCRIPCION As String = "ESTO ES UNA PRUEBA DE LA NUEVA VERSI�N DEL SAII. NO CONTESTE A ESTE MAIL." & vbCrLf & vbCrLf & vbCrLf
        Public Shared ReadOnly AVISO_PRUEBAS_ASUNTO As String = ""
        Public Shared ReadOnly AVISO_PRUEBAS_DESCRIPCION As String = ""

    End Class
End Namespace


*/
}
