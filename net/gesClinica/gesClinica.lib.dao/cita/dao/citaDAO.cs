using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.cita.dao
{	
	internal class citaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from cita c"
            + " left join empleado emp on c.id_empleado = emp.id_empleado"
            + " left join estadocita ec on c.id_estadocita = ec.id_estadocita"
            + " left join paciente pac on c.id_paciente = pac.id_paciente"
            + " left join sala sa on c.id_sala = sa.id_sala"
            + " left join terapia te on c.id_terapia = te.id_terapia"
            + " left join tipoterapia tt on te.id_tipoterapia= tt.id_tipoterapia";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Cita res = null;
				if (reader!=null)
				{
                    res = new Cita();
                    res.Fecha = Convert.ToDateTime(reader["fecha_cita"]);
                    res.ID = Convert.ToInt32(reader["id_cita"]);
                    res.Duracion = Convert.ToInt32(reader["duracion_cita"]);
                    res.Sintomas = Convert.ToString(reader["sintomas_cita"]);
                    res.Diagnostico = Convert.ToString(reader["diagnostico_cita"]);
                    res.Tratamiento = Convert.ToString(reader["tratamiento_cita"]);

                    res.Presencial = Convert.ToBoolean(reader["presencial_cita"]);
                    res.Notas = Convert.ToString(reader["notas_cita"]);
                    res.Facturada = Convert.ToBoolean(reader["facturada_cita"]);

                    res.Empleado = new Empleado();
                    res.Empleado.ID = Convert.ToInt32(reader["id_empleado"]);
                    res.Empleado.Apellido1 = Convert.ToString(reader["apellido1_empleado"]);
                    res.Empleado.Apellido2 = Convert.ToString(reader["apellido2_empleado"]);
                    res.Empleado.Nombre = Convert.ToString(reader["nombre_empleado"]);

                    if (!Convert.IsDBNull(reader["id_estadocita"]))
                    {
                        res.EstadoCita = new EstadoCita();
                        res.EstadoCita.ID = Convert.ToInt32(reader["id_estadocita"]);
                        res.EstadoCita.Descripcion = Convert.ToString(reader["descripcion_estadocita"]);
                        res.EstadoCita.Color = Convert.ToString(reader["color_estadocita"]);
                        if (!Convert.IsDBNull(reader["generarecibo_estadocita"])) res.EstadoCita.GeneraRecibo = Convert.ToBoolean(reader["generarecibo_estadocita"]);
                        if (!Convert.IsDBNull(reader["avion_estadocita"])) res.EstadoCita.Avion = Convert.ToBoolean(reader["avion_estadocita"]);
                    }
                    res.Paciente = new Paciente();
                    res.Paciente.ID = Convert.ToInt32(reader["id_paciente"]);
                    res.Paciente.Apellido1 = Convert.ToString(reader["apellido1_paciente"]);
                    res.Paciente.Apellido2 = Convert.ToString(reader["apellido2_paciente"]);
                    res.Paciente.Nombre = Convert.ToString(reader["nombre_paciente"]);
                    res.Paciente.MuyImportante = Convert.ToString(reader["muyImportante_paciente"]);
                    if (!Convert.IsDBNull(reader["fechaNacimiento_paciente"])) res.Paciente.FechaNacimiento = Convert.ToDateTime(reader["fechaNacimiento_paciente"]);
                    if (!Convert.IsDBNull(reader["telefono1_paciente"])) res.Paciente.Telefono1 = Convert.ToString(reader["telefono1_paciente"]);
                    if (!Convert.IsDBNull(reader["telefono2_paciente"])) res.Paciente.Telefono2 = Convert.ToString(reader["telefono2_paciente"]);
                    if (!Convert.IsDBNull(reader["telefono3_paciente"])) res.Paciente.Telefono3 = Convert.ToString(reader["telefono3_paciente"]);
                    if (!Convert.IsDBNull(reader["notasAgenda_paciente"])) res.Paciente.NotasAgenda = Convert.ToString(reader["notasAgenda_paciente"]);

                    if (!Convert.IsDBNull(reader["id_sala"]))
                    {
                        res.Sala = new Sala();
                        res.Sala.ID = Convert.ToInt32(reader["id_sala"]);
                        res.Sala.Descripcion = Convert.ToString(reader["descripcion_sala"]);res.Sala.Descripcion = Convert.ToString(reader["descripcion_sala"]);
                        if (!Convert.IsDBNull(reader["color_sala"])) res.Sala.Color = Convert.ToString(reader["color_sala"]);
                    }
                    if (!Convert.IsDBNull(reader["id_terapia"]))
                    {
                        res.Terapia = new Terapia();
                        res.Terapia.ID = Convert.ToInt32(reader["id_terapia"]);
                        res.Terapia.Descripcion = Convert.ToString(reader["descripcion_terapia"]);

                        if (!Convert.IsDBNull(reader["id_tipoterapia"]))
                        {
                            res.Terapia.TipoTerapia = new TipoTerapia();
                            res.Terapia.TipoTerapia.ID = Convert.ToInt32(reader["id_tipoterapia"]);
                            if (!Convert.IsDBNull(reader["descripcion_tipoterapia"])) res.Terapia.TipoTerapia.Descripcion = Convert.ToString(reader["descripcion_tipoterapia"]);
                            if (!Convert.IsDBNull(reader["cobrable_tipoterapia"])) res.Terapia.TipoTerapia.Cobrable = Convert.ToBoolean(reader["cobrable_tipoterapia"]);
                            if (!Convert.IsDBNull(reader["codigo_tipoterapia"])) res.Terapia.TipoTerapia.Codigo = lib.vo.TipoTerapia.CodigoFromName(Convert.ToString(reader["codigo_tipoterapia"]));
                            if (!Convert.IsDBNull(reader["color_tipoterapia"])) res.Terapia.TipoTerapia.Color = Convert.ToString(reader["color_tipoterapia"]);
                        }
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
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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

        public List<Cita> doGetAll(DbCommand command, vo.filtro.FiltroCita filtroCita)
        {
            try
            {
                string where = " ((fecha_cita >= " + this.PARAMETERPREFIX + "fechaDesde_cita) or (" + this.PARAMETERPREFIX + "fechaDesde_cita is null))"
                    + " AND "
                    + " ((fecha_cita < " + this.PARAMETERPREFIX + "fechaHasta_cita) or (" + this.PARAMETERPREFIX + "fechaHasta_cita is null))";

                if (filtroCita.Sala != null)
                {
                    where += " AND (c.id_sala = " + this.PARAMETERPREFIX + "id_sala)";
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", filtroCita.Sala.ID, command));
                }
                if (filtroCita.Empleado != null)
                {
                    where += " AND (c.id_empleado = " + this.PARAMETERPREFIX + "id_empleado)";
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", filtroCita.Empleado.ID, command));
                }               
                
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", filtroCita.Fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", filtroCita.Fecha.Date.AddDays(1), command));


                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, Paciente paciente)
        {
            try
            {
                string where = " c.id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, Paciente paciente, Empleado empleado)
        {
            try
            {
                string where = " c.id_paciente = " + this.PARAMETERPREFIX + "id_paciente"
                + " AND "
                + " c.id_empleado = " + this.PARAMETERPREFIX + "id_empleado";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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
        
        public object doGetAll(DbCommand command, common.tipos.ParDateTime fecha, Sala sala)
        {
            try
            {
                string where = " (c.id_sala = " + this.PARAMETERPREFIX + "id_sala)"
                    + " AND "
                    + " ((fecha_cita >= " + this.PARAMETERPREFIX + "fechaDesde_cita) or (" + this.PARAMETERPREFIX + "fechaDesde_cita is null))"
                    + " AND "
                    + " ((fecha_cita < " + this.PARAMETERPREFIX + "fechaHasta_cita) or (" + this.PARAMETERPREFIX + "fechaHasta_cita is null))";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", sala.ID, command));
                if (fecha.Desde.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", fecha.Desde.Value.Date, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", Convert.DBNull, command));
                if (fecha.Hasta.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", fecha.Hasta.Value.Date.AddDays(1), command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", Convert.DBNull, command));


                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, DateTime fecha, bool facturada, bool soloPresencial)
        {
            try
            {
                string where = " (c.facturada_cita = " + this.PARAMETERPREFIX + "facturada_cita)"
                    + " AND "
                    + " ((fecha_cita >= " + this.PARAMETERPREFIX + "fechaDesde_cita) or (" + this.PARAMETERPREFIX + "fechaDesde_cita is null))"
                    + " AND "
                    + " ((fecha_cita < " + this.PARAMETERPREFIX + "fechaHasta_cita) or (" + this.PARAMETERPREFIX + "fechaHasta_cita is null))";
                
                if (soloPresencial)
                {
                    where += " AND presencial_cita = " + this.PARAMETERPREFIX + "presencial_cita ";
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "presencial_cita", true, command));
                }
                
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturada_cita", facturada, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", fecha.Date.AddDays(1), command));


                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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


        public object doGetAll(DbCommand command, common.tipos.ParDateTime fecha, Paciente paciente)
        {
            try
            {
                string where = " (c.id_paciente = " + this.PARAMETERPREFIX + "id_paciente)"
                    + " AND "
                    + " ((fecha_cita >= " + this.PARAMETERPREFIX + "fechaDesde_cita) or (" + this.PARAMETERPREFIX + "fechaDesde_cita is null))"
                    + " AND "
                    + " ((fecha_cita < " + this.PARAMETERPREFIX + "fechaHasta_cita) or (" + this.PARAMETERPREFIX + "fechaHasta_cita is null))";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));
                if (fecha.Desde.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", fecha.Desde.Value.Date, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_cita", Convert.DBNull, command));
                if (fecha.Hasta.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", fecha.Hasta.Value.Date.AddDays(1), command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_cita", Convert.DBNull, command));


                DbDataReader reader = command.ExecuteReader();
                List<Cita> res = (List<Cita>)this.dataReaderToList(reader);
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
                Cita objVO = (Cita)obj;

                string where = " c.id_cita = " + this.PARAMETERPREFIX + "id_cita";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Cita res = null;
                if (reader.Read())
                    res = (Cita)this.dataReaderToObject(reader);
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
                Cita objVO = (Cita)obj;
                string where = " id_cita = " + this.PARAMETERPREFIX + "id_cita";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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
                Cita objVO = (Cita)obj;
                string query = "insert into cita "
                    + " (fecha_cita, id_terapia, id_sala, id_paciente, id_empleado, id_estadocita, duracion_cita, presencial_cita, sintomas_cita, diagnostico_cita, tratamiento_cita, notas_cita, programada_cita, facturada_cita)"
                    + " values "
                    + string.Format(" ({0}fecha_cita, {0}id_terapia, {0}id_sala, {0}id_paciente, {0}id_empleado, {0}id_estadocita, {0}duracion_cita, {0}presencial_cita, {0}sintomas_cita, {0}diagnostico_cita, {0}tratamiento_cita, {0}notas_cita, {0}programada_cita, {0}facturada_cita)", this.PARAMETERPREFIX);
                    //+ " (" + this.PARAMETERPREFIX + "fecha_cita, " + this.PARAMETERPREFIX + "id_terapia, " + this.PARAMETERPREFIX + "id_sala, " + this.PARAMETERPREFIX + "id_paciente, " + this.PARAMETERPREFIX + "id_empleado, " + this.PARAMETERPREFIX + "id_estadocita, " + this.PARAMETERPREFIX + "duracion_cita, " + this.PARAMETERPREFIX + "presencial_cita)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_cita", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_cita", objVO.Fecha, command));
                if (objVO.Terapia!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.Terapia.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", Convert.DBNull, command));
                if (objVO.Sala != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.Sala.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                if (objVO.EstadoCita!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.EstadoCita.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "presencial_cita", objVO.Presencial, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sintomas_cita", objVO.Sintomas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "diagnostico_cita", objVO.Diagnostico, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tratamiento_cita", objVO.Tratamiento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "notas_cita", objVO.Notas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "programada_cita", objVO.Programada, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturada_cita", objVO.Facturada, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

                command.ExecuteNonQuery();
                /*
                long res = Convert.ToInt32(command.Parameters["" + this.PARAMETERPREFIX + "id"].Value);
                return res;*/
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
                Cita objVO = (Cita)obj;
                string query = "update cita "
                    + "  set "
                    + "  fecha_cita = " + this.PARAMETERPREFIX + "fecha_cita"
                    + " ,id_terapia = " + this.PARAMETERPREFIX + "id_terapia"
                    + " ,id_sala = " + this.PARAMETERPREFIX + "id_sala"
                    + " ,id_paciente = " + this.PARAMETERPREFIX + "id_paciente"
                    + " ,id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                    + " ,id_estadocita = " + this.PARAMETERPREFIX + "id_estadocita"
                    + " ,duracion_cita = " + this.PARAMETERPREFIX + "duracion_cita"
                    + " ,presencial_cita = " + this.PARAMETERPREFIX + "presencial_cita"
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_cita", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_cita", objVO.Fecha, command));
                if (objVO.Terapia != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.Terapia.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", Convert.DBNull, command));
                if (objVO.Sala != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.Sala.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", Convert.DBNull, command)); command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                if (objVO.EstadoCita!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.EstadoCita.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "presencial_cita", objVO.Presencial, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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

        public object doUpdateFacturada(DbCommand command, Cita obj)
        {
            try
            {
                Cita objVO = (Cita)obj;
                string query = "update cita "
                    + "  set "
                    + "  facturada_cita = " + this.PARAMETERPREFIX + "facturada_cita "
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturada_cita", objVO.Facturada, command));
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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

        public object doUpdateDatosClinicos(DbCommand command, object obj)
        {
            try
            {
                Cita objVO = (Cita)obj;
                string query = "update cita "
                    + "  set "
                    + "  sintomas_cita = " + this.PARAMETERPREFIX + "sintomas_cita"
                    + " ,diagnostico_cita = " + this.PARAMETERPREFIX + "diagnostico_cita"
                    + " ,tratamiento_cita = " + this.PARAMETERPREFIX + "tratamiento_cita"
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sintomas_cita", objVO.Sintomas, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "diagnostico_cita", objVO.Diagnostico, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tratamiento_cita", objVO.Tratamiento, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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
        public object doUpdateNotas(DbCommand command, object obj)
        {
            try
            {
                Cita objVO = (Cita)obj;
                string query = "update cita "
                    + "  set "
                    + "  notas_cita = " + this.PARAMETERPREFIX + "notas_cita"
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "notas_cita", objVO.Notas, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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
                Cita objVO = (Cita)obj;
                string query = "delete from cita "
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

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
                System.Collections.Generic.List<Cita> res = new System.Collections.Generic.List<Cita>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Cita)dataReaderToObject(reader));
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
