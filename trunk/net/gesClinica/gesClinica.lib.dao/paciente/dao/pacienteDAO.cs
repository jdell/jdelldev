using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.paciente.dao
{	
	internal class pacienteDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select *, 0 as avion_paciente from paciente e"
            //string query = "select *, (select count(id_cita) from cita c left join estadocita ecita on c.id_estadocita=ecita.id_estadocita where fecha_cita>=adddate(now(), INTERVAL 3 MONTH) and c.id_paciente = e.id_paciente and ecita.avion_estadocita=1) as avion_paciente from paciente e"
            + " left join estadocivil ec on e.id_estadocivil = ec.id_estadocivil"
            + " left join tarifa t on e.id_tarifa = t.id_tarifa";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by apellido1_paciente, apellido2_paciente, nombre_paciente asc";
            
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
                    res.Apellido1 = Convert.ToString(reader["apellido1_paciente"]);
                    res.Apellido2 = Convert.ToString(reader["apellido2_paciente"]);
                    res.Nombre = Convert.ToString(reader["nombre_paciente"]);
                    res.Mujer = Convert.ToBoolean(reader["mujer_paciente"]);

                    if (!Convert.IsDBNull(reader["codigo_subcuenta"]))
                    {
                        res.SubCuenta = new SubCuenta();
                        res.SubCuenta.Codigo = Convert.ToString(reader["codigo_subcuenta"]);
                    }
                    if (!Convert.IsDBNull(reader["id_estadocivil"]))
                    {
                        res.EstadoCivil = new EstadoCivil();
                        res.EstadoCivil.ID = Convert.ToInt32(reader["id_estadocivil"]);
                        res.EstadoCivil.Descripcion = Convert.ToString(reader["descripcion_estadocivil"]);
                    }
                    res.Tarifa = new Tarifa();
                    res.Tarifa.ID = Convert.ToInt32(reader["id_tarifa"]);
                    res.Tarifa.Descripcion = Convert.ToString(reader["descripcion_tarifa"]);
                    res.Tarifa.Descuento = Convert.ToInt32(reader["descuento_tarifa"]);

                    res.ID= Convert.ToInt32(reader["id_paciente"]);

                    res.MuyImportante = Convert.ToString(reader["muyImportante_paciente"]);

                    res.Direccion = Convert.ToString(reader["direccion_paciente"]);
                    res.Localidad = Convert.ToString(reader["localidad_paciente"]);
                    res.CP = Convert.ToString(reader["cp_paciente"]);
                    res.Telefono1 = Convert.ToString(reader["telefono1_paciente"]);
                    res.Telefono2 = Convert.ToString(reader["telefono2_paciente"]);
                    res.Telefono3 = Convert.ToString(reader["telefono3_paciente"]);
                    if (!Convert.IsDBNull(reader["fechaNacimiento_paciente"]))
                        res.FechaNacimiento= Convert.ToDateTime(reader["fechaNacimiento_paciente"]);
                    res.NIF= Convert.ToString(reader["nif_paciente"]);
                    res.Hijos= Convert.ToInt32(reader["hijos_paciente"]);
                    res.Profesion= Convert.ToString(reader["profesion_paciente"]);
                    res.Provincia= Convert.ToString(reader["provincia_paciente"]);
                    res.FechaAlta = Convert.ToDateTime(reader["fechaAlta_paciente"]);
                    res.Observaciones = Convert.ToString(reader["observaciones_paciente"]);
                    res.RecomendadoPor = Convert.ToString(reader["recomendadopor_paciente"]);

                    if (!Convert.IsDBNull(reader["foto_paciente"]))
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["foto_paciente"]);
                        if (ms.Length>0) res.Foto = System.Drawing.Image.FromStream(ms);
                    }
                    if (!Convert.IsDBNull(reader["avion_paciente"]))
                        res.setAviones(Convert.ToInt32(reader["avion_paciente"]));

                    if (!Convert.IsDBNull(reader["notasAgenda_paciente"]))
                        res.NotasAgenda = Convert.ToString(reader["notasAgenda_paciente"]);
                        
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

                string where = " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));

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
                Paciente objVO = (Paciente)obj;
                string where = " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));

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
                Paciente objVO = (Paciente)obj;
                string query = "insert into paciente "
                    + " (apellido1_paciente, apellido2_paciente, nombre_paciente, mujer_paciente, id_estadocivil, id_tarifa, direccion_paciente, localidad_paciente, cp_paciente, telefono1_paciente, telefono2_paciente, telefono3_paciente, fechaNacimiento_paciente, nif_paciente, hijos_paciente, profesion_paciente, provincia_paciente, fechaAlta_paciente, observaciones_paciente, foto_paciente, recomendadopor_paciente, muyImportante_paciente, codigo_subcuenta, notasAgenda_paciente)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "apellido1_paciente, " + this.PARAMETERPREFIX + "apellido2_paciente, " + this.PARAMETERPREFIX + "nombre_paciente, " + this.PARAMETERPREFIX + "mujer_paciente, " + this.PARAMETERPREFIX + "id_estadocivil, " + this.PARAMETERPREFIX + "id_tarifa, " + this.PARAMETERPREFIX + "direccion_paciente, " + this.PARAMETERPREFIX + "localidad_paciente, " + this.PARAMETERPREFIX + "cp_paciente, " + this.PARAMETERPREFIX + "telefono1_paciente, " + this.PARAMETERPREFIX + "telefono2_paciente, " + this.PARAMETERPREFIX + "telefono3_paciente, " + this.PARAMETERPREFIX + "fechaNacimiento_paciente, " + this.PARAMETERPREFIX + "nif_paciente, " + this.PARAMETERPREFIX + "hijos_paciente, " + this.PARAMETERPREFIX + "profesion_paciente, " + this.PARAMETERPREFIX + "provincia_paciente, " + this.PARAMETERPREFIX + "fechaAlta_paciente, " + this.PARAMETERPREFIX + "observaciones_paciente, " + this.PARAMETERPREFIX + "foto_paciente, " + this.PARAMETERPREFIX + "recomendadopor_paciente, " + this.PARAMETERPREFIX + "muyImportante_paciente, " + this.PARAMETERPREFIX + "codigo_subcuenta, " + this.PARAMETERPREFIX + "notasAgenda_paciente)";
                   // + "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido1_paciente", objVO.Apellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido2_paciente", objVO.Apellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_paciente", objVO.Nombre, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "mujer_paciente", objVO.Mujer, command)); ;
                if (objVO.EstadoCivil!=null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", objVO.EstadoCivil.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.Tarifa.ID, command));
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "muyImportante_paciente", objVO.MuyImportante, command));
               
                if (objVO.SubCuenta != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", Convert.DBNull, command));
            
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_paciente", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "localidad_paciente", objVO.Localidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_paciente", objVO.CP, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_paciente", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_paciente", objVO.Telefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono3_paciente", objVO.Telefono3, command));
                if (objVO.FechaNacimiento.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaNacimiento_paciente", objVO.FechaNacimiento.Value, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaNacimiento_paciente", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nif_paciente", objVO.NIF, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "hijos_paciente", objVO.Hijos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "profesion_paciente", objVO.Profesion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_paciente", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaAlta_paciente", objVO.FechaAlta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_paciente", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "recomendadopor_paciente", objVO.RecomendadoPor, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "notasAgenda_paciente", objVO.NotasAgenda, command));
               
                if (objVO.Foto!=null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    objVO.Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "foto_paciente", ms.GetBuffer(), command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "foto_paciente", Convert.DBNull, command));
                
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
                Paciente objVO = (Paciente)obj;
                string query = "update paciente "
                    + "  set "
                    + "  mujer_paciente = " + this.PARAMETERPREFIX + "mujer_paciente"
                    + " ,apellido1_paciente = " + this.PARAMETERPREFIX + "apellido1_paciente"
                    + " ,apellido2_paciente = " + this.PARAMETERPREFIX + "apellido2_paciente"
                    + " ,id_estadocivil = " + this.PARAMETERPREFIX + "id_estadocivil"
                    + " ,nombre_paciente = " + this.PARAMETERPREFIX + "nombre_paciente"
                    + " ,id_tarifa = " + this.PARAMETERPREFIX + "id_tarifa"
                    + " ,direccion_paciente = " + this.PARAMETERPREFIX + "direccion_paciente"
                    + " ,localidad_paciente = " + this.PARAMETERPREFIX + "localidad_paciente"
                    + " ,cp_paciente = " + this.PARAMETERPREFIX + "cp_paciente"
                    + " ,telefono1_paciente = " + this.PARAMETERPREFIX + "telefono1_paciente"
                    + " ,telefono2_paciente = " + this.PARAMETERPREFIX + "telefono2_paciente"
                    + " ,telefono3_paciente = " + this.PARAMETERPREFIX + "telefono3_paciente"
                    + " ,fechaNacimiento_paciente = " + this.PARAMETERPREFIX + "fechaNacimiento_paciente"
                    + " ,nif_paciente = " + this.PARAMETERPREFIX + "nif_paciente"
                    + " ,hijos_paciente = " + this.PARAMETERPREFIX + "hijos_paciente"
                    + " ,profesion_paciente = " + this.PARAMETERPREFIX + "profesion_paciente"
                    + " ,provincia_paciente = " + this.PARAMETERPREFIX + "provincia_paciente"
                    + " ,fechaAlta_paciente = " + this.PARAMETERPREFIX + "fechaAlta_paciente"
                    + " ,observaciones_paciente = " + this.PARAMETERPREFIX + "observaciones_paciente"
                    + " ,foto_paciente = " + this.PARAMETERPREFIX + "foto_paciente"
                    + " ,recomendadopor_paciente = " + this.PARAMETERPREFIX + "recomendadopor_paciente"
                    + " ,muyImportante_paciente = " + this.PARAMETERPREFIX + "muyImportante_paciente"
                    + " ,codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta"
                    + " ,notasAgenda_paciente = " + this.PARAMETERPREFIX + "notasAgenda_paciente"
                    + " where"
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido1_paciente", objVO.Apellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "apellido2_paciente", objVO.Apellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_paciente", objVO.Nombre, command)); ;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "mujer_paciente", objVO.Mujer, command)); ;
                if (objVO.EstadoCivil != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", objVO.EstadoCivil.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", Convert.DBNull, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.Tarifa.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));

                if (objVO.SubCuenta != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", Convert.DBNull, command));
      
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "muyImportante_paciente", objVO.MuyImportante, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_paciente", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "localidad_paciente", objVO.Localidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_paciente", objVO.CP, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_paciente", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_paciente", objVO.Telefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono3_paciente", objVO.Telefono3, command));
                if (objVO.FechaNacimiento.HasValue)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaNacimiento_paciente", objVO.FechaNacimiento.Value, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaNacimiento_paciente", Convert.DBNull, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nif_paciente", objVO.NIF, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "hijos_paciente", objVO.Hijos, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "profesion_paciente", objVO.Profesion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_paciente", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fechaAlta_paciente", objVO.FechaAlta, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_paciente", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "recomendadopor_paciente", objVO.RecomendadoPor, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "notasAgenda_paciente", objVO.NotasAgenda, command));


                if (objVO.Foto != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    objVO.Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "foto_paciente", ms.GetBuffer(), command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "foto_paciente", Convert.DBNull, command));
                
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

        public object doUpdateMuyImportante(DbCommand command, object obj)
        {
            try
            {
                Paciente objVO = (Paciente)obj;
                string query = "update paciente "
                    + "  set "
                    + " muyImportante_paciente = " + this.PARAMETERPREFIX + "muyImportante_paciente"
                    + " where"
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "muyImportante_paciente", objVO.MuyImportante, command));

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

        public object doUpdateNotasAgenda(DbCommand command, object obj)
        {
            try
            {
                Paciente objVO = (Paciente)obj;
                string query = "update paciente "
                    + "  set "
                    + " notasAgenda_paciente = " + this.PARAMETERPREFIX + "notasAgenda_paciente"
                    + " where"
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "notasAgenda_paciente", objVO.NotasAgenda, command));

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
                Paciente objVO = (Paciente)obj;
                string query = "delete from paciente "
                    + " where"
                    + " id_paciente = " + this.PARAMETERPREFIX + "id_paciente";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));

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

        public int doGetAviones(DbCommand command, Paciente obj)
        {
            try
            {
                Paciente objVO = (Paciente)obj;

                string query = string.Format("select count(id_cita) as aviones from cita c left join estadocita ecita on c.id_estadocita=ecita.id_estadocita where fecha_cita>=adddate(now(), INTERVAL -6 MONTH) and c.id_paciente = {0}id_paciente and ecita.avion_estadocita=1", this.PARAMETERPREFIX);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_paciente", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                int res  = 0;
                if (reader.Read())
                    res = Convert.ToInt32(reader["aviones"]);
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

    }
}
