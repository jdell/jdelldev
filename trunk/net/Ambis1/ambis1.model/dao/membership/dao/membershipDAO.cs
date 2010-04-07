using System;
using System.Data.Common;
using ambis1.model.dao._template;
using ambis1.model.vo;
using System.Collections.Generic;

namespace ambis1.model.dao.membership.dao
{	
	internal class membershipDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from membership c"
                + " left join member m ON c.id_member = m.id_member";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by id_membership desc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Membership res = null;
				if (reader!=null)
				{
                    res = new Membership();
                    res.Active = Convert.ToBoolean(reader["active_membership"]);
                    res.CreationDate = Convert.ToDateTime(reader["creationdate_membership"]);
                    res.FromDate = Convert.ToDateTime(reader["fromdate_membership"]);
                    res.ID = Convert.ToInt32(reader["id_membership"]);
                    res.Member = Member.getNewMember(Member.TypeFromName(Convert.ToString(reader["type_member"])));
                    res.Member.ID = Convert.ToInt32(reader["id_member"]);
                    res.Member.LastName = Convert.ToString(reader["lastName_member"]);
                    res.Member.MiddleName= Convert.ToString(reader["middleName_member"]);
                    res.Member.FirstName = Convert.ToString(reader["firstName_member"]);
                    res.Member.Number = Convert.ToInt32(reader["number_member"]);
                    
                    res.NumOfMonths = Convert.ToInt32(reader["numofmonths_membership"]);
                    res.Price= Convert.ToSingle(reader["price_membership"]);
                    res.TypeOfMembership = new TypeOfMembership();
                    res.TypeOfMembership.ID= Convert.ToInt32(reader["id_typeofmembership"]);

                    if (!Convert.IsDBNull(reader["paid_membership"])) res.Paid = Convert.ToBoolean(reader["paid_membership"]);
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
                List<Membership> res = (List<Membership>)this.dataReaderToList(reader);
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
                Membership objVO = (Membership)obj;

                string where = " c.id_membership = " + this.PARAMETERPREFIX + "id_membership";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_membership", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Membership res = null;
                if (reader.Read())
                    res = (Membership)this.dataReaderToObject(reader);
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
        public object doGetByMember(DbCommand command, Member obj)
        {
            try
            {
                //TODO: CORREGIR!! (Order By)
                Member objVO = (Member)obj;

                string where = " c.id_member = " + this.PARAMETERPREFIX + "id_member";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Membership res = null;
                if (reader.Read())
                    res = (Membership)this.dataReaderToObject(reader);
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
                Membership objVO = (Membership)obj;
                string where = " c.id_membership = " + this.PARAMETERPREFIX + "id_membership";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_membership", objVO.ID, command));

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
                Membership objVO = (Membership)obj;
                string query = "insert into membership "
                    + " (paid_membership, active_membership, id_typeofmembership, id_member, creationdate_membership, fromdate_membership, numofmonths_membership, price_membership)"
                    + " values "
                    + " ({0}paid_membership, {0}active_membership, {0}id_typeofmembership, {0}id_member, {0}creationdate_membership, {0}fromdate_membership, {0}numofmonths_membership, {0}price_membership)";

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
                Membership objVO = (Membership)obj;
                string query = "update membership "
                    + "  set "
                    + "  id_typeofmembership = {0}id_typeofmembership"
                    + " ,id_member = {0}id_member"
                   // + " ,creationdate_membership = {0}creationdate_membership"
                    + " ,fromdate_membership = {0}fromdate_membership"
                    + " ,numofmonths_membership = {0}numofmonths_membership"
                    + " ,price_membership = {0}price_membership"
                    + " ,active_membership = {0}active_membership"
                    + " ,paid_membership = {0}paid_membership"
                    + " where"
                    + " id_membership = {0}id_membership";

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
                Membership objVO = (Membership)obj;
                string query = "delete from membership "
                    + " where"
                    + " id_membership = {0}id_membership";

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
                System.Collections.Generic.List<Membership> res = new System.Collections.Generic.List<Membership>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Membership)dataReaderToObject(reader));
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
                Membership objVO = (Membership)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "active_membership", objVO.Active, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "creationdate_membership", objVO.CreationDate, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fromdate_membership", objVO.FromDate, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.Member.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numofmonths_membership", objVO.NumOfMonths, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "price_membership", objVO.Price, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_typeofmembership", objVO.TypeOfMembership.ID, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "paid_membership", objVO.Paid, command));

                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_membership", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_membership", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
