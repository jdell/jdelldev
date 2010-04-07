using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.terapia.dao
{	
	internal class terapiaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from terapia e"
                + " left join tipoterapia tt on e.id_tipoterapia = tt.id_tipoterapia";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_terapia asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Terapia res = null;
				if (reader!=null)
				{
                    res = new Terapia();
                    res.Activo = Convert.ToBoolean(reader["activo_terapia"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_terapia"]);
                    res.ID = Convert.ToInt32(reader["id_terapia"]);
                    res.Duracion = Convert.ToInt32(reader["duracion_terapia"]);
                    res.Precio = Convert.ToSingle(reader["precio_terapia"]);
                    if (!Convert.IsDBNull(reader["codigo_subcuenta"]))
                    {
                        res.SubCuenta = new SubCuenta();
                        res.SubCuenta.Codigo = Convert.ToString(reader["codigo_subcuenta"]);
                    }
                    if (!Convert.IsDBNull(reader["id_tipoterapia"]))
                    {
                        res.TipoTerapia = new TipoTerapia();
                        res.TipoTerapia.ID = Convert.ToInt32(reader["id_tipoterapia"]);
                        if (!Convert.IsDBNull(reader["descripcion_tipoterapia"])) res.TipoTerapia.Descripcion = Convert.ToString(reader["descripcion_tipoterapia"]);
                        if (!Convert.IsDBNull(reader["cobrable_tipoterapia"])) res.TipoTerapia.Cobrable = Convert.ToBoolean(reader["cobrable_tipoterapia"]);
                        if (!Convert.IsDBNull(reader["codigo_tipoterapia"])) res.TipoTerapia.Codigo = lib.vo.TipoTerapia.CodigoFromName(Convert.ToString(reader["codigo_tipoterapia"]));
                        if (!Convert.IsDBNull(reader["color_tipoterapia"])) res.TipoTerapia.Color = Convert.ToString(reader["color_tipoterapia"]);
                    }
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
                List<Terapia> res = (List<Terapia>)this.dataReaderToList(reader);
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
                    string where = " activo_terapia = " + this.PARAMETERPREFIX + "activo_terapia ";
                    string query = getQuery(where);
                    command.CommandText = query;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_terapia", true, command));
                }

                DbDataReader reader = command.ExecuteReader();
                List<Terapia> res = (List<Terapia>)this.dataReaderToList(reader);
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
                Terapia objVO = (Terapia)obj;

                string where = " e.id_terapia = " + this.PARAMETERPREFIX + "id_terapia";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Terapia res = null;
                if (reader.Read())
                    res = (Terapia)this.dataReaderToObject(reader);
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
                Terapia objVO = (Terapia)obj;
                string where = " e.id_terapia = " + this.PARAMETERPREFIX + "id_terapia";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.ID, command));

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
                Terapia objVO = (Terapia)obj;
                string query = "insert into terapia "
                    + " (descripcion_terapia, precio_terapia, duracion_terapia, activo_terapia, codigo_subcuenta, id_tipoterapia)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_terapia, " + this.PARAMETERPREFIX + "precio_terapia, " + this.PARAMETERPREFIX + "duracion_terapia, " + this.PARAMETERPREFIX + "activo_terapia, " + this.PARAMETERPREFIX + "codigo_subcuenta, " + this.PARAMETERPREFIX + "id_tipoterapia)";
                   // + "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "precio_terapia", objVO.Precio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_terapia", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_terapia", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_terapia", objVO.Activo, command));

                if (objVO.SubCuenta != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", Convert.DBNull, command));

                if (objVO.TipoTerapia != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.TipoTerapia.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", Convert.DBNull, command));

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
                Terapia objVO = (Terapia)obj;
                string query = "update terapia "
                    + "  set "
                    + "  descripcion_terapia = " + this.PARAMETERPREFIX + "descripcion_terapia"
                    + " ,duracion_terapia = " + this.PARAMETERPREFIX + "duracion_terapia"
                    + " ,precio_terapia = " + this.PARAMETERPREFIX + "precio_terapia"
                    + " ,activo_terapia = " + this.PARAMETERPREFIX + "activo_terapia"
                    + " ,codigo_subcuenta = " + this.PARAMETERPREFIX + "codigo_subcuenta"
                    + " ,id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia"
                    + " where"
                    + " id_terapia = " + this.PARAMETERPREFIX + "id_terapia";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "precio_terapia", objVO.Precio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "duracion_terapia", objVO.Duracion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_terapia", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_terapia", objVO.Activo, command));

                if (objVO.SubCuenta != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", objVO.SubCuenta.Codigo, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_subcuenta", Convert.DBNull, command));

                if (objVO.TipoTerapia != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.TipoTerapia.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", Convert.DBNull, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.ID, command));

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
                Terapia objVO = (Terapia)obj;
                string query = "delete from terapia "
                    + " where"
                    + " id_terapia = " + this.PARAMETERPREFIX + "id_terapia";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.ID, command));

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
        public object doUpdateTipTerapia(DbCommand command, TipoTerapia obj)
        {
            try
            {
                TipoTerapia objVO = (TipoTerapia)obj;
                string query = "update terapia "
                    + "  set "
                    + " id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia";

                command.CommandText = query;

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.ID, command));
                
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
                System.Collections.Generic.List<Terapia> res = new System.Collections.Generic.List<Terapia>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Terapia)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }


        public Terapia doGetDependiente(DbCommand command, Terapia obj)
        {
            try
            {
                Terapia objVO = (Terapia)obj;
                string query = "select * from terapia e"
                + " left join tipoterapia tt on e.id_tipoterapia = tt.id_tipoterapia"
                + " left join r_terapia_terapia rtt on e.id_terapia = rtt.idsecond_terapia"
                + " WHERE rtt.idfirst_terapia = " + this.PARAMETERPREFIX + "id_terapia";
               
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_terapia", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Terapia res = null;
                if (reader.Read())
                    res = (Terapia)this.dataReaderToObject(reader);
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

        public List<Terapia> doGetAllIn(DbCommand command, Empleado empleado, bool soloActivo)
        {
            try
            {

                string where = " id_terapia in (select id_terapia from r_empleado_terapia where id_empleado = " + this.PARAMETERPREFIX + "id_empleado)";
                if (soloActivo)
                {
                    where += " AND activo_terapia = " + this.PARAMETERPREFIX + "activo_terapia";
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "activo_terapia", true, command));
                }

                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Terapia> res = (List<Terapia>)this.dataReaderToList(reader);
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

        public List<Terapia> doGetAllOut(DbCommand command, Empleado empleado, bool soloActivo)
        {
            try
            {
                string where = " id_terapia not in (select id_terapia from r_empleado_terapia where id_empleado = " + this.PARAMETERPREFIX + "id_empleado)";
                if (soloActivo)
                {
                    where += " AND activo_terapia = " + this.PARAMETERPREFIX + "activo_terapia";
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "activo_terapia", true, command));
                }

                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_empleado", empleado.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Terapia> res = (List<Terapia>)this.dataReaderToList(reader);
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

        public void doBindTerapia(DbCommand command, Terapia first, Terapia second)
        {
            try
            {
                string query = "insert into r_terapia_terapia "
                    + " (idfirst_terapia, idsecond_terapia)"
                    + " values "
                    + string.Format(" ({0}idfirst_terapia, {0}idsecond_terapia)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "idfirst_terapia", first.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "idsecond_terapia", second.ID, command));

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
        public void doUnBindTerapia(DbCommand command, Terapia first, Terapia second)
        {
            try
            {
                string query = "delete from r_terapia_terapia "
                    + " where "
                    + string.Format("idfirst_terapia={0}idfirst_terapia", this.PARAMETERPREFIX)
                    + " AND "
                    + string.Format("idsecond_terapia={0}idsecond_terapia", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "idfirst_terapia", first.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "idsecond_terapia", second.ID, command));

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
        public void doUnBindAllTerapia(DbCommand command, Terapia first)
        {
            try
            {
                string query = "delete from r_terapia_terapia "
                    + " where "
                    + string.Format("idfirst_terapia={0}idfirst_terapia", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "idfirst_terapia", first.ID, command));

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
