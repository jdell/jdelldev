using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc._common
{
    public abstract class cache
    {
        //private static _common.secciones.ImportacionSection IMPORTACION = null;
        //private static _common.secciones.FontAgendaSection FONTAGENDA = null;

        //internal static System.Drawing.Font FontAgenda
        //{
        //    get
        //    {
        //        System.Drawing.Font res = new System.Drawing.Font(FONTAGENDA.NameFontAgenda, FONTAGENDA.SizeFontAgenda, (System.Drawing.FontStyle)System.Enum.Parse(typeof(System.Drawing.FontStyle), FONTAGENDA.StyleFontAgenda));
        //        return res;
        //    }
        //}

        //internal static bool IsImportEnabled
        //{
        //    get
        //    {
        //        return IMPORTACION.ImportOldData;
        //    }
        //}
        internal static bool IsOwnerPrint
        {
            get
            {
                //TODO: OwnerPrint. False
                //return IMPORTACION.OwnerPrint;
                return false;
            }
        }
        
        public static bool Initialize()
        {
            try
            {
                bool res = true;

                ////if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Importación", c, t));
                //InitializeImportacion();
                
                ////if (Processing != null) Processing(new _events.ProgressEventArgs("Operación completada", c, t));
                //InitializeFontAgenda();

                return res;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        
        public static bool Dispose()
        {
            try
            {
                bool res = true;

                //if (!System.IO.File.Exists(asr.lib.common.variables.configpath.GetFullPath()))
                //    throw new _exceptions.common.ConfigFileNotFoundException();
                                
                //int c = 0;
                //int t = 2;
                //int delay = 0;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Administración", c, t));
                //InitializeAdministracion(loginEmpleado);
                //System.Threading.Thread.Sleep(delay);
                //c += 1;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración asr", c, t));
                //InitializeasrConfig();
                //System.Threading.Thread.Sleep(delay);
                //c += 1;
                
                //IMPORTACION = null;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Operación completada", c, t));

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region ************ Seccion IMPORTACION *************
        //internal static void InitializeImportacion()
        //{
        //    try
        //    {
        //        IMPORTACION = new asr.app.pc._common.secciones.ImportacionSection();
        //        repsol.util.config.sections.section importacionSetting = repsol.util.config.sections.section.getSectionSetting(asr.lib.common.variables.configpath.GetFullPath(), IMPORTACION.Name);
        //        if (importacionSetting != null)
        //        {
        //            try
        //            {
        //                IMPORTACION.ImportOldData = Convert.ToBoolean(importacionSetting["importOldData"].Value);
        //                IMPORTACION.OwnerPrint = Convert.ToBoolean(importacionSetting["ownerPrint"].Value);
        //            }
        //            catch
        //            {
        //                throw new lib.bl._exceptions.common.IncorrectFormatConfigFileException();
        //            }
        //        }
        //        else
        //            throw new lib.bl._exceptions.common.InitializeCacheException();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion


        #region ************ Seccion FONTAGENDA *************
        //internal static void InitializeFontAgenda()
        //{
        //    try
        //    {
        //        FONTAGENDA = new asr.app.pc._common.secciones.FontAgendaSection();
        //        repsol.util.config.sections.section fontAgendaSetting = repsol.util.config.sections.section.getSectionSetting(asr.lib.common.variables.configpath.GetFullPath(), FONTAGENDA.Name);
        //        if (fontAgendaSetting != null)
        //        {
        //            try
        //            {
        //                FONTAGENDA.NameFontAgenda = Convert.ToString(fontAgendaSetting["nameFontAgenda"].Value);
        //                FONTAGENDA.SizeFontAgenda = Convert.ToSingle(fontAgendaSetting["sizeFontAgenda"].Value);
        //                FONTAGENDA.StyleFontAgenda = Convert.ToString(fontAgendaSetting["styleFontAgenda"].Value);
        //            }
        //            catch
        //            {
        //                throw new lib.bl._exceptions.common.IncorrectFormatConfigFileException();
        //            }
        //        }
        //        else
        //            throw new lib.bl._exceptions.common.InitializeCacheException();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
      
    }
}
