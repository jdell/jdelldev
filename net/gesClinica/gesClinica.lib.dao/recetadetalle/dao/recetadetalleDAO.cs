using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.recetadetalle.dao
{	
	internal class recetadetalleDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from recetadetalle pd"
            + " left join receta p on pd.id_receta = p.id_receta"
            + " left join producto c on pd.id_producto = c.id_producto"
            + " left join laboratorio l on c.id_laboratorio = l.id_laboratorio";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				RecetaDetalle res = null;
				if (reader!=null)
				{
                    res = new RecetaDetalle();
                    res.ID = Convert.ToInt32(reader["id_recetadetalle"]);
                    res.Producto = new Producto();
                    res.Producto.ID = Convert.ToInt32(reader["id_producto"]);
                    res.Producto.Descripcion = Convert.ToString(reader["descripcion_producto"]);
                    if (!Convert.IsDBNull(reader["id_laboratorio"]))
                    {
                        res.Producto.Laboratorio = new Laboratorio();
                        res.Producto.Laboratorio.ID = Convert.ToInt32(reader["id_laboratorio"]);
                        if (!Convert.IsDBNull(reader["nombre_laboratorio"])) res.Producto.Laboratorio.Nombre = Convert.ToString(reader["nombre_laboratorio"]);
                    }

                    res.Receta = new Receta();
                    res.Receta.ID = Convert.ToInt32(reader["id_receta"]);

                    res.Posologia = Convert.ToString(reader["posologia_recetadetalle"]);
                    res.Cantidad = Convert.ToInt32(reader["cantidad_recetadetalle"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public void doDeleteAll(DbCommand command, Receta receta)
        {
            try
            {
                string query = "delete from recetadetalle "
                    + " where"
                    + " id_receta = " + this.PARAMETERPREFIX + "id_receta";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", receta.ID, command));

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
                List<RecetaDetalle> res = (List<RecetaDetalle>)this.dataReaderToList(reader);
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

        public List<RecetaDetalle> doGetAll(DbCommand command, Receta receta)
        {
            try
            {
                string where = " pd.id_receta = " + this.PARAMETERPREFIX + "id_receta";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", receta.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<RecetaDetalle> res = (List<RecetaDetalle>)this.dataReaderToList(reader);
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
                RecetaDetalle objVO = (RecetaDetalle)obj;

                string where = " id_recetadetalle = " + this.PARAMETERPREFIX + "id_recetadetalle";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_recetadetalle", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                RecetaDetalle res = null;
                if (reader.Read())
                    res = (RecetaDetalle)this.dataReaderToObject(reader);
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
                RecetaDetalle objVO = (RecetaDetalle)obj;
                string where = " id_recetadetalle = " + this.PARAMETERPREFIX + "id_recetadetalle";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_recetadetalle", objVO.ID, command));

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
                RecetaDetalle objVO = (RecetaDetalle)obj;
                string query = "insert into recetadetalle "
                    + " (id_receta, id_producto, posologia_recetadetalle, cantidad_recetadetalle)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "id_receta, " + this.PARAMETERPREFIX + "id_producto, " + this.PARAMETERPREFIX + "posologia_recetadetalle, " + this.PARAMETERPREFIX + "cantidad_recetadetalle)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.Receta.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.Producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "posologia_recetadetalle", objVO.Posologia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "cantidad_recetadetalle", objVO.Cantidad, command));
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
                RecetaDetalle objVO = (RecetaDetalle)obj;
                string query = "update recetadetalle "
                    + "  set "
                    + "  id_receta = " + this.PARAMETERPREFIX + "id_receta"
                    + " ,id_producto = " + this.PARAMETERPREFIX + "id_producto"
                    + " ,posologia_recetadetalle = " + this.PARAMETERPREFIX + "posologia_recetadetalle"
                    + " ,cantidad_recetadetalle = " + this.PARAMETERPREFIX + "cantidad_recetadetalle"
                    + " where"
                    + " id_recetadetalle = " + this.PARAMETERPREFIX + "id_recetadetalle";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.Receta.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", objVO.Producto.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "posologia_recetadetalle", objVO.Posologia, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "cantidad_recetadetalle", objVO.Cantidad, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_recetadetalle", objVO.ID, command));

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
                RecetaDetalle objVO = (RecetaDetalle)obj;
                string query = "delete from recetadetalle "
                    + " where"
                    + " id_recetadetalle = " + this.PARAMETERPREFIX + "id_recetadetalle";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_recetadetalle", objVO.ID, command));

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
                System.Collections.Generic.List<RecetaDetalle> res = new System.Collections.Generic.List<RecetaDetalle>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((RecetaDetalle)dataReaderToObject(reader));
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
