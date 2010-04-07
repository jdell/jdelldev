using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.receta.dao
{	
	internal class recetaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from recetas e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Receta res = null;
				if (reader!=null)
				{
                    res = new Receta();
                    if (!Convert.IsDBNull(reader["IdReceta"])) res.ID = Convert.ToString(reader["IdReceta"]);
                    if (!Convert.IsDBNull(reader["NúmEnvases"])) res.NumeroEnvases = Convert.ToInt32(reader["NúmEnvases"]);
                    if (!Convert.IsDBNull(reader["Posología"])) res.Posologia = Convert.ToString(reader["Posología"]);
                    if (!Convert.IsDBNull(reader["IdProducto"]))
                    {
                        res.Producto = new Producto();
                        res.Producto.ID = Convert.ToString(reader["IdProducto"]);
                    }
                    if (!Convert.IsDBNull(reader["IdVisita"]))
                    {
                        res.Visita = new Visita();
                        res.Visita.ID = Convert.ToString(reader["IdVisita"]);
                    }
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
                List<Receta> res = (List<Receta>)this.dataReaderToList(reader);
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
                System.Collections.Generic.List<Receta> res = new System.Collections.Generic.List<Receta>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Receta)dataReaderToObject(reader));
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
