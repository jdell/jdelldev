using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.visita.dao
{	
	internal class visitaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from visitas e"
            + " left join actividades a on a.idActividad = e.idActividad";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by HoraCita asc";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Visita res = null;
				if (reader!=null)
				{
                    res = new Visita();

                    if (!Convert.IsDBNull(reader["Adeudado"])) res.Adeudado = Convert.ToSingle(reader["Adeudado"]);
                    if (!Convert.IsDBNull(reader["ConDatos"])) res.ConDatos = Convert.ToBoolean(reader["ConDatos"]);
                    if (!Convert.IsDBNull(reader["Diagnóstico"])) res.Diagnostico = Convert.ToString(reader["Diagnóstico"]);
                    if (!Convert.IsDBNull(reader["IdEstado"])) res.Estado = Convert.ToInt32(reader["IdEstado"]);
                    if (!Convert.IsDBNull(reader["HoraCita"])) res.HoraCita = Convert.ToDateTime(reader["HoraCita"]);
                    if (!Convert.IsDBNull(reader["CodVisita"])) res.ID = Convert.ToString(reader["CodVisita"]);
                    if (!Convert.IsDBNull(reader["Llegada"])) res.Llegada = Convert.ToDateTime(reader["Llegada"]);
                    if (!Convert.IsDBNull(reader["e.Moneda"])) res.Moneda = Convert.ToInt32(reader["e.Moneda"]);
                    if (!Convert.IsDBNull(reader["NoPresentado"])) res.NoPresentado = Convert.ToBoolean(reader["NoPresentado"]);
                        if (!Convert.IsDBNull(reader["CodPaciente"]))
                        {
                            res.Paciente = new Paciente();
                            res.Paciente.Codigo = Convert.ToString(reader["CodPaciente"]);
                        }
                        if (!Convert.IsDBNull(reader["Petición"])) res.Peticion = Convert.ToDateTime(reader["Petición"]);
                        if (!Convert.IsDBNull(reader["Presencial"])) res.Presencial = Convert.ToBoolean(reader["Presencial"]);
                        if (!Convert.IsDBNull(reader["RecetaLibre"])) res.RecetaLibre = Convert.ToString(reader["RecetaLibre"]);
                        if (!Convert.IsDBNull(reader["Salida"])) res.Salida = Convert.ToDateTime(reader["Salida"]);
                        if (!Convert.IsDBNull(reader["Síntomas"])) res.Sintomas = Convert.ToString(reader["Síntomas"]);
                        if (!Convert.IsDBNull(reader["e.IdTerapeuta"]))
                        {
                            res.Terapeuta = new Terapeuta();
                            res.Terapeuta.ID = Convert.ToString(reader["e.IdTerapeuta"]);
                        }
                        if (!Convert.IsDBNull(reader["Tratamiento"])) res.Tratamiento = Convert.ToString(reader["Tratamiento"]);
                        if (!Convert.IsDBNull(reader["e.IdActividad"]))
                        {
                            res.Actividad = new Actividad();
                            res.Actividad.ID = Convert.ToString(reader["e.IdActividad"]);
                            if (!Convert.IsDBNull(reader["Tiempo"])) res.Actividad.Tiempo = Convert.ToDateTime(reader["Tiempo"]);
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
                List<Visita> res = (List<Visita>)this.dataReaderToList(reader);
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
                //Visita objVO = (Visita)obj;

                //string where = " Codigo = " + this.PARAMETERPREFIX + "Codigo";
                //string query = getQuery(where);
                //command.CommandText = query;
                //command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "Codigo", objVO.Codigo, command));

                //DbDataReader reader = command.ExecuteReader();
                //Visita res = null;
                //if (reader.Read())
                //    res = (Visita)this.dataReaderToObject(reader);
                //reader.Close();

                //return res;
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
                System.Collections.Generic.List<Visita> res = new System.Collections.Generic.List<Visita>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Visita)dataReaderToObject(reader));
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
