using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.documento.dao
{	
	internal class documentoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from documentos e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by DocFecha asc";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Documento res = null;
				if (reader!=null)
				{
                    res = new Documento();

                    if (!Convert.IsDBNull(reader["IdDoc"])) res.ID = Convert.ToString(reader["IdDoc"]);
                    if (!Convert.IsDBNull(reader["IdTipDoc"]))
                    {
                        res.TipoDocumento = new TipoDocumento();
                        res.TipoDocumento.ID = Convert.ToString(reader["IdTipDoc"]);
                    }
                    if (!Convert.IsDBNull(reader["DocDescripción"])) res.Descripcion = Convert.ToString(reader["DocDescripción"]);
                    if (!Convert.IsDBNull(reader["DocFecha"])) res.Fecha = Convert.ToDateTime(reader["DocFecha"]);
                    if (!Convert.IsDBNull(reader["DocOle"])) res.Content = (byte[])reader["DocOle"];
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
                List<Documento> res = (List<Documento>)this.dataReaderToList(reader);
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
                System.Collections.Generic.List<Documento> res = new System.Collections.Generic.List<Documento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Documento)dataReaderToObject(reader));
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
