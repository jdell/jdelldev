using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.payment.dao
{	
	internal class paymentDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from payment c"
                + " LEFT JOIN invoice i ON i.id_invoice=c.id_invoice";

            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by date_payment asc";
            
            return query;
        }
        public object doDeleteAll(DbCommand command, Invoice obj)
        {
            try
            {
                Invoice objVO = (Invoice)obj;
                string query = "delete from payment "
                    + " where"
                    + " id_invoice = {0}id_invoice";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));

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
      
        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Payment res = null;
				if (reader!=null)
				{
                    res = new Payment();
                    res.Amount = Convert.ToSingle(reader["amount_payment"]);
                    res.Date= Convert.ToDateTime(reader["date_payment"]);
                    res.ID = Convert.ToInt32(reader["id_payment"]);
                    if (!Convert.IsDBNull(reader["id_invoice"]))
                    {
                        res.Invoice = new Invoice();
                        res.Invoice.ID = Convert.ToInt32(reader["id_invoice"]);
                    }
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
                List<Payment> res = (List<Payment>)this.dataReaderToList(reader);
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

        public List<Payment> doGetAllByInvoice(DbCommand command, Invoice obj)
        {
            try
            {
                Invoice objVO = (Invoice)obj;

                string where = " c.id_invoice = " + this.PARAMETERPREFIX + "id_invoice";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Payment> res = (List<Payment>)this.dataReaderToList(reader);
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
                Payment objVO = (Payment)obj;

                string where = " c.id_payment = " + this.PARAMETERPREFIX + "id_payment";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payment", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Payment res = null;
                if (reader.Read())
                    res = (Payment)this.dataReaderToObject(reader);
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
                Payment objVO = (Payment)obj;
                string where = " c.id_payment = " + this.PARAMETERPREFIX + "id_payment";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payment", objVO.ID, command));

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
                Payment objVO = (Payment)obj;
                string query = "insert into payment "
                    + " (amount_payment, date_payment, id_invoice)"
                    + " values "
                    + " ({0}amount_payment, {0}date_payment, {0}id_invoice)";

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
                Payment objVO = (Payment)obj;
                string query = "update payment "
                    + "  set "
                    + "  amount_payment = {0}amount_payment"
                    + " ,date_payment = {0}date_payment"
                    + " ,id_invoice = {0}id_invoice"
                    + " where"
                    + " id_payment = {0}id_payment";

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
                Payment objVO = (Payment)obj;
                string query = "delete from payment "
                    + " where"
                    + " id_payment = {0}id_payment";

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
                System.Collections.Generic.List<Payment> res = new System.Collections.Generic.List<Payment>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Payment)dataReaderToObject(reader));
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
                Payment objVO = (Payment)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "amount_payment", objVO.Amount, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "date_payment", objVO.Date, command));
                    if (objVO.Invoice!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.Invoice.ID, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", Convert.DBNull, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payment", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_payment", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
