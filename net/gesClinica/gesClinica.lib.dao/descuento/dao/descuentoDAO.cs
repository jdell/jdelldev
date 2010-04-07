using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.descuento.dao
{	
	internal class descuentoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from descuento d"
            + " left join empleado e on d.id_empleado = e.id_empleado"
            + " left join paciente p on d.id_paciente = p.id_paciente";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Descuento res = null;
				if (reader!=null)
				{
                    res = new Descuento();

                    res.Discount = Convert.ToInt32(reader["discount_descuento"]);

                    res.Empleado = new Empleado();
                    res.Empleado.ID = Convert.ToInt32(reader["id_empleado"]);
                    res.Empleado.Nombre = Convert.ToString(reader["nombre_empleado"]);
                    res.Empleado.Apellido1= Convert.ToString(reader["apellido1_empleado"]);
                    res.Empleado.Apellido2= Convert.ToString(reader["apellido2_empleado"]);

                    res.Paciente = new Paciente();
                    res.Paciente.ID = Convert.ToInt32(reader["id_paciente"]);
                    res.Paciente.Nombre = Convert.ToString(reader["nombre_paciente"]);
                    res.Paciente.Apellido1 = Convert.ToString(reader["apellido1_paciente"]);
                    res.Paciente.Apellido2 = Convert.ToString(reader["apellido2_paciente"]);
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
                List<Descuento> res = (List<Descuento>)this.dataReaderToList(reader);
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

        public List<Descuento> doGetAll(DbCommand command, Paciente paciente)
        {
            try
            {
                string query = "select t.*, {1}(discount_descuento, 0) discount_descuento, "
                + " {1}(d.id_paciente, {0}id_paciente) id_paciente, "
                + " {1}(p.nombre_paciente, {0}nombre_paciente) nombre_paciente, "
                + " {1}(p.apellido1_paciente, {0}apellido1_paciente) apellido1_paciente, "
                + " {1}(p.apellido2_paciente, {0}apellido2_paciente) apellido2_paciente"
                + " from empleado t"
                + " left join descuento d on t.id_empleado= d.id_empleado and id_paciente = {0}id_paciente"
                + " left join paciente p on d.id_paciente = p.id_paciente"
                + " where "
                + " t.terapeuta_empleado = {0}terapeuta_empleado";

                query = string.Format(query, this.PARAMETERPREFIX, this.ISNULLFUNCTION);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_paciente", paciente.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido1_paciente", paciente.Apellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido2_paciente", paciente.Apellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "terapeuta_empleado", true, command));

                DbDataReader reader = command.ExecuteReader();
                List<Descuento> res = (List<Descuento>)this.dataReaderToList(reader);
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
                Descuento objVO = (Descuento)obj;

                string where = " d.id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                + " AND "
                + " d.id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Descuento res = null;
                if (reader.Read())
                    res = (Descuento)this.dataReaderToObject(reader);
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
                Descuento objVO = (Descuento)obj;
                string where = " d.id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                + " AND "
                + " d.id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));

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
                Descuento objVO = (Descuento)obj;
                string query = "insert into descuento "
                    + " (discount_descuento, id_paciente, id_empleado)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "discount_descuento," + this.PARAMETERPREFIX + "id_paciente," + this.PARAMETERPREFIX + "id_empleado)";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "discount_descuento", objVO.Discount, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));

                command.ExecuteNonQuery();
                return 0;
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
                Descuento objVO = (Descuento)obj;
                string query = "update descuento "
                    + "  set "
                    + "  discount_descuento = " + this.PARAMETERPREFIX + "discount_descuento"
                    + " where"
                    + " id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                    + " AND "
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "discount_descuento", objVO.Discount, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));

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
                Descuento objVO = (Descuento)obj;
                string query = "delete from descuento "
                    + " where"
                    + " id_empleado = " + this.PARAMETERPREFIX + "id_empleado"
                    + " AND "
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.Paciente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.Empleado.ID, command));

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

        public void doDeleteAll(DbCommand command, Paciente paciente)
        {
            try
            {
                string query = "delete from descuento "
                    + " where"
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", paciente.ID, command));

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
                System.Collections.Generic.List<Descuento> res = new System.Collections.Generic.List<Descuento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Descuento)dataReaderToObject(reader));
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
