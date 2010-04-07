using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.configuracion.dao
{	
	internal class configuracionDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from configuracion e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Configuracion res = null;
				if (reader!=null)
				{
                    res = new Configuracion();
                    res.Clase = Convert.ToString(reader["class_configuracion"]);
                    res.Clave = Convert.ToString(reader["keyvalue_configuracion"]);
                    if (!Convert.IsDBNull(reader["parent_configuracion"]))
                    {
                        res.Parent = new Configuracion();
                        res.Parent.ID = Convert.ToInt32(reader["parent_configuracion"]);
                    }
                    res.ID= Convert.ToInt32(reader["id_configuracion"]);
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
                List<Configuracion> res = (List<Configuracion>)this.dataReaderToList(reader);
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

        public List<lib.vo.Configuracion> doGetAllChilds(DbCommand command, Configuracion configuracion)
        {
            try
            {
                //string query = getQuery();
                //command.CommandText = query;

                string where = string.Format(" parent_configuracion = {0}parent_configuracion", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", configuracion.ID, command));
              

                DbDataReader reader = command.ExecuteReader();
                List<Configuracion> res = (List<Configuracion>)this.dataReaderToList(reader);
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


        public Configuracion doGetByClase(DbCommand command, Configuracion obj)
        {
            try
            {
                Configuracion objVO = (Configuracion)obj;

                string where = string.Format(" class_configuracion = {0}class_configuracion AND parent_configuracion is null", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "class_configuracion", objVO.Clase, command));
                
                DbDataReader reader = command.ExecuteReader();
                Configuracion res = null;
                if (reader.Read())
                    res = (Configuracion)this.dataReaderToObject(reader);
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

        public Configuracion doGetByClaseYClave(DbCommand command, Configuracion obj)
        {
            try
            {
                Configuracion objVO = (Configuracion)obj;

                string where = string.Format(" class_configuracion = {0}class_configuracion AND keyvalue_configuracion = {0}keyvalue_configuracion AND parent_configuracion is null", this.PARAMETERPREFIX);
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "class_configuracion", objVO.Clase, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "keyvalue_configuracion", objVO.Clave, command));

                DbDataReader reader = command.ExecuteReader();
                Configuracion res = null;
                if (reader.Read())
                    res = (Configuracion)this.dataReaderToObject(reader);
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
                Configuracion objVO = (Configuracion)obj;

                string where = " id_configuracion = " + this.PARAMETERPREFIX + "id_configuracion";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_configuracion", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Configuracion res = null;
                if (reader.Read())
                    res = (Configuracion)this.dataReaderToObject(reader);
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
                Configuracion objVO = (Configuracion)obj;
                string where = " id_configuracion = " + this.PARAMETERPREFIX + "id_configuracion";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_configuracion", objVO.ID, command));

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
                Configuracion objVO = (Configuracion)obj;
                string query = "insert into configuracion "
                    + " (class_configuracion, keyvalue_configuracion, parent_configuracion)"
                    + " values "
                    + string.Format(" ({0}class_configuracion, {0}keyvalue_configuracion, {0}parent_configuracion)", this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "class_configuracion", objVO.Clase, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "keyvalue_configuracion", objVO.Clave, command));

                if (objVO.Parent != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", objVO.Parent.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", Convert.DBNull, command));

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
                Configuracion objVO = (Configuracion)obj;
                string query = "update configuracion "
                    + "  set "
                    + "  class_configuracion = " + this.PARAMETERPREFIX + "class_configuracion"
                    + " ,keyvalue_configuracion = " + this.PARAMETERPREFIX + "keyvalue_configuracion"
                    + " ,parent_configuracion = " + this.PARAMETERPREFIX + "parent_configuracion"
                    + " where"
                    + " id_configuracion = " + this.PARAMETERPREFIX + "id_configuracion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "class_configuracion", objVO.Clase, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "keyvalue_configuracion", objVO.Clave, command));

                if (objVO.Parent != null)
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", objVO.Parent.ID, command));
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", Convert.DBNull, command));
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_configuracion", objVO.ID, command));

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
                Configuracion objVO = (Configuracion)obj;
                string query = "delete from configuracion "
                    + " where"
                    + " id_configuracion = " + this.PARAMETERPREFIX + "id_configuracion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_configuracion", objVO.ID, command));

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
        public object doDeleteAllChilds(DbCommand command, object obj)
        {
            try
            {
                Configuracion objVO = (Configuracion)obj;
                string query = "delete from configuracion "
                    + " where"
                    + " parent_configuracion = " + this.PARAMETERPREFIX + "parent_configuracion";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_configuracion", objVO.ID, command));

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
                System.Collections.Generic.List<Configuracion> res = new System.Collections.Generic.List<Configuracion>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Configuracion)dataReaderToObject(reader));
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
