using System;

namespace asr.lib.dao._common.plain
{
	
	internal sealed class PlainActionProcessor
	{
		
		public PlainActionProcessor()
		{
		}
		internal static object process(asr.lib.dao._common.DAOFactory factory, NonTransactionalPlainAction action)
		{
			System.Data.Common.DbConnection connection = null;
			
			try
			{
				connection = factory.Connection;
				connection.Open();
				
				factory.Command = connection.CreateCommand();

				return action.execute(factory);
				
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				connection.Close();
			}
		}
		
		internal static object process(asr.lib.dao._common.DAOFactory factory, TransactionalPlainAction action)
		{
			bool commited = false;
			System.Data.Common.DbConnection connection = null;
			System.Data.Common.DbTransaction transaction = null;
			
			try
			{
				connection = factory.Connection;
				connection.Open();
				
				factory.Command = connection.CreateCommand();
				transaction = connection.BeginTransaction(System.Data.IsolationLevel.Serializable);
				factory.Command.Transaction = transaction;
				
				object result = action.execute(factory);

				transaction.Commit();
				commited = true;
				
				
				return result;
				
			}
			catch(Exception ex)
			{
				throw ex;
			}
			finally
			{
				try
				{
					if (transaction.Connection!=null)
					{
						if (!commited) transaction.Rollback();
					}
					connection.Close();
				}
				catch(Exception ex)
				{
					throw ex;
				}
			}
		}
	}
}
