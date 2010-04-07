using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.evento.dao
{	
	internal class eventoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from evento e"
            + " left join empleado emp on e.id_empleado = emp.id_empleado"
            + " left join estadoevento ev on e.id_estadoevento = ev.id_estadoevento"
            +" left join sala s on e.id_sala = s.id_sala";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Evento res = null;
				if (reader!=null)
				{
                    res = new Evento();
                    res.Duracion = Convert.ToInt32(reader["duracion_evento"]);

                    res.Empleado = new Empleado();
                    res.Empleado.ID = Convert.ToInt32(reader["id_empleado"]);
                    res.Empleado.Nombre = Convert.ToString(reader["nombre_empleado"]);
                    res.Empleado.Apellido1 = Convert.ToString(reader["apellido1_empleado"]);
                    res.Empleado.Apellido2 = Convert.ToString(reader["apellido2_empleado"]);

                    res.Fecha = Convert.ToDateTime(reader["fecha_evento"]);
                    res.Publico = Convert.ToBoolean(reader["publico_evento"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_evento"]);
                    res.ID= Convert.ToInt32(reader["id_evento"]);

                    res.Sala = new Sala();
                    res.Sala.ID = Convert.ToInt32(reader["id_sala"]);
                    res.Sala.Descripcion = Convert.ToString(reader["descripcion_sala"]);

                    if (!Convert.IsDBNull(reader["id_estadoevento"]))
                    {
                        res.EstadoEvento = new EstadoEvento();
                        res.EstadoEvento.ID = Convert.ToInt32(reader["id_estadoevento"]);
                        res.EstadoEvento.Descripcion = Convert.ToString(reader["descripcion_estadoevento"]);
                        res.EstadoEvento.Color = Convert.ToString(reader["color_estadoevento"]);
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
                List<Evento> res = (List<Evento>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, Empleado empleado)
        {
            try
            {
                string where = " e.id_empleado = " + this.PARAMETERPREFIX + "id_empleado or e.publico_evento = " + this.PARAMETERPREFIX + "publico_evento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "publico_evento", true, command));

                DbDataReader reader = command.ExecuteReader();
                List<Evento> res = (List<Evento>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, Empleado empleado, common.tipos.ParDateTime fecha, Sala sala)
        {
            try
            {
                string where = " (e.id_empleado = " + this.PARAMETERPREFIX + "id_empleado or e.publico_evento = " + this.PARAMETERPREFIX + "publico_evento)"
                + " AND "
                + " (e.id_sala = " + this.PARAMETERPREFIX + "id_sala)"
                + " AND "
                + " ((fecha_evento >= " + this.PARAMETERPREFIX + "fechaDesde_evento) or (" + this.PARAMETERPREFIX + "fechaDesde_evento is null))"
                + " AND "
                + " ((fecha_evento < " + this.PARAMETERPREFIX + "fechaHasta_evento) or (" + this.PARAMETERPREFIX + "fechaHasta_evento is null))";
            
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", sala.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "publico_evento", true, command));
                if (fecha.Desde.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_evento", fecha.Desde.Value.Date, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_evento", Convert.DBNull, command));
                if (fecha.Hasta.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_evento", fecha.Hasta.Value.Date.AddDays(1), command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_evento", Convert.DBNull, command));


                DbDataReader reader = command.ExecuteReader();
                List<Evento> res = (List<Evento>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, Empleado empleado, common.tipos.ParDateTime fecha)
        {
            try
            {
                string where = " (e.id_empleado = " + this.PARAMETERPREFIX + "id_empleado or e.publico_evento = " + this.PARAMETERPREFIX + "publico_evento)"
                + " AND "
                + " ((fecha_evento >= " + this.PARAMETERPREFIX + "fechaDesde_evento) or (" + this.PARAMETERPREFIX + "fechaDesde_evento is null))"
                + " AND "
                + " ((fecha_evento < " + this.PARAMETERPREFIX + "fechaHasta_evento) or (" + this.PARAMETERPREFIX + "fechaHasta_evento is null))";

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "publico_evento", true, command));
                if (fecha.Desde.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_evento", fecha.Desde.Value.Date, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_evento", Convert.DBNull, command));
                if (fecha.Hasta.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_evento", fecha.Hasta.Value.Date.AddDays(1), command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_evento", Convert.DBNull, command));


                DbDataReader reader = command.ExecuteReader();
                List<Evento> res = (List<Evento>)this.dataReaderToList(reader);
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
                Evento objVO = (Evento)obj;

                string where = " id_evento = " + this.PARAMETERPREFIX + "id_evento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_evento", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Evento res = null;
                if (reader.Read())
                    res = (Evento)this.dataReaderToObject(reader);
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
                Evento objVO = (Evento)obj;
                string where = " id_evento = " + this.PARAMETERPREFIX + "id_evento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_evento", objVO.ID, command));

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
                Evento objVO = (Evento)obj;
                string query = "insert into evento "
                    + " (descripcion_evento, fecha_evento, duracion_evento, id_empleado, publico_evento, id_sala, id_estadoevento)"
                    + " values "
                    + string.Format(" ({0}descripcion_evento, {0}fecha_evento, {0}duracion_evento, {0}id_empleado, {0}publico_evento, {0}id_sala, {0}id_estadoevento)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_evento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_evento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_evento", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "publico_evento", objVO.Publico, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.Sala.ID, command));

                if (objVO.EstadoEvento!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.EstadoEvento.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", Convert.DBNull, command));

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
                Evento objVO = (Evento)obj;
                string query = "update evento "
                    + "  set "
                    + "  descripcion_evento = " + this.PARAMETERPREFIX + "descripcion_evento"
                    + " ,fecha_evento = " + this.PARAMETERPREFIX + "fecha_evento"
                    + " ,duracion_evento = " + this.PARAMETERPREFIX + "duracion_evento"
                    + " ,id_empleado= " + this.PARAMETERPREFIX + "id_empleado"
                    + " ,publico_evento = " + this.PARAMETERPREFIX + "publico_evento"
                    + " ,id_sala = " + this.PARAMETERPREFIX + "id_sala"
                    + " ,id_estadoevento = " + this.PARAMETERPREFIX + "id_estadoevento"
                    + " where"
                    + " id_evento = " + this.PARAMETERPREFIX + "id_evento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_evento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_evento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_evento", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "publico_evento", objVO.Publico, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.Sala.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_evento", objVO.ID, command));

                if (objVO.EstadoEvento != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.EstadoEvento.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", Convert.DBNull, command));

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
                Evento objVO = (Evento)obj;
                string query = "delete from evento "
                    + " where"
                    + " id_evento = " + this.PARAMETERPREFIX + "id_evento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_evento", objVO.ID, command));

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
                System.Collections.Generic.List<Evento> res = new System.Collections.Generic.List<Evento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Evento)dataReaderToObject(reader));
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
