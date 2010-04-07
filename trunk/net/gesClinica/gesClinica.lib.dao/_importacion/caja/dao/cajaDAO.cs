using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.caja.dao
{	
	internal class cajaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from caja e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by Fecha asc";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Caja res = null;
				if (reader!=null)
				{
                    res = new Caja();
                    if (!Convert.IsDBNull(reader["Debe"])) res.Debe = Convert.ToSingle(reader["Debe"]);
                    if (!Convert.IsDBNull(reader["Descripción"])) res.Descripcion = Convert.ToString(reader["Descripción"]);
                    if (!Convert.IsDBNull(reader["Factura"])) res.Factura = Convert.ToString(reader["Factura"]);
                    if (!Convert.IsDBNull(reader["Fecha"])) res.Fecha = Convert.ToDateTime(reader["Fecha"]);
                    if (!Convert.IsDBNull(reader["Haber"])) res.Haber = Convert.ToSingle(reader["Haber"]);
                    if (!Convert.IsDBNull(reader["IdCaja"])) res.ID = Convert.ToString(reader["IdCaja"]);
                    if (!Convert.IsDBNull(reader["IdPaciente"]))
                    {
                        res.Paciente = new Paciente();
                        res.Paciente.Codigo = Convert.ToString(reader["IdPaciente"]);
                    }
                    if (!Convert.IsDBNull(reader["IdTipoCaja"]))
                    {
                        res.TipoCaja = new TipoCaja();
                        res.TipoCaja.ID = Convert.ToString(reader["IdTipoCaja"]);
                    }
                    if (!Convert.IsDBNull(reader["Transferido"])) res.Transferido = Convert.ToBoolean(reader["Transferido"]);
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
                List<Caja> res = (List<Caja>)this.dataReaderToList(reader);
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
                System.Collections.Generic.List<Caja> res = new System.Collections.Generic.List<Caja>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Caja)dataReaderToObject(reader));
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
