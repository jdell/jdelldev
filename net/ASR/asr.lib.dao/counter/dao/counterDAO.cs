using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.counter.dao
{	
	internal class counterDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from counter c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by year_counter asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Counter res = null;
				if (reader!=null)
				{
                    res = new Counter();
                    res.ID = Convert.ToInt32(reader["id_counter"]);
                    res.Number = Convert.ToInt32(reader["number_counter"]);
                    res.Serie = new Serie();
                    res.Serie.ID = Convert.ToInt32(reader["id_serie"]);
                    res.Year = Convert.ToInt32(reader["year_counter"]);
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
                List<Counter> res = (List<Counter>)this.dataReaderToList(reader);
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
                Counter objVO = (Counter)obj;

                string where = " c.id_counter = " + this.PARAMETERPREFIX + "id_counter";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_counter", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Counter res = null;
                if (reader.Read())
                    res = (Counter)this.dataReaderToObject(reader);
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

        public object doGetByYearAndSerie(DbCommand command, object obj)
        {
            try
            {
                Counter objVO = (Counter)obj;

                string where = string.Format("c.year_counter = {0}year_counter AND c.id_serie = {0}id_serie", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "year_counter", objVO.Year, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_serie", objVO.Serie.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Counter res = null;
                if (reader.Read())
                    res = (Counter)this.dataReaderToObject(reader);
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
                Counter objVO = (Counter)obj;
                string where = " c.id_counter = " + this.PARAMETERPREFIX + "id_counter";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_counter", objVO.ID, command));

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
                Counter objVO = (Counter)obj;
                string query = "insert into counter "
                    + " (year_counter, number_counter, id_serie)"
                    + " values "
                    + " ({0}year_counter, {0}number_counter, {0}id_serie)";

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
                Counter objVO = (Counter)obj;
                string query = "update counter "
                    + "  set "
                    + " year_counter = {0}year_counter"
                    + ",number_counter = {0}number_counter"
                    + ",id_serie = {0}id_serie"
                    + " where"
                    + " id_counter = {0}id_counter";

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
                Counter objVO = (Counter)obj;
                string query = "delete from counter "
                    + " where"
                    + " id_counter = {0}id_counter";

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
                System.Collections.Generic.List<Counter> res = new System.Collections.Generic.List<Counter>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Counter)dataReaderToObject(reader));
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
                Counter objVO = (Counter)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "year_counter", objVO.Year, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "number_counter", objVO.Number, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_serie", objVO.Serie.ID, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_counter", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_counter", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
