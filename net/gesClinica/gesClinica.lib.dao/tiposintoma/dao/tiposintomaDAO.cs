using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tiposintoma.dao
{	
	internal class tiposintomaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tiposintoma e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tiposintoma asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoSintoma res = null;
				if (reader!=null)
				{
                    res = new TipoSintoma();
                    res.Descripcion = Convert.ToString(reader["descripcion_tiposintoma"]);
                    res.ID= Convert.ToInt32(reader["id_tiposintoma"]);
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
                List<TipoSintoma> res = (List<TipoSintoma>)this.dataReaderToList(reader);
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
                TipoSintoma objVO = (TipoSintoma)obj;

                string where = " id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoSintoma res = null;
                if (reader.Read())
                    res = (TipoSintoma)this.dataReaderToObject(reader);
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
                TipoSintoma objVO = (TipoSintoma)obj;
                string where = " id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.ID, command));

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
                TipoSintoma objVO = (TipoSintoma)obj;
                string query = "insert into tiposintoma "
                    + " (descripcion_tiposintoma)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tiposintoma)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tiposintoma", objVO.Descripcion, command));
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
                TipoSintoma objVO = (TipoSintoma)obj;
                string query = "update tiposintoma "
                    + "  set "
                    + "  descripcion_tiposintoma = " + this.PARAMETERPREFIX + "descripcion_tiposintoma"
                    + " where"
                    + " id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tiposintoma", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.ID, command));

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
                TipoSintoma objVO = (TipoSintoma)obj;
                string query = "delete from tiposintoma "
                    + " where"
                    + " id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.ID, command));

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
                System.Collections.Generic.List<TipoSintoma> res = new System.Collections.Generic.List<TipoSintoma>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoSintoma)dataReaderToObject(reader));
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
