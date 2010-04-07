using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.task.dao
{	
	internal class taskDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from task c"
                + " LEFT JOIN staff s ON s.id_staff=c.id_staff";

            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by priority_task asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Task res = null;
				if (reader!=null)
				{
                    res = new Task();
                    res.Completed = Convert.ToBoolean(reader["completed_task"]);
                    res.Description= Convert.ToString(reader["description_task"]);
                    res.ID = Convert.ToInt32(reader["id_task"]);
                    res.Priority= Convert.ToBoolean(reader["priority_task"]);
                    if (!Convert.IsDBNull(reader["id_staff"]))
                    {
                        res.Staff = new Staff();
                        res.Staff.ID = Convert.ToInt32(reader["id_staff"]);
                        res.Staff.Name = Convert.ToString(reader["name_staff"]);
                        if (!Convert.IsDBNull(reader["phone_staff"])) res.Staff.Phone = Convert.ToString(reader["phone_staff"]);
                    }
                    if (!Convert.IsDBNull(reader["date_task"])) res.Date = Convert.ToDateTime(reader["date_task"]);
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
                List<Task> res = (List<Task>)this.dataReaderToList(reader);
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
                Task objVO = (Task)obj;

                string where = " c.id_task = " + this.PARAMETERPREFIX + "id_task";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_task", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Task res = null;
                if (reader.Read())
                    res = (Task)this.dataReaderToObject(reader);
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
                Task objVO = (Task)obj;
                string where = " c.id_task = " + this.PARAMETERPREFIX + "id_task";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_task", objVO.ID, command));

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
                Task objVO = (Task)obj;
                string query = "insert into task "
                    + " (completed_task, description_task, priority_task, date_task, id_staff)"
                    + " values "
                    + " ({0}completed_task, {0}description_task, {0}priority_task, {0}date_task, {0}id_staff)";

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
                Task objVO = (Task)obj;
                string query = "update task "
                    + "  set "
                    + "  completed_task = {0}completed_task"
                    + " ,description_task = {0}description_task"
                    + " ,priority_task = {0}priority_task"
                    + " ,date_task = {0}date_task"
                    + " ,id_staff = {0}id_staff"
                    + " where"
                    + " id_task = {0}id_task";

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
                Task objVO = (Task)obj;
                string query = "delete from task "
                    + " where"
                    + " id_task = {0}id_task";

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
                System.Collections.Generic.List<Task> res = new System.Collections.Generic.List<Task>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Task)dataReaderToObject(reader));
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
                Task objVO = (Task)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "completed_task", objVO.Completed, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_task", objVO.Description, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "priority_task", objVO.Priority, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "date_task", objVO.Date, command));
                    if (objVO.Staff!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_staff", objVO.Staff.ID, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_staff", Convert.DBNull, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_task", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_task", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
