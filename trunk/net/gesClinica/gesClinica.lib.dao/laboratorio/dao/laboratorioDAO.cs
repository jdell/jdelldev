using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.laboratorio.dao
{	
	internal class laboratorioDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from laboratorio e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by nombre_laboratorio asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Laboratorio res = null;
				if (reader!=null)
				{
                    res = new Laboratorio();
                    res.Direccion = Convert.ToString(reader["direccion_laboratorio"]);
                    res.Fax= Convert.ToString(reader["fax_laboratorio"]);
                    res.ID= Convert.ToInt32(reader["id_laboratorio"]);
                    res.Localidad= Convert.ToString(reader["localidad_laboratorio"]);
                    res.Mail= Convert.ToString(reader["mail_laboratorio"]);
                    res.Nombre= Convert.ToString(reader["nombre_laboratorio"]);
                    res.Observaciones = Convert.ToString(reader["observaciones_laboratorio"]);
                    res.Provincia= Convert.ToString(reader["provincia_laboratorio"]);
                    res.Telefono1= Convert.ToString(reader["telefono1_laboratorio"]);
                    res.Telefono2= Convert.ToString(reader["telefono2_laboratorio"]);
                    res.Telefono3= Convert.ToString(reader["telefono3_laboratorio"]);
                    res.VisitadorApellido1 = Convert.ToString(reader["visitadorApellido1_laboratorio"]);
                    res.VisitadorApellido2 = Convert.ToString(reader["visitadorApellido2_laboratorio"]);
                    res.VisitadorFax = Convert.ToString(reader["visitadorFax_laboratorio"]);
                    res.VisitadorMail = Convert.ToString(reader["visitadorMail_laboratorio"]);
                    res.VisitadorNombre = Convert.ToString(reader["visitadorNombre_laboratorio"]);
                    res.VisitadorObservaciones = Convert.ToString(reader["visitadorObservaciones_laboratorio"]);
                    res.VisitadorTelefono1 = Convert.ToString(reader["visitadorTelefono1_laboratorio"]);
                    res.VisitadorTelefono2 = Convert.ToString(reader["visitadorTelefono2_laboratorio"]);
                    res.VisitadorTelefono3 = Convert.ToString(reader["visitadorTelefono3_laboratorio"]);
                    res.Web = Convert.ToString(reader["web_laboratorio"]);
                    res.CP = Convert.ToString(reader["cp_laboratorio"]);
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
                List<Laboratorio> res = (List<Laboratorio>)this.dataReaderToList(reader);
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
                Laboratorio objVO = (Laboratorio)obj;

                string where = " id_laboratorio = " + this.PARAMETERPREFIX + "id_laboratorio";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Laboratorio res = null;
                if (reader.Read())
                    res = (Laboratorio)this.dataReaderToObject(reader);
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
                Laboratorio objVO = (Laboratorio)obj;
                string where = " id_laboratorio = " + this.PARAMETERPREFIX + "id_laboratorio";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.ID, command));

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
                Laboratorio objVO = (Laboratorio)obj;
                string query = "insert into laboratorio "
                    + "(direccion_laboratorio ,fax_laboratorio ,localidad_laboratorio ,mail_laboratorio ,nombre_laboratorio ,observaciones_laboratorio ,provincia_laboratorio ,telefono1_laboratorio ,telefono2_laboratorio ,telefono3_laboratorio ,visitadorApellido1_laboratorio ,visitadorApellido2_laboratorio ,visitadorFax_laboratorio ,visitadorMail_laboratorio ,visitadorNombre_laboratorio ,visitadorObservaciones_laboratorio ,visitadorTelefono1_laboratorio ,visitadorTelefono2_laboratorio ,visitadorTelefono3_laboratorio ,web_laboratorio, cp_laboratorio)"
                    + " values "
                    + string.Format("({0}direccion_laboratorio ,{0}fax_laboratorio ,{0}localidad_laboratorio ,{0}mail_laboratorio ,{0}nombre_laboratorio ,{0}observaciones_laboratorio ,{0}provincia_laboratorio ,{0}telefono1_laboratorio ,{0}telefono2_laboratorio ,{0}telefono3_laboratorio ,{0}visitadorApellido1_laboratorio ,{0}visitadorApellido2_laboratorio ,{0}visitadorFax_laboratorio ,{0}visitadorMail_laboratorio ,{0}visitadorNombre_laboratorio ,{0}visitadorObservaciones_laboratorio ,{0}visitadorTelefono1_laboratorio ,{0}visitadorTelefono2_laboratorio ,{0}visitadorTelefono3_laboratorio ,{0}web_laboratorio, {0}cp_laboratorio)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_laboratorio", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax_laboratorio", objVO.Fax, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "localidad_laboratorio", objVO.Localidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mail_laboratorio", objVO.Mail, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_laboratorio", objVO.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_laboratorio", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_laboratorio", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_laboratorio", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_laboratorio", objVO.Telefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono3_laboratorio", objVO.Telefono3, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorApellido1_laboratorio", objVO.VisitadorApellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorApellido2_laboratorio", objVO.VisitadorApellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorFax_laboratorio", objVO.VisitadorFax, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorMail_laboratorio", objVO.VisitadorMail, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorNombre_laboratorio", objVO.VisitadorNombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorObservaciones_laboratorio", objVO.VisitadorObservaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono1_laboratorio", objVO.VisitadorTelefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono2_laboratorio", objVO.VisitadorTelefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono3_laboratorio", objVO.VisitadorTelefono3, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "web_laboratorio", objVO.Web, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_laboratorio", objVO.CP, command));
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

                command.ExecuteNonQuery();

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
                Laboratorio objVO = (Laboratorio)obj;
                string query = "update laboratorio "
                    + "  set "
                    + "  direccion_laboratorio = " + this.PARAMETERPREFIX + "direccion_laboratorio"
                    + " ,fax_laboratorio = " + this.PARAMETERPREFIX + "fax_laboratorio"
                    + " ,localidad_laboratorio = " + this.PARAMETERPREFIX + "localidad_laboratorio"
                    + " ,mail_laboratorio = " + this.PARAMETERPREFIX + "mail_laboratorio"
                    + " ,nombre_laboratorio = " + this.PARAMETERPREFIX + "nombre_laboratorio"
                    + " ,observaciones_laboratorio = " + this.PARAMETERPREFIX + "observaciones_laboratorio"
                    + " ,provincia_laboratorio = " + this.PARAMETERPREFIX + "provincia_laboratorio"
                    + " ,telefono1_laboratorio = " + this.PARAMETERPREFIX + "telefono1_laboratorio"
                    + " ,telefono2_laboratorio = " + this.PARAMETERPREFIX + "telefono2_laboratorio"
                    + " ,telefono3_laboratorio = " + this.PARAMETERPREFIX + "telefono3_laboratorio"
                    + " ,visitadorApellido1_laboratorio = " + this.PARAMETERPREFIX + "visitadorApellido1_laboratorio"
                    + " ,visitadorApellido2_laboratorio = " + this.PARAMETERPREFIX + "visitadorApellido2_laboratorio"
                    + " ,visitadorFax_laboratorio = " + this.PARAMETERPREFIX + "visitadorFax_laboratorio"
                    + " ,visitadorMail_laboratorio = " + this.PARAMETERPREFIX + "visitadorMail_laboratorio"
                    + " ,visitadorNombre_laboratorio = " + this.PARAMETERPREFIX + "visitadorNombre_laboratorio"
                    + " ,visitadorObservaciones_laboratorio = " + this.PARAMETERPREFIX + "visitadorObservaciones_laboratorio"
                    + " ,visitadorTelefono1_laboratorio = " + this.PARAMETERPREFIX + "visitadorTelefono1_laboratorio"
                    + " ,visitadorTelefono2_laboratorio = " + this.PARAMETERPREFIX + "visitadorTelefono2_laboratorio"
                    + " ,visitadorTelefono3_laboratorio = " + this.PARAMETERPREFIX + "visitadorTelefono3_laboratorio"
                    + " ,web_laboratorio = " + this.PARAMETERPREFIX + "web_laboratorio"
                    + " ,cp_laboratorio = " + this.PARAMETERPREFIX + "cp_laboratorio"
                    + " where"
                    + " id_laboratorio = " + this.PARAMETERPREFIX + "id_laboratorio";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "direccion_laboratorio", objVO.Direccion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "fax_laboratorio", objVO.Fax, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "localidad_laboratorio", objVO.Localidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mail_laboratorio", objVO.Mail, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_laboratorio", objVO.Nombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_laboratorio", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "provincia_laboratorio", objVO.Provincia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono1_laboratorio", objVO.Telefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono2_laboratorio", objVO.Telefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "telefono3_laboratorio", objVO.Telefono3, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorApellido1_laboratorio", objVO.VisitadorApellido1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorApellido2_laboratorio", objVO.VisitadorApellido2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorFax_laboratorio", objVO.VisitadorFax, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorMail_laboratorio", objVO.VisitadorMail, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorNombre_laboratorio", objVO.VisitadorNombre, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorObservaciones_laboratorio", objVO.VisitadorObservaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono1_laboratorio", objVO.VisitadorTelefono1, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono2_laboratorio", objVO.VisitadorTelefono2, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "visitadorTelefono3_laboratorio", objVO.VisitadorTelefono3, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "web_laboratorio", objVO.Web, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cp_laboratorio", objVO.CP, command));
                                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.ID, command));

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
                Laboratorio objVO = (Laboratorio)obj;
                string query = "delete from laboratorio "
                    + " where"
                    + " id_laboratorio = " + this.PARAMETERPREFIX + "id_laboratorio";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.ID, command));

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
                System.Collections.Generic.List<Laboratorio> res = new System.Collections.Generic.List<Laboratorio>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Laboratorio)dataReaderToObject(reader));
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
