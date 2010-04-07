using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tipooperacion.dao
{	
	internal class tipooperacionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tipooperacion e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoOperacion res = null;
				if (reader!=null)
				{
                    res = new TipoOperacion();
                    res.Facturable = Convert.ToBoolean(reader["facturable_tipooperacion"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_tipooperacion"]);
                    res.ID= Convert.ToInt32(reader["id_tipooperacion"]);
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
                List<TipoOperacion> res = (List<TipoOperacion>)this.dataReaderToList(reader);
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
                TipoOperacion objVO = (TipoOperacion)obj;

                string where = " id_tipooperacion = " + this.PARAMETERPREFIX + "id_tipooperacion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipooperacion", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoOperacion res = null;
                if (reader.Read())
                    res = (TipoOperacion)this.dataReaderToObject(reader);
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
                TipoOperacion objVO = (TipoOperacion)obj;
                string where = " id_tipooperacion = " + this.PARAMETERPREFIX + "id_tipooperacion";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipooperacion", objVO.ID, command));

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
                TipoOperacion objVO = (TipoOperacion)obj;
                string query = "insert into tipooperacion "
                    + " (descripcion_tipooperacion, facturable_tipooperacion)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tipooperacion, " + this.PARAMETERPREFIX + "facturable_tipooperacion)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipooperacion", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturable_tipooperacion", objVO.Facturable, command));
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
                TipoOperacion objVO = (TipoOperacion)obj;
                string query = "update tipooperacion "
                    + "  set "
                    + "  descripcion_tipooperacion = " + this.PARAMETERPREFIX + "descripcion_tipooperacion"
                    + " ,facturable_tipooperacion = " + this.PARAMETERPREFIX + "facturable_tipooperacion"
                    + " where"
                    + " id_tipooperacion = " + this.PARAMETERPREFIX + "id_tipooperacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipooperacion", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturable_tipooperacion", objVO.Facturable, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipooperacion", objVO.ID, command));

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
                TipoOperacion objVO = (TipoOperacion)obj;
                string query = "delete from tipooperacion "
                    + " where"
                    + " id_tipooperacion = " + this.PARAMETERPREFIX + "id_tipooperacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipooperacion", objVO.ID, command));

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
                System.Collections.Generic.List<TipoOperacion> res = new System.Collections.Generic.List<TipoOperacion>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoOperacion)dataReaderToObject(reader));
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
