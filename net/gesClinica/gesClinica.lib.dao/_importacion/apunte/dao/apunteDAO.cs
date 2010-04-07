using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.apunte.dao
{	
	internal class apunteDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from apuntes e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by fecha asc";

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
                    if (!Convert.IsDBNull(reader["Abono"])) res.Abono = Convert.ToString(reader["Abono"]);
                    if (!Convert.IsDBNull(reader["Asiento"])) res.Asiento = Convert.ToInt32(reader["Asiento"]);
                    if (!Convert.IsDBNull(reader["CentroDeCoste"])) res.CentroCoste = Convert.ToString(reader["CentroDeCoste"]);
                    if (!Convert.IsDBNull(reader["Codigo"])) res.Codigo = Convert.ToString(reader["Codigo"]);
                    if (!Convert.IsDBNull(reader["CodUsuario"])) res.CodigoUsuario = Convert.ToInt32(reader["CodUsuario"]);
                    if (!Convert.IsDBNull(reader["ConceptoCodigo"])) res.ConceptoCodigo = Convert.ToString(reader["ConceptoCodigo"]);
                    if (!Convert.IsDBNull(reader["ConceptoTexto"])) res.ConceptoTexto = Convert.ToString(reader["ConceptoTexto"]);
                    if (!Convert.IsDBNull(reader["Consolidado"])) res.Consolidado = Convert.ToString(reader["Consolidado"]);
                    if (!Convert.IsDBNull(reader["ContraPartida"]))
                    {
                        res.ContraPartida = new SubCuenta();
                        res.ContraPartida.Codigo = Convert.ToString(reader["ContraPartida"]);
                    }
                    if (!Convert.IsDBNull(reader["CuentaReferencia"])) res.CuentaReferencia = Convert.ToString(reader["CuentaReferencia"]);
                    if (!Convert.IsDBNull(reader["Debe"])) res.Debe = Convert.ToSingle(reader["Debe"]);
                    if (!Convert.IsDBNull(reader["Documento"])) res.Documento = Convert.ToString(reader["Documento"]);
                    if (!Convert.IsDBNull(reader["CodEjercicio"]))
                    {
                        res.Ejercicio = new Ejercicio();
                        res.Ejercicio.Codigo = Convert.ToString(reader["CodEjercicio"]);
                    }
                    if (!Convert.IsDBNull(reader["Empresa"])) res.Empresa = Convert.ToString(reader["Empresa"]);
                    if (!Convert.IsDBNull(reader["Factura"])) res.Factura = Convert.ToString(reader["Factura"]);
                    if (!Convert.IsDBNull(reader["Fecha"])) res.Fecha = Convert.ToDateTime(reader["Fecha"]);
                    if (!Convert.IsDBNull(reader["FechaGrabacion"])) res.FechaGrabacion = Convert.ToDateTime(reader["FechaGrabacion"]);
                    if (!Convert.IsDBNull(reader["Haber"])) res.Haber = Convert.ToSingle(reader["Haber"]);
                    if (!Convert.IsDBNull(reader["Moneda"])) res.Moneda = Convert.ToInt32(reader["Moneda"]);
                    if (!Convert.IsDBNull(reader["Apunte"])) res.NumeroApunte = Convert.ToInt32(reader["Apunte"]);
                    if (!Convert.IsDBNull(reader["Punteado"])) res.Punteado = Convert.ToString(reader["Punteado"]);
                    if (!Convert.IsDBNull(reader["Referencia"])) res.Referencia = Convert.ToString(reader["Referencia"]);
                    if (!Convert.IsDBNull(reader["SubCuenta"]))
                    {
                        res.SubCuenta = new SubCuenta();
                        res.SubCuenta.Codigo = Convert.ToString(reader["SubCuenta"]);
                    }
                    if (!Convert.IsDBNull(reader["TipoDocumento"])) res.TipoDocumento = Convert.ToString(reader["TipoDocumento"]);
                    if (!Convert.IsDBNull(reader["Unidades"])) res.Unidades = Convert.ToInt32(reader["Unidades"]);
                    if (!Convert.IsDBNull(reader["Vencimiento"])) res.Vencimiento = Convert.ToDateTime(reader["Vencimiento"]);
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

        public override object doGet(DbCommand command, object obj)
        {
            try
            {
                Apunte objVO = (Apunte)obj;

                string where = " Codigo = " + this.PARAMETERPREFIX + "Codigo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "Codigo", objVO.Codigo, command));

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
