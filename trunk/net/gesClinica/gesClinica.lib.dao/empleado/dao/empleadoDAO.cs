using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.empleado.dao
{	
	internal class empleadoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from empleado e"
            + " left join empresa em on e.id_empresa = em.id_empresa";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Empleado res = null;
				if (reader!=null)
				{
                    res = new Empleado();
                    res.VerSoloLoMio = Convert.ToBoolean(reader["verSoloLoMio_empleado"]);
                    res.Activo = Convert.ToBoolean(reader["activo_empleado"]);
                    res.Administrativo = Convert.ToBoolean(reader["administrativo_empleado"]);
                    res.Apellido1 = Convert.ToString(reader["apellido1_empleado"]);
                    res.Apellido2 = Convert.ToString(reader["apellido2_empleado"]);
                    res.Comision = Convert.ToInt32(reader["comision_empleado"]);
                    res.Nombre = Convert.ToString(reader["nombre_empleado"]);
                    res.Terapeuta = Convert.ToBoolean(reader["terapeuta_empleado"]);
                    res.ID = Convert.ToInt32(reader["id_empleado"]);
                    res.Login = Convert.ToString(reader["login_empleado"]);
                    res.Gerente = Convert.ToBoolean(reader["gerente_empleado"]);
                    res.Firma = Convert.ToString(reader["firma_empleado"]);

                    res.Empresa = new Empresa();
                    res.Empresa.RazonSocial = Convert.ToString(reader["razonsocial_empresa"]);
                    res.Empresa.ID = Convert.ToInt32(reader["id_empresa"]);

                    res.Empresa.FacturaConcepto = Convert.ToString(reader["facturaConcepto_empresa"]);
                    res.Empresa.FacturaCliente = Convert.ToString(reader["facturaCliente_empresa"]);
                    res.Empresa.FacturaFormato = lib.vo.Empresa.FormatoFromName(Convert.ToString(reader["facturaFormato_empresa"]));
                    res.Empresa.FacturaIva = Convert.ToInt32(reader["facturaIva_empresa"]);

                    res.Empresa.CIF = Convert.ToString(reader["cif_empresa"]);
                    res.Empresa.Direccion = Convert.ToString(reader["direccion_empresa"]);
                    res.Empresa.OtrosDatos = Convert.ToString(reader["otrosdatos_empresa"]);
                    if (!Convert.IsDBNull(reader["contabilizarfactura_empresa"])) res.Empresa.ContabilizarFactura = Convert.ToBoolean(reader["contabilizarfactura_empresa"]);
			
                    if (!Convert.IsDBNull(reader["color1_empleado"])) res.Color1 = Convert.ToString(reader["color1_empleado"]);
                    if (!Convert.IsDBNull(reader["color2_empleado"])) res.Color2 = Convert.ToString(reader["color2_empleado"]);

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
                List<Empleado> res = (List<Empleado>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, Empresa empresa)
        {
            try
            {
                string where = " e.id_empresa = " + this.PARAMETERPREFIX + "id_empresa ";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", empresa.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Empleado> res = (List<Empleado>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, bool soloActivo)
        {
            try
            {

                if (!soloActivo)
                {
                    string query = getQuery();
                    command.CommandText = query;
                }
                else
                {
                    string where = " activo_empleado = " + this.PARAMETERPREFIX + "activo_empleado ";
                    string query = getQuery(where);
                    command.CommandText = query;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_empleado", true, command));
                }


                DbDataReader reader = command.ExecuteReader();
                List<Empleado> res = (List<Empleado>)this.dataReaderToList(reader);
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

        public object doGetAllTerapeutas(DbCommand command)
        {
            try
            {
                string where = " terapeuta_empleado = " + this.PARAMETERPREFIX + "terapeuta_empleado";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "terapeuta_empleado", true, command));

                DbDataReader reader = command.ExecuteReader();
                List<Empleado> res = (List<Empleado>)this.dataReaderToList(reader);
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
                Empleado objVO = (Empleado)obj;

                string where = " id_empleado = " + this.PARAMETERPREFIX + "id_empleado";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Empleado res = null;
                if (reader.Read())
                    res = (Empleado)this.dataReaderToObject(reader);
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


        public object doGetByLogin(DbCommand command, Empleado empleado)
        {
            try
            {
                Empleado objVO = (Empleado)empleado;

                string where = " login_empleado = " + this.PARAMETERPREFIX + "login_empleado ";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "login_empleado", objVO.Login, command));

                DbDataReader reader = command.ExecuteReader();
                Empleado res = null;
                if (reader.Read())
                    res = (Empleado)this.dataReaderToObject(reader);
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
                Empleado objVO = (Empleado)obj;
                string where = " id_empleado = " + this.PARAMETERPREFIX + "id_empleado";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.ID, command));

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
                Empleado objVO = (Empleado)obj;
                string query = "insert into empleado "
                    + " (administrativo_empleado, apellido1_empleado, apellido2_empleado, comision_empleado, nombre_empleado, terapeuta_empleado, login_empleado, activo_empleado, gerente_empleado, firma_empleado, id_empresa, verSoloLoMio_empleado, color1_empleado, color2_empleado)"
                    + " values "
                    + string.Format(" ({0}administrativo_empleado, {0}apellido1_empleado, {0}apellido2_empleado, {0}comision_empleado, {0}nombre_empleado, {0}terapeuta_empleado, {0}login_empleado, {0}activo_empleado, {0}gerente_empleado, {0}firma_empleado, {0}id_empresa, {0}verSoloLoMio_empleado, {0}color1_empleado, {0}color2_empleado)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "administrativo_empleado", objVO.Administrativo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido1_empleado", objVO.Apellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido2_empleado", objVO.Apellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "comision_empleado", objVO.Comision, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_empleado", objVO.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "login_empleado", objVO.Login, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "terapeuta_empleado", objVO.Terapeuta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_empleado", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "gerente_empleado", objVO.Gerente, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "firma_empleado", objVO.Firma, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "verSoloLoMio_empleado", objVO.VerSoloLoMio, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color1_empleado", objVO.Color1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color2_empleado", objVO.Color2, command));
                

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));
                
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
                Empleado objVO = (Empleado)obj;
                string query = "update empleado "
                    + "  set "
                    + "  administrativo_empleado = " + this.PARAMETERPREFIX + "administrativo_empleado"
                    + " ,apellido1_empleado = " + this.PARAMETERPREFIX + "apellido1_empleado"
                    + " ,apellido2_empleado = " + this.PARAMETERPREFIX + "apellido2_empleado"
                    + " ,comision_empleado = " + this.PARAMETERPREFIX + "comision_empleado"
                    + " ,nombre_empleado = " + this.PARAMETERPREFIX + "nombre_empleado"
                    + " ,terapeuta_empleado = " + this.PARAMETERPREFIX + "terapeuta_empleado"
                    + " ,login_empleado = " + this.PARAMETERPREFIX + "login_empleado"
                    + " ,activo_empleado = " + this.PARAMETERPREFIX + "activo_empleado"
                    + " ,gerente_empleado = " + this.PARAMETERPREFIX + "gerente_empleado"
                    + " ,firma_empleado = " + this.PARAMETERPREFIX + "firma_empleado"
                    + " ,id_empresa = " + this.PARAMETERPREFIX + "id_empresa"
                    + " ,verSoloLoMio_empleado = " + this.PARAMETERPREFIX + "verSoloLoMio_empleado"
                    + " ,color1_empleado = " + this.PARAMETERPREFIX + "color1_empleado"
                    + " ,color2_empleado = " + this.PARAMETERPREFIX + "color2_empleado"
                    + " where"
                    + " id_empleado = " + this.PARAMETERPREFIX + "id_empleado";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "administrativo_empleado", objVO.Administrativo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido1_empleado", objVO.Apellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido2_empleado", objVO.Apellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "comision_empleado", objVO.Comision, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_empleado", objVO.Nombre, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "terapeuta_empleado", objVO.Terapeuta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "login_empleado", objVO.Login, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_empleado", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "gerente_empleado", objVO.Gerente, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "firma_empleado", objVO.Firma, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "verSoloLoMio_empleado", objVO.VerSoloLoMio, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color1_empleado", objVO.Color1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color2_empleado", objVO.Color2, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empresa", objVO.Empresa.ID, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.ID, command));

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
                Empleado objVO = (Empleado)obj;
                string query = "delete from empleado "
                    + " where"
                    + " id_empleado = " + this.PARAMETERPREFIX + "id_empleado";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", objVO.ID, command));

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
                System.Collections.Generic.List<Empleado> res = new System.Collections.Generic.List<Empleado>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Empleado)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        public void doBind(DbCommand command, Empleado empleado, Terapia terapia)
        {
            try
            {
                string query = "insert into r_empleado_terapia "
                    + " (id_empleado, id_terapia)"
                    + " values "
                    + string.Format(" ({0}id_empleado, {0}id_terapia)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", terapia.ID, command));

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
        public void doUnBind(DbCommand command, Empleado empleado, Terapia terapia)
        {
            try
            {
                string query = "delete from r_empleado_terapia "
                    + " where "
                    + string.Format("id_empleado={0}id_empleado", this.PARAMETERPREFIX)
                    + " AND "
                    + string.Format("id_terapia={0}id_terapia", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", terapia.ID, command));

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
        public void doUnBindAll(DbCommand command, Empleado empleado)
        {
            try
            {
                string query = "delete from r_empleado_terapia "
                    + " where "
                    + string.Format("id_empleado={0}id_empleado", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));

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
    }
}
