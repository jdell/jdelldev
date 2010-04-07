using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.pago.dao
{	
	internal class pagoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select *"
            + " ,emp.id_empleado emp_id_empleado, emp.nombre_empleado emp_nombre_empleado, emp.apellido1_empleado emp_apellido1_empleado, emp.apellido2_empleado emp_apellido2_empleado, emp.comision_empleado emp_comision_empleado, emp.color1_empleado emp_color1_empleado, emp.color2_empleado emp_color2_empleado"
            + " from pago e"
            + " left join formapago tf on e.id_formapago = tf.id_formapago"
            + " left join operacion op on e.id_operacion = op.id_operacion"
            + " left join cita ci on op.id_cita = ci.id_cita"
            + " left join empleado emp on ci.id_empleado = emp.id_empleado";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Pago res = null;
				if (reader!=null)
				{
                    res = new Pago();
                    res.FormaPago = new FormaPago();
                    res.FormaPago.ID = Convert.ToInt32(reader["id_formapago"]);
                    res.FormaPago.Descripcion = Convert.ToString(reader["descripcion_formapago"]);

                    res.Fecha = Convert.ToDateTime(reader["fecha_pago"]);
                    res.Importe = Convert.ToSingle(reader["importe_pago"]);
                    res.Observaciones= Convert.ToString(reader["observaciones_pago"]);
                    res.Operacion = new Operacion();
                    res.Operacion.ID = Convert.ToInt32(reader["id_operacion"]); 
                    res.Operacion.Tipo = Operacion.TipoFromName(Convert.ToString(reader["tipo_operacion"]));
                    if (!Convert.IsDBNull(reader["id_cita"]))
                    {
                        res.Operacion.Cita = new Cita();
                        res.Operacion.Cita.ID = Convert.ToInt32(reader["id_cita"]);
                        res.Operacion.Cita.Fecha = Convert.ToDateTime(reader["fecha_cita"]);

                        
                        res.Operacion.Cita.Empleado = new Empleado();
                        res.Operacion.Cita.Empleado.ID = Convert.ToInt32(reader["emp_id_empleado"]);
                        res.Operacion.Cita.Empleado.Nombre = Convert.ToString(reader["emp_nombre_empleado"]);
                        res.Operacion.Cita.Empleado.Apellido1 = Convert.ToString(reader["emp_apellido1_empleado"]);
                        res.Operacion.Cita.Empleado.Apellido2 = Convert.ToString(reader["emp_apellido2_empleado"]);
                        res.Operacion.Cita.Empleado.Comision = Convert.ToInt32(reader["emp_comision_empleado"]);
                    }
                    res.ID= Convert.ToInt32(reader["id_pago"]);
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
                List<Pago> res = (List<Pago>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, FormaPago formaPago)
        {
            try
            {
                string where = " tf.id_formapago = " + this.PARAMETERPREFIX + "id_formapago";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", formaPago.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Pago> res = (List<Pago>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, Operacion operacion)
        {
            try
            {
                string where = " e.id_operacion = " + this.PARAMETERPREFIX + "id_operacion";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", operacion.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Pago> res = (List<Pago>)this.dataReaderToList(reader);
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
        public List<Pago> doGetAll(DbCommand command, DateTime fecha)
        {
            try
            {
                string where = string.Format("fecha_pago >= {0}fechaDesde_pago AND fecha_pago < {0}fechaHasta_pago", this.PARAMETERPREFIX);

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_pago", fecha.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_pago", fecha.Date.AddDays(1), command));
                
                DbDataReader reader = command.ExecuteReader();
                List<Pago> res = (List<Pago>)this.dataReaderToList(reader);
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
                Pago objVO = (Pago)obj;

                string where = " id_pago = " + this.PARAMETERPREFIX + "id_pago";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_pago", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Pago res = null;
                if (reader.Read())
                    res = (Pago)this.dataReaderToObject(reader);
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
                Pago objVO = (Pago)obj;
                string where = " id_pago = " + this.PARAMETERPREFIX + "id_pago  ";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_pago", objVO.ID, command));

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
                Pago objVO = (Pago)obj;
                string query = "insert into pago "
                    + " (fecha_pago, id_formapago, importe_pago, observaciones_pago, id_operacion)"
                    + " values "
                    + string.Format("({0}fecha_pago, {0}id_formapago, {0}importe_pago, {0}observaciones_pago, {0}id_operacion)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_pago", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.FormaPago.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "importe_pago", objVO.Importe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_pago", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.Operacion.ID, command));
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
                Pago objVO = (Pago)obj;
                string query = "update pago "
                    + "  set "
                    + "  fecha_pago = " + this.PARAMETERPREFIX + "fecha_pago"
                    + " ,id_formapago = " + this.PARAMETERPREFIX + "id_formapago"
                    + " ,importe_pago = " + this.PARAMETERPREFIX + "importe_pago"
                    + " ,observaciones_pago = " + this.PARAMETERPREFIX + "observaciones_pago"
                    + " ,id_operacion = " + this.PARAMETERPREFIX + "id_operacion"
                    + " where"
                    + " id_pago = " + this.PARAMETERPREFIX + "id_pago";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_pago", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_formapago", objVO.FormaPago.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "importe_pago", objVO.Importe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_pago", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_operacion", objVO.Operacion.ID, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_pago", objVO.ID, command));

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
                Pago objVO = (Pago)obj;
                string query = "delete from pago "
                    + " where"
                    + " id_pago = " + this.PARAMETERPREFIX + "id_pago";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_pago", objVO.ID, command));

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
                string query = "delete from pago ";

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
                System.Collections.Generic.List<Pago> res = new System.Collections.Generic.List<Pago>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Pago)dataReaderToObject(reader));
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
