using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.message.dao
{	
	internal class messageDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from message c"
                + " LEFT JOIN staff st ON c.id_staff = st.id_staff";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by date_message asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Message res = null;
				if (reader!=null)
				{
                    res = new Message();
                    res.CalledToSeeYou = Convert.ToBoolean(reader["calledToSeeYou_message"]);
                    res.Date = Convert.ToDateTime(reader["date_message"]);
                    res.From = Convert.ToString(reader["from_message"]);
                    res.Of= Convert.ToString(reader["of_message"]);
                    res.Phone= Convert.ToString(reader["phone_message"]);
                    res.PleaseCall= Convert.ToBoolean(reader["pleaseCall_message"]);
                    res.ReturnedYourCall= Convert.ToBoolean(reader["returnedYourCall_message"]);
                    res.Telephoned = Convert.ToBoolean(reader["telephoned_message"]);
                    res.Text = Convert.ToString(reader["text_message"]);
                    res.Urgent = Convert.ToBoolean(reader["urgent_message"]);
                    res.VisitedYourOffice= Convert.ToBoolean(reader["visitedYourOffice_message"]);
                    res.WantsToSeeYou= Convert.ToBoolean(reader["wantsToSeeYou_message"]);
                    res.WillCallAgain= Convert.ToBoolean(reader["willCallAgain_message"]);
                    res.ID = Convert.ToInt32(reader["id_message"]);

                    res.Staff = new Staff();
                    res.Staff.ID = Convert.ToInt32(reader["id_staff"]);
                    res.Staff.Name = Convert.ToString(reader["name_staff"]);
                    if (!Convert.IsDBNull(reader["phone_staff"])) res.Staff.Phone = Convert.ToString(reader["phone_staff"]);

                    res.Checked = Convert.ToBoolean(reader["checked_message"]);
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
                List<Message> res = (List<Message>)this.dataReaderToList(reader);
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
                Message objVO = (Message)obj;

                string where = " c.id_message = " + this.PARAMETERPREFIX + "id_message";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_message", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Message res = null;
                if (reader.Read())
                    res = (Message)this.dataReaderToObject(reader);
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
                Message objVO = (Message)obj;
                string where = " c.id_message = " + this.PARAMETERPREFIX + "id_message";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_message", objVO.ID, command));

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
                Message objVO = (Message)obj;
                string query = "insert into message "
                    + " (calledToSeeYou_message, date_message, from_message, of_message, phone_message, pleaseCall_message, returnedYourCall_message, telephoned_message, text_message, urgent_message, visitedYourOffice_message, wantsToSeeYou_message, willCallAgain_message, id_staff, checked_message)"
                    + " values "
                    + " ({0}calledToSeeYou_message, {0}date_message, {0}from_message, {0}of_message, {0}phone_message, {0}pleaseCall_message, {0}returnedYourCall_message, {0}telephoned_message, {0}text_message, {0}urgent_message, {0}visitedYourOffice_message, {0}wantsToSeeYou_message, {0}willCallAgain_message, {0}id_staff, {0}checked_message)";

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
                Message objVO = (Message)obj;
                string query = "update message "
                    + "  set "
                    + "  date_message = {0}date_message"
                    + " ,from_message = {0}from_message"
                    + " ,of_message = {0}of_message"
                    + " ,phone_message = {0}phone_message"
                    + " ,pleaseCall_message = {0}pleaseCall_message"
                    + " ,returnedYourCall_message = {0}returnedYourCall_message"
                    + " ,calledToSeeYou_message = {0}calledToSeeYou_message"
                    + " ,telephoned_message = {0}telephoned_message"
                    + " ,text_message = {0}text_message"
                    + " ,urgent_message = {0}urgent_message"
                    + " ,visitedYourOffice_message = {0}visitedYourOffice_message"
                    + " ,wantsToSeeYou_message = {0}wantsToSeeYou_message"
                    + " ,willCallAgain_message = {0}willCallAgain_message"
                    + " ,id_staff = {0}id_staff"
                    + " ,checked_message = {0}checked_message"
                    + " where"
                    + " id_message = {0}id_message";

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
                Message objVO = (Message)obj;
                string query = "delete from message "
                    + " where"
                    + " id_message = {0}id_message";

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
                System.Collections.Generic.List<Message> res = new System.Collections.Generic.List<Message>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Message)dataReaderToObject(reader));
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
                Message objVO = (Message)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "calledToSeeYou_message", objVO.CalledToSeeYou, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "date_message", objVO.Date, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "from_message", objVO.From, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "of_message", objVO.Of, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "phone_message", objVO.Phone, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "pleaseCall_message", objVO.PleaseCall, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "returnedYourCall_message", objVO.ReturnedYourCall, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "telephoned_message", objVO.Telephoned, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "text_message", objVO.Text, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "urgent_message", objVO.Urgent, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "visitedYourOffice_message", objVO.VisitedYourOffice, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "wantsToSeeYou_message", objVO.WantsToSeeYou, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "willCallAgain_message", objVO.WillCallAgain, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "checked_message", objVO.Checked, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_staff", objVO.Staff.ID, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_message", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_message", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
