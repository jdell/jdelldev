using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.factura.dao
{	
	internal class facturaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select *"
                + ", e.id_empleado as e_id_empleado, e.nombre_empleado as e_nombre_empleado, e.apellido1_empleado as e_apellido1_empleado, e.apellido2_empleado as e_apellido2_empleado, e.comision_empleado as e_comision_empleado "
                + " from factura f"
                + " inner join operacion o on f.id_operacion = o.id_operacion"
                + " inner join cita c on o.id_cita = c.id_cita"
                + " inner join paciente p on c.id_paciente = p.id_paciente"
                + " inner join empleado e on c.id_empleado = e.id_empleado";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Factura res = null;
				if (reader!=null)
				{
                    res = new Factura();
                    res.Fecha = Convert.ToDateTime(reader["fecha_factura"]);
                    res.ID = Convert.ToInt32(reader["id_factura"]);
                    res.Numero = Convert.ToInt32(reader["numero_factura"]);
                    res.Observaciones = Convert.ToString(reader["observaciones_factura"]);
                    res.Concepto = Convert.ToString(reader["concepto_factura"]);
                    res.Cliente = Convert.ToString(reader["cliente_factura"]);
                    res.Contabilizada = Convert.ToBoolean(reader["contabilizada_factura"]);
                    
                    res.Operacion = new Operacion();
                    res.Operacion.ID = Convert.ToInt32(reader["id_operacion"]);

                    if (!Convert.IsDBNull(reader["id_cita"]))
                    {
                        res.Operacion.Cita = new Cita();
                        res.Operacion.Cita.ID = Convert.ToInt32(reader["id_cita"]);
                        res.Operacion.Cita.Paciente = new Paciente();
                        res.Operacion.Cita.Paciente.ID = Convert.ToInt32(reader["id_paciente"]);
                        res.Operacion.Cita.Paciente.Nombre = Convert.ToString(reader["nombre_paciente"]);
                        res.Operacion.Cita.Paciente.Apellido1 = Convert.ToString(reader["apellido1_paciente"]);
                        res.Operacion.Cita.Paciente.Apellido2 = Convert.ToString(reader["apellido2_paciente"]);

                        res.Operacion.Cita.Empleado = new Empleado();
                        res.Operacion.Cita.Empleado.ID = Convert.ToInt32(reader["e_id_empleado"]);
                        res.Operacion.Cita.Empleado.Nombre = Convert.ToString(reader["e_nombre_empleado"]);
                        res.Operacion.Cita.Empleado.Apellido1 = Convert.ToString(reader["e_apellido1_empleado"]);
                        res.Operacion.Cita.Empleado.Apellido2 = Convert.ToString(reader["e_apellido2_empleado"]);
                        res.Operacion.Cita.Empleado.Comision = Convert.ToInt32(reader["e_comision_empleado"]);
                    }
                    
                    res.Serie= Convert.ToString(reader["serie_factura"]);
                    res.Importe = Convert.ToSingle(reader["importe_factura"]);
                    res.IVA = Convert.ToInt32(reader["iva_factura"]);
                    res.Descuento = Convert.ToInt32(reader["descuento_factura"]);
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
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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
                Factura objVO = (Factura)obj;

                string where = " id_factura = " + this.PARAMETERPREFIX + "id_factura";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_factura", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Factura res = null;
                if (reader.Read())
                    res = (Factura)this.dataReaderToObject(reader);
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


        public Factura doGetByAsiento(DbCommand command, Asiento obj)
        {
            try
            {
                Asiento objVO = (Asiento)obj;
                //TODO: aqui
                string where = " numero_factura = " + this.PARAMETERPREFIX + "numero_factura";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_factura", objVO.NumeroFactura, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Factura res = null;
                if (reader.Read())
                    res = (Factura)this.dataReaderToObject(reader);
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
                Factura objVO = (Factura)obj;
                string where = " id_factura = " + this.PARAMETERPREFIX + "id_factura";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_factura", objVO.ID, command));

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

        public bool doCheckIfExists(DbCommand command, int numero, Empresa empresa)
        {
            try
            {                
                string query = "select * from factura f"
                + " inner join operacion o on f.id_operacion = o.id_operacion"
                + " inner join cita c on o.id_cita = c.id_cita"
                + " inner join empleado e on c.id_empleado = e.id_empleado"
                + " where "
                + " numero_factura = {0}numero_factura"
                + " AND "
                + " id_empresa = {0}id_empresa";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_factura", numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

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


        public Factura doGetByOperacion(DbCommand command, Operacion operacion)
        {
            try
            {
                string where = " f.id_operacion = " + this.PARAMETERPREFIX + "id_operacion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", operacion.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Factura res = null;
                if (reader.Read())
                    res = (Factura)this.dataReaderToObject(reader);
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

        public List<Factura> doGetAll(DbCommand command, Ejercicio ejercicio)
        {
            try
            {
                string query = "select *"
                + ", e.id_empleado as e_id_empleado, e.nombre_empleado as e_nombre_empleado, e.apellido1_empleado as e_apellido1_empleado, e.apellido2_empleado as e_apellido2_empleado, e.comision_empleado as e_comision_empleado "
                + " from factura f"
                + " inner join operacion o on f.id_operacion = o.id_operacion"
                + " inner join cita c on o.id_cita = c.id_cita"
                + " inner join paciente p on c.id_paciente = p.id_paciente"
                + " inner join empleado e on c.id_empleado = e.id_empleado"
                + " where "
                + " fecha_factura >= {0}fechaDesde_factura"
                + " AND fecha_factura < {0}fechaHasta_factura"
                + " AND e.id_empresa = {0}id_empresa";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", ejercicio.Empresa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_factura", ejercicio.FechaInicial.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_factura", ejercicio.FechaFinal.Date.AddDays(1), command));

                DbDataReader reader = command.ExecuteReader();
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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

        public List<Factura> doGetAll(DbCommand command, Empleado empleado)
        {
            try
            {
                string query = "select * from factura f"
                + " inner join operacion o on f.id_operacion = o.id_operacion"
                + " inner join cita c on o.id_cita = c.id_cita"
                + " where "
                + " id_empleado = {0}id_empleado";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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

        public List<Factura> doGetAllNoContabilizada(DbCommand command, DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            try
            {
             //   string query = "select *"
             //+ ", e.id_empleado as e_id_empleado, e.nombre_empleado as e_nombre_empleado, e.apellido1_empleado as e_apellido1_empleado, e.apellido2_empleado as e_apellido2_empleado, e.comision_empleado as e_comision_empleado "
             //+ " from factura f"
             //+ " inner join operacion o on f.id_operacion = o.id_operacion"
             //+ " inner join cita c on o.id_cita = c.id_cita"
             //+ " inner join paciente p on c.id_paciente = p.id_paciente"
             //+ " inner join empleado e on c.id_empleado = e.id_empleado"
             //+ " where ";

                string where = string.Format("fecha_factura >= {0}fechaDesde_factura AND fecha_factura < {0}fechaHasta_factura AND contabilizada_factura={0}contabilizada_factura AND id_empresa = {0}id_empresa", this.PARAMETERPREFIX);
                string query = getQuery(where);
                //query += where;

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_factura", fechaDesde.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_factura", fechaHasta.Date.AddDays(1), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizada_factura", false, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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
        public List<Factura> doGetAll(DbCommand command, DateTime fecha)
        {
            try
            {
                string where = string.Format("fecha_factura >= {0}fechaDesde_factura AND fecha_factura < {0}fechaHasta_factura", this.PARAMETERPREFIX);
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_factura", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_factura", fecha.Date.AddDays(1), command));

                DbDataReader reader = command.ExecuteReader();
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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
        public List<Factura> doGetAllContabilizada(DbCommand command, DateTime fechaDesde, DateTime fechaHasta, Empresa empresa)
        {
            try
            {
                //   string query = "select *"
                //+ ", e.id_empleado as e_id_empleado, e.nombre_empleado as e_nombre_empleado, e.apellido1_empleado as e_apellido1_empleado, e.apellido2_empleado as e_apellido2_empleado, e.comision_empleado as e_comision_empleado "
                //+ " from factura f"
                //+ " inner join operacion o on f.id_operacion = o.id_operacion"
                //+ " inner join cita c on o.id_cita = c.id_cita"
                //+ " inner join paciente p on c.id_paciente = p.id_paciente"
                //+ " inner join empleado e on c.id_empleado = e.id_empleado"
                //+ " where ";

                string where = string.Format("fecha_factura >= {0}fechaDesde_factura AND fecha_factura < {0}fechaHasta_factura AND contabilizada_factura={0}contabilizada_factura AND id_empresa = {0}id_empresa", this.PARAMETERPREFIX);
                string query = getQuery(where);
                //query += where;

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_factura", fechaDesde.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_factura", fechaHasta.Date.AddDays(1), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizada_factura", true, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Factura> res = (List<Factura>)this.dataReaderToList(reader);
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
                Factura objVO = (Factura)obj;
                string query = "insert into factura "
                    + " (fecha_factura, id_operacion, numero_factura, serie_factura, observaciones_factura, iva_factura, descuento_factura, importe_factura, concepto_factura, cliente_factura, contabilizada_factura)"
                    + " values "
                    + string.Format(" ({0}fecha_factura, {0}id_operacion, {0}numero_factura, {0}serie_factura, {0}observaciones_factura, {0}iva_factura, {0}descuento_factura, {0}importe_factura, {0}concepto_factura, {0}cliente_factura, {0}contabilizada_factura)", this.PARAMETERPREFIX);
                    //+ " (" + this.PARAMETERPREFIX + "descripcion_factura," + this.PARAMETERPREFIX + "activo_factura)";
                //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_factura", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.Operacion.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_factura", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "serie_factura", objVO.Serie, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_factura", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "iva_factura", objVO.IVA, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "descuento_factura", objVO.Descuento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "importe_factura", objVO.Importe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "concepto_factura", objVO.Concepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cliente_factura", objVO.Cliente, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizada_factura", objVO.Contabilizada, command));

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
                Factura objVO = (Factura)obj;
                string query = "update factura "
                    + "  set "
                    + "  fecha_factura = " + this.PARAMETERPREFIX + "fecha_factura"
                    + " ,id_operacion = " + this.PARAMETERPREFIX + "id_operacion"
                    + " ,numero_factura = " + this.PARAMETERPREFIX + "numero_factura"
                    + " ,serie_factura = " + this.PARAMETERPREFIX + "serie_factura"
                    + " ,observaciones_factura = " + this.PARAMETERPREFIX + "observaciones_factura"
                    + " ,iva_factura = " + this.PARAMETERPREFIX + "iva_factura"
                    + " ,descuento_factura = " + this.PARAMETERPREFIX + "descuento_factura"
                    + " ,importe_factura = " + this.PARAMETERPREFIX + "importe_factura"
                    + " ,concepto_factura = " + this.PARAMETERPREFIX + "concepto_factura"
                    + " ,cliente_factura = " + this.PARAMETERPREFIX + "cliente_factura"
                    + " ,contabilizada_factura = " + this.PARAMETERPREFIX + "contabilizada_factura"
                    + " where"
                    + " id_factura = " + this.PARAMETERPREFIX + "id_factura";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.DateTime, "" + this.PARAMETERPREFIX + "fecha_factura", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.Operacion.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_factura", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "serie_factura", objVO.Serie, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_factura", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "iva_factura", objVO.IVA, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "descuento_factura", objVO.Descuento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "importe_factura", objVO.Importe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "concepto_factura", objVO.Concepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cliente_factura", objVO.Cliente, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizada_factura", objVO.Contabilizada, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_factura", objVO.ID, command));

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

        public object doUpdateContabilizada(DbCommand command, object obj)
        {
            try
            {
                Factura objVO = (Factura)obj;
                string query = "update factura "
                    + "  set "
                    + " contabilizada_factura = " + this.PARAMETERPREFIX + "contabilizada_factura"
                    + " where"
                    + " id_factura = " + this.PARAMETERPREFIX + "id_factura";

                command.CommandText = query;

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizada_factura", objVO.Contabilizada, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_factura", objVO.ID, command));

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
                Factura objVO = (Factura)obj;
                string query = "delete from factura "
                    + " where"
                    + " id_factura = " + this.PARAMETERPREFIX + "id_factura";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_factura", objVO.ID, command));

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
                System.Collections.Generic.List<Factura> res = new System.Collections.Generic.List<Factura>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Factura)dataReaderToObject(reader));
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
