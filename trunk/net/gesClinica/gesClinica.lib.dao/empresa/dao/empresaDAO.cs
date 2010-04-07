using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.empresa.dao
{	
	internal class empresaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from empresa e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Empresa res = null;
				if (reader!=null)
				{
                    res = new Empresa();
                    res.RazonSocial = Convert.ToString(reader["razonsocial_empresa"]);
                    res.ID = Convert.ToInt32(reader["id_empresa"]);
                 
                    res.FacturaConcepto = Convert.ToString(reader["facturaConcepto_empresa"]);
                    res.FacturaCliente = Convert.ToString(reader["facturaCliente_empresa"]);
                    res.FacturaFormato = lib.vo.Empresa.FormatoFromName(Convert.ToString(reader["facturaFormato_empresa"]));
                    res.FacturaIva = Convert.ToInt32(reader["facturaIva_empresa"]);

                    res.CIF = Convert.ToString(reader["cif_empresa"]);
                    res.Direccion= Convert.ToString(reader["direccion_empresa"]);
                    res.OtrosDatos= Convert.ToString(reader["otrosdatos_empresa"]);

                    if (!Convert.IsDBNull(reader["contabilizarfactura_empresa"])) res.ContabilizarFactura = Convert.ToBoolean(reader["contabilizarfactura_empresa"]);
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
                List<Empresa> res = (List<Empresa>)this.dataReaderToList(reader);
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
                Empresa objVO = (Empresa)obj;

                string where = " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Empresa res = null;
                if (reader.Read())
                    res = (Empresa)this.dataReaderToObject(reader);
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
                Empresa objVO = (Empresa)obj;
                string where = " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.ID, command));

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
                Empresa objVO = (Empresa)obj;
                string query = "insert into empresa "
                    + " (razonsocial_empresa, facturaFormato_empresa, facturaCliente_empresa, facturaIva_empresa, cif_empresa, direccion_empresa, otrosdatos_empresa, facturaconcepto_empresa, contabilizarfactura_empresa)"
                    + " values "
                    + string.Format(" ({0}razonsocial_empresa, {0}facturaFormato_empresa, {0}facturaCliente_empresa, {0}facturaIva_empresa, {0}cif_empresa, {0}direccion_empresa, {0}otrosdatos_empresa, {0}facturaconcepto_empresa, {0}contabilizarfactura_empresa)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "razonsocial_empresa", objVO.RazonSocial, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaFormato_empresa", lib.vo.Empresa.NameFromFormato(objVO.FacturaFormato), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaCliente_empresa", objVO.FacturaCliente, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaConcepto_empresa", objVO.FacturaConcepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "facturaIva_empresa", objVO.FacturaIva, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cif_empresa", objVO.CIF, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_empresa", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "otrosdatos_empresa", objVO.OtrosDatos, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizarfactura_empresa", objVO.ContabilizarFactura, command));
                
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
                Empresa objVO = (Empresa)obj;
                string query = "update empresa "
                    + "  set "
                    + "  razonsocial_empresa = " + this.PARAMETERPREFIX + "razonsocial_empresa"
                    + " ,facturaFormato_empresa = " + this.PARAMETERPREFIX + "facturaFormato_empresa"
                    + " ,facturaCliente_empresa = " + this.PARAMETERPREFIX + "facturaCliente_empresa"
                    + " ,facturaIva_empresa = " + this.PARAMETERPREFIX + "facturaIva_empresa"
                    + " ,cif_empresa = " + this.PARAMETERPREFIX + "cif_empresa"
                    + " ,direccion_empresa = " + this.PARAMETERPREFIX + "direccion_empresa"
                    + " ,otrosdatos_empresa = " + this.PARAMETERPREFIX + "otrosdatos_empresa"
                    + " ,facturaConcepto_empresa = " + this.PARAMETERPREFIX + "facturaConcepto_empresa"
                    + " ,contabilizarfactura_empresa = " + this.PARAMETERPREFIX + "contabilizarfactura_empresa"
                    + " where"
                    + " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "razonsocial_empresa", objVO.RazonSocial, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaFormato_empresa", lib.vo.Empresa.NameFromFormato(objVO.FacturaFormato), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaCliente_empresa", objVO.FacturaCliente, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "facturaConcepto_empresa", objVO.FacturaConcepto, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "facturaIva_empresa", objVO.FacturaIva, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cif_empresa", objVO.CIF, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_empresa", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "otrosdatos_empresa", objVO.OtrosDatos, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "contabilizarfactura_empresa", objVO.ContabilizarFactura, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.ID, command));

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
                Empresa objVO = (Empresa)obj;
                string query = "delete from empresa "
                    + " where"
                    + " id_empresa = " + this.PARAMETERPREFIX + "id_empresa";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.ID, command));

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
                System.Collections.Generic.List<Empresa> res = new System.Collections.Generic.List<Empresa>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Empresa)dataReaderToObject(reader));
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
