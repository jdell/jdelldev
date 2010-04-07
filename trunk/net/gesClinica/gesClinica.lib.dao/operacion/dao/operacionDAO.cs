using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.operacion.dao
{	
	internal class operacionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select *"
            + ",e.id_empleado e_id_empleado, e.nombre_empleado e_nombre_empleado, e.apellido1_empleado e_apellido1_empleado, e.apellido2_empleado e_apellido2_empleado, e.comision_empleado e_comision_empleado, e.color1_empleado e_color1_empleado, e.color2_empleado e_color2_empleado"
            + ",em.id_empleado em_id_empleado, em.nombre_empleado em_nombre_empleado, em.apellido1_empleado em_apellido1_empleado, em.apellido2_empleado em_apellido2_empleado, em.comision_empleado em_comision_empleado"
            + ",p.id_paciente p_id_paciente, p.nombre_paciente p_nombre_paciente, p.apellido1_paciente p_apellido1_paciente, p.apellido2_paciente p_apellido2_paciente"
            + ",pm.id_paciente pm_id_paciente, pm.nombre_paciente pm_nombre_paciente, pm.apellido1_paciente pm_apellido1_paciente, pm.apellido2_paciente pm_apellido2_paciente"
            + " , (select count(*) from pago left join formapago on pago.id_formapago=formapago.id_formapago where pago.id_operacion = o.id_operacion and formapago.facturar_formapago=1)>0 debeFacturarse_operacion"
            + " from operacion o"
            + " left join paciente pm on o.id_paciente = pm.id_paciente"
            + " left join cita c on o.id_cita = c.id_cita"
            + " left join paciente p on c.id_paciente = p.id_paciente"
            + " left join terapia t on c.id_terapia = t.id_terapia"
            + " left join empleado e on c.id_empleado = e.id_empleado"
            +" left join empleado em on o.id_empleado = em.id_empleado";
            //+ " left join tipooperacion tf on e.tipo_operacion = tf.tipo_operacion";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);

            query += " ORDER BY o.tipo_operacion, c.fecha_cita";

            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Operacion res = null;
				if (reader!=null)
				{
                    res = new Operacion();
                    res.Tipo = Operacion.TipoFromName(Convert.ToString(reader["tipo_operacion"]));

                    res.Fecha = Convert.ToDateTime(reader["fecha_operacion"]);
                    res.ID= Convert.ToInt32(reader["id_operacion"]);
                    res.Debe = Convert.ToSingle(reader["debe_operacion"]);
                    res.Haber = Convert.ToSingle(reader["haber_operacion"]);
                    res.Facturado = Convert.ToBoolean(reader["facturado_operacion"]);
                    res.FacturaAntigua = Convert.ToString(reader["facturaAntigua_operacion"]);
                    res.DebeFacturarse = Convert.ToBoolean(reader["debeFacturarse_operacion"]);

                    res.Observaciones = Convert.ToString(reader["observaciones_operacion"]);

                    if (!Convert.IsDBNull(reader["id_cita"]) && res.Tipo == tTIPOOPERACION.OPERACION_PACIENTE)
                    {
                        res.Cita = new Cita();
                        res.Cita.ID = Convert.ToInt32(reader["id_cita"]);
                        res.Cita.Fecha = Convert.ToDateTime(reader["fecha_cita"]);
                        res.Cita.Paciente = new Paciente();
                        res.Cita.Paciente.ID = Convert.ToInt32(reader["p_id_paciente"]);
                        res.Cita.Paciente.Nombre = Convert.ToString(reader["p_nombre_paciente"]);
                        res.Cita.Paciente.Apellido1 = Convert.ToString(reader["p_apellido1_paciente"]);
                        res.Cita.Paciente.Apellido2 = Convert.ToString(reader["p_apellido2_paciente"]);

                        res.Cita.Terapia = new Terapia();
                        res.Cita.Terapia.ID = Convert.ToInt32(reader["id_terapia"]);
                        res.Cita.Terapia.Descripcion = Convert.ToString(reader["descripcion_terapia"]);

                        res.Cita.Empleado = new Empleado();
                        res.Cita.Empleado.ID = Convert.ToInt32(reader["e_id_empleado"]);
                        res.Cita.Empleado.Nombre = Convert.ToString(reader["e_nombre_empleado"]);
                        res.Cita.Empleado.Apellido1 = Convert.ToString(reader["e_apellido1_empleado"]);
                        res.Cita.Empleado.Apellido2 = Convert.ToString(reader["e_apellido2_empleado"]);
                        res.Cita.Empleado.Comision = Convert.ToInt32(reader["e_comision_empleado"]);
                        if (!Convert.IsDBNull("e_color1_empleado")) res.Cita.Empleado.Color1 = Convert.ToString(reader["e_color1_empleado"]);
                        if (!Convert.IsDBNull("e_color2_empleado")) res.Cita.Empleado.Color2 = Convert.ToString(reader["e_color2_empleado"]);
                    }

                    if (!Convert.IsDBNull(reader["em_id_empleado"]) && res.Tipo == tTIPOOPERACION.PAGO_TERAPEUTA)
                    {
                        res.Empleado = new Empleado();
                        res.Empleado.ID = Convert.ToInt32(reader["em_id_empleado"]);
                        res.Empleado.Nombre = Convert.ToString(reader["em_nombre_empleado"]);
                        res.Empleado.Apellido1 = Convert.ToString(reader["em_apellido1_empleado"]);
                        res.Empleado.Apellido2 = Convert.ToString(reader["em_apellido2_empleado"]);
                        res.Empleado.Comision = Convert.ToInt32(reader["em_comision_empleado"]);
                    }
                    if (!Convert.IsDBNull(reader["pm_id_paciente"]))
                    {
                        res.Paciente = new Paciente();
                        res.Paciente.ID = Convert.ToInt32(reader["pm_id_paciente"]);
                        res.Paciente.Nombre = Convert.ToString(reader["pm_nombre_paciente"]);
                        res.Paciente.Apellido1 = Convert.ToString(reader["pm_apellido1_paciente"]);
                        res.Paciente.Apellido2 = Convert.ToString(reader["pm_apellido2_paciente"]);
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
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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

        public List<Operacion> doGetAllByTipo(DbCommand command, vo.tTIPOOPERACION tipo)
        {
            try
            {
                string where = string.Format("tipo_operacion = {0}tipo_operacion", this.PARAMETERPREFIX);

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_operacion", Operacion.NameFromTipo(tipo), command));
                
                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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

        public List<Operacion> doGetAll(DbCommand command, lib.common.tipos.ParDateTime fechas, List<vo.tTIPOOPERACION> tipos)
        {
            try
            {
                string where = string.Format("fecha_operacion >= {0}fechaDesde_operacion AND fecha_operacion < {0}fechaHasta_operacion",this.PARAMETERPREFIX);
                string wtipo = string.Empty;
                if (tipos.Count > 0)
                {
                    wtipo = "((1=0) ";
                    foreach (vo.tTIPOOPERACION tipo in tipos)
                    {
                        wtipo += string.Format(" OR tipo_operacion = '{0}'", tipo.ToString());
                    }
                    wtipo += ")";
                }
                if (!string.IsNullOrEmpty(wtipo))
                    where += " AND " + wtipo;

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_operacion", fechas.Desde.Value, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_operacion", fechas.Hasta.Value.AddDays(1).Date, command));

                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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
        public List<Operacion> doGetAll(DbCommand command, DateTime fecha)
        {
            try
            {
                string where = string.Format("fecha_operacion >= {0}fechaDesde_operacion AND fecha_operacion < {0}fechaHasta_operacion",this.PARAMETERPREFIX);
                
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_operacion", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_operacion", fecha.Date.AddDays(1), command));

                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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

        public List<Operacion> doGetAll(DbCommand command, Paciente paciente)
        {
            try
            {
                string where = string.Format("pm.id_paciente = {0}id_paciente", this.PARAMETERPREFIX);

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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

        public List<Operacion> doGetAll(DbCommand command, DateTime fecha, Empleado empleado)
        {
            try
            {
                string where = string.Format("fecha_operacion >= {0}fechaDesde_operacion AND fecha_operacion < {0}fechaHasta_operacion AND c.id_empleado = {0}id_empleado", this.PARAMETERPREFIX);

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_operacion", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_operacion", fecha.Date.AddDays(1), command));

                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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

        public List<Operacion> doGetAll(DbCommand command, DateTime fecha, Empresa empresa)
        {
            try
            {
                string where = string.Format("tipo_operacion = {0}tipo_operacion AND fecha_operacion >= {0}fechaDesde_operacion AND fecha_operacion < {0}fechaHasta_operacion AND e.id_empresa = {0}id_empresa", this.PARAMETERPREFIX);

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_operacion", lib.vo.tTIPOOPERACION.OPERACION_PACIENTE.ToString(), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_operacion", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_operacion", fecha.Date.AddDays(1), command));

                DbDataReader reader = command.ExecuteReader();
                List<Operacion> res = (List<Operacion>)this.dataReaderToList(reader);
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
                Operacion objVO = (Operacion)obj;

                string where = " id_operacion = " + this.PARAMETERPREFIX + "id_operacion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Operacion res = null;
                if (reader.Read())
                    res = (Operacion)this.dataReaderToObject(reader);
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

        public Operacion doGet(DbCommand command, Cita obj)
        {
            try
            {
                Cita objVO = (Cita)obj;

                string where = " o.id_cita = " + this.PARAMETERPREFIX + "id_cita";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Operacion res = null;
                if (reader.Read())
                    res = (Operacion)this.dataReaderToObject(reader);
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
                Operacion objVO = (Operacion)obj;
                string where = " id_operacion = " + this.PARAMETERPREFIX + "id_operacion";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.ID, command));

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

        public bool doCheckIfExists(DbCommand command, vo.tTIPOOPERACION tipo, DateTime fecha)
        {
            try
            {
                string where = string.Format("tipo_operacion = {0}tipo_operacion and fecha_operacion >= {0}fechaDesde_operacion AND fecha_operacion < {0}fechaHasta_operacion", this.PARAMETERPREFIX);
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_operacion", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_operacion", fecha.Date.AddDays(1), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_operacion", Operacion.NameFromTipo(tipo), command));

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
                Operacion objVO = (Operacion)obj;
                string query = "insert into operacion "
                    + " (fecha_operacion, tipo_operacion, id_cita, debe_operacion, haber_operacion, facturado_operacion, facturaAntigua_operacion, observaciones_operacion, id_empleado, id_paciente)"
                    + " values "
                    + string.Format(" ({0}fecha_operacion, {0}tipo_operacion, {0}id_cita, {0}debe_operacion, {0}haber_operacion, {0}facturado_operacion, {0}facturaAntigua_operacion, {0}observaciones_operacion, {0}id_empleado, {0}id_paciente)", this.PARAMETERPREFIX);
                    //+ " (" + this.PARAMETERPREFIX + "fecha_operacion," + this.PARAMETERPREFIX + "tipo_operacion)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_operacion", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_operacion", Operacion.NameFromTipo(objVO.Tipo), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_operacion", objVO.Observaciones, command));

                if (objVO.Cita != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", Convert.DBNull, command));

                if (objVO.Paciente != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", Convert.DBNull, command));

                if (objVO.Empleado != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", Convert.DBNull, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "debe_operacion", objVO.Debe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "haber_operacion", objVO.Haber, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturado_operacion", objVO.Facturado, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaAntigua_operacion", objVO.FacturaAntigua, command));

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
                Operacion objVO = (Operacion)obj;
                string query = "update operacion "
                    + "  set "
                    + "  fecha_operacion = " + this.PARAMETERPREFIX + "fecha_operacion"
                    + " ,tipo_operacion = " + this.PARAMETERPREFIX + "tipo_operacion"
                    + " ,id_cita = " + this.PARAMETERPREFIX + "id_cita"
                    + " ,debe_operacion = " + this.PARAMETERPREFIX + "debe_operacion"
                    + " ,haber_operacion = " + this.PARAMETERPREFIX + "haber_operacion"
                    + " ,facturado_operacion = " + this.PARAMETERPREFIX + "facturado_operacion"
                    + " ,observaciones_operacion = " + this.PARAMETERPREFIX + "observaciones_operacion"
                    + " ,facturaAntigua_operacion = " + this.PARAMETERPREFIX + "facturaAntigua_operacion"
                    + " ,id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                    + " ,id_paciente = " + this.PARAMETERPREFIX + "id_paciente"
                    + " where"
                    + " id_operacion = " + this.PARAMETERPREFIX + "id_operacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_operacion", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_operacion", Operacion.NameFromTipo(objVO.Tipo), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_operacion", objVO.Observaciones, command));

                if (objVO.Cita != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", Convert.DBNull, command));

                if (objVO.Paciente != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", Convert.DBNull, command));

                if (objVO.Empleado != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", Convert.DBNull, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "debe_operacion", objVO.Debe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "haber_operacion", objVO.Haber, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturado_operacion", objVO.Facturado, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaAntigua_operacion", objVO.FacturaAntigua, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.ID, command));

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

        public object doUpdateFacturada(DbCommand command, Operacion obj)
        {
            try
            {
                Operacion objVO = (Operacion)obj;
                string query = "update operacion "
                    + "  set "
                    + " facturado_operacion = " + this.PARAMETERPREFIX + "facturado_operacion"
                    + ",facturaAntigua_operacion = " + this.PARAMETERPREFIX + "facturaAntigua_operacion"
                    + " where"
                    + " id_operacion = " + this.PARAMETERPREFIX + "id_operacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "facturado_operacion", objVO.Facturado, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaAntigua_operacion", objVO.FacturaAntigua, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.ID, command));

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
                Operacion objVO = (Operacion)obj;
                string query = "delete from operacion "
                    + " where"
                    + " id_operacion = " + this.PARAMETERPREFIX + "id_operacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.ID, command));

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
        public void doDeleteAll(DbCommand command)
        {
            try
            {
                string query = "delete from operacion ";

                command.CommandText = query;
                
                command.ExecuteNonQuery();
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
                System.Collections.Generic.List<Operacion> res = new System.Collections.Generic.List<Operacion>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Operacion)dataReaderToObject(reader));
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
