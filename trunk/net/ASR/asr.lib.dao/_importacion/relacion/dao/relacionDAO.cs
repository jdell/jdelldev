using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.relacion.dao
{	
	internal class relacionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from relacion e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Relacion res = null;
				if (reader!=null)
				{
                    res = new Relacion();
                    res.ID= Convert.ToInt32(reader["id_relacion"]);
                    res.IdNuevo = Convert.ToString(reader["nuevo_relacion"]);
                    res.IdAntiguo = Convert.ToString(reader["antiguo_relacion"]);
                    res.Tipo = Convert.ToString(reader["tipo_relacion"]);
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
                List<Relacion> res = (List<Relacion>)this.dataReaderToList(reader);
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
                Relacion objVO = (Relacion)obj;

                string where = " id_relacion = " + this.PARAMETERPREFIX + "id_relacion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_relacion", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Relacion res = null;
                if (reader.Read())
                    res = (Relacion)this.dataReaderToObject(reader);
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
        public Relacion doGetByIDAntiguoAndTipo(DbCommand command, Relacion obj)
        {
            try
            {
                Relacion objVO = (Relacion)obj;

                string where = " antiguo_relacion = " + this.PARAMETERPREFIX + "antiguo_relacion"
                + " AND "
                + " tipo_relacion = " + this.PARAMETERPREFIX + "tipo_relacion";

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "antiguo_relacion", objVO.IdAntiguo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_relacion", objVO.Tipo, command));

                DbDataReader reader = command.ExecuteReader();
                Relacion res = null;
                if (reader.Read())
                    res = (Relacion)this.dataReaderToObject(reader);
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
                Relacion objVO = (Relacion)obj;
                //string where = " id_relacion = " + this.PARAMETERPREFIX + "id_relacion";
                //string query = getQuery(where);
                //command.CommandText = query;
                //command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_relacion", objVO.ID, command));

                string where = " antiguo_relacion = " + this.PARAMETERPREFIX + "antiguo_relacion"
                + " AND "
                + " tipo_relacion = " + this.PARAMETERPREFIX + "tipo_relacion";

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "antiguo_relacion", objVO.IdAntiguo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_relacion", objVO.Tipo, command));


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
                Relacion objVO = (Relacion)obj;
                string query = "insert into relacion "
                    + " (nuevo_relacion, antiguo_relacion, tipo_relacion)"
                    + " values "
                    + string.Format("({0}nuevo_relacion, {0}antiguo_relacion, {0}tipo_relacion)", this.PARAMETERPREFIX);
                    

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nuevo_relacion", objVO.IdNuevo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "antiguo_relacion", objVO.IdAntiguo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_relacion", objVO.Tipo, command));

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
                Relacion objVO = (Relacion)obj;
                string query = "update relacion "
                    + "  set "
                    + "  nuevo_relacion = " + this.PARAMETERPREFIX + "nuevo_relacion"
                    + " ,antiguo_relacion = " + this.PARAMETERPREFIX + "antiguo_relacion"
                    + " ,tipo_relacion = " + this.PARAMETERPREFIX + "tipo_relacion"
                    + " where"
                    + " id_relacion = " + this.PARAMETERPREFIX + "id_relacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nuevo_relacion", objVO.IdNuevo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "antiguo_relacion", objVO.IdAntiguo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "tipo_relacion", objVO.Tipo, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_relacion", objVO.ID, command));

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
                Relacion objVO = (Relacion)obj;
                string query = "delete from relacion "
                    + " where"
                    + " id_relacion = " + this.PARAMETERPREFIX + "id_relacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_relacion", objVO.ID, command));

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
                System.Collections.Generic.List<Relacion> res = new System.Collections.Generic.List<Relacion>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Relacion)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }


        public bool doDeleteAllDataBase(DbCommand command, bool primeraParte)
        {
            try
            {
                System.Text.StringBuilder strB = new System.Text.StringBuilder();
                strB.AppendLine("truncate table relacion;");
                strB.AppendLine("truncate table tabla;");
                if (primeraParte)
                {
                    strB.AppendLine("truncate table documento;");
                    strB.AppendLine("truncate table tipodocumento;");
                    strB.AppendLine("truncate table apunte;");
                    strB.AppendLine("truncate table asiento;");
                    strB.AppendLine("truncate table ejercicio;");
                    strB.AppendLine("truncate table festivo;");
                    strB.AppendLine("truncate table tipofestivo;");
                    strB.AppendLine("truncate table sintoma;");
                    strB.AppendLine("truncate table tiposintoma;");
                    strB.AppendLine("truncate table contador;");
                    strB.AppendLine("truncate table factura;");
                    strB.AppendLine("truncate table operacion;");
                    strB.AppendLine("truncate table cita;");
                    strB.AppendLine("truncate table evento;");
                    strB.AppendLine("truncate table subcuenta;");
                    strB.AppendLine("truncate table paciente;");
                    strB.AppendLine("truncate table estadocivil;");
                    strB.AppendLine("truncate table tarifa;");
                    strB.AppendLine("truncate table terapia;");
                    strB.AppendLine("truncate table empleado;");
                    strB.AppendLine("truncate table producto;");
                    strB.AppendLine("truncate table componente;");
                    strB.AppendLine("truncate table laboratorio;");
                    strB.AppendLine("truncate table indicacion;");
                    strB.AppendLine("truncate table empresa;");
                    strB.AppendLine("truncate table sala;");
                    strB.AppendLine("truncate table estadocita;");
                    strB.AppendLine("truncate table formapago;");
                }
                else
                {
                    strB.AppendLine("truncate table ejercicio;");
                    strB.AppendLine("truncate table asiento;");
                    strB.AppendLine("truncate table apunte;");
                }

                string query = strB.ToString();

                command.CommandText = query;

                command.ExecuteNonQuery();
                return true;
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

        public bool doDeleteAllDataBaseTerceros(DbCommand command)
        {
            try
            {
                System.Text.StringBuilder strB = new System.Text.StringBuilder();
                strB.AppendLine(string.Format("delete from relacion where tipo_relacion='{0}';", typeof(vo.importacion.Tercero).FullName));
                strB.AppendLine(string.Format("delete from tabla where descripcion_tabla='{0}';", typeof(vo.importacion.Tercero).FullName));
                
                strB.AppendLine("truncate table tercero;");

                string query = strB.ToString();

                command.CommandText = query;

                command.ExecuteNonQuery();
                return true;
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
