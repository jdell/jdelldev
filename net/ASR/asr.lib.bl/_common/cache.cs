using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.bl._common
{
    public abstract class cache
    {
        internal static _common.secciones.AdministracionSection ADMINISTRACION = null;
        //internal static _common.secciones.asrConfigSection asrCONFIG = null;
        internal static _common.secciones.MantenimientoSection MANTENIMIENTO = null;

        internal static _common.secciones.CompanyInfoSection COMPANYINFO = null;
        public static string CompanyName
        {
            get
            {
                return COMPANYINFO.CompanyName;
            }
        }
        private static lib.vo.User _user;
        public static lib.vo.User USER
        {
            get { return cache._user; }
        }

        public static Int32 AccountRecordChartsHistory
        {
            get
            {
                return -ADMINISTRACION.AccountRecordChartMonths;
            }
        }
        public static bool IsPresentationMode
        {
            get
            {
                return ADMINISTRACION.PresentationMode;
            }
        }
        public static string UrlASRBridge
        {
            get
            {
                return ADMINISTRACION.UlrASRBridge;
            }
        }
        public static bool IsMasterUser
        {
            get
            {
                return ADMINISTRACION.MasterUser.Contains(USER.Login);
            }
        }
        internal static bool IsSystemUser
        {
            get
            {
                return ADMINISTRACION.SystemUser.ToUpper() == USER.Login.ToUpper();
            }
        }

        public delegate void ProcessingHandler(_events.ProgressEventArgs e);
        public static event ProcessingHandler Processing;

        //public delegate void RefreshAgendaHandler();
        //public static event RefreshAgendaHandler RefreshAgenda;

        public delegate void DataBaseUpdatingHandler(string mensaje, System.ComponentModel.CancelEventArgs e);
        public static event DataBaseUpdatingHandler DataBaseUpdating;

        public delegate void DataBaseUpdatedHandler(string mensaje);
        public static event DataBaseUpdatedHandler DataBaseUpdated;
        
        public static bool Initialize(string loginEmpleado)
        {
            try
            {
                bool res = true;

                if (!System.IO.File.Exists(asr.lib.common.variables.configpath.GetFullPath()))
                    throw new _exceptions.common.ConfigFileNotFoundException();

                int c = 0;
                int t = 5;
                int delay = 0;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Comprobando actualizaciones", c, t));
                CheckUpdates();
                System.Threading.Thread.Sleep(delay);
                c += 1;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Administración", c, t));
                InitializeAdministracion(loginEmpleado.ToUpper());
                System.Threading.Thread.Sleep(delay);
                c += 1;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Company Info", c, t));
                InitializeCompanyInfo();
                System.Threading.Thread.Sleep(delay);
                c += 1;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración asr", c, t));
                //InitializeasrConfig();
                //System.Threading.Thread.Sleep(delay);
                //c += 1;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Operación completada", c, t));
                
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
                                
                int c = 0;
                int t = 2;
                //int delay = 0;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Administración", c, t));
                //InitializeAdministracion(loginEmpleado);
                //System.Threading.Thread.Sleep(delay);
                //c += 1;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración asr", c, t));
                //InitializeasrConfig();
                //System.Threading.Thread.Sleep(delay);
                //c += 1;
                
                //_empleado = null;
                ADMINISTRACION = null;
                //asrCONFIG = null;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Operación completada", c, t));

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region ************ Seccion ADMINISTRACION *************
        internal static void InitializeAdministracion(string loginEmpleado)
        {
            try
            {
                _user = new asr.lib.vo.User(loginEmpleado);
                

                ADMINISTRACION = new asr.lib.bl._common.secciones.AdministracionSection();
                repsol.util.config.sections.section administracionSetting = repsol.util.config.sections.section.getSectionSetting(asr.lib.common.variables.configpath.GetFullPath(),ADMINISTRACION.Name);
                if (administracionSetting != null)
                {
                    try
                    {
                        ADMINISTRACION.SetMasterUsers(administracionSetting["MasterUser"].Value, ";");
                        ADMINISTRACION.SystemUser = administracionSetting["SystemUser"].Value;
                        ADMINISTRACION.PresentationMode = Convert.ToBoolean(administracionSetting["PresentationMode"].Value);
                        ADMINISTRACION.AccountRecordChartMonths = Convert.ToInt32(administracionSetting["AccountRecordChartMonths"].Value);
                        ADMINISTRACION.UlrASRBridge = Convert.ToString(administracionSetting["UlrASRBridge"].Value);
                    }
                    catch
                    {
                        throw new _exceptions.common.IncorrectFormatConfigFileException();
                    }
                    //if ((IsSystemUser) || (IsMasterUser))
                    //{
                    //    empleado.doGetByLogin lnEmpleado = new asr.lib.bl.empleado.doGetByLogin(_empleado);
                    //    lnEmpleado.SystemAction = true;
                    //    lib.vo.Empleado tmpUser = lnEmpleado.execute();
                    //    if (tmpUser != null)
                    //        _empleado = tmpUser;
                    //    else
                    //    {
                    if (IsSystemUser)
                    {
                        _user = new asr.lib.vo.User(ADMINISTRACION.SystemUser);
                        _user.FirstName = "SYSTEM USER";
                    }
                    else
                    {
                        _user = new asr.lib.vo.User(loginEmpleado.ToUpper());
                        _user.FirstName = "MASTER USER";
                    }
                    _user.LastName = loginEmpleado;
                    //    }
                    //}
                    //else
                    //{
                    //    empleado.doGetByLogin lnEmpleado = new asr.lib.bl.empleado.doGetByLogin(_empleado);
                    //    lnEmpleado.SystemAction = true;
                    //    lib.vo.Empleado tmpUser = lnEmpleado.execute();
                    //    if (tmpUser != null)
                    //    {
                    //        if (!tmpUser.Activo) throw new _exceptions.empleado.EmployeeNotEnabledException(loginEmpleado);
                    //    }
                    //    else
                    //        throw new _exceptions.empleado.EmployeeNotFoundException(loginEmpleado);
                    //    _empleado = tmpUser;
                    //}
                }
                else
                    throw new _exceptions.common.InitializeCacheException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ************ Seccion asrCONFIG *************
        //internal static void InitializeasrConfig()
        //{
        //    try
        //    {
        //        asrCONFIG = new asr.lib.bl._common.secciones.asrConfigSection();
        //        repsol.util.config.sections.section asrConfigSetting = repsol.util.config.sections.section.getSectionSetting(asr.lib.common.variables.configpath.GetFullPath(), asrCONFIG.Name);
        //        if (asrConfigSetting != null)
        //        {
        //            try
        //            {
        //                asrCONFIG.HoraEntrada = Convert.ToInt32(asrConfigSetting["HoraEntrada"].Value);
        //                asrCONFIG.HoraSalida = Convert.ToInt32(asrConfigSetting["HoraSalida"].Value);
        //                asrCONFIG.MinutoEntrada = Convert.ToInt32(asrConfigSetting["MinutoEntrada"].Value);
        //                asrCONFIG.MinutoSalida = Convert.ToInt32(asrConfigSetting["MinutoSalida"].Value);
        //                asrCONFIG.SerieFacturacion = Convert.ToString(asrConfigSetting["SerieFacturacion"].Value);
        //                asrCONFIG.IVA = Convert.ToInt32(asrConfigSetting["IVA"].Value);
        //                asrCONFIG.TimeOutAgenda = Convert.ToInt32(asrConfigSetting["TimeOutAgenda"].Value);
        //                asrCONFIG.SaltoAgenda = Convert.ToInt32(asrConfigSetting["SaltoAgenda"].Value);
        //            }
        //            catch
        //            {
        //                throw new _exceptions.common.IncorrectFormatConfigFileException();
        //            }
        //        }
        //        else
        //            throw new _exceptions.common.InitializeCacheException();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion


        #region ************ Seccion COMPANYINFO *************
        internal static void InitializeCompanyInfo()
        {
            try
            {
                COMPANYINFO = new asr.lib.bl._common.secciones.CompanyInfoSection();
                repsol.util.config.sections.section companyInfoSetting = repsol.util.config.sections.section.getSectionSetting(asr.lib.common.variables.configpath.GetFullPath(), COMPANYINFO.Name);
                if (companyInfoSetting != null)
                {
                    try
                    {
                        COMPANYINFO.CompanyAddress = companyInfoSetting["CompanyAddress"].Value;
                        COMPANYINFO.CompanyCity = companyInfoSetting["CompanyCity"].Value;
                        COMPANYINFO.CompanyFax = companyInfoSetting["CompanyFax"].Value;
                        COMPANYINFO.CompanyName = companyInfoSetting["CompanyName"].Value;
                        COMPANYINFO.CompanyPhone1 = companyInfoSetting["CompanyPhone1"].Value;
                        COMPANYINFO.CompanyPhone2 = companyInfoSetting["CompanyPhone2"].Value;
                        COMPANYINFO.CompanyState = companyInfoSetting["CompanyState"].Value;
                        COMPANYINFO.CompanyZipCode = companyInfoSetting["CompanyZipCode"].Value;

                        COMPANYINFO.CompanyTaxPercentage= Convert.ToSingle(companyInfoSetting["CompanyTaxPercentage"].Value);
                    }
                    catch
                    {
                        throw new _exceptions.common.IncorrectFormatConfigFileException();
                    }
                }
                else
                    throw new _exceptions.common.InitializeCacheException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ************ Seccion CHECKUPDATES *************
        internal static void CheckUpdates()
        {
            try
            {
#if LTS
                repsol.util.versionBD versionBD = new repsol.util.versionBD(lib.common.variables.configpath.GetFullPath(), dao._common.conexion.tCONEXION.lts.ToString(), "_sql");
#else
                repsol.util.versionBD versionBD = new repsol.util.versionBD(lib.common.variables.configpath.GetFullPath(), dao._common.conexion.tCONEXION.asr.ToString(), "_sql");
#endif
                if (versionBD.Actualizable)
                {
                    if (DataBaseUpdating != null)
                    {
                        System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();
                        e.Cancel = false;
                        string msg = "Hay actualizaciones disponibles en la Base de Datos. ¿Desea actualizar ahora?";
                        DataBaseUpdating(msg, e);
                        if (!e.Cancel)
                        {
                            repsol.util.bd.vo.upgrade.upgradeVO upgradeVO = versionBD.Upgrade();
                            if (DataBaseUpdated != null) DataBaseUpdated(upgradeVO.Descripcion);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        /*
        Public Shared Function CerrarSAII(ByVal appFullPath As String) As Boolean
            Try
                Dim res As Boolean = True

                '<20080116> Añado la ruta completa a la aplicación que se está ejecutando en este
                'momento para incluir en las notificaciones
                RUTA_APLICACION = appFullPath
                '</20080116> *******************************************************************

                Dim c As Integer = 0
                Dim t As Integer = 3
                Dim delay As Integer = 0

                RaiseEvent Processing(New _events.ProgressEventArgs("Notificando incidentes modificados", c, t))
                '*********** Notificamos todos los incidentes que tenemos en memoria ***********
                If (Not MANTENIMIENTO Is Nothing) AndAlso (Not MANTENIMIENTO.DebugMode) Then
                    If (Not INCIDENTES Is Nothing) Then
                        Dim doNotificar As incidente.doNotificarIncidente
                        For Each p As Par In INCIDENTES.Values
                            If (CType(p.NewValue, saiiVO.incidente.incidenteVO).HasDifferences(p.OldValue)) Then
                                Dim incidente As saiiVO.incidente.incidenteVO = p.NewValue
                                'doNotificar = New incidente.doNotificarIncidente(incidente, incidente.Substract(p.OldValue))
                                doNotificar = New incidente.doNotificarIncidente(incidente, p.OldValue)
                                doNotificar.SystemAction = True
                                doNotificar.execute()
                            End If
                        Next
                    End If
                End If
                System.Threading.Thread.Sleep(delay)
                c += 1

                'RaiseEvent Processing(New _events.ProgressEventArgs("Notificando medidas modificadas", c, t))
                ''*********** Notificamos todos los incidentes que tenemos en memoria ***********
                'If (Not MANTENIMIENTO_DEBUG) Then
                '    If (Not MEDIDAS Is Nothing) Then
                '        Dim doNotificar As medida.doNotificarMedidaAdoptada
                '        For Each p As Par In MEDIDAS.Values
                '            If (CType(p.NewValue, saiiVO.medidaadoptada.medidaadoptadaVO).HasDifferences(p.OldValue)) Then
                '                Dim medida As saiiVO.medidaadoptada.medidaadoptadaVO = p.NewValue

                '                Dim doSelIncidente As New incidente.doSeleccionarIncidente(medida.Incidente)
                '                medida.Incidente = doSelIncidente.execute

                '                Dim doSelComision As New comision.doSeleccionarComisionPorIncidente(medida.Incidente)
                '                medida.Incidente.Comision = doSelComision.execute

                '                Dim doSelIntegrantes As New integrante.doSeleccionarIntegrantesPorComision(medida.Incidente.Comision)
                '                medida.Incidente.Comision.Integrantes = doSelIntegrantes.execute

                '                If (Not medida.Incidente.IntegrantesComision Is Nothing) Then
                '                    For Each integrante As saiiVO.integrante.integranteVO In medida.Incidente.IntegrantesComision
                '                        Dim doSelMedidas As New medidaadoptada.doSeleccionarMedidasAdoptadasPorIntegrante(integrante)
                '                        integrante.MedidasAdoptadas = doSelMedidas.execute
                '                    Next
                '                End If

                '                doNotificar = New saiiBL.medida.doNotificarMedidaAdoptada(medida, p.OldValue)
                '                doNotificar.execute()
                '            End If
                '        Next
                '    End If
                'End If
                'System.Threading.Thread.Sleep(delay)
                'c += 1

                RaiseEvent Processing(New _events.ProgressEventArgs("Desconectando", c, t))
                registrarDesconexion()
                System.Threading.Thread.Sleep(delay)
                c += 1

                RaiseEvent Processing(New _events.ProgressEventArgs("Borrando caché", c, t))
                USUARIO = Nothing
                If (Not INCIDENTES Is Nothing) Then INCIDENTES.Clear()
                INCIDENTES = Nothing
                MANTENIMIENTO = Nothing
                System.Threading.Thread.Sleep(delay)
                c += 1

                RaiseEvent Processing(New _events.ProgressEventArgs("Operación completada", c, t))

                Return res
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        */

        /*
        #region ************ Seccion MANTENIMIENTO *************
        private static void InitializeMaintenance()
        {
            try
            {
                MANTENIMIENTO = new asr.lib.bl._common.secciones.MantenimientoSection();
                //asr.lib.common.
                    //TODO: aquí!
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        #endregion

#Region 
        Private Shared Sub InicializaMantenimiento()
            Try
                MANTENIMIENTO = New _common.secciones.MantenimientoSection
                Dim mantenimientoSetting As saiiUTIL.funciones.section.sectionSetting = saiiUTIL.funciones.section.sectionSetting.getSectionSetting(MANTENIMIENTO.Name)
                If (Not mantenimientoSetting Is Nothing) Then
                    Try
                        MANTENIMIENTO.DebugMode = Convert.ToBoolean(mantenimientoSetting("Debug").Value)
                        MANTENIMIENTO.EnMantenimiento = Convert.ToBoolean(mantenimientoSetting("enMantenimiento").Value)
                        MANTENIMIENTO.Mensaje = Convert.ToString(mantenimientoSetting("mensaje").Value)
                        MANTENIMIENTO.Detalle = Convert.ToString(mantenimientoSetting("detalle").Value)
                        MANTENIMIENTO.TiempoEspera = Convert.ToInt32(mantenimientoSetting("tiempoEspera").Value)
                    Catch ex As Exception
                        Throw New _exceptions._common.IncorrectFormatConfigFileException
                    End Try

                Else
                    Throw New _exceptions._common.InitializeCacheException
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#End Region
            */
    }
}
