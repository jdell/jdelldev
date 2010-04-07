using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.invoicedetail.dao
{	
	internal class invoicedetailDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from invoicedetail c"
                + " LEFT JOIN invoice inv ON c.id_invoice = inv.id_invoice"
                + " LEFT JOIN client cl ON inv.id_client = cl.id_client";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by date_invoice desc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				InvoiceDetail res = null;
				if (reader!=null)
				{
                    res = new InvoiceDetail();
                    res.Amount = Convert.ToInt32(reader["amount_invoicedetail"]);
                    res.Description = Convert.ToString(reader["description_invoicedetail"]);
                    res.Invoice = new Invoice();
                    res.Invoice.ID = Convert.ToInt32(reader["id_invoice"]);
                    if (!Convert.IsDBNull(reader["date_invoice"])) res.Invoice.Date = Convert.ToDateTime(reader["date_invoice"]);
                    if (!Convert.IsDBNull(reader["income_invoice"])) res.Invoice.Income = Convert.ToBoolean(reader["income_invoice"]);
                    if (!Convert.IsDBNull(reader["id_client"]))
				    {
                        res.Invoice.Client = new Client();
                        res.Invoice.Client.ID = Convert.ToInt32(reader["id_client"]);
                        if (!Convert.IsDBNull(reader["firstName_client"])) res.Invoice.Client.FirstName = Convert.ToString(reader["firstName_client"]);
                        if (!Convert.IsDBNull(reader["lastName_client"])) res.Invoice.Client.LastName= Convert.ToString(reader["lastName_client"]);
                    }
                    res.Price = Convert.ToSingle(reader["price_invoicedetail"]);
                    if (!Convert.IsDBNull(reader["stateFee_invoicedetail"])) res.StateFee = Convert.ToSingle(reader["stateFee_invoicedetail"]);
                    res.Service = new Service();
                    res.Service.ID = Convert.ToInt32(reader["id_service"]);
                    res.ID = Convert.ToInt32(reader["id_invoicedetail"]);
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
                List<InvoiceDetail> res = (List<InvoiceDetail>)this.dataReaderToList(reader);
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

        public List<InvoiceDetail> doGetAllByInvoice(DbCommand command, Invoice obj)
        {
            try
            {
                Invoice objVO = (Invoice)obj;

                string where = " c.id_invoice = " + this.PARAMETERPREFIX + "id_invoice";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<InvoiceDetail> res = (List<InvoiceDetail>)this.dataReaderToList(reader);
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
                InvoiceDetail objVO = (InvoiceDetail)obj;

                string where = " c.id_invoicedetail = " + this.PARAMETERPREFIX + "id_invoicedetail";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoicedetail", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                InvoiceDetail res = null;
                if (reader.Read())
                    res = (InvoiceDetail)this.dataReaderToObject(reader);
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
                InvoiceDetail objVO = (InvoiceDetail)obj;
                string where = " c.id_invoicedetail = " + this.PARAMETERPREFIX + "id_invoicedetail";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoicedetail", objVO.ID, command));

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
                InvoiceDetail objVO = (InvoiceDetail)obj;
                string query = "insert into invoicedetail "
                    + " (amount_invoicedetail, description_invoicedetail, id_invoice, price_invoicedetail, id_service, stateFee_invoicedetail)"
                    + " values "
                    + " ({0}amount_invoicedetail, {0}description_invoicedetail, {0}id_invoice, {0}price_invoicedetail, {0}id_service, {0}stateFee_invoicedetail)";

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
                InvoiceDetail objVO = (InvoiceDetail)obj;
                string query = "update invoicedetail "
                    + "  set "
                    + "  amount_invoicedetail = {0}amount_invoicedetail"
                    + " ,description_invoicedetail = {0}description_invoicedetail"
                    + " ,id_invoice = {0}id_invoice"
                    + " ,price_invoicedetail = {0}price_invoicedetail"
                    + " ,id_service = {0}id_service"
                    + " ,stateFee_invoicedetail = {0}stateFee_invoicedetail"
                    + " where"
                    + " id_invoicedetail = {0}id_invoicedetail";

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
                InvoiceDetail objVO = (InvoiceDetail)obj;
                string query = "delete from invoicedetail "
                    + " where"
                    + " id_invoicedetail = {0}id_invoicedetail";

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
        public object doDeleteAll(DbCommand command, Invoice obj)
        {
            try
            {
                Invoice objVO = (Invoice)obj;
                string query = "delete from invoicedetail "
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
      
        protected override object dataReaderToList(DbDataReader reader)
        {
            try
            {
                System.Collections.Generic.List<InvoiceDetail> res = new System.Collections.Generic.List<InvoiceDetail>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((InvoiceDetail)dataReaderToObject(reader));
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
                InvoiceDetail objVO = (InvoiceDetail)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "amount_invoicedetail", objVO.Amount, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "description_invoicedetail", objVO.Description, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoice", objVO.Invoice.ID, command));;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "price_invoicedetail", objVO.Price, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_service", objVO.Service.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "stateFee_invoicedetail", objVO.StateFee, command));
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoicedetail", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_invoicedetail", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
