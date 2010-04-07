using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.apunte.dao
{	
	internal class apunteDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from apunte e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Apunte res = null;
				if (reader!=null)
				{
                    res = new Apunte();
                    res.Asiento = new Asiento();
                    res.Asiento.ID = Convert.ToInt32(reader["id_asiento"]);

                    //TODO: Numero Asiento. Poner en Proc. Almac.
                    //res.Asiento.Numero = Convert.ToInt32(reader["numero_asiento"]);
                    res.Concepto = Convert.ToString(reader["concepto_apunte"]);
                    res.Consolidado= Convert.ToBoolean(reader["consolidado_apunte"]);
                    if (!Convert.IsDBNull(reader["contrapartida_apunte"]))
                    {
                        res.ContraPartida = new SubCuenta();
                        res.ContraPartida.Codigo = Convert.ToString(reader["contrapartida_apunte"]);
                    }
                    res.Debe = Convert.ToSingle(reader["debe_apunte"]);
                    res.Fecha = Convert.ToDateTime(reader["fecha_apunte"]);
                    res.Haber= Convert.ToSingle(reader["haber_apunte"]);
                    res.ID= Convert.ToInt32(reader["id_apunte"]);
                    res.NumeroFactura= Convert.ToInt32(reader["numeroFactura_apunte"]);
                    res.Punteado= Convert.ToBoolean(reader["punteado_apunte"]);
                    res.Referencia= Convert.ToString(reader["referencia_apunte"]);
                    res.SubCuenta = new SubCuenta();
                    res.SubCuenta.Codigo= Convert.ToString(reader["subcuenta_apunte"]);
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
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, vo.Asiento asiento)
        {
            try
            {
                string where = " id_asiento = " + this.PARAMETERPREFIX + "id_asiento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", asiento.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public List<Apunte> doGetAll(DbCommand command, List<vo.SubCuenta> lista, Ejercicio ejercicio)
        {
            try
            {
                string where = string.Empty;
                if (lista != null)
                {
                    where = " ((1=0) ";
                    foreach (vo.SubCuenta subc in lista)
                    {
                        where += string.Format(" OR (subcuenta_apunte like '{0}%') ", subc.Codigo);
                    }
                    where += " )";
                }

                string query =
                  " select * from apunte ap"
                + " left join asiento asi on asi.id_asiento = ap.id_asiento"
                + " left join ejercicio ej on ej.id_ejercicio = asi.id_ejercicio"
                + " where "
                + where
                + " AND "
                + " ej.id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, vo.SubCuenta subCuenta, Ejercicio ejercicio)
        {
            try
            {
                string query = 
                  " select * from apunte ap"
                + " left join asiento asi on asi.id_asiento = ap.id_asiento"
                + " left join ejercicio ej on ej.id_ejercicio = asi.id_ejercicio"
                + " where "
                + " subcuenta_apunte = {0}subcuenta_apunte  "
                + " AND "
                + " ej.id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "subcuenta_apunte", subCuenta.Codigo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public List<Apunte> doGetAll(DbCommand command, Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                string query =
                  " select * from apunte ap"
                + " left join asiento asi on asi.id_asiento = ap.id_asiento"
                + " left join ejercicio ej on ej.id_ejercicio = asi.id_ejercicio"
                + " where "
                + " fecha_apunte >= {0}fechaDesde_apunte"
                + " AND "
                + " fecha_apunte < {0}fechaHasta_apunte"
                + " AND "
                + " ej.id_ejercicio = {0}id_ejercicio";
                
                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_apunte", fechaDesde.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_apunte", fechaHasta.Date.AddDays(1), command));
                
                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public List<Apunte> doGetAll(DbCommand command, SubCuenta subCuenta, Ejercicio ejercicio, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                string query =
                  " select * from apunte ap"
                + " left join asiento asi on asi.id_asiento = ap.id_asiento"
                + " left join ejercicio ej on ej.id_ejercicio = asi.id_ejercicio"
                + " where "
                + " subcuenta_apunte = {0}subcuenta_apunte  "
                + " AND "
                + " fecha_apunte >= {0}fechaDesde_apunte"
                + " AND "
                + " fecha_apunte < {0}fechaHasta_apunte"
                + " AND "
                + " ej.id_ejercicio = {0}id_ejercicio";

                query = string.Format(query, this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaDesde_apunte", fechaDesde.Date, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaHasta_apunte", fechaHasta.Date.AddDays(1), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "subcuenta_apunte", subCuenta.Codigo, command));
          
                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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

        public List<Apunte> doGetAllFacturasEmitidas(DbCommand command, Ejercicio ejercicio)
        {
            try
            {
                string query = string.Format("{0} sp_doGetAllFacturasEmitidas ({1}id_ejercicio)", this.CALLSTOREDPROCEDURE, this.PARAMETERPREFIX);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public List<Apunte> doGetAllFacturasRecibidas(DbCommand command, Ejercicio ejercicio)
        {
            try
            {
                string query = string.Format("{0} sp_doGetAllFacturasRecibidas ({1}id_ejercicio)", this.CALLSTOREDPROCEDURE, this.PARAMETERPREFIX);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
        public List<Apunte> doGetAllAmortizaciones(DbCommand command, Ejercicio ejercicio)
        {
            try
            {
                string query = string.Format("{0} sp_doGetAllAmortizaciones ({1}id_ejercicio)", this.CALLSTOREDPROCEDURE, this.PARAMETERPREFIX);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_ejercicio", ejercicio.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Apunte> res = (List<Apunte>)this.dataReaderToList(reader);
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
                Apunte objVO = (Apunte)obj;

                string where = " id_apunte = " + this.PARAMETERPREFIX + "id_apunte";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_apunte", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Apunte res = null;
                if (reader.Read())
                    res = (Apunte)this.dataReaderToObject(reader);
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
                Apunte objVO = (Apunte)obj;
                string where = " id_apunte = " + this.PARAMETERPREFIX + "id_apunte";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_apunte", objVO.ID, command));

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
                Apunte objVO = (Apunte)obj;
                string query = "insert into apunte "
                    + " (id_asiento, concepto_apunte, consolidado_apunte, contrapartida_apunte, debe_apunte, fecha_apunte, haber_apunte, numeroFactura_apunte, punteado_apunte, referencia_apunte, subcuenta_apunte)"
                    + " values "
                    + string.Format(" ({0}id_asiento, {0}concepto_apunte, {0}consolidado_apunte, {0}contrapartida_apunte, {0}debe_apunte, {0}fecha_apunte, {0}haber_apunte, {0}numeroFactura_apunte, {0}punteado_apunte, {0}referencia_apunte, {0}subcuenta_apunte)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", objVO.Asiento.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "concepto_apunte", objVO.Concepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "consolidado_apunte", objVO.Consolidado, command));
                if (objVO.ContraPartida!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_apunte", objVO.ContraPartida.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_apunte", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "debe_apunte", objVO.Debe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_apunte", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "haber_apunte", objVO.Haber, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numeroFactura_apunte", objVO.NumeroFactura, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "punteado_apunte", objVO.Punteado, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "referencia_apunte", objVO.Referencia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "subcuenta_apunte", objVO.SubCuenta.Codigo, command));

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
                Apunte objVO = (Apunte)obj;
                string query = "update apunte "
                    + "  set "
                    + "  id_asiento = " + this.PARAMETERPREFIX + "id_asiento"
                    + " ,concepto_apunte = " + this.PARAMETERPREFIX + "concepto_apunte"
                    + " ,consolidado_apunte = " + this.PARAMETERPREFIX + "consolidado_apunte"
                    + " ,contrapartida_apunte = " + this.PARAMETERPREFIX + "contrapartida_apunte"
                    + " ,debe_apunte = " + this.PARAMETERPREFIX + "debe_apunte"
                    + " ,fecha_apunte = " + this.PARAMETERPREFIX + "fecha_apunte"
                    + " ,haber_apunte = " + this.PARAMETERPREFIX + "haber_apunte"
                    + " ,numeroFactura_apunte = " + this.PARAMETERPREFIX + "numeroFactura_apunte"
                    + " ,punteado_apunte = " + this.PARAMETERPREFIX + "punteado_apunte"
                    + " ,referencia_apunte = " + this.PARAMETERPREFIX + "referencia_apunte"
                    + " ,subcuenta_apunte = " + this.PARAMETERPREFIX + "subcuenta_apunte"
                    + " where"
                    + " id_apunte = " + this.PARAMETERPREFIX + "id_apunte";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_asiento", objVO.Asiento.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "concepto_apunte", objVO.Concepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "consolidado_apunte", objVO.Consolidado, command));
                if (objVO.ContraPartida != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_apunte", objVO.ContraPartida.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contrapartida_apunte", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "debe_apunte", objVO.Debe, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_apunte", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "haber_apunte", objVO.Haber, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numeroFactura_apunte", objVO.NumeroFactura, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "punteado_apunte", objVO.Punteado, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "referencia_apunte", objVO.Referencia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "subcuenta_apunte", objVO.SubCuenta.Codigo, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_apunte", objVO.ID, command));

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
                Apunte objVO = (Apunte)obj;
                string query = "delete from apunte "
                    + " where"
                    + " id_apunte = " + this.PARAMETERPREFIX + "id_apunte";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_apunte", objVO.ID, command));

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

        public object doDeleteByAsiento(DbCommand command, Asiento obj)
        {
            try
            {
                Asiento objVO = (Asiento)obj;
                string query = "delete from apunte "
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
                System.Collections.Generic.List<Apunte> res = new System.Collections.Generic.List<Apunte>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Apunte)dataReaderToObject(reader));
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
