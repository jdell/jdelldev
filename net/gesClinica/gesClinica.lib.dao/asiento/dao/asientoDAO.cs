using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.asiento.dao
{	
	internal class asientoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from asiento e"
            + " left join ejercicio ej on e.id_ejercicio = ej.id_ejercicio";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Asiento res = null;
				if (reader!=null)
				{
                    res = new Asiento();
                    res.Ejercicio = new Ejercicio();
                    res.Ejercicio.ID = Convert.ToInt32(reader["id_ejercicio"]);
                    res.Ejercicio.Descripcion= Convert.ToString(reader["descripcion_ejercicio"]);
                    res.Fecha = Convert.ToDateTime(reader["fecha_asiento"]);
                    res.ID = Convert.ToInt32(reader["id_asiento"]);
                    res.Numero = Convert.ToInt32(reader["numero_asiento"]);
                    res.Observaciones= Convert.ToString(reader["observaciones_asiento"]);

                    res.NumeroFactura = Convert.ToInt32(reader["numerofactura_asiento"]);
                    res.TipoAsiento = (vo.tTIPOASIENTO)System.Enum.Parse(typeof(vo.tTIPOASIENTO),Convert.ToString(reader["tipo_asiento"]));
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
                List<Asiento> res = (List<Asiento>)this.dataReaderToList(reader);
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
        public List<Asiento> doGetAll(DbCommand command, Ejercicio ejercicio)
        {
            try
            {
                string where = " e.id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));


                DbDataReader reader = command.ExecuteReader();
                List<Asiento> res = (List<Asiento>)this.dataReaderToList(reader);
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

        public List<Asiento> doGetAll(DbCommand command, Factura factura, Ejercicio ejercicio)
        {
            try
            {
                string where = 
                      " e.id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio"
                    + " AND "
                    + " e.numerofactura_asiento = " + this.PARAMETERPREFIX + "numerofactura_asiento"
                    + " AND "
                    + " e.tipo_asiento = " + this.PARAMETERPREFIX + "tipo_asiento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numerofactura_asiento", factura.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_asiento", tTIPOASIENTO.FACTURA_EMITIDA.ToString(), command));


                DbDataReader reader = command.ExecuteReader();
                List<Asiento> res = (List<Asiento>)this.dataReaderToList(reader);
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
                Asiento objVO = (Asiento)obj;

                string where = " id_asiento = " + this.PARAMETERPREFIX + "id_asiento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Asiento res = null;
                if (reader.Read())
                    res = (Asiento)this.dataReaderToObject(reader);
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
        public Asiento doGetBy(DbCommand command, object obj)
        {
            try
            {
                Asiento objVO = (Asiento)obj;

                string where = " e.id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio"
                + " AND "
                + " numero_asiento = " + this.PARAMETERPREFIX + "numero_asiento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_asiento", objVO.Numero, command));

                DbDataReader reader = command.ExecuteReader();
                Asiento res = null;
                if (reader.Read())
                    res = (Asiento)this.dataReaderToObject(reader);
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
                Asiento objVO = (Asiento)obj;
                string where = " e.id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio"
                + " AND "
                + " numero_asiento = " + this.PARAMETERPREFIX + "numero_asiento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_asiento", objVO.Numero, command));

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
                //res.Ejercicio.ID = Convert.ToInt32(reader["id_ejercicio"]);
                //res.Fecha = Convert.ToString(reader["fecha_asiento"]);
                //res.ID = Convert.ToInt32(reader["id_asiento"]);
                //res.Numero = Convert.ToInt32(reader["numero_asiento"]);
                //res.Observaciones = Convert.ToString(reader["observaciones_asiento"]);

                Asiento objVO = (Asiento)obj;
                string query = "insert into asiento "
                    + " (id_ejercicio, fecha_asiento, numero_asiento, observaciones_asiento, numerofactura_asiento, tipo_asiento)"
                    + " values "
                    + string.Format(" ({0}id_ejercicio, {0}fecha_asiento, {0}numero_asiento, {0}observaciones_asiento, {0}numerofactura_asiento, {0}tipo_asiento)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_asiento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_asiento", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_asiento", objVO.Observaciones, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numerofactura_asiento", objVO.NumeroFactura, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_asiento", objVO.TipoAsiento, command));

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
                Asiento objVO = (Asiento)obj;
                string query = "update asiento "
                    + "  set "
                    + "  id_ejercicio = " + this.PARAMETERPREFIX + "id_ejercicio"
                    + " ,fecha_asiento = " + this.PARAMETERPREFIX + "fecha_asiento"
                    + " ,numero_asiento = " + this.PARAMETERPREFIX + "numero_asiento"
                    + " ,observaciones_asiento = " + this.PARAMETERPREFIX + "observaciones_asiento"
                    + " ,numerofactura_asiento = " + this.PARAMETERPREFIX + "numerofactura_asiento"
                    + " ,tipo_asiento = " + this.PARAMETERPREFIX + "tipo_asiento"
                    + " where"
                    + " id_asiento = " + this.PARAMETERPREFIX + "id_asiento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", objVO.Ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_asiento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numero_asiento", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_asiento", objVO.Observaciones, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numerofactura_asiento", objVO.NumeroFactura, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_asiento", objVO.TipoAsiento, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", objVO.ID, command));

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
                Asiento objVO = (Asiento)obj;
                string query = "delete from asiento "
                    + " where"
                    + " id_asiento = " + this.PARAMETERPREFIX + "id_asiento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", objVO.ID, command));

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
                System.Collections.Generic.List<Asiento> res = new System.Collections.Generic.List<Asiento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Asiento)dataReaderToObject(reader));
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
