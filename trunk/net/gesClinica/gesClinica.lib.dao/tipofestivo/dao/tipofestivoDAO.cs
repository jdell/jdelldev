using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tipofestivo.dao
{	
	internal class tipofestivoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tipofestivo e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tipofestivo asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoFestivo res = null;
				if (reader!=null)
				{
                    res = new TipoFestivo();
                    res.Color = Convert.ToString(reader["color_tipofestivo"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_tipofestivo"]);
                    res.ID= Convert.ToInt32(reader["id_tipofestivo"]);
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
                List<TipoFestivo> res = (List<TipoFestivo>)this.dataReaderToList(reader);
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
                TipoFestivo objVO = (TipoFestivo)obj;

                string where = " id_tipofestivo = " + this.PARAMETERPREFIX + "id_tipofestivo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoFestivo res = null;
                if (reader.Read())
                    res = (TipoFestivo)this.dataReaderToObject(reader);
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
                TipoFestivo objVO = (TipoFestivo)obj;
                string where = " id_tipofestivo = " + this.PARAMETERPREFIX + "id_tipofestivo";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.ID, command));

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
                TipoFestivo objVO = (TipoFestivo)obj;
                string query = "insert into tipofestivo "
                    + " (descripcion_tipofestivo, color_tipofestivo)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tipofestivo, " + this.PARAMETERPREFIX + "color_tipofestivo)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipofestivo", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_tipofestivo", objVO.Color, command));
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
                TipoFestivo objVO = (TipoFestivo)obj;
                string query = "update tipofestivo "
                    + "  set "
                    + "  descripcion_tipofestivo = " + this.PARAMETERPREFIX + "descripcion_tipofestivo"
                    + " ,color_tipofestivo = " + this.PARAMETERPREFIX + "color_tipofestivo"
                    + " where"
                    + " id_tipofestivo = " + this.PARAMETERPREFIX + "id_tipofestivo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipofestivo", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_tipofestivo", objVO.Color, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.ID, command));

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
                TipoFestivo objVO = (TipoFestivo)obj;
                string query = "delete from tipofestivo "
                    + " where"
                    + " id_tipofestivo = " + this.PARAMETERPREFIX + "id_tipofestivo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.ID, command));

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
                System.Collections.Generic.List<TipoFestivo> res = new System.Collections.Generic.List<TipoFestivo>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoFestivo)dataReaderToObject(reader));
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
