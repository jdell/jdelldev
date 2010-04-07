using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tipounidad.dao
{	
	internal class tipounidadDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tipounidad e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tipounidad asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoUnidad res = null;
				if (reader!=null)
				{
                    res = new TipoUnidad();
                    res.Descripcion = Convert.ToString(reader["descripcion_tipounidad"]);
                    res.ID= Convert.ToInt32(reader["id_tipounidad"]);
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
                List<TipoUnidad> res = (List<TipoUnidad>)this.dataReaderToList(reader);
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
                TipoUnidad objVO = (TipoUnidad)obj;

                string where = " id_tipounidad = " + this.PARAMETERPREFIX + "id_tipounidad";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoUnidad res = null;
                if (reader.Read())
                    res = (TipoUnidad)this.dataReaderToObject(reader);
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
                TipoUnidad objVO = (TipoUnidad)obj;
                string where = " id_tipounidad = " + this.PARAMETERPREFIX + "id_tipounidad";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.ID, command));

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
                TipoUnidad objVO = (TipoUnidad)obj;
                string query = "insert into tipounidad "
                    + " (descripcion_tipounidad)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tipounidad)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipounidad", objVO.Descripcion, command));
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
                TipoUnidad objVO = (TipoUnidad)obj;
                string query = "update tipounidad "
                    + "  set "
                    + "  descripcion_tipounidad = " + this.PARAMETERPREFIX + "descripcion_tipounidad"
                    + " where"
                    + " id_tipounidad = " + this.PARAMETERPREFIX + "id_tipounidad";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipounidad", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.ID, command));

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
                TipoUnidad objVO = (TipoUnidad)obj;
                string query = "delete from tipounidad "
                    + " where"
                    + " id_tipounidad = " + this.PARAMETERPREFIX + "id_tipounidad";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.ID, command));

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
                System.Collections.Generic.List<TipoUnidad> res = new System.Collections.Generic.List<TipoUnidad>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoUnidad)dataReaderToObject(reader));
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
