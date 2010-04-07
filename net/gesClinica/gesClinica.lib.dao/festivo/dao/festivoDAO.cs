using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.festivo.dao
{	
	internal class festivoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from festivo e"
            + " left join tipofestivo tf on e.id_tipofestivo = tf.id_tipofestivo";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Festivo res = null;
				if (reader!=null)
				{
                    res = new Festivo();
                    res.TipoFestivo = new TipoFestivo();
                    res.TipoFestivo.ID = Convert.ToInt32(reader["id_tipofestivo"]);
                    res.TipoFestivo.Descripcion = Convert.ToString(reader["descripcion_tipofestivo"]);
                    res.TipoFestivo.Color = Convert.ToString(reader["color_tipofestivo"]);

                    res.Fecha = Convert.ToDateTime(reader["fecha_festivo"]);
                    res.ID= Convert.ToInt32(reader["id_festivo"]);
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
                List<Festivo> res = (List<Festivo>)this.dataReaderToList(reader);
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
                Festivo objVO = (Festivo)obj;

                string where = " id_festivo = " + this.PARAMETERPREFIX + "id_festivo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_festivo", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Festivo res = null;
                if (reader.Read())
                    res = (Festivo)this.dataReaderToObject(reader);
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
                Festivo objVO = (Festivo)obj;
                string where = " fecha_festivo = " + this.PARAMETERPREFIX + "fecha_festivo ";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_festivo", objVO.Fecha, command));

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
                Festivo objVO = (Festivo)obj;
                string query = "insert into festivo "
                    + " (fecha_festivo, id_tipofestivo)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "fecha_festivo," + this.PARAMETERPREFIX + "id_tipofestivo)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_festivo", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.TipoFestivo.ID, command));
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
                Festivo objVO = (Festivo)obj;
                string query = "update festivo "
                    + "  set "
                    + "  fecha_festivo = " + this.PARAMETERPREFIX + "fecha_festivo"
                    + " ,id_tipofestivo = " + this.PARAMETERPREFIX + "id_tipofestivo"
                    + " where"
                    + " id_festivo = " + this.PARAMETERPREFIX + "id_festivo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_festivo", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipofestivo", objVO.TipoFestivo.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_festivo", objVO.ID, command));

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
                Festivo objVO = (Festivo)obj;
                string query = "delete from festivo "
                    + " where"
                    + " id_festivo = " + this.PARAMETERPREFIX + "id_festivo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_festivo", objVO.ID, command));

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
        public void doDeleteAll(DbCommand command)
        {
            try
            {
                string query = "delete from festivo ";

                command.CommandText = query;
                
                command.ExecuteNonQuery();
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
                System.Collections.Generic.List<Festivo> res = new System.Collections.Generic.List<Festivo>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Festivo)dataReaderToObject(reader));
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
