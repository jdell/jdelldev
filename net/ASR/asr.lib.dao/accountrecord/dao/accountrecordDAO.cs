using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.accountrecord.dao
{	
	internal class accountrecordDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from accountrecord c"
                + " LEFT JOIN activity act ON c.id_activity = act.id_activity ";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by date_accountrecord asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				AccountRecord res = null;
				if (reader!=null)
				{
                    res = new AccountRecord();
                    res.Amount = Convert.ToSingle(reader["amount_accountrecord"]);
                    res.Client = new Client();
                    res.Client.ID = Convert.ToInt32(reader["id_client"]);
                    res.Date = Convert.ToDateTime(reader["date_accountrecord"]);
                    res.Description = Convert.ToString(reader["description_accountrecord"]);
                    res.ID = Convert.ToInt32(reader["id_accountrecord"]);
                    res.Reference = Convert.ToString(reader["reference_accountrecord"]);
                    res.Incoming= Convert.ToBoolean(reader["incoming_accountrecord"]);

                    if (!Convert.IsDBNull(reader["id_activity"]))
                    {
                        res.Activity = new Activity();
                        res.Activity.ID = Convert.ToInt32(reader["id_activity"]);
                        res.Activity.Description = Convert.ToString(reader["description_activity"]);
                    }

                    if (!Convert.IsDBNull(reader["external_accountrecord"]))
                        res.ExternalId = Convert.ToInt32(reader["external_accountrecord"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public override object doGetAll(DbCommand command)
        {
            try
            {
                string query = getQuery();
                command.CommandText = query;

                DbDataReader reader = command.ExecuteReader();
                List<AccountRecord> res = (List<AccountRecord>)this.dataReaderToList(reader);
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public object doGetAllByClient(DbCommand command, Client client)
        {
            try
            {
                Client objVO = client;

                string where = " c.id_client = " + this.PARAMETERPREFIX + "id_client";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));


                DbDataReader reader = command.ExecuteReader();
                List<AccountRecord> res = (List<AccountRecord>)this.dataReaderToList(reader);
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }


        public override object doGet(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;

                string where = " c.id_accountrecord = " + this.PARAMETERPREFIX + "id_accountrecord";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_accountrecord", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                AccountRecord res = null;
                if (reader.Read())
                    res = (AccountRecord)this.dataReaderToObject(reader);
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }


        public object doGetByExternalId(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;

                string where = " c.external_accountrecord = " + this.PARAMETERPREFIX + "external_accountrecord";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_accountrecord", objVO.ExternalId, command));

                DbDataReader reader = command.ExecuteReader();
                AccountRecord res = null;
                if (reader.Read())
                    res = (AccountRecord)this.dataReaderToObject(reader);
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override bool doCheckIfExists(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;
                string where = " c.id_accountrecord = " + this.PARAMETERPREFIX + "id_accountrecord";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_accountrecord", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                bool res = reader.Read();
                reader.Close();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doAdd(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;
                string query = "insert into accountrecord "
                    + " (date_accountrecord, description_accountrecord, amount_accountrecord, reference_accountrecord, id_client, incoming_accountrecord, id_activity, external_accountrecord)"
                    + " values "
                    + " ({0}date_accountrecord, {0}description_accountrecord, {0}amount_accountrecord, {0}reference_accountrecord, {0}id_client, {0}incoming_accountrecord, {0}id_activity, {0}external_accountrecord)";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.INSERT);
            
                command.ExecuteNonQuery();
                return this.GetGeneratedIdentifier(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doUpdate(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;
                string query = "update accountrecord "
                    + "  set "
                    + "  date_accountrecord = {0}date_accountrecord"
                    + " ,description_accountrecord = {0}description_accountrecord"
                    + " ,amount_accountrecord = {0}amount_accountrecord"
                    + " ,reference_accountrecord = {0}reference_accountrecord"
                    + " ,id_client = {0}id_client"
                    + " ,incoming_accountrecord = {0}incoming_accountrecord"
                    + " ,id_activity = {0}id_activity"
                    + " ,external_accountrecord = {0}external_accountrecord"
                    + " where"
                    + " id_accountrecord = {0}id_accountrecord";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.UPDATE);

                command.ExecuteNonQuery();
                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }

        public override object doDelete(DbCommand command, object obj)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;
                string query = "delete from accountrecord "
                    + " where"
                    + " id_accountrecord = {0}id_accountrecord";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.DELETE);
            
                command.ExecuteNonQuery();
                return objVO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Parameters.Clear();
            }
        }
      
        protected override object dataReaderToList(DbDataReader reader)
        {
            try
            {
                System.Collections.Generic.List<AccountRecord> res = new System.Collections.Generic.List<AccountRecord>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((AccountRecord)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        protected override void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction)
        {
            try
            {
                AccountRecord objVO = (AccountRecord)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "amount_accountrecord", objVO.Amount, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "date_accountrecord", objVO.Date, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_accountrecord", objVO.Description, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "incoming_accountrecord", objVO.Incoming, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "reference_accountrecord", objVO.Reference, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_activity", objVO.Activity.ID, command));
                    if (objVO.ExternalId!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_accountrecord", objVO.ExternalId, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_accountrecord", Convert.DBNull, command));
                    
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_accountrecord", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_accountrecord", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
