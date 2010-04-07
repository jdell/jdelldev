using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.tercero.dao
{	
	internal class terceroDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from terceros e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
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
                    if (!Convert.IsDBNull(reader["Codigo"])) res.Codigo= Convert.ToString(reader["Codigo"]);
                    if (!Convert.IsDBNull(reader["Cuenta"]))
                    {
                        res.SubCuenta = new SubCuenta();
                        res.SubCuenta.Codigo = Convert.ToString(reader["Cuenta"]);
                    }
                    if (!Convert.IsDBNull(reader["NIF"])) res.Nif = Convert.ToString(reader["NIF"]);
                    if (!Convert.IsDBNull(reader["Nombre"])) res.Nombre = Convert.ToString(reader["Nombre"]);
                    if (!Convert.IsDBNull(reader["Sigla"])) res.Sigla = Convert.ToString(reader["Sigla"]);
                    if (!Convert.IsDBNull(reader["Domicilio"])) res.Domicilio = Convert.ToString(reader["Domicilio"]);
                    if (!Convert.IsDBNull(reader["Numero"])) res.Numero = Convert.ToString(reader["Numero"]);
                    if (!Convert.IsDBNull(reader["Escalera"])) res.Escalera = Convert.ToString(reader["Escalera"]);
                    if (!Convert.IsDBNull(reader["Piso"])) res.Piso = Convert.ToString(reader["Piso"]);
                    if (!Convert.IsDBNull(reader["Puerta"])) res.Puerta = Convert.ToString(reader["Puerta"]);
                    if (!Convert.IsDBNull(reader["Poblacion"])) res.Poblacion = Convert.ToString(reader["Poblacion"]);
                    if (!Convert.IsDBNull(reader["Provincia"])) res.Provincia = Convert.ToString(reader["Provincia"]);
                    if (!Convert.IsDBNull(reader["CodigoPostal"])) res.Cp = Convert.ToString(reader["CodigoPostal"]);
                    if (!Convert.IsDBNull(reader["Telefono1"])) res.Telefono1 = Convert.ToString(reader["Telefono1"]);
                    if (!Convert.IsDBNull(reader["Telefono2"])) res.Telefono2 = Convert.ToString(reader["Telefono2"]);
                    if (!Convert.IsDBNull(reader["Fax1"])) res.Fax1 = Convert.ToString(reader["Fax1"]);
                    if (!Convert.IsDBNull(reader["Fax2"])) res.Fax2 = Convert.ToString(reader["Fax2"]);
                    if (!Convert.IsDBNull(reader["Persona"])) res.Persona = Convert.ToString(reader["Persona"]);
                    if (!Convert.IsDBNull(reader["Actividad"])) res.Actividad = Convert.ToString(reader["Actividad"]);
                    if (!Convert.IsDBNull(reader["Nacionalidad"])) res.Nacionalidad = Convert.ToString(reader["Nacionalidad"]);
                    if (!Convert.IsDBNull(reader["Recargo"])) res.Recargo = Convert.ToBoolean(reader["Recargo"]);
                    if (!Convert.IsDBNull(reader["FechaAlta"])) res.Fecha = Convert.ToDateTime(reader["FechaAlta"]);
                    if (!Convert.IsDBNull(reader["FormaPago"])) res.FormaPago = Convert.ToString(reader["FormaPago"]);
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

                string where = " Codigo = " + this.PARAMETERPREFIX + "Codigo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "Codigo", objVO.Codigo, command));

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
