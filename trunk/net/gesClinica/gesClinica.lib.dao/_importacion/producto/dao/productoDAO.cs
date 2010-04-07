using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.producto.dao
{	
	internal class productoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from productos e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Producto res = null;
				if (reader!=null)
				{
                    res = new Producto();

                    if (!Convert.IsDBNull(reader["Producto"])) res.Descripcion = Convert.ToString(reader["Producto"]);
                    if (!Convert.IsDBNull(reader["Documento"])) res.Documento= Convert.ToString(reader["Documento"]);
                    if (!Convert.IsDBNull(reader["IdProducto"])) res.ID = Convert.ToString(reader["IdProducto"]);
                    if (!Convert.IsDBNull(reader["IdLaboratorio"]))
                    {
                        res.Laboratorio = new Laboratorio();
                        res.Laboratorio.ID = Convert.ToString(reader["IdLaboratorio"]);
                    }
                    if (!Convert.IsDBNull(reader["Posología"])) res.Posologia = Convert.ToString(reader["Posología"]);
                    if (!Convert.IsDBNull(reader["Retirado"])) res.Retirado = Convert.ToBoolean(reader["Retirado"]);
                    if (!Convert.IsDBNull(reader["PVP"])) res.PVP = Convert.ToSingle(reader["PVP"]);

                    if (!Convert.IsDBNull(reader["Unidades"])) res.Unidades = Convert.ToInt32(reader["Unidades"]);
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
                List<Producto> res = (List<Producto>)this.dataReaderToList(reader);
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
                System.Collections.Generic.List<Producto> res = new System.Collections.Generic.List<Producto>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Producto)dataReaderToObject(reader));
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
