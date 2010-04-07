using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.contador.dao
{
    [Obsolete("Obsoleto debido al cross que hay entre gestión y contabilidad.", true)]
	internal class contadorDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from contador e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Contador res = null;
				if (reader!=null)
				{
                    res = new Contador();
                    res.Año= Convert.ToInt32(reader["ano_contador"]);
                    res.Empresa = new Empresa();
                    res.Empresa.ID= Convert.ToInt32(reader["id_empresa"]);
                    res.ID= Convert.ToInt32(reader["id_contador"]);
                    res.Numero= Convert.ToInt32(reader["numero_contador"]);
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
                List<Contador> res = (List<Contador>)this.dataReaderToList(reader);
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

        public List<Contador> doGetAll(DbCommand command, Empresa empresa)
        {
            try
            {
                string where = " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));
             
                DbDataReader reader = command.ExecuteReader();
                List<Contador> res = (List<Contador>)this.dataReaderToList(reader);
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
                Contador objVO = (Contador)obj;

                //string where = " id_contador = " + this.PARAMETERPREFIX + "id_contador";
                //string query = getQuery(where);
                //command.CommandText = query;
                //command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_contador", objVO.ID, command));

                string where = " ano_contador = " + this.PARAMETERPREFIX + "ano_contador "
                + " AND "
                + " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ano_contador", objVO.Año, command));
                
                DbDataReader reader = command.ExecuteReader();
                Contador res = null;
                if (reader.Read())
                    res = (Contador)this.dataReaderToObject(reader);
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
                Contador objVO = (Contador)obj;
                string where = " ano_contador = " + this.PARAMETERPREFIX + "ano_contador "
                + " AND "
                + " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ano_contador", objVO.Año, command));

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
                Contador objVO = (Contador)obj;
                string query = "insert into contador "
                    + " (ano_contador, id_empresa, numero_contador)"
                    + " values "
                    + string.Format("({0}ano_contador, {0}id_empresa, {0}numero_contador)", this.PARAMETERPREFIX);
                    

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ano_contador", objVO.Año, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_contador", objVO.Numero, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

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
                Contador objVO = (Contador)obj;
                string query = "update contador "
                    + "  set "
                    + "  ano_contador = " + this.PARAMETERPREFIX + "ano_contador"
                    + " ,id_empresa = " + this.PARAMETERPREFIX + "id_empresa"
                    + " ,numero_contador = " + this.PARAMETERPREFIX + "numero_contador"
                    + " where"
                    + " id_contador = " + this.PARAMETERPREFIX + "id_contador";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ano_contador", objVO.Año, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_contador", objVO.Numero, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_contador", objVO.ID, command));

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
                Contador objVO = (Contador)obj;
                string query = "delete from contador "
                    + " where"
                    + " id_contador = " + this.PARAMETERPREFIX + "id_contador";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_contador", objVO.ID, command));

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
                System.Collections.Generic.List<Contador> res = new System.Collections.Generic.List<Contador>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Contador)dataReaderToObject(reader));
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
