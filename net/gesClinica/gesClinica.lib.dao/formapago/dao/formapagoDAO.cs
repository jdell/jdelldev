using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.formapago.dao
{	
	internal class formapagoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from formapago e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_formapago asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				FormaPago res = null;
				if (reader!=null)
				{
                    res = new FormaPago();
                    res.Descripcion = Convert.ToString(reader["descripcion_formapago"]);
                    res.ID= Convert.ToInt32(reader["id_formapago"]);
                    if (!Convert.IsDBNull(reader["facturar_formapago"])) res.Facturar = Convert.ToBoolean(reader["facturar_formapago"]);
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
                List<FormaPago> res = (List<FormaPago>)this.dataReaderToList(reader);
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
                FormaPago objVO = (FormaPago)obj;

                string where = " id_formapago = " + this.PARAMETERPREFIX + "id_formapago";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                FormaPago res = null;
                if (reader.Read())
                    res = (FormaPago)this.dataReaderToObject(reader);
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
                FormaPago objVO = (FormaPago)obj;
                string where = " id_formapago = " + this.PARAMETERPREFIX + "id_formapago";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.ID, command));

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
                FormaPago objVO = (FormaPago)obj;
                string query = "insert into formapago "
                    + " (descripcion_formapago, facturar_formapago)"
                    + " values "
                    + string.Format(" ({0}descripcion_formapago, {0}facturar_formapago)", this.PARAMETERPREFIX);
                   // + "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_formapago", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturar_formapago", objVO.Facturar, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

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
                FormaPago objVO = (FormaPago)obj;
                string query = "update formapago "
                    + "  set "
                    + "  descripcion_formapago = " + this.PARAMETERPREFIX + "descripcion_formapago"
                    + " ,facturar_formapago = " + this.PARAMETERPREFIX + "facturar_formapago "
                    + " where"
                    + " id_formapago = " + this.PARAMETERPREFIX + "id_formapago";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_formapago", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturar_formapago", objVO.Facturar, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.ID, command));

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
                FormaPago objVO = (FormaPago)obj;
                string query = "delete from formapago "
                    + " where"
                    + " id_formapago = " + this.PARAMETERPREFIX + "id_formapago";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.ID, command));

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
                System.Collections.Generic.List<FormaPago> res = new System.Collections.Generic.List<FormaPago>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((FormaPago)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }
    }
}
