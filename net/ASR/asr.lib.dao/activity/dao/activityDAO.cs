using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.activity.dao
{	
	internal class activityDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from activity c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by description_activity asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Activity res = null;
				if (reader!=null)
				{
                    res = new Activity();
                    res.Description= Convert.ToString(reader["description_activity"]);
                    res.ID = Convert.ToInt32(reader["id_activity"]);
                    res.Income = Convert.ToBoolean(reader["income_activity"]);
                    if (!Convert.IsDBNull(reader["id_client"]))
                    {
                        res.Client = new Client();
                        res.Client.ID = Convert.ToInt32(reader["id_client"]);
                    }
                    if (!Convert.IsDBNull(reader["external_activity"]))
                        res.ExternalId =  Convert.ToInt32(reader["external_activity"]);
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
                List<Activity> res = (List<Activity>)this.dataReaderToList(reader);
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
                List<Activity> res = (List<Activity>)this.dataReaderToList(reader);
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
        public object doGetAllIncomes(DbCommand command, Client client, bool incomes)
        {
            try
            {
                string where = string.Format("c.id_client = {0}id_client and c.income_activity = {0}income_activity", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_activity", incomes, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", client.ID, command));


                DbDataReader reader = command.ExecuteReader();
                List<Activity> res = (List<Activity>)this.dataReaderToList(reader);
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
                Activity objVO = (Activity)obj;

                string where = " c.id_activity = " + this.PARAMETERPREFIX + "id_activity";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_activity", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Activity res = null;
                if (reader.Read())
                    res = (Activity)this.dataReaderToObject(reader);
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
                Activity objVO = (Activity)obj;

                string where = " c.external_activity = " + this.PARAMETERPREFIX + "external_activity";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_activity", objVO.ExternalId, command));

                DbDataReader reader = command.ExecuteReader();
                Activity res = null;
                if (reader.Read())
                    res = (Activity)this.dataReaderToObject(reader);
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

        public object doGetByDescription(DbCommand command, object obj)
        {
            try
            {
                Activity objVO = (Activity)obj;

                string where = " c.description_activity = " + this.PARAMETERPREFIX + "description_activity";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_activity", objVO.Description, command));

                DbDataReader reader = command.ExecuteReader();
                Activity res = null;
                if (reader.Read())
                    res = (Activity)this.dataReaderToObject(reader);
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
        public object doGetByDescriptionAndClient(DbCommand command, object obj)
        {
            try
            {
                Activity objVO = (Activity)obj;

                string where = string.Format("c.id_client = {0}id_client and c.description_activity = {0}description_activity", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_activity", objVO.Description, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Activity res = null;
                if (reader.Read())
                    res = (Activity)this.dataReaderToObject(reader);
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
                Activity objVO = (Activity)obj;
                string where = " c.id_activity = " + this.PARAMETERPREFIX + "id_activity";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_activity", objVO.ID, command));

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
                Activity objVO = (Activity)obj;
                string query = "insert into activity "
                    + " (description_activity, income_activity, id_client, external_activity)"
                    + " values "
                    + " ({0}description_activity, {0}income_activity, {0}id_client, {0}external_activity)";

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
                Activity objVO = (Activity)obj;
                string query = "update activity "
                    + "  set "
                    + "  income_activity = {0}income_activity"
                    + " ,description_activity = {0}description_activity"
                    + " ,id_client = {0}id_client"
                    + " ,external_activity = {0}external_activity"
                    + " where"
                    + " id_activity = {0}id_activity";

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
                Activity objVO = (Activity)obj;
                string query = "delete from activity "
                    + " where"
                    + " id_activity = {0}id_activity";

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
                System.Collections.Generic.List<Activity> res = new System.Collections.Generic.List<Activity>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Activity)dataReaderToObject(reader));
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
                Activity objVO = (Activity)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_activity", objVO.Description, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_activity", objVO.Income, command)); ;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command)); ;
             
                    if (objVO.ExternalId != null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_activity", objVO.ExternalId, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_activity", Convert.DBNull, command));
             
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_activity", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_activity", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
