using System;
using System.Data.Common;
using asr.lib.dao._template;
using System.Collections.Generic;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.actividad.dao
{	
	internal class actividadDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from actividades e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by IdActividad asc";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Actividad res = null;
				if (reader!=null)
				{
                    res = new Actividad();

                    if (!Convert.IsDBNull(reader["Activa"])) res.Activa = Convert.ToBoolean(reader["Activa"]);
                    if (!Convert.IsDBNull(reader["Actividad"])) res.Descripcion = Convert.ToString(reader["Actividad"]);
                    if (!Convert.IsDBNull(reader["IdActividad"])) res.ID = Convert.ToString(reader["IdActividad"]);
                    if (!Convert.IsDBNull(reader["Importe"])) res.Importe = Convert.ToSingle(reader["Importe"]);
                    if (!Convert.IsDBNull(reader["CodCuenta"]))
                    {
                        res.SubCuenta = new SubCuenta();
                        res.SubCuenta.Codigo = Convert.ToString(reader["CodCuenta"]);
                    }
                    if (!Convert.IsDBNull(reader["IdTerapeuta"]))
                    {
                        res.Terapeuta = new Terapeuta();
                        res.Terapeuta.ID = Convert.ToString(reader["IdTerapeuta"]);
                    }
                    if (!Convert.IsDBNull(reader["Tiempo"])) res.Tiempo = Convert.ToDateTime(reader["Tiempo"]);
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
                List<Actividad> res = (List<Actividad>)this.dataReaderToList(reader);
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
                throw new Exception("No implementado");
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
                throw new Exception("No implementado");
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
                throw new Exception("No implementado");
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
                throw new Exception("No implementado");
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
                throw new Exception("No implementado");
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
                System.Collections.Generic.List<Actividad> res = new System.Collections.Generic.List<Actividad>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Actividad)dataReaderToObject(reader));
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
