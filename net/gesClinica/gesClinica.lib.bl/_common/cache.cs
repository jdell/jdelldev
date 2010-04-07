using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.bl._common
{
    public abstract class cache
    {
      
        internal static _common.secciones.AdministracionSection ADMINISTRACION = null;
        internal static _common.secciones.GesClinicaConfigSection GESCLINICACONFIG = null;
        internal static _common.secciones.MantenimientoSection MANTENIMIENTO = null;

        internal static _common.secciones.SubCuentasSection SUBCUENTAS = null;

        internal static System.Timers.Timer TIMEOUTAGENDA;

        private static lib.vo.Empleado _empleado;

        public static lib.vo.Empleado EMPLEADO
        {
            get { return cache._empleado; }
        }

        public static string DefaultSubCuentaPaciente
        {
            get
            {
                return SUBCUENTAS.SubCuentaPaciente;
            }
        }

        public static bool IsMasterUser
        {
            get
            {
                return ADMINISTRACION.MasterUser.Contains(EMPLEADO.Login);
            }
        }
        internal static bool IsSystemUser
        {
            get
            {
                return ADMINISTRACION.SystemUser.ToUpper() == EMPLEADO.Login.ToUpper();
            }
        }

        public static int WorkingHourStart
        {
            get
            {
                return GESCLINICACONFIG.HoraEntrada;
            }
        }
        public static int WorkingHourEnd
        {
            get
            {
                return GESCLINICACONFIG.HoraSalida;
            }
        }
        public static int WorkingMinuteStart
        {
            get
            {
                return GESCLINICACONFIG.MinutoEntrada;
            }
        }
        public static int WorkingMinuteEnd
        {
            get
            {
                return GESCLINICACONFIG.MinutoSalida;
            }
        }

        public static int WorkingScheduleStep
        {
            get
            {
                return GESCLINICACONFIG.SaltoAgenda;
            }
        }

        public delegate void ProcessingHandler(_events.ProgressEventArgs e);
        public static event ProcessingHandler Processing;

        public delegate void RefreshAgendaHandler();
        public static event RefreshAgendaHandler RefreshAgenda;

        public delegate void DataBaseUpdatingHandler(string mensaje, System.ComponentModel.CancelEventArgs e);
        public static event DataBaseUpdatingHandler DataBaseUpdating;

        public delegate void DataBaseUpdatedHandler(string mensaje);
        public static event DataBaseUpdatedHandler DataBaseUpdated;
        
        public static bool Initialize(string loginEmpleado)
        {
            try
            {
                bool res = true;

                if (!System.IO.File.Exists(gesClinica.lib.common.variables.configpath.GetFullPath()))
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

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración gesClinica", c, t));
                InitializeGesClinicaConfig();
                System.Threading.Thread.Sleep(delay);
                c += 1;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración TimeOut Agenda", c, t));
                InitializeTimeOutAgenda();
                System.Threading.Thread.Sleep(delay);
                c += 1;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Contabilidad", c, t));
                InitializeSubCuentas();
                System.Threading.Thread.Sleep(delay);
                c += 1;

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

                //if (!System.IO.File.Exists(gesClinica.lib.common.variables.configpath.GetFullPath()))
                //    throw new _exceptions.common.ConfigFileNotFoundException();
                                
                int c = 0;
                int t = 2;
                //int delay = 0;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Administración", c, t));
                //InitializeAdministracion(loginEmpleado);
                //System.Threading.Thread.Sleep(delay);
                //c += 1;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración gesClinica", c, t));
                //InitializeGesClinicaConfig();
                //System.Threading.Thread.Sleep(delay);
                //c += 1;
                
                _empleado = null;
                ADMINISTRACION = null;
                GESCLINICACONFIG = null;

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
                _empleado = new gesClinica.lib.vo.Empleado(loginEmpleado);
                

                ADMINISTRACION = new gesClinica.lib.bl._common.secciones.AdministracionSection();
                repsol.util.config.sections.section administracionSetting = repsol.util.config.sections.section.getSectionSetting(gesClinica.lib.common.variables.configpath.GetFullPath(),ADMINISTRACION.Name);
                if (administracionSetting != null)
                {
                    try
                    {
                        ADMINISTRACION.SetMasterUsers(administracionSetting["MasterUser"].Value, ";");
                        ADMINISTRACION.SystemUser = administracionSetting["SystemUser"].Value;                  
                    }
                    catch
                    {
                        throw new _exceptions.common.IncorrectFormatConfigFileException();
                    }
                    if ((IsSystemUser) || (IsMasterUser))
                    {
                        empleado.doGetByLogin lnEmpleado = new gesClinica.lib.bl.empleado.doGetByLogin(_empleado);
                        lnEmpleado.SystemAction = true;
                        lib.vo.Empleado tmpUser = lnEmpleado.execute();
                        if (tmpUser != null)
                            _empleado = tmpUser;
                        else
                        {
                            if (IsSystemUser)
                            {
                                _empleado = new gesClinica.lib.vo.Empleado(ADMINISTRACION.SystemUser);
                                _empleado.Nombre = "SYSTEM USER";
                            }
                            else
                            {
                                _empleado = new gesClinica.lib.vo.Empleado(loginEmpleado.ToUpper());
                                _empleado.Nombre = "MASTER USER";
                            }
                            _empleado.Apellido2 = loginEmpleado;
                        }
                    }
                    else
                    {
                        empleado.doGetByLogin lnEmpleado = new gesClinica.lib.bl.empleado.doGetByLogin(_empleado);
                        lnEmpleado.SystemAction = true;
                        lib.vo.Empleado tmpUser = lnEmpleado.execute();
                        if (tmpUser != null)
                        {
                            if (!tmpUser.Activo) throw new _exceptions.empleado.EmployeeNotEnabledException(loginEmpleado);
                        }
                        else
                            throw new _exceptions.empleado.EmployeeNotFoundException(loginEmpleado);
                        _empleado = tmpUser;
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

        #region ************ Seccion GESCLINICACONFIG *************
        internal static void InitializeGesClinicaConfig()
        {
            try
            {
                GESCLINICACONFIG = new gesClinica.lib.bl._common.secciones.GesClinicaConfigSection();
                repsol.util.config.sections.section gesClinicaConfigSetting = repsol.util.config.sections.section.getSectionSetting(gesClinica.lib.common.variables.configpath.GetFullPath(), GESCLINICACONFIG.Name);
                if (gesClinicaConfigSetting != null)
                {
                    try
                    {
                        GESCLINICACONFIG.HoraEntrada = Convert.ToInt32(gesClinicaConfigSetting["HoraEntrada"].Value);
                        GESCLINICACONFIG.HoraSalida = Convert.ToInt32(gesClinicaConfigSetting["HoraSalida"].Value);
                        GESCLINICACONFIG.MinutoEntrada = Convert.ToInt32(gesClinicaConfigSetting["MinutoEntrada"].Value);
                        GESCLINICACONFIG.MinutoSalida = Convert.ToInt32(gesClinicaConfigSetting["MinutoSalida"].Value);
                        GESCLINICACONFIG.SerieFacturacion = Convert.ToString(gesClinicaConfigSetting["SerieFacturacion"].Value);
                        GESCLINICACONFIG.IVA = Convert.ToInt32(gesClinicaConfigSetting["IVA"].Value);
                        GESCLINICACONFIG.TimeOutAgenda = Convert.ToInt32(gesClinicaConfigSetting["TimeOutAgenda"].Value);
                        GESCLINICACONFIG.SaltoAgenda = Convert.ToInt32(gesClinicaConfigSetting["SaltoAgenda"].Value);
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

        #region ************ Seccion TIMEOUTAGENDA *************
        internal static void InitializeTimeOutAgenda()
        {
            try
            {
                TIMEOUTAGENDA = new System.Timers.Timer(GESCLINICACONFIG.TimeOutAgendaInMilliseconds);
                TIMEOUTAGENDA.Enabled = true;
                TIMEOUTAGENDA.Elapsed += new System.Timers.ElapsedEventHandler(TIMEOUTAGENDA_Elapsed);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void TIMEOUTAGENDA_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (RefreshAgenda != null) RefreshAgenda();
        }
        #endregion

        #region ************ Seccion SUBCUENTAS *************
        internal static void InitializeSubCuentas()
        {
            try
            {
                SUBCUENTAS = new gesClinica.lib.bl._common.secciones.SubCuentasSection();
                repsol.util.config.sections.section subCuentasSetting = repsol.util.config.sections.section.getSectionSetting(gesClinica.lib.common.variables.configpath.GetFullPath(), SUBCUENTAS.Name);
                if (subCuentasSetting != null)
                {
                    try
                    {
                        SUBCUENTAS.Servicio = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasServicio"].Value, ";");
                        SUBCUENTAS.Cliente = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasCliente"].Value, ";");
                        SUBCUENTAS.Retencion = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasRetencion"].Value, ";");
                        SUBCUENTAS.Origen = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasOrigen"].Value, ";");
                        SUBCUENTAS.Proveedor = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasProveedor"].Value, ";");
                        SUBCUENTAS.Gasto = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasGasto"].Value, ";");
                        SUBCUENTAS.Destino = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasDestino"].Value, ";");
                        SUBCUENTAS.Medio = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasMedio"].Value, ";");

                        SUBCUENTAS.AmortizacionBien = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasAmortizacionBien"].Value, ";");
                        SUBCUENTAS.AmortizacionGasto = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasAmortizacionGasto"].Value, ";");

                        SUBCUENTAS.PrestamoAmortizacion = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasPrestamoAmortizacion"].Value, ";");
                        SUBCUENTAS.PrestamoIntereses = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasPrestamoIntereses"].Value, ";");
                        SUBCUENTAS.PrestamoCuentaCargo = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasPrestamoCuentaCargo"].Value, ";");

                        SUBCUENTAS.SueldosSalario = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasSueldosSalario"].Value, ";");
                        SUBCUENTAS.SueldosSeguridadSocial = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasSueldosSeguridadSocial"].Value, ";");
                        SUBCUENTAS.SueldosMedioPago = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasSueldosMedioPago"].Value, ";");
                        SUBCUENTAS.SueldosRetencion = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasSueldosRetencion"].Value, ";");
                        SUBCUENTAS.SueldosSeguridadSocialAcreedora = gesClinica.lib.bl._common.secciones.SubCuentasSection.GetLists(subCuentasSetting["subcuentasSueldosSeguridadSocialAcreedora"].Value, ";");

                        SUBCUENTAS.SubCuentaPaciente = subCuentasSetting["subcuentasPaciente"].Value;

                        SUBCUENTAS.SubCuentaPerdidasYGanancias = subCuentasSetting["subcuentasPerdidasYGanancias"].Value;     
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
                repsol.util.versionBD versionBD = new repsol.util.versionBD(lib.common.variables.configpath.GetFullPath(), dao._common.conexion.tCONEXION.gesClinica.ToString(), "_sql");
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
                MANTENIMIENTO = new gesClinica.lib.bl._common.secciones.MantenimientoSection();
                //gesClinica.lib.common.
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
