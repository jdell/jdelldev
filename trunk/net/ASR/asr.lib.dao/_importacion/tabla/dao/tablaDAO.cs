using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;
using asr.lib.vo.importacion;

namespace asr.lib.dao._importacion.tabla.dao
{	
	internal class tablaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tabla e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Tabla res = null;
				if (reader!=null)
				{
                    res = new Tabla();
                    res.ID= Convert.ToInt32(reader["id_tabla"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_tabla"]);
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
                List<Tabla> res = (List<Tabla>)this.dataReaderToList(reader);
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
                Tabla objVO = (Tabla)obj;

                string where = " id_tabla = " + this.PARAMETERPREFIX + "id_tabla";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tabla", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Tabla res = null;
                if (reader.Read())
                    res = (Tabla)this.dataReaderToObject(reader);
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
                Tabla objVO = (Tabla)obj;
                string where = " descripcion_tabla = " + this.PARAMETERPREFIX + "descripcion_tabla";

                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tabla", objVO.Descripcion, command));


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
                Tabla objVO = (Tabla)obj;
                string query = "insert into tabla "
                    + " (descripcion_tabla)"
                    + " values "
                    + string.Format("({0}descripcion_tabla)", this.PARAMETERPREFIX);
                    

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tabla", objVO.Descripcion, command));

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
                Tabla objVO = (Tabla)obj;
                string query = "update tabla "
                    + "  set "
                    + " descripcion_tabla = " + this.PARAMETERPREFIX + "descripcion_tabla"
                    + " where"
                    + " id_tabla = " + this.PARAMETERPREFIX + "id_tabla";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tabla", objVO.Descripcion, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tabla", objVO.ID, command));

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
                Tabla objVO = (Tabla)obj;
                string query = "delete from tabla "
                    + " where"
                    + " id_tabla = " + this.PARAMETERPREFIX + "id_tabla";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tabla", objVO.ID, command));

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
                System.Collections.Generic.List<Tabla> res = new System.Collections.Generic.List<Tabla>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Tabla)dataReaderToObject(reader));
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
