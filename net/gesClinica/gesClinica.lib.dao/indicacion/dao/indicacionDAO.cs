using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.indicacion.dao
{	
	internal class indicacionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from indicacion e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_indicacion asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Indicacion res = null;
				if (reader!=null)
				{
                    res = new Indicacion();
                    res.Descripcion = Convert.ToString(reader["descripcion_indicacion"]);
                    res.ID= Convert.ToInt32(reader["id_indicacion"]);
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
                List<Indicacion> res = (List<Indicacion>)this.dataReaderToList(reader);
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
                Indicacion objVO = (Indicacion)obj;

                string where = " id_indicacion = " + this.PARAMETERPREFIX + "id_indicacion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Indicacion res = null;
                if (reader.Read())
                    res = (Indicacion)this.dataReaderToObject(reader);
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
                Indicacion objVO = (Indicacion)obj;
                string where = " id_indicacion = " + this.PARAMETERPREFIX + "id_indicacion";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", objVO.ID, command));

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
                Indicacion objVO = (Indicacion)obj;
                string query = "insert into indicacion "
                    + " (descripcion_indicacion)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_indicacion)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_indicacion", objVO.Descripcion, command));
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
                Indicacion objVO = (Indicacion)obj;
                string query = "update indicacion "
                    + "  set "
                    + "  descripcion_indicacion = " + this.PARAMETERPREFIX + "descripcion_indicacion"
                    + " where"
                    + " id_indicacion = " + this.PARAMETERPREFIX + "id_indicacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_indicacion", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", objVO.ID, command));

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
                Indicacion objVO = (Indicacion)obj;
                string query = "delete from indicacion "
                    + " where"
                    + " id_indicacion = " + this.PARAMETERPREFIX + "id_indicacion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_indicacion", objVO.ID, command));

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
                System.Collections.Generic.List<Indicacion> res = new System.Collections.Generic.List<Indicacion>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Indicacion)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Indicacion> doGetAllInIndicacion(DbCommand command, Producto producto)
        {
            try
            {

                string where = " id_indicacion in (select id_indicacion from r_producto_indicacion where id_producto = " + this.PARAMETERPREFIX + "id_producto)";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Indicacion> res = (List<Indicacion>)this.dataReaderToList(reader);
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
        public List<Indicacion> doGetAllOutIndicacion(DbCommand command, Producto producto)
        {
            try
            {
                string where = " id_indicacion not in (select id_indicacion from r_producto_indicacion where id_producto = " + this.PARAMETERPREFIX + "id_producto)";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Indicacion> res = (List<Indicacion>)this.dataReaderToList(reader);
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

        public List<Indicacion> doGetAllInContraIndicacion(DbCommand command, Producto producto)
        {
            try
            {

                string where = " id_indicacion in (select id_indicacion from r_producto_contraindicacion where id_producto = " + this.PARAMETERPREFIX + "id_producto)";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Indicacion> res = (List<Indicacion>)this.dataReaderToList(reader);
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
        public List<Indicacion> doGetAllOutContraIndicacion(DbCommand command, Producto producto)
        {
            try
            {
                string where = " id_indicacion not in (select id_indicacion from r_producto_contraindicacion where id_producto = " + this.PARAMETERPREFIX + "id_producto)";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_producto", producto.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Indicacion> res = (List<Indicacion>)this.dataReaderToList(reader);
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
