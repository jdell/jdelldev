using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tercero.dao
{	
	internal class terceroDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tercero e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by nombre_tercero asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Tercero res = null;
				if (reader!=null)
				{
                    res = new Tercero();
                    res.Actividad = Convert.ToString(reader["actividad_tercero"]);
                    res.Cp = Convert.ToString(reader["cp_tercero"]);
                    res.Domicilio = Convert.ToString(reader["domicilio_tercero"]);
                    res.Escalera= Convert.ToString(reader["escalera_tercero"]);
                    res.Fax1= Convert.ToString(reader["fax1_tercero"]);
                    res.Fax2= Convert.ToString(reader["fax2_tercero"]);
                    res.Fecha= Convert.ToDateTime(reader["fechaAlta_tercero"]);
                    res.FormaPago= Convert.ToString(reader["formapago_tercero"]);
                    res.ID = Convert.ToInt32(reader["id_tercero"]);
                    res.Nacionalidad = Convert.ToString(reader["nacionalidad_tercero"]);
                    res.Nif = Convert.ToString(reader["nif_tercero"]);
                    res.Nombre = Convert.ToString(reader["nombre_tercero"]);
                    res.Numero = Convert.ToString(reader["numero_tercero"]);
                    res.Persona = Convert.ToString(reader["persona_tercero"]);
                    res.Piso = Convert.ToString(reader["piso_tercero"]);
                    res.Poblacion = Convert.ToString(reader["poblacion_tercero"]);
                    res.Provincia = Convert.ToString(reader["provincia_tercero"]);
                    res.Puerta = Convert.ToString(reader["puerta_tercero"]);
                    res.Recargo= Convert.ToBoolean(reader["recargo_tercero"]);
                    res.Sigla = Convert.ToString(reader["sigla_tercero"]);
                    res.SubCuenta = new SubCuenta();
                    res.SubCuenta.Codigo = Convert.ToString(reader["codigo_subcuenta"]);
                    res.Telefono1 = Convert.ToString(reader["telefono1_tercero"]);
                    res.Telefono2 = Convert.ToString(reader["telefono2_tercero"]);
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
                List<Tercero> res = (List<Tercero>)this.dataReaderToList(reader);
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
                Tercero objVO = (Tercero)obj;

                string where = " id_tercero = " + this.PARAMETERPREFIX + "id_tercero";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tercero", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Tercero res = null;
                if (reader.Read())
                    res = (Tercero)this.dataReaderToObject(reader);
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

        public lib.vo.Tercero doGetBySubCuenta(DbCommand command, SubCuenta obj)
        {
            try
            {
                SubCuenta objVO = (SubCuenta)obj;

                string where = " codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.Codigo, command));

                DbDataReader reader = command.ExecuteReader();
                Tercero res = null;
                if (reader.Read())
                    res = (Tercero)this.dataReaderToObject(reader);
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
                Tercero objVO = (Tercero)obj;
                string where = " id_tercero = " + this.PARAMETERPREFIX + "id_tercero";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tercero", objVO.ID, command));

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
                Tercero objVO = (Tercero)obj;
                string query = "insert into tercero "
                    + " (actividad_tercero, cp_tercero, domicilio_tercero, escalera_tercero, fax1_tercero, fax2_tercero, fechaAlta_tercero, formapago_tercero, nacionalidad_tercero, nif_tercero, nombre_tercero, numero_tercero, persona_tercero, piso_tercero, poblacion_tercero, provincia_tercero, puerta_tercero, recargo_tercero, sigla_tercero, codigo_subcuenta, telefono1_tercero, telefono2_tercero)"
                    + " values "
                    + string.Format(" ({0}actividad_tercero, {0}cp_tercero, {0}domicilio_tercero, {0}escalera_tercero, {0}fax1_tercero, {0}fax2_tercero, {0}fechaAlta_tercero, {0}formapago_tercero, {0}nacionalidad_tercero, {0}nif_tercero, {0}nombre_tercero, {0}numero_tercero, {0}persona_tercero, {0}piso_tercero, {0}poblacion_tercero, {0}provincia_tercero, {0}puerta_tercero, {0}recargo_tercero, {0}sigla_tercero, {0}codigo_subcuenta, {0}telefono1_tercero, {0}telefono2_tercero)", this.PARAMETERPREFIX);
                   
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "actividad_tercero", objVO.Actividad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_tercero", objVO.Cp, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "domicilio_tercero", objVO.Domicilio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "escalera_tercero", objVO.Escalera, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax1_tercero", objVO.Fax1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax2_tercero", objVO.Fax2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaAlta_tercero", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "formapago_tercero", objVO.FormaPago, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nacionalidad_tercero", objVO.Nacionalidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nif_tercero", objVO.Nif, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_tercero", objVO.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "numero_tercero", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "persona_tercero", objVO.Persona, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "piso_tercero", objVO.Piso, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "poblacion_tercero", objVO.Poblacion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_tercero", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "puerta_tercero", objVO.Puerta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "recargo_tercero", objVO.Recargo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sigla_tercero", objVO.Sigla, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_tercero", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_tercero", objVO.Telefono2, command));

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
                Tercero objVO = (Tercero)obj;
                string query = "update tercero "
                    + "  set "
                    + "  actividad_tercero = " + this.PARAMETERPREFIX + "actividad_tercero"
                    + " ,cp_tercero = " + this.PARAMETERPREFIX + "cp_tercero"
                    + " ,domicilio_tercero = " + this.PARAMETERPREFIX + "domicilio_tercero"
                    + " ,escalera_tercero = " + this.PARAMETERPREFIX + "escalera_tercero"
                    + " ,fax1_tercero = " + this.PARAMETERPREFIX + "fax1_tercero"
                    + " ,fax2_tercero = " + this.PARAMETERPREFIX + "fax2_tercero"
                    + " ,fechaAlta_tercero = " + this.PARAMETERPREFIX + "fechaAlta_tercero"
                    + " ,formapago_tercero = " + this.PARAMETERPREFIX + "formapago_tercero"
                    + " ,nacionalidad_tercero = " + this.PARAMETERPREFIX + "nacionalidad_tercero"
                    + " ,nif_tercero = " + this.PARAMETERPREFIX + "nif_tercero"
                    + " ,nombre_tercero = " + this.PARAMETERPREFIX + "nombre_tercero"
                    + " ,numero_tercero = " + this.PARAMETERPREFIX + "numero_tercero"
                    + " ,persona_tercero = " + this.PARAMETERPREFIX + "persona_tercero"
                    + " ,piso_tercero = " + this.PARAMETERPREFIX + "piso_tercero"
                    + " ,poblacion_tercero = " + this.PARAMETERPREFIX + "poblacion_tercero"
                    + " ,provincia_tercero = " + this.PARAMETERPREFIX + "provincia_tercero"
                    + " ,puerta_tercero = " + this.PARAMETERPREFIX + "puerta_tercero"
                    + " ,recargo_tercero = " + this.PARAMETERPREFIX + "recargo_tercero"
                    + " ,sigla_tercero = " + this.PARAMETERPREFIX + "sigla_tercero"
                    + " ,codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta"
                    + " ,telefono1_tercero = " + this.PARAMETERPREFIX + "telefono1_tercero"
                    + " ,telefono2_tercero = " + this.PARAMETERPREFIX + "telefono2_tercero"
                    + " where"
                    + " id_tercero = " + this.PARAMETERPREFIX + "id_tercero";

                command.CommandText = query;

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "actividad_tercero", objVO.Actividad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_tercero", objVO.Cp, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "domicilio_tercero", objVO.Domicilio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "escalera_tercero", objVO.Escalera, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax1_tercero", objVO.Fax1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax2_tercero", objVO.Fax2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaAlta_tercero", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "formapago_tercero", objVO.FormaPago, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nacionalidad_tercero", objVO.Nacionalidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nif_tercero", objVO.Nif, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_tercero", objVO.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "numero_tercero", objVO.Numero, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "persona_tercero", objVO.Persona, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "piso_tercero", objVO.Piso, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "poblacion_tercero", objVO.Poblacion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_tercero", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "puerta_tercero", objVO.Puerta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "recargo_tercero", objVO.Recargo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "sigla_tercero", objVO.Sigla, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_tercero", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_tercero", objVO.Telefono2, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tercero", objVO.ID, command));

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
                Tercero objVO = (Tercero)obj;
                string query = "delete from tercero "
                    + " where"
                    + " id_tercero = " + this.PARAMETERPREFIX + "id_tercero";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tercero", objVO.ID, command));

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
                System.Collections.Generic.List<Tercero> res = new System.Collections.Generic.List<Tercero>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Tercero)dataReaderToObject(reader));
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
