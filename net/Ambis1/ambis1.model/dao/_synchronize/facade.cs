using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ambis1.model.dao._common;

using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.Server;
using Microsoft.Synchronization.Data.SqlServerCe;
using System.Data.SqlServerCe;

namespace ambis1.model.dao._synchronize
{
    internal class facade
    {
        internal DAOFactory factoryLocal;
        internal DAOFactory factoryServer;

        public facade()
        {
            factoryLocal = new DAOFactory(ambis1.model.dao._common.connection.tCONNECTION.Local);
            factoryServer = new DAOFactory(ambis1.model.dao._common.connection.tCONNECTION.Server);
        }

        //public List<Cage> doGetAll()
        //{
        //    try
        //    {
        //        // 
        //        // 1. Create instance of the sync components (client, agent, server)
        //        // This demo illustrates direct connection to server database. In this scenario, 
        //        // sync components - client provider, sync agent and server provider - reside at
        //        // the client side. On the server, each table might need to be extended with sync
        //        // related columns to store metadata. This demo adds three more columns to the
        //        // orders and order_details tables for bidirectional sync. The changes are illustrated
        //        // in demo.sql file.
        //        //
        //        //
        //        DbServerSyncProvider serverSyncProvider = new DbServerSyncProvider();

        //        SyncAgent syncAgent = new SyncAgent();
        //        syncAgent.RemoteProvider = serverSyncProvider;

        //        //
        //        // 2. Prepare server db connection and attach it to the sync agent
        //        //
        //        serverSyncProvider.Connection = this.factoryServer.Connection;

        //        //
        //        // 3. Prepare client db connection and attach it to the sync provider
        //        //                      
        //        string localDBPath = "";
        //        string connString = "Data Source=" + localDBPath;

        //        if (false == File.Exists(localDBPath))
        //        {
        //            SqlCeEngine clientEngine = new SqlCeEngine(connString);
        //            clientEngine.CreateDatabase();
        //            clientEngine.Dispose();
        //        }
        //        SqlCeClientSyncProvider clientSyncProvider = new SqlCeClientSyncProvider(connString);
        //        syncAgent.LocalProvider = clientSyncProvider;

        //        //
        //        // 4. Create SyncTables and SyncGroups
        //        // To sync a table, a SyncTable object needs to be created and setup with desired properties:
        //        // TableCreationOption tells the agent how to initialize the new table in the local database
        //        // SyncDirection is how changes from with respect to client {Download, Upload, Bidirectional or Snapshot}
        //        //
        //        //
        //        SyncTable tableTypeOfMembership = new SyncTable("typeofmembership");
        //        tableTypeOfMembership.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
        //        tableTypeOfMembership.SyncDirection = SyncDirection.Bidirectional;
        //        /*
        //        SyncTable tableOrderDetails = new SyncTable("order_details");
        //        tableOrderDetails.CreationOption = TableCreationOption.DropExistingOrCreateNewTable;
        //        tableOrderDetails.SyncDirection = SyncDirection.Bidirectional;
        //        */
        //        //
        //        // Sync changes for both tables as one bunch, using SyncGroup object
        //        // This is important if the tables has PK-FK relationship, grouping will ensure that 
        //        // and FK change won't be applied before its PK is applied
        //        //
        //        //
        //        SyncGroup typeOfMembershipGroup = new SyncGroup("AllChanges");
        //        tableTypeOfMembership.SyncGroup = typeOfMembershipGroup;
        //        //tableOrderDetails.SyncGroup = orderGroup;

        //        syncAgent.Configuration.SyncTables.Add(tableTypeOfMembership);
        //        //syncAgent.Configuration.SyncTables.Add(tableOrderDetails);

        //        //
        //        // 5. Create sync adapter for each sync table and attach it to the server provider
        //        // Following DataAdapter style in ADO.NET, SyncAdapte is the equivelent for
        //        // Sync. SyncAdapterBuilder is a helper class to simplify the process of 
        //        // creating sync commands.                 
        //        //
        //        //
        //        SyncAdapter typeOfMembershipAdapter = new SyncAdapter("typeofmembership");
        //        System.Data.Common.DbCommand incInsTypeOfMembershipCmd = factoryServer.Connection.CreateCommand();
        //        incInsTypeOfMembershipCmd.CommandType = System.Data.CommandType.Text;
        //        incInsTypeOfMembershipCmd.CommandText = String.Format("SELECT id_typeofmembership, description_typeofmembership FROM typeofmembership "
        //            + " WHERE track_insert is null OR (track_insert > {0}{1} abd track_insert <= {0}{2})", "?", SyncSession.SyncLastReceivedAnchor, SyncSession.SyncNewReceivedAnchor );

