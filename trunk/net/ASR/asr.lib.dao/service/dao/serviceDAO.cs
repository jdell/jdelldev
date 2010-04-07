using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.service.dao
{	
	internal class serviceDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from service c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by description_service asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Service res = null;
				if (reader!=null)
				{
                    res = new Service();
                    res.Price = Convert.ToSingle(reader["price_service"]);
                    res.Description= Convert.ToString(reader["description_service"]);
                    res.ID = Convert.ToInt32(reader["id_service"]);
                    if (!Convert.IsDBNull(reader["stateFee_service"])) res.StateFee = Convert.ToSingle(reader["stateFee_service"]);
                    if (!Convert.IsDBNull(reader["income_service"])) res.Income = Convert.ToBoolean(reader["income_service"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public List<Service> doGetAll(DbCommand command, bool income)
        {
            try
            {
                string where = " c.income_service = " + this.PARAMETERPREFIX + "income_service";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_service", income, command));

                DbDataReader reader = command.ExecuteReader();
                List<Service> res = (List<Service>)this.dataReaderToList(reader);
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

        public override object doGetAll(DbCommand command)
        {
            try
            {
                string query = getQuery();
                command.CommandText = query;

                DbDataReader reader = command.ExecuteReader();
                List<Service> res = (List<Service>)this.dataReaderToList(reader);
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
                Service objVO = (Service)obj;

                string where = " c.id_service = " + this.PARAMETERPREFIX + "id_service";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_service", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Service res = null;
                if (reader.Read())
                    res = (Service)this.dataReaderToObject(reader);
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
                Service objVO = (Service)obj;
                string where = " c.id_service = " + this.PARAMETERPREFIX + "id_service";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_service", objVO.ID, command));

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
                Service objVO = (Service)obj;
                string query = "insert into service "
                    + " (price_service, description_service, stateFee_service, income_service)"
                    + " values "
                    + " ({0}price_service, {0}description_service, {0}stateFee_service, {0}income_service)";

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
                Service objVO = (Service)obj;
                string query = "update service "
                    + "  set "
                    + "  price_service = {0}price_service"
                    + " ,description_service = {0}description_service"
                    + " ,stateFee_service = {0}stateFee_service"
                    + " ,income_service = {0}income_service"
                    + " where"
                    + " id_service = {0}id_service";

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
                Service objVO = (Service)obj;
                string query = "delete from service "
                    + " where"
                    + " id_service = {0}id_service";

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
                System.Collections.Generic.List<Service> res = new System.Collections.Generic.List<Service>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Service)dataReaderToObject(reader));
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
                Service objVO = (Service)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "price_service", objVO.Price, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "stateFee_service", objVO.StateFee, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_service", objVO.Description, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_service", objVO.Income, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_service", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_service", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
