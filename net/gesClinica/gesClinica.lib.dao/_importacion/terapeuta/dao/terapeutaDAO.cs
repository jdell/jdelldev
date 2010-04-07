using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.terapeuta.dao
{	
	internal class terapeutaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from terapeutas e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Terapeuta res = null;
				if (reader!=null)
				{
                    res = new Terapeuta();

                    if (!Convert.IsDBNull(reader["FactorCobro"])) res.FactorCobro = Convert.ToSingle(reader["FactorCobro"]);
                    if (!Convert.IsDBNull(reader["FacAutomática"])) res.FacturaAutomatica = Convert.ToBoolean(reader["FacAutomática"]);
                    if (!Convert.IsDBNull(reader["HoraFin"])) res.HoraFin = Convert.ToDateTime(reader["HoraFin"]);
                    if (!Convert.IsDBNull(reader["HoraFinT"])) res.HoraFinT = Convert.ToDateTime(reader["HoraFinT"]);
                    if (!Convert.IsDBNull(reader["HoraInicio"])) res.HoraInicio = Convert.ToDateTime(reader["HoraInicio"]);
                    if (!Convert.IsDBNull(reader["HoraInicioT"])) res.HoraInicioT = Convert.ToDateTime(reader["HoraInicioT"]);
                    if (!Convert.IsDBNull(reader["IdTerapeuta"])) res.ID = Convert.ToString(reader["IdTerapeuta"]);
                    if (!Convert.IsDBNull(reader["IntervaloConsultas"])) res.IntervaloConsultas = Convert.ToDateTime(reader["IntervaloConsultas"]);
                    if (!Convert.IsDBNull(reader["Terapeuta"])) res.Nombre = Convert.ToString(reader["Terapeuta"]);
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
                List<Terapeuta> res = (List<Terapeuta>)this.dataReaderToList(reader);
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
                System.Collections.Generic.List<Terapeuta> res = new System.Collections.Generic.List<Terapeuta>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Terapeuta)dataReaderToObject(reader));
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
