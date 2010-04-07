using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using System.Collections.Generic;
using gesClinica.lib.vo.importacion;

namespace gesClinica.lib.dao._importacion.indicacion.dao
{	
	internal class indicacionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from indicaciones i";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
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
                    res.ID= Convert.ToString(reader["IdIndicación"]);
                    res.Descripcion = Convert.ToString(reader["Indicación"]);
				}
				return res;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public List<vo.importacion.Indicacion> doGetAllByProductoIn(DbCommand command, Producto producto)
        {
            try
            {
                string query = "select i.* from indicaciones i"
                + " left join RelProInd rel on i.IdIndicación = rel.IdIndicación "
                + " where "
                + string.Format("IdProducto = {0}IdProducto", "@");

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "IdProducto", producto.ID, command));

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
        public List<vo.importacion.Indicacion> doGetAllByProductoCIn(DbCommand command, Producto producto)
        {
            try
            {
                string query = "select i.* from indicaciones i"
                + " left join RelProCIn rel on i.IdIndicación = rel.IdIndicación "
                + " where "
                + string.Format("IdProducto = {0}IdProducto", "@");

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "IdProducto", producto.ID, command));

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

                string where = " IdIndicación = " + this.PARAMETERPREFIX + "IdIndicación";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "IdIndicación", objVO.ID, command));

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
    }
}
