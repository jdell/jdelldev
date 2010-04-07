using System;
using System.Data.Common;

namespace ambis1.model.dao._common
{	
	internal class DAOFactory
	{
        DbProviderFactory _factory;
        DbConnection _connection;
        DbCommand _command;
		
		public DbConnection Connection {
			get {
				return _connection;
			}
			set {
				_connection = value;
			}
		}

		public DbCommand Command {
			get {
				return _command;
			}
			set {
				_command = value;
			}
		}
		
		public DAOFactory()
		{
#if DEBUG
            initFactory(ambis1.model.dao._common.connection.tCONNECTION.Server);
#else
            initFactory(ambis1.model.dao._common.connection.tCONNECTION.Local);
#endif
        }
		public DAOFactory(ambis1.model.dao._common.connection.tCONNECTION connectionType)
		{
			initFactory(connectionType);
		}
		private void initFactory(ambis1.model.dao._common.connection.tCONNECTION connectionType)
		{
            repsol.util.config.connections.connection con = repsol.util.config.connections.connection.getConnectionSetting(ambis1.model.common.variables.configpath.GetFullPath(), connectionType.ToString());
            this._factory = DbProviderFactories.GetFactory(con.ProviderName);
            this._connection = this._factory.CreateConnection();
            //TODO: Conexion - Crifrar
            this._connection.ConnectionString = repsol.crypto.tripleDES.descifrar(new repsol.crypto.byteBlock(repsol.crypto.byteBlock.parse(con.ConnectionString)));
            //this._connection.ConnectionString = con.ConnectionString;
            this._command = this._factory.CreateCommand();
            this._command.Connection = this._connection;	
		}
	}
}
