using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.ejercicio.dao
{	
	internal class ejercicioDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from ejercicio e"
            + " left join empresa emp on e.id_empresa = emp.id_empresa";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
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
                    res.Descripcion = Convert.ToString(reader["descripcion_ejercicio"]);
                    res.Empresa = new Empresa();
                    res.Empresa.ID = Convert.ToInt32(reader["id_empresa"]);
                    res.Empresa.RazonSocial = Convert.ToString(reader["razonsocial_empresa"]);
                    res.FechaFinal= Convert.ToDateTime(reader["fechaFinal_ejercicio"]);
                    res.FechaInicial= Convert.ToDateTime(reader["fechaInicial_ejercicio"]);
                    res.ID= Convert.ToInt32(reader["id_ejercicio"]);
                    res.UltimaFacturaEmitida= Convert.ToInt32(reader["ultimaFacturaEmitida_ejercicio"]);
                    res.UltimaFacturaRecibida = Convert.ToInt32(reader["ultimaFacturaRecibida_ejercicio"]);
                    res.UltimoAsiento = Convert.ToInt32(reader["ultimoAsiento_ejercicio"]);
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
        public object doGetAll(DbCommand command, Empresa empresa)
        {
            try
            {
                string where = " e.id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

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

                string where = " id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.ID, command));

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

        public Ejercicio doGetByFecha(DbCommand command, DateTime fecha, Empresa empresa)
        {
            try
            {
                string where = string.Format("(fechaInicial_ejercicio <= {0}fecha) and (fechaFinal_ejercicio>={0}fecha) and (e.id_empresa={0}id_empresa)", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int64, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

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
                Ejercicio objVO = (Ejercicio)obj;
                string where = " id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.ID, command));

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

        public bool doCheckIfExistsAsiento(DbCommand command, int numero, Ejercicio ejercicio)
        {
            try
            {
                string query = "select * from asiento a"
                + " where "
                + " numero_asiento = {0}numero_asiento"
                + " AND "
                + " id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_asiento", numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

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

        public bool doCheckIfExistsFacturaEmitida(DbCommand command, int numero, Ejercicio ejercicio)
        {
            try
            {
                string query = "select * from asiento a"
                + " where "
                + " numerofactura_asiento = {0}numerofactura_asiento "
                + " AND "
                + " tipo_asiento = {0}tipo_asiento "
                + " AND "
                + " id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numerofactura_asiento", numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_asiento", vo.tTIPOASIENTO.FACTURA_EMITIDA, command));

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

        public bool doCheckIfExistsFacturaRecibida(DbCommand command, int numero, Ejercicio ejercicio)
        {
            try
            {
                string query = "select * from asiento a"
                + " where "
                + " numerofactura_asiento = {0}numerofactura_asiento "
                + " AND "
                + " tipo_asiento = {0}tipo_asiento "
                + " AND "
                + " id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numerofactura_asiento", numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_asiento", vo.tTIPOASIENTO.FACTURA_RECIBIDA, command));

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
                Ejercicio objVO = (Ejercicio)obj;
                string query = "insert into ejercicio "
                    + " (descripcion_ejercicio, id_empresa, fechaFinal_ejercicio, fechaInicial_ejercicio, ultimaFacturaEmitida_ejercicio, ultimoAsiento_ejercicio, ultimaFacturaRecibida_ejercicio)"
                    + " values "
                    + string.Format(" ({0}descripcion_ejercicio, {0}id_empresa, {0}fechaFinal_ejercicio, {0}fechaInicial_ejercicio, {0}ultimaFacturaEmitida_ejercicio, {0}ultimoAsiento_ejercicio, {0}ultimaFacturaRecibida_ejercicio)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_ejercicio", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fechaFinal_ejercicio", objVO.FechaFinal, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fechaInicial_ejercicio", objVO.FechaInicial, command));
                //command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimaFacturaEmitida_ejercicio", objVO.UltimaFacturaEmitida, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimoAsiento_ejercicio", objVO.UltimoAsiento, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimaFacturaRecibida_ejercicio", objVO.UltimaFacturaRecibida, command));

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
                Ejercicio objVO = (Ejercicio)obj;
                string query = "update ejercicio "
                    + "  set "
                    + "  descripcion_ejercicio = " + this.PARAMETERPREFIX + "descripcion_ejercicio"
                    + " ,id_empresa = " + this.PARAMETERPREFIX + "id_empresa"
                    + " ,fechaFinal_ejercicio = " + this.PARAMETERPREFIX + "fechaFinal_ejercicio"
                    + " ,fechaInicial_ejercicio = " + this.PARAMETERPREFIX + "fechaInicial_ejercicio"
                    + " ,ultimaFacturaEmitida_ejercicio = " + this.PARAMETERPREFIX + "ultimaFacturaEmitida_ejercicio"
                    + " ,ultimoAsiento_ejercicio = " + this.PARAMETERPREFIX + "ultimoAsiento_ejercicio"
                    + " ,ultimaFacturaRecibida_ejercicio = " + this.PARAMETERPREFIX + "ultimaFacturaRecibida_ejercicio "
                    + " where"
                    + " id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_ejercicio", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fechaFinal_ejercicio", objVO.FechaFinal, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fechaInicial_ejercicio", objVO.FechaInicial, command));
                //command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimaFacturaEmitida_ejercicio", objVO.UltimaFacturaEmitida, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimoAsiento_ejercicio", objVO.UltimoAsiento, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "ultimaFacturaRecibida_ejercicio", objVO.UltimaFacturaRecibida, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.ID, command));

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
                Ejercicio objVO = (Ejercicio)obj;
                string query = "delete from ejercicio "
                    + " where"
                    + " id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.ID, command));

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
