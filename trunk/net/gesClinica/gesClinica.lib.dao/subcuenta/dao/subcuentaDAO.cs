using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.subcuenta.dao
{	
	internal class subcuentaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from subcuenta e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by codigo_subcuenta, descripcion_subcuenta";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				SubCuenta res = null;
				if (reader!=null)
				{
                    res = new SubCuenta();
                    res.Bloqueada = Convert.ToBoolean(reader["bloqueada_subcuenta"]);
                    res.Codigo = Convert.ToString(reader["codigo_subcuenta"]);
                    res.ContraPartida = new SubCuenta();
                    res.ContraPartida.Codigo= Convert.ToString(reader["contrapartida_subcuenta"]);
                    res.Descripcion= Convert.ToString(reader["descripcion_subcuenta"]);
                    res.Haber= Convert.ToBoolean(reader["haber_subcuenta"]);
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
                List<SubCuenta> res = (List<SubCuenta>)this.dataReaderToList(reader);
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
        public List<SubCuenta> doGetAll(DbCommand command, List<String> lista)
        {
            try
            {
                string where = "(1=1)";
                if (lista != null)
                {
                    where += " AND ((1=0) ";
                    foreach (string codigo in lista)
                    {
                        where += string.Format(" OR (codigo_subcuenta like '{0}%') ",codigo);
                    }
                    where += " )";
                }

                where += string.Format(" AND bloqueada_subcuenta = {0}bloqueada_subcuenta", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "bloqueada_subcuenta", false, command));

                DbDataReader reader = command.ExecuteReader();
                List<SubCuenta> res = (List<SubCuenta>)this.dataReaderToList(reader);
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
                SubCuenta objVO = (SubCuenta)obj;

                string where = " codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));

                DbDataReader reader = command.ExecuteReader();
                SubCuenta res = null;
                if (reader.Read())
                    res = (SubCuenta)this.dataReaderToObject(reader);
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
                SubCuenta objVO = (SubCuenta)obj;
                string where = " codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));

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
                SubCuenta objVO = (SubCuenta)obj;
                string query = "insert into subcuenta "
                    + " (bloqueada_subcuenta, codigo_subcuenta, contrapartida_subcuenta, descripcion_subcuenta, haber_subcuenta)"
                    + " values "
                    + string.Format("({0}bloqueada_subcuenta, {0}codigo_subcuenta, {0}contrapartida_subcuenta, {0}descripcion_subcuenta, {0}haber_subcuenta)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "bloqueada_subcuenta", objVO.Bloqueada, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));
                if (objVO.ContraPartida!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_subcuenta", objVO.ContraPartida.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_subcuenta", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_subcuenta", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "haber_subcuenta", objVO.Haber, command));
                
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

        public override object doUpdate(DbCommand command, object obj)
        {
            try
            {
                SubCuenta objVO = (SubCuenta)obj;
                string query = "update subcuenta "
                    + "  set "
                    + "  bloqueada_subcuenta = " + this.PARAMETERPREFIX + "bloqueada_subcuenta"
                    + " ,contrapartida_subcuenta = " + this.PARAMETERPREFIX + "contrapartida_subcuenta"
                    + " ,descripcion_subcuenta = " + this.PARAMETERPREFIX + "descripcion_subcuenta"
                    + " ,haber_subcuenta = " + this.PARAMETERPREFIX + "haber_subcuenta"
                    + " where"
                    + " codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "bloqueada_subcuenta", objVO.Bloqueada, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));
                if (objVO.ContraPartida != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_subcuenta", objVO.ContraPartida.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_subcuenta", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_subcuenta", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "haber_subcuenta", objVO.Haber, command));
           
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
                SubCuenta objVO = (SubCuenta)obj;
                string query = "delete from subcuenta "
                    + " where"
                    + " codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));

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
                System.Collections.Generic.List<SubCuenta> res = new System.Collections.Generic.List<SubCuenta>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((SubCuenta)dataReaderToObject(reader));
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