        //        System.Data.Common.DbParameter parameterServer;

        //        parameterServer = incInsTypeOfMembershipCmd.CreateParameter();
        //        parameterServer.DbType = System.Data.DbType.Time;
        //        parameterServer.ParameterName = string.Format("{0}{1}", "?", SyncSession.SyncLastReceivedAnchor);
        //        incInsTypeOfMembershipCmd.Parameters.Add(parameterServer);

        //        parameterServer = incInsTypeOfMembershipCmd.CreateParameter();
        //        parameterServer.DbType = System.Data.DbType.Time;
        //        parameterServer.ParameterName = string.Format("{0}{1}", "?", SyncSession.SyncNewReceivedAnchor);
        //        incInsTypeOfMembershipCmd.Parameters.Add(parameterServer);

        //        serverSyncProvider.SyncAdapters.Add(typeOfMembershipAdapter);

        //        SyncSchema syncSchema = new SyncSchema();
        //        serverSyncProvider.Schema = syncSchema;

        //        syncSchema.Tables.Add("typeofmembership");
        //        syncSchema.Tables["typeofmembership"].Columns.Add("id_typeofmembership");
        //        syncSchema.Tables["typeofmembership"].Columns["id_typeofmembership"].AllowNull = false;
        //        syncSchema.Tables["typeofmembership"].Columns["id_typeofmembership"].ProviderDataType = "NUMERIC";
        //        syncSchema.Tables["typeofmembership"].Columns["id_typeofmembership"].NumericPrecision = 5;
        //        syncSchema.Tables["typeofmembership"].Columns["id_typeofmembership"].NumericScale = 0;
        //        syncSchema.Tables["typeofmembership"].Columns["id_typeofmembership"].AutoIncrement= true;
        //        syncSchema.Tables["typeofmembership"].PrimaryKey = new string[]{"id_typeofmembership"};

        //        syncSchema.Tables["typeofmembership"].Columns.Add("description_typeofmembership");
        //        syncSchema.Tables["typeofmembership"].Columns["description_typeofmembership"].ProviderDataType = "CHAR";
        //        syncSchema.Tables["typeofmembership"].Columns["description_typeofmembership"].MaxLength = 50; 

        //        ////AQIU!
        //        //SqlSyncAdapterBuilder typeOfMembershipBuilder = new SqlSyncAdapterBuilder();
        //        //typeOfMembershipBuilder.Connection = serverConnection;
        //        //typeOfMembershipBuilder.SyncDirection = SyncDirection.Bidirectional;

        //        //// base table
        //        //typeOfMembershipBuilder.TableName = "typeofmembership";
        //        //typeOfMembershipBuilder.DataColumns.Add("id_typeofmembership");
        //        //typeOfMembershipBuilder.DataColumns.Add("description_typeofmembership");

        //        //// tombstone table
        //        //typeOfMembershipBuilder.TombstoneTableName = "typeofmembership_tombstone";
        //        //typeOfMembershipBuilder.TombstoneDataColumns.Add("id_typeofmembership");
        //        //typeOfMembershipBuilder.TombstoneDataColumns.Add("description_typeofmembership");

        //        //// tracking\sync columns
        //        //typeOfMembershipBuilder.CreationTrackingColumn = @"create_timestamp";
        //        //typeOfMembershipBuilder.UpdateTrackingColumn = @"update_timestamp";
        //        //typeOfMembershipBuilder.DeletionTrackingColumn = @"update_timestamp";
        //        //typeOfMembershipBuilder.UpdateOriginatorIdColumn = @"update_originator_id";

        //        //SyncAdapter typeOfMembershipSyncAdapter = typeOfMembershipBuilder.ToSyncAdapter();
        //        //((System.Data.Common.DbParameter)typeOfMembershipSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_last_received_anchor"]).DbType = DbType.Binary;
        //        //((System.Data.Common.DbParameter)typeOfMembershipSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_new_received_anchor"]).DbType = DbType.Binary;
        //        //serverSyncProvider.SyncAdapters.Add(typeOfMembershipSyncAdapter);


        //        ////SqlSyncAdapterBuilder orderDetailsBuilder = new SqlSyncAdapterBuilder();
        //        ////orderDetailsBuilder.SyncDirection = SyncDirection.Bidirectional;
        //        ////orderDetailsBuilder.Connection = serverConnection;

