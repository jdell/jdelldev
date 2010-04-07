using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.bl._common
{
    public abstract class cache
    {
        internal static _common.sections.AdministracionSection ADMINISTRATION = null;
        internal static _common.sections.MainConfigSection MAINCONFIG = null;
        internal static _common.sections.MaintenanceSection MAINTENANCE = null;

        internal static _common.sections.CompanyInfoSection COMPANYINFO = null;
        public static string CompanyName
        {
            get
            {
                return COMPANYINFO.CompanyName;
            }
        }

        public static int WorkingHourStart
        {
            get
            {
                return MAINCONFIG.HoraEntrada;
            }
        }
        public static int WorkingHourEnd
        {
            get
            {
                return MAINCONFIG.HoraSalida;
            }
        }
        public static int WorkingMinuteStart
        {
            get
            {
                return MAINCONFIG.MinutoEntrada;
            }
        }
        public static int WorkingMinuteEnd
        {
            get
            {
                return MAINCONFIG.MinutoSalida;
            }
        }
        public static int WorkingScheduleStep
        {
            get
            {
                return MAINCONFIG.SaltoAgenda;
            }
        }
        public static Int32 AccountRecordChartsHistory
        {
            get
            {
                return -ADMINISTRATION.AccountRecordChartMonths;
            }
        }
        public static bool IsPresentationMode
        {
            get
            {
                return ADMINISTRATION.PresentationMode;
            }
        }
        public static bool IsMasterUser
        {
            get
            {
                //TODO: Employeer. DB
                //return ADMINISTRACION.MasterUser.Contains(EMPLEADO.Login);
                return true;
            }
        }
        internal static bool IsSystemUser
        {
            get
            {
                //TODO: Employeer. DB
                //return ADMINISTRACION.SystemUser.ToUpper() == EMPLEADO.Login.ToUpper();
                return true;
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

                if (!System.IO.File.Exists(ambis1.model.common.variables.configpath.GetFullPath()))
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

                if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración asr", c, t));
                InitializeMainConfig();
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

                //if (!System.IO.File.Exists(ambis1.model.common.variables.configpath.GetFullPath()))
                //    throw new _exceptions.common.ConfigFileNotFoundException();
                                
                int c = 0;
                int t = 2;
                //int delay = 0;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Administración", c, t));
                //InitializeAdministracion(loginEmpleado);
                //System.Threading.Thread.Sleep(delay);
                //c += 1;

                //if (Processing != null) Processing(new _events.ProgressEventArgs("Iniciando caché: Configuración asr", c, t));
                //InitializeMainConfig();
                //System.Threading.Thread.Sleep(delay);
                //c += 1;
                
                //_empleado = null;
                ADMINISTRATION = null;
                //MAINCONFIG = null;

                if (Processing != null) Processing(new _events.ProgressEventArgs("Operación completada", c, t));

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region ************ SYNCHRONIZE *************
        internal static void InitializeSynchronize()
        {
            try
            {

                //// 
                //// 1. Create instance of the sync components (client, agent, server)
                //// This demo illustrates direct connection to server database. In this scenario, 
                //// sync components - client provider, sync agent and server provider - reside at
                //// the client side. On the server, each table might need to be extended with sync
                //// related columns to store metadata. This demo adds three more columns to the
                //// orders and order_details tables for bidirectional sync. The changes are illustrated
                //// in demo.sql file.
                ////
                ////
                //DbServerSyncProvider serverSyncProvider = new DbServerSyncProvider();

                //SyncAgent syncAgent = new SyncAgent();
                //syncAgent.RemoteProvider = serverSyncProvider;

                //SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                ////
                //// 2. Prepare server db connection and attach it to the sync agent
                ////
                //builder["Data Source"] = textServerMachine.Text;
                //builder["integrated Security"] = true;
                //builder["Initial Catalog"] = "asr_doubleplay_test";
                //builder["User"] = "asr_doubletest";
                //builder["Password"] = "Doubleplay1";
                //SqlConnection serverConnection = new SqlConnection(builder.ConnectionString);

                //serverSyncProvider.Connection = serverConnection;


                ////
                //// 3. Prepare client db connection and attach it to the sync provider
                ////                                
                //string connString = "Data Source=" + dbPathTextBox.Text;

                //if (false == File.Exists(dbPathTextBox.Text))
                //{
                //    SqlCeEngine clientEngine = new SqlCeEngine(connString);
                //    clientEngine.CreateDatabase();
                //    clientEngine.Dispose();
                //}
                //SqlCeClientSyncProvider clientSyncProvider = new SqlCeClientSyncProvider(connString);
                //syncAgent.LocalProvider = clientSyncProvider;


                ////
                //// 4. Create SyncTables and SyncGroups
                //// To sync a table, a SyncTable object needs to be created and setup with desired properties:
                //// TableCreationOption tells the agent how to initialize the new table in the local database
                //// SyncDirection is how changes from with respect to client {Download, Upload, Bidirectional or Snapshot}
                ////
                ////
                //SyncTable tableOrders = new SyncTable("typeofmembership");
                //tableOrders.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
                //tableOrders.SyncDirection = SyncDirection.Bidirectional;
                ///*
                //SyncTable tableOrderDetails = new SyncTable("order_details");
                //tableOrderDetails.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
                //tableOrderDetails.SyncDirection = SyncDirection.Bidirectional;
                //*/
                ////
                //// Sync changes for both tables as one bunch, using SyncGroup object
                //// This is important if the tables has PK-FK relationship, grouping will ensure that 
                //// and FK change won't be applied before its PK is applied
                ////
                ////
                //SyncGroup orderGroup = new SyncGroup("AllChanges");
                //tableOrders.SyncGroup = orderGroup;
                ////tableOrderDetails.SyncGroup = orderGroup;

                //syncAgent.Configuration.SyncTables.Add(tableOrders);
                ////syncAgent.Configuration.SyncTables.Add(tableOrderDetails);



                ////
                //// 5. Create sync adapter for each sync table and attach it to the server provider
                //// Following DataAdapter style in ADO.NET, SyncAdapte is the equivelent for
                //// Sync. SyncAdapterBuilder is a helper class to simplify the process of 
                //// creating sync commands.                 
                ////
                ////

                //SqlSyncAdapterBuilder ordersBuilder = new SqlSyncAdapterBuilder();
                //ordersBuilder.Connection = serverConnection;
                //ordersBuilder.SyncDirection = SyncDirection.Bidirectional;

                //// base table
                //ordersBuilder.TableName = "typeofmembership";
                //ordersBuilder.DataColumns.Add("id_typeofmembership");
                //ordersBuilder.DataColumns.Add("description_typeofmembership");

                //// tombstone table
                //ordersBuilder.TombstoneTableName = "typeofmembership_tombstone";
                //ordersBuilder.TombstoneDataColumns.Add("id_typeofmembership");
                //ordersBuilder.TombstoneDataColumns.Add("description_typeofmembership");

                //// tracking\sync columns
                //ordersBuilder.CreationTrackingColumn = @"create_timestamp";
                //ordersBuilder.UpdateTrackingColumn = @"update_timestamp";
                //ordersBuilder.DeletionTrackingColumn = @"update_timestamp";
                //ordersBuilder.UpdateOriginatorIdColumn = @"update_originator_id";

                //SyncAdapter ordersSyncAdapter = ordersBuilder.ToSyncAdapter();
                //((SqlParameter)ordersSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_last_received_anchor"]).DbType = DbType.Binary;
                //((SqlParameter)ordersSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_new_received_anchor"]).DbType = DbType.Binary;
                //serverSyncProvider.SyncAdapters.Add(ordersSyncAdapter);


                //SqlSyncAdapterBuilder orderDetailsBuilder = new SqlSyncAdapterBuilder();
                //orderDetailsBuilder.SyncDirection = SyncDirection.Bidirectional;
                //orderDetailsBuilder.Connection = serverConnection;

                ////// base table
                ////orderDetailsBuilder.TableName = "order_details";
                ////orderDetailsBuilder.DataColumns.Add("order_id");
                ////orderDetailsBuilder.DataColumns.Add("order_details_id");
                ////orderDetailsBuilder.DataColumns.Add("product");
                ////orderDetailsBuilder.DataColumns.Add("quantity");

                ////// tombstone table
                ////orderDetailsBuilder.TombstoneTableName = "order_details_tombstone";
                ////orderDetailsBuilder.TombstoneDataColumns.Add("order_id");
                ////orderDetailsBuilder.TombstoneDataColumns.Add("order_details_id");
                ////orderDetailsBuilder.TombstoneDataColumns.Add("product");
                ////orderDetailsBuilder.TombstoneDataColumns.Add("quantity");

                ////// tracking\sync columns
                ////orderDetailsBuilder.CreationTrackingColumn = @"create_timestamp";
                ////orderDetailsBuilder.UpdateTrackingColumn = @"update_timestamp";
                ////orderDetailsBuilder.DeletionTrackingColumn = @"update_timestamp";
                ////orderDetailsBuilder.UpdateOriginatorIdColumn = @"update_originator_id";


                ////SyncAdapter orderDetailsSyncAdapter = orderDetailsBuilder.ToSyncAdapter();
                ////((SqlParameter)orderDetailsSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_last_received_anchor"]).DbType = DbType.Binary;
                ////((SqlParameter)orderDetailsSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_new_received_anchor"]).DbType = DbType.Binary;
                ////serverSyncProvider.SyncAdapters.Add(orderDetailsSyncAdapter);


                ////
                //// 6. Setup provider wide commands
                //// There are two commands on the provider itself and not on a table sync adapter:
                //// SelectNewAnchorCommand: Returns the new high watermark for current sync, this value is
                //// stored at the client and used the low watermark in the next sync
                //// SelectClientIdCommand: Finds out the client ID on the server, this command helps
                //// avoid downloading changes that the client had made before and applied to the server
                ////
                ////

                //// select new anchor command
                //SqlCommand anchorCmd = new SqlCommand();
                //anchorCmd.CommandType = CommandType.Text;
                //anchorCmd.CommandText = "Select @" + SyncSession.SyncNewReceivedAnchor + " = @@DBTS";  // for SQL Server 2005 SP2, use "min_active_rowversion() - 1"
                //anchorCmd.Parameters.Add("@" + SyncSession.SyncNewReceivedAnchor, SqlDbType.Timestamp).Direction = ParameterDirection.Output;

                //serverSyncProvider.SelectNewAnchorCommand = anchorCmd;

                //// client ID command (give the client id of 1)
                //// in remote server scenario (middle tear), this command will reference a local client table for the ID               
                //SqlCommand clientIdCmd = new SqlCommand();
                //clientIdCmd.CommandType = CommandType.Text;
                //clientIdCmd.CommandText = "SELECT @" + SyncSession.SyncOriginatorId + " = 1";
                //clientIdCmd.Parameters.Add("@" + SyncSession.SyncOriginatorId, SqlDbType.Int).Direction = ParameterDirection.Output;

                //serverSyncProvider.SelectClientIdCommand = clientIdCmd;


                ////
                //// 7. Kickoff sync process                
                ////

                //// Setup the progress form and sync progress event handler                
                //_progressForm = new ProgressForm();
                //_progressForm.Show();

                //clientSyncProvider.SyncProgress += new EventHandler<SyncProgressEventArgs>(ShowProgress);
                //clientSyncProvider.ApplyChangeFailed += new EventHandler<ApplyChangeFailedEventArgs>(ShowFailures);
                //serverSyncProvider.SyncProgress += new EventHandler<SyncProgressEventArgs>(ShowProgress);
                //SyncStatistics syncStats = syncAgent.Synchronize();

                //// Update the UI
                //_progressForm.EnableClose();
                //_progressForm = null;
                //buttonRefreshOrders_Click(null, null);
                //buttonRefreshOrderDetails_Click(null, null);  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region ************ Seccion ADMINISTRACION *************
        internal static void InitializeAdministracion(string loginEmpleado)
        {
            try
            {
                //_empleado = new ambis1.model.vo.Empleado(loginEmpleado);
                

                ADMINISTRATION = new ambis1.model.bl._common.sections.AdministracionSection();
                repsol.util.config.sections.section administracionSetting = repsol.util.config.sections.section.getSectionSetting(ambis1.model.common.variables.configpath.GetFullPath(),ADMINISTRATION.Name);
                if (administracionSetting != null)
                {
                    try
                    {
                        ADMINISTRATION.SetMasterUsers(administracionSetting["MasterUser"].Value, ";");
                        ADMINISTRATION.SystemUser = administracionSetting["SystemUser"].Value;
                        ADMINISTRATION.PresentationMode = Convert.ToBoolean(administracionSetting["PresentationMode"].Value);
                        ADMINISTRATION.AccountRecordChartMonths = Convert.ToInt32(administracionSetting["AccountRecordChartMonths"].Value);   
                    }
                    catch
                    {
                        throw new _exceptions.common.IncorrectFormatConfigFileException();
                    }
                    //if ((IsSystemUser) || (IsMasterUser))
                    //{
                    //    empleado.doGetByLogin lnEmpleado = new ambis1.model.bl.empleado.doGetByLogin(_empleado);
                    //    lnEmpleado.SystemAction = true;
                    //    lib.vo.Empleado tmpUser = lnEmpleado.execute();
                    //    if (tmpUser != null)
                    //        _empleado = tmpUser;
                    //    else
                    //    {
                    //        if (IsSystemUser)
                    //        {
                    //            _empleado = new ambis1.model.vo.Empleado(ADMINISTRACION.SystemUser);
                    //            _empleado.Nombre = "SYSTEM USER";
                    //        }
                    //        else
                    //        {
                    //            _empleado = new ambis1.model.vo.Empleado(loginEmpleado.ToUpper());
                    //            _empleado.Nombre = "MASTER USER";
                    //        }
                    //        _empleado.Apellido2 = loginEmpleado;
                    //    }
                    //}
                    //else
                    //{
                    //    empleado.doGetByLogin lnEmpleado = new ambis1.model.bl.empleado.doGetByLogin(_empleado);
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

        #region ************ Seccion MAINCONFIG *************
        internal static void InitializeMainConfig()
        {
            try
            {
                MAINCONFIG = new ambis1.model.bl._common.sections.MainConfigSection();
                repsol.util.config.sections.section MainConfigSetting = repsol.util.config.sections.section.getSectionSetting(ambis1.model.common.variables.configpath.GetFullPath(), MAINCONFIG.Name);
                if (MainConfigSetting != null)
                {
                    try
                    {
                        MAINCONFIG.HoraEntrada = Convert.ToInt32(MainConfigSetting["HoraEntrada"].Value);
                        MAINCONFIG.HoraSalida = Convert.ToInt32(MainConfigSetting["HoraSalida"].Value);
                        MAINCONFIG.MinutoEntrada = Convert.ToInt32(MainConfigSetting["MinutoEntrada"].Value);
                        MAINCONFIG.MinutoSalida = Convert.ToInt32(MainConfigSetting["MinutoSalida"].Value);
                        MAINCONFIG.TimeOutAgenda = Convert.ToInt32(MainConfigSetting["TimeOutAgenda"].Value);
                        MAINCONFIG.SaltoAgenda = Convert.ToInt32(MainConfigSetting["SaltoAgenda"].Value);
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


        #region ************ Seccion COMPANYINFO *************
        internal static void InitializeCompanyInfo()
        {
            try
            {
                COMPANYINFO = new ambis1.model.bl._common.sections.CompanyInfoSection();
                repsol.util.config.sections.section companyInfoSetting = repsol.util.config.sections.section.getSectionSetting(ambis1.model.common.variables.configpath.GetFullPath(), COMPANYINFO.Name);
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
#if DEBUG
                repsol.util.versionBD versionBD = new repsol.util.versionBD(model.common.variables.configpath.GetFullPath(), dao._common.connection.tCONNECTION.Server.ToString(), "_sql");
#else
                repsol.util.versionBD versionBD = new repsol.util.versionBD(model.common.variables.configpath.GetFullPath(), dao._common.connection.tCONNECTION.ambis1.ToString(), "_sql");
#endif

                if (versionBD.Actualizable)
                {
                    if (DataBaseUpdating != null)
                    {
                        System.ComponentModel.CancelEventArgs e = new System.ComponentModel.CancelEventArgs();
                        e.Cancel = false;
                        string msg = "Available updates!! Click OK to update now";
                        //Hay actualizaciones disponibles en la Base de Datos. ¿Desea actualizar ahora?
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
                MANTENIMIENTO = new ambis1.model.bl._common.sections.MantenimientoSection();
                //ambis1.model.common.
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
                MANTENIMIENTO = New _common.sections.MantenimientoSection
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
