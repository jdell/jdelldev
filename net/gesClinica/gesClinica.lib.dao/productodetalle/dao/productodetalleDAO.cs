using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.productodetalle.dao
{	
	internal class productodetalleDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from productodetalle pd"
            + " left join producto p on pd.id_producto = p.id_producto"
            + " left join componente c on pd.id_componente = c.id_componente";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				ProductoDetalle res = null;
				if (reader!=null)
				{
                    res = new ProductoDetalle();
                    res.ID = Convert.ToInt32(reader["id_productodetalle"]);
                    res.Componente = new Componente();
                    res.Componente.ID = Convert.ToInt32(reader["id_componente"]);
                    res.Componente.Descripcion = Convert.ToString(reader["descripcion_componente"]);

                    res.Producto = new Producto();
                    res.Producto.ID = Convert.ToInt32(reader["id_producto"]);
                    res.Producto.Descripcion = Convert.ToString(reader["descripcion_producto"]);

                    res.Dosis = Convert.ToString(reader["dosis_productodetalle"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public void doDeleteAll(DbCommand command, Producto producto)
        {
            try
            {
                string query = "delete from productodetalle "
                    + " where"
                    + " id_producto = " + this.PARAMETERPREFIX + "id_producto";

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

        public override object doGetAll(DbCommand command)
        {
            try
            {
                string query = getQuery();
                command.CommandText = query;

                DbDataReader reader = command.ExecuteReader();
                List<ProductoDetalle> res = (List<ProductoDetalle>)this.dataReaderToList(reader);
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

        public List<ProductoDetalle> doGetAll(DbCommand command, Producto producto)
        {
            try
            {
                string where = " pd.id_producto = " + this.PARAMETERPREFIX + "id_producto";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<ProductoDetalle> res = (List<ProductoDetalle>)this.dataReaderToList(reader);
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
                ProductoDetalle objVO = (ProductoDetalle)obj;

                string where = " id_productodetalle = " + this.PARAMETERPREFIX + "id_productodetalle";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_productodetalle", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                ProductoDetalle res = null;
                if (reader.Read())
                    res = (ProductoDetalle)this.dataReaderToObject(reader);
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
                ProductoDetalle objVO = (ProductoDetalle)obj;
                string where = " id_productodetalle = " + this.PARAMETERPREFIX + "id_productodetalle";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_productodetalle", objVO.ID, command));

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
                ProductoDetalle objVO = (ProductoDetalle)obj;
                string query = "insert into productodetalle "
                    + " (id_producto, id_componente, dosis_productodetalle)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "id_producto, " + this.PARAMETERPREFIX + "id_componente, " + this.PARAMETERPREFIX + "dosis_productodetalle)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.Producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_componente", objVO.Componente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dosis_productodetalle", objVO.Dosis, command));
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
                ProductoDetalle objVO = (ProductoDetalle)obj;
                string query = "update productodetalle "
                    + "  set "
                    + "  id_producto = " + this.PARAMETERPREFIX + "id_producto"
                    + " ,id_componente = " + this.PARAMETERPREFIX + "id_componente"
                    + " ,dosis_productodetalle = " + this.PARAMETERPREFIX + "dosis_productodetalle"
                    + " where"
                    + " id_productodetalle = " + this.PARAMETERPREFIX + "id_productodetalle";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.Producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_componente", objVO.Componente.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "dosis_productodetalle", objVO.Dosis, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_productodetalle", objVO.ID, command));

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
                ProductoDetalle objVO = (ProductoDetalle)obj;
                string query = "delete from productodetalle "
                    + " where"
                    + " id_productodetalle = " + this.PARAMETERPREFIX + "id_productodetalle";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_productodetalle", objVO.ID, command));

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
                System.Collections.Generic.List<ProductoDetalle> res = new System.Collections.Generic.List<ProductoDetalle>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((ProductoDetalle)dataReaderToObject(reader));
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