        //        ////// base table
        //        ////orderDetailsBuilder.TableName = "order_details";
        //        ////orderDetailsBuilder.DataColumns.Add("order_id");
        //        ////orderDetailsBuilder.DataColumns.Add("order_details_id");
        //        ////orderDetailsBuilder.DataColumns.Add("product");
        //        ////orderDetailsBuilder.DataColumns.Add("quantity");

        //        ////// tombstone table
        //        ////orderDetailsBuilder.TombstoneTableName = "order_details_tombstone";
        //        ////orderDetailsBuilder.TombstoneDataColumns.Add("order_id");
        //        ////orderDetailsBuilder.TombstoneDataColumns.Add("order_details_id");
        //        ////orderDetailsBuilder.TombstoneDataColumns.Add("product");
        //        ////orderDetailsBuilder.TombstoneDataColumns.Add("quantity");

        //        ////// tracking\sync columns
        //        ////orderDetailsBuilder.CreationTrackingColumn = @"create_timestamp";
        //        ////orderDetailsBuilder.UpdateTrackingColumn = @"update_timestamp";
        //        ////orderDetailsBuilder.DeletionTrackingColumn = @"update_timestamp";
        //        ////orderDetailsBuilder.UpdateOriginatorIdColumn = @"update_originator_id";


        //        ////SyncAdapter orderDetailsSyncAdapter = orderDetailsBuilder.ToSyncAdapter();
        //        ////((SqlParameter)orderDetailsSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_last_received_anchor"]).DbType = DbType.Binary;
        //        ////((SqlParameter)orderDetailsSyncAdapter.SelectIncrementalInsertsCommand.Parameters["@sync_new_received_anchor"]).DbType = DbType.Binary;
        //        ////serverSyncProvider.SyncAdapters.Add(orderDetailsSyncAdapter);


        //        ////
        //        //// 6. Setup provider wide commands
        //        //// There are two commands on the provider itself and not on a table sync adapter:
        //        //// SelectNewAnchorCommand: Returns the new high watermark for current sync, this value is
        //        //// stored at the client and used the low watermark in the next sync
        //        //// SelectClientIdCommand: Finds out the client ID on the server, this command helps
        //        //// avoid downloading changes that the client had made before and applied to the server
        //        ////
        //        ////

        //        //// select new anchor command
        //        //SqlCommand anchorCmd = new SqlCommand();
        //        //anchorCmd.CommandType = CommandType.Text;
        //        //anchorCmd.CommandText = "Select @" + SyncSession.SyncNewReceivedAnchor + " = @@DBTS";  // for SQL Server 2005 SP2, use "min_active_rowversion() - 1"
        //        //anchorCmd.Parameters.Add("@" + SyncSession.SyncNewReceivedAnchor, SqlDbType.Timestamp).Direction = ParameterDirection.Output;

        //        //serverSyncProvider.SelectNewAnchorCommand = anchorCmd;

        //        //// client ID command (give the client id of 1)
        //        //// in remote server scenario (middle tear), this command will reference a local client table for the ID               
        //        //SqlCommand clientIdCmd = new SqlCommand();
        //        //clientIdCmd.CommandType = CommandType.Text;
        //        //clientIdCmd.CommandText = "SELECT @" + SyncSession.SyncOriginatorId + " = 1";
        //        //clientIdCmd.Parameters.Add("@" + SyncSession.SyncOriginatorId, SqlDbType.Int).Direction = ParameterDirection.Output;

        //        //serverSyncProvider.SelectClientIdCommand = clientIdCmd;


        //        ////
        //        //// 7. Kickoff sync process                
        //        ////

        //        //// Setup the progress form and sync progress event handler                
        //        //_progressForm = new ProgressForm();
        //        //_progressForm.Show();

        //        //clientSyncProvider.SyncProgress += new EventHandler<SyncProgressEventArgs>(ShowProgress);
        //        //clientSyncProvider.ApplyChangeFailed += new EventHandler<ApplyChangeFailedEventArgs>(ShowFailures);
        //        //serverSyncProvider.SyncProgress += new EventHandler<SyncProgressEventArgs>(ShowProgress);
        //        //SyncStatistics syncStats = syncAgent.Synchronize();

        //        //// Update the UI
        //        //_progressForm.EnableClose();
        //        //_progressForm = null;
        //        //buttonRefreshOrders_Click(null, null);
        //        //buttonRefreshOrderDetails_Click(null, null);   
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
