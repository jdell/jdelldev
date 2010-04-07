using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.ejercicio.dao
{	
	internal class ejercicioDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from ejercicios e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by FechaInicial asc";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Ejercicio res = null;
				if (reader!=null)
				{
                    res = new Ejercicio();
                    if (!Convert.IsDBNull(reader["Codigo"])) res.Codigo = Convert.ToString(reader["Codigo"]);
                    if (!Convert.IsDBNull(reader["Descripcion"])) res.Descripcion = Convert.ToString(reader["Descripcion"]);
                    if (!Convert.IsDBNull(reader["Empresa"])) res.Empresa = Convert.ToString(reader["Empresa"]);
                    if (!Convert.IsDBNull(reader["FechaFinal"])) res.FechaFinal = Convert.ToDateTime(reader["FechaFinal"]);
                    if (!Convert.IsDBNull(reader["FechaInicial"])) res.FechaInicial = Convert.ToDateTime(reader["FechaInicial"]);
                    if (!Convert.IsDBNull(reader["TriMesCerrado"])) res.TrimestreCerrado = Convert.ToInt32(reader["TriMesCerrado"]);
                    if (!Convert.IsDBNull(reader["UltimaFacEmitida"])) res.UltimaFacturaEmitida = Convert.ToInt32(reader["UltimaFacEmitida"]);
                    if (!Convert.IsDBNull(reader["UltimaFacRecibida"])) res.UltimaFacturaRecibida = Convert.ToInt32(reader["UltimaFacRecibida"]);
                    if (!Convert.IsDBNull(reader["UltimoAsiento"])) res.UltimoAsiento = Convert.ToInt32(reader["UltimoAsiento"]);
                    if (!Convert.IsDBNull(reader["UltAstoDiferido"])) res.UltimoAsientoDiferido = Convert.ToInt32(reader["UltAstoDiferido"]);
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
                List<Ejercicio> res = (List<Ejercicio>)this.dataReaderToList(reader);
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
                Ejercicio objVO = (Ejercicio)obj;

                string where = " Codigo = " + this.PARAMETERPREFIX + "Codigo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "Codigo", objVO.Codigo, command));

                DbDataReader reader = command.ExecuteReader();
                Ejercicio res = null;
                if (reader.Read())
                    res = (Ejercicio)this.dataReaderToObject(reader);
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
                System.Collections.Generic.List<Ejercicio> res = new System.Collections.Generic.List<Ejercicio>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Ejercicio)dataReaderToObject(reader));
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
