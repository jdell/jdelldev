using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.customer.dao
{	
	internal class customerDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from customer c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by name_customer asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Customer res = null;
				if (reader!=null)
				{
                    res = new Customer();
                    res.Address = Convert.ToString(reader["address_customer"]);
                    res.Fax = Convert.ToString(reader["fax_customer"]);
                    res.ID = Convert.ToInt32(reader["id_customer"]);
                    res.Name = Convert.ToString(reader["name_customer"]);
                    res.Phone = Convert.ToString(reader["phone_customer"]);

                    res.City = Convert.ToString(reader["city_customer"]);
                    res.State = Convert.ToString(reader["state_customer"]);
                    res.ZipCode = Convert.ToString(reader["zipCode_customer"]);
                    if (Convert.IsDBNull(reader["active_customer"])) res.Active = Convert.ToBoolean(reader["active_customer"]);
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
                List<Customer> res = (List<Customer>)this.dataReaderToList(reader);
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
                Customer objVO = (Customer)obj;

                string where = " c.id_customer = " + this.PARAMETERPREFIX + "id_customer";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Customer res = null;
                if (reader.Read())
                    res = (Customer)this.dataReaderToObject(reader);
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
                Customer objVO = (Customer)obj;
                string where = " c.id_customer = " + this.PARAMETERPREFIX + "id_customer";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.ID, command));

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
                Customer objVO = (Customer)obj;
                string query = "insert into customer "
                    + " (name_customer, address_customer, phone_customer, fax_customer, city_customer, state_customer, zipCode_customer, active_customer)"
                    + " values "
                    + " ({0}name_customer, {0}address_customer, {0}phone_customer, {0}fax_customer, {0}city_customer, {0}state_customer, {0}zipCode_customer, {0}active_customer)";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.INSERT);
            
                command.ExecuteNonQuery();
                //long res = Convert.ToInt32(command.Parameters["" + this.PARAMETERPREFIX + "id"].Value);
                //return res;
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
                Customer objVO = (Customer)obj;
                string query = "update customer "
                    + "  set "
                    + "  name_customer = {0}name_customer"
                    + " ,address_customer = {0}address_customer"
                    + " ,phone_customer = {0}phone_customer"
                    + " ,fax_customer = {0}fax_customer"
                    + " ,city_customer = {0}city_customer"
                    + " ,state_customer = {0}state_customer"
                    + " ,zipCode_customer = {0}zipCode_customer"
                    + " ,active_customer = {0}active_customer"
                    + " where"
                    + " id_customer = {0}id_customer";

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
                Customer objVO = (Customer)obj;
                string query = "delete from customer "
                    + " where"
                    + " id_customer = {0}id_customer";

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
                System.Collections.Generic.List<Customer> res = new System.Collections.Generic.List<Customer>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Customer)dataReaderToObject(reader));
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
                Customer objVO = (Customer)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "name_customer", objVO.Name, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "address_customer", objVO.Address, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "phone_customer", objVO.Phone, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax_customer", objVO.Fax, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "city_customer", objVO.City, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "state_customer", objVO.State, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "zipCode_customer", objVO.ZipCode, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "active_customer", objVO.Active, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
