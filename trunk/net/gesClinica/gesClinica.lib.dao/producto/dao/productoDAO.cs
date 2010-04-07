using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.producto.dao
{	
	internal class productoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from producto e"
            + " left join laboratorio l on e.id_laboratorio = l.id_laboratorio"
            + " left join tipounidad tu on e.id_tipounidad= tu.id_tipounidad";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_producto asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Producto res = null;
				if (reader!=null)
				{
                    res = new Producto();
                    res.Activo = Convert.ToBoolean(reader["activo_producto"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_producto"]);
                    res.ID= Convert.ToInt32(reader["id_producto"]);
                    res.Laboratorio = new Laboratorio();
                    res.Laboratorio.ID = Convert.ToInt32(reader["id_laboratorio"]);
                    res.Laboratorio.Nombre = Convert.ToString(reader["nombre_laboratorio"]);
                    res.Posologia = Convert.ToString(reader["posologia_producto"]);
                    res.Documento = Convert.ToString(reader["documento_producto"]);
                    res.Precio = Convert.ToSingle(reader["precio_producto"]);
                    if (!Convert.IsDBNull(reader["id_tipounidad"]))
                    {
                        res.TipoUnidad = new TipoUnidad();
                        res.TipoUnidad.ID = Convert.ToInt32(reader["id_tipounidad"]);
                        if (!Convert.IsDBNull(reader["descripcion_tipounidad"])) res.TipoUnidad.Descripcion = Convert.ToString(reader["descripcion_tipounidad"]);
                    }
                    res.Unidades = Convert.ToInt32(reader["unidades_producto"]);

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
                List<Producto> res = (List<Producto>)this.dataReaderToList(reader);
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
                    string where = " activo_producto = " + this.PARAMETERPREFIX + "activo_producto ";
                    string query = getQuery(where);
                    command.CommandText = query;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_producto", true, command));
                }

                DbDataReader reader = command.ExecuteReader();
                List<Producto> res = (List<Producto>)this.dataReaderToList(reader);
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

        public List<Producto> doGetAll(DbCommand command, vo.filtro.FiltroProducto filtroProducto)
        {
            try
            {

                string where = " activo_producto = " + this.PARAMETERPREFIX + "activo_producto ";

                if (filtroProducto.Indicacion != null)
                {
                    //******* Descripcion ********
                    string indicacionWhere = " (1=1) ";
                    string descripcion = gesClinica.lib.common.funciones.filter.parseString(filtroProducto.Indicacion.Descripcion);
                    foreach (string cad in descripcion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                        indicacionWhere += string.Format(" AND ((i.descripcion_indicacion like '%{0}%') or (''='{0}')) ", cad);

                    where += string.Format(" AND (e.id_producto in (select id_producto from r_producto_indicacion r left join indicacion i on r.id_indicacion = i.id_indicacion where {0}))", indicacionWhere);
                    //where += " AND (c.id_sala = " + this.PARAMETERPREFIX + "id_sala)";
                    //command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "id_sala", filtroProducto.Sala.ID, command));
                }
                if (filtroProducto.Laboratorio != null)
                {
                    //******* Laboratorio ********
                    string laboratorio = gesClinica.lib.common.funciones.filter.parseString(filtroProducto.Laboratorio.Nombre);
                    foreach (string cad in laboratorio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                        where += string.Format(" AND ((l.nombre_laboratorio like '%{0}%') or (''='{0}')) ", cad);

                    //where += " AND (l.nombre_laboratorio = " + this.PARAMETERPREFIX + "nombre_laboratorio)";
                    //command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "nombre_laboratorio", filtroProducto.Laboratorio.Nombre, command));
                }
                if (filtroProducto.Producto != null)
                {
                    //******* Descripcion ********
                    string descripcion = gesClinica.lib.common.funciones.filter.parseString(filtroProducto.Producto.Descripcion);
                    foreach (string cad in descripcion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                        where += string.Format(" AND ((e.descripcion_producto like '%{0}%') or (''='{0}')) ", cad);

                    //where += " AND (e.descripcion_producto = " + this.PARAMETERPREFIX + "descripcion_producto)";
                    //command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_producto", filtroProducto.Producto.Descripcion, command));
                }

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_producto", true, command));
            
                DbDataReader reader = command.ExecuteReader();
                List<Producto> res = (List<Producto>)this.dataReaderToList(reader);
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
                Producto objVO = (Producto)obj;

                string where = " id_producto = " + this.PARAMETERPREFIX + "id_producto";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Producto res = null;
                if (reader.Read())
                    res = (Producto)this.dataReaderToObject(reader);
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
                Producto objVO = (Producto)obj;
                string where = " id_producto = " + this.PARAMETERPREFIX + "id_producto";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.ID, command));

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
                Producto objVO = (Producto)obj;
                string query = "insert into producto "
                    + " (descripcion_producto, id_laboratorio, posologia_producto, documento_producto, activo_producto, precio_producto, unidades_producto, id_tipounidad)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_producto, " + this.PARAMETERPREFIX + "id_laboratorio, " + this.PARAMETERPREFIX + "posologia_producto, " + this.PARAMETERPREFIX + "documento_producto, " + this.PARAMETERPREFIX + "activo_producto, " + this.PARAMETERPREFIX + "precio_producto, " + this.PARAMETERPREFIX + "unidades_producto, " + this.PARAMETERPREFIX + "id_tipounidad)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_producto", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.Laboratorio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "posologia_producto", objVO.Posologia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "documento_producto", objVO.Documento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_producto", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "precio_producto", objVO.Precio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "unidades_producto", objVO.Unidades, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.TipoUnidad.ID, command));

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
                Producto objVO = (Producto)obj;
                string query = "update producto "
                    + "  set "
                    + "  descripcion_producto = " + this.PARAMETERPREFIX + "descripcion_producto"
                    + " ,id_laboratorio = " + this.PARAMETERPREFIX + "id_laboratorio"
                    + " ,posologia_producto = " + this.PARAMETERPREFIX + "posologia_producto"
                    + " ,documento_producto = " + this.PARAMETERPREFIX + "documento_producto"
                    + " ,activo_producto = " + this.PARAMETERPREFIX + "activo_producto"
                    + " ,precio_producto = " + this.PARAMETERPREFIX + "precio_producto"
                    + " ,unidades_producto = " + this.PARAMETERPREFIX + "unidades_producto"
                    + " ,id_tipounidad = " + this.PARAMETERPREFIX + "id_tipounidad"
                    + " where"
                    + " id_producto = " + this.PARAMETERPREFIX + "id_producto";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_producto", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_laboratorio", objVO.Laboratorio.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "posologia_producto", objVO.Posologia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "documento_producto", objVO.Documento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_producto", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "precio_producto", objVO.Precio, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.ID, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "unidades_producto", objVO.Unidades, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipounidad", objVO.TipoUnidad.ID, command));

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
                Producto objVO = (Producto)obj;
                string query = "delete from producto "
                    + " where"
                    + " id_producto = " + this.PARAMETERPREFIX + "id_producto";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.ID, command));

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
                System.Collections.Generic.List<Producto> res = new System.Collections.Generic.List<Producto>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Producto)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        public void doBindIndicacion(DbCommand command, Producto producto, Indicacion indicacion)
        {
            try
            {
                string query = "insert into r_producto_indicacion "
                    + " (id_producto, id_indicacion)"
                    + " values "
                    + string.Format(" ({0}id_producto, {0}id_indicacion)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", indicacion.ID, command));

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
        public void doUnBindIndicacion(DbCommand command, Producto producto, Indicacion indicacion)
        {
            try
            {
                string query = "delete from r_producto_indicacion "
                    + " where "
                    + string.Format("id_producto={0}id_producto", this.PARAMETERPREFIX)
                    + " AND "
                    + string.Format("id_indicacion={0}id_indicacion", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", indicacion.ID, command));

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
        public void doUnBindAllIndicacion(DbCommand command, Producto producto)
        {
            try
            {
                string query = "delete from r_producto_indicacion "
                    + " where "
                    + string.Format("id_producto={0}id_producto", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

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

        public void doBindContraIndicacion(DbCommand command, Producto producto, Indicacion indicacion)
        {
            try
            {
                string query = "insert into r_producto_contraindicacion "
                    + " (id_producto, id_indicacion)"
                    + " values "
                    + string.Format(" ({0}id_producto, {0}id_indicacion)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", indicacion.ID, command));

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
        public void doUnBindContraIndicacion(DbCommand command, Producto producto, Indicacion indicacion)
        {
            try
            {
                string query = "delete from r_producto_contraindicacion "
                    + " where "
                    + string.Format("id_producto={0}id_producto", this.PARAMETERPREFIX)
                    + " AND "
                    + string.Format("id_indicacion={0}id_indicacion", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", indicacion.ID, command));

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
        public void doUnBindAllContraIndicacion(DbCommand command, Producto producto)
        {
            try
            {
                string query = "delete from r_producto_contraindicacion "
                    + " where "
                    + string.Format("id_producto={0}id_producto", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

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
