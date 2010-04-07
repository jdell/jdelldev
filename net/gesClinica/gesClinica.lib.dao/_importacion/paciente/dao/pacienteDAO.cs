using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.paciente.dao
{	
	internal class pacienteDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from paciente e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Paciente res = null;
				if (reader!=null)
				{
                    res = new Paciente();
                    if (!Convert.IsDBNull(reader["Apellido1"])) res.Apellido1 = Convert.ToString(reader["Apellido1"]);
                    if (!Convert.IsDBNull(reader["Apellido2"])) res.Apellido2 = Convert.ToString(reader["Apellido2"]);
                    res.Club = new Club();
                    res.Club.ID= Convert.ToString(reader["IdClub"]);

                    res.Codigo = Convert.ToString(reader["Codigo"]);
                    if (!Convert.IsDBNull(reader["Cip"])) res.Cp = Convert.ToString(reader["Cip"]);
                    if (!Convert.IsDBNull(reader["Direccion"])) res.Direccion = Convert.ToString(reader["Direccion"]);
                    if (!Convert.IsDBNull(reader["Dni"])) res.Dni = Convert.ToString(reader["Dni"]);
                    if (!Convert.IsDBNull(reader["EstadoCivi"])) res.EstadoCivil = Convert.ToString(reader["EstadoCivi"]);
                    if (!Convert.IsDBNull(reader["Ext1"])) res.Ext1 = Convert.ToString(reader["Ext1"]);
                    if (!Convert.IsDBNull(reader["Ext2"])) res.Ext2 = Convert.ToString(reader["Ext2"]);
                    if (!Convert.IsDBNull(reader["FechaInici"])) res.FechaInicio = Convert.ToDateTime(reader["FechaInici"]);
                    if (!Convert.IsDBNull(reader["FechaNacim"])) res.FechaNacimiento = Convert.ToDateTime(reader["FechaNacim"]);
                    if (!Convert.IsDBNull(reader["LetraNif"])) res.LetraNif = Convert.ToString(reader["LetraNif"]);
                    if (!Convert.IsDBNull(reader["Localidad"])) res.Localidad = Convert.ToString(reader["Localidad"]);
                    if (!Convert.IsDBNull(reader["Moneda"])) res.Moneda = Convert.ToInt32(reader["Moneda"]);
                    if (!Convert.IsDBNull(reader["NoEnviarCorreo"])) res.NoEnviarCorreo = Convert.ToBoolean(reader["NoEnviarCorreo"]);
                    if (!Convert.IsDBNull(reader["Nombre"])) res.Nombre = Convert.ToString(reader["Nombre"]);
                    if (!Convert.IsDBNull(reader["NotasBreves"])) res.NotasBreves = Convert.ToString(reader["NotasBreves"]);
                    if (!Convert.IsDBNull(reader["NumeroHijo"])) res.NumeroHijos = Convert.ToInt32(reader["NumeroHijo"]);
                    if (!Convert.IsDBNull(reader["Profesion"])) res.Profesion = Convert.ToString(reader["Profesion"]);
                    if (!Convert.IsDBNull(reader["Provincia"])) res.Provincia = Convert.ToString(reader["Provincia"]);
                    if (!Convert.IsDBNull(reader["Saldo"])) res.Saldo = Convert.ToSingle(reader["Saldo"]);
                    if (!Convert.IsDBNull(reader["Sexo"])) res.Sexo = Convert.ToString(reader["Sexo"]);
                    if (!Convert.IsDBNull(reader["Telefono1"])) res.Telefono1 = Convert.ToString(reader["Telefono1"]);
                    if (!Convert.IsDBNull(reader["Telefono2"])) res.Telefono2 = Convert.ToString(reader["Telefono2"]);
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
                List<Paciente> res = (List<Paciente>)this.dataReaderToList(reader);
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
                Paciente objVO = (Paciente)obj;

                string where = " Codigo = " + this.PARAMETERPREFIX + "Codigo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "Codigo", objVO.Codigo, command));

                DbDataReader reader = command.ExecuteReader();
                Paciente res = null;
                if (reader.Read())
                    res = (Paciente)this.dataReaderToObject(reader);
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
                System.Collections.Generic.List<Paciente> res = new System.Collections.Generic.List<Paciente>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Paciente)dataReaderToObject(reader));
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
