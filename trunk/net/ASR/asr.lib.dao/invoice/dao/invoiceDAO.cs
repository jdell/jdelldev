using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.invoice.dao
{	
	internal class invoiceDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from invoice c"
                + " LEFT JOIN client cl ON c.id_client = cl.id_client"
                + " LEFT JOIN payable pay ON c.id_payable = pay.id_payable"
                + " LEFT JOIN serie ser ON c.id_serie = ser.id_serie";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by date_invoice asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Invoice res = null;
				if (reader!=null)
				{
                    res = new Invoice();
                    if (!Convert.IsDBNull(reader["id_client"]))
                    {
                        res.Client = new Client();
                        res.Client.ID = Convert.ToInt32(reader["id_client"]);
                        res.Client.FirstName = Convert.ToString(reader["firstName_client"]);
                        res.Client.LastName = Convert.ToString(reader["lastName_client"]);
                        res.Client.HomeAddress = Convert.ToString(reader["homeAddress_client"]);
                        res.Client.HomeCity = Convert.ToString(reader["homeCity_client"]);
                        res.Client.HomeState = Convert.ToString(reader["homeState_client"]);
                        res.Client.HomeZipCode = Convert.ToString(reader["homeZipCode_client"]);
                    }
                    res.Comment = Convert.ToString(reader["comment_invoice"]);
                    res.Date = Convert.ToDateTime(reader["date_invoice"]);
                    res.ID = Convert.ToInt32(reader["id_invoice"]);

                    if (!Convert.IsDBNull(reader["id_payable"]))
                    {
                        res.Payable = new Payable();
                        res.Payable.ID = Convert.ToInt32(reader["id_payable"]); ;
                        res.Payable.Description= Convert.ToString(reader["description_payable"]);
                    }
                    if (!Convert.IsDBNull(reader["pending_invoice"])) res.Pending= Convert.ToBoolean(reader["pending_invoice"]); ;
                    if (!Convert.IsDBNull(reader["number_invoice"])) res.Number= Convert.ToInt32(reader["number_invoice"]); ;

                    if (!Convert.IsDBNull(reader["id_serie"]))
                    {
                        res.Serie = new Serie();
                        res.Serie.ID = Convert.ToInt32(reader["id_serie"]); ;
                        res.Serie.Description = Convert.ToString(reader["description_serie"]);
                    }

                    if (!Convert.IsDBNull(reader["income_invoice"])) res.Income= Convert.ToBoolean(reader["income_invoice"]); ;
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
                List<Invoice> res = (List<Invoice>)this.dataReaderToList(reader);
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


        public List<Invoice> doGetAll(DbCommand command, bool income)
        {
            try
            {
                string where = " c.income_invoice = " + this.PARAMETERPREFIX + "income_invoice";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_invoice", income, command));

                DbDataReader reader = command.ExecuteReader();
                List<Invoice> res = (List<Invoice>)this.dataReaderToList(reader);
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
                Invoice objVO = (Invoice)obj;

                string where = " c.id_invoice = " + this.PARAMETERPREFIX + "id_invoice";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Invoice res = null;
                if (reader.Read())
                    res = (Invoice)this.dataReaderToObject(reader);
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
                Invoice objVO = (Invoice)obj;
                string where = " c.id_invoice = " + this.PARAMETERPREFIX + "id_invoice";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));

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
                Invoice objVO = (Invoice)obj;
                string query = "insert into invoice "
                    + " (date_invoice, id_client, comment_invoice, pending_invoice, id_payable, number_invoice, id_serie, income_invoice)"
                    + " values "
                    + " ({0}date_invoice, {0}id_client, {0}comment_invoice, {0}pending_invoice, {0}id_payable, {0}number_invoice, {0}id_serie, {0}income_invoice)";

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
                Invoice objVO = (Invoice)obj;
                string query = "update invoice "
                    + "  set "
                    + "  date_invoice = {0}date_invoice"
                    + " ,id_client = {0}id_client"
                    + " ,comment_invoice = {0}comment_invoice"
                    + " ,pending_invoice = {0}pending_invoice"
                    + " ,id_payable = {0}id_payable"
                    + " ,number_invoice = {0}number_invoice"
                    + " ,id_serie = {0}id_serie"
                    + " ,income_invoice = {0}income_invoice"
                    + " where"
                    + " id_invoice = {0}id_invoice";

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
                Invoice objVO = (Invoice)obj;
                string query = "delete from invoice "
                    + " where"
                    + " id_invoice = {0}id_invoice";

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
                System.Collections.Generic.List<Invoice> res = new System.Collections.Generic.List<Invoice>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Invoice)dataReaderToObject(reader));
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
                Invoice objVO = (Invoice)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "date_invoice", objVO.Date, command));
                    if (objVO.Client!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", Convert.DBNull, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "comment_invoice", objVO.Comment, command)); 
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "number_invoice", objVO.Number, command));
                    if (objVO.Serie != null) 
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_serie", objVO.Serie.ID, command)); 
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_serie", Convert.DBNull, command)); 

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "income_invoice", objVO.Income, command)); 

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "pending_invoice", objVO.Pending, command)); 

                    if (objVO.Payable!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payable", objVO.Payable.ID, command)); 
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payable", Convert.DBNull, command)); 

                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
