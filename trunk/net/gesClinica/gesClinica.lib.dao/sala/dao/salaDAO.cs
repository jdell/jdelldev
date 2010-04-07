using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.sala.dao
{	
	internal class salaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from sala e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Sala res = null;
				if (reader!=null)
				{
                    res = new Sala();
                    res.Activo= Convert.ToBoolean(reader["activo_sala"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_sala"]);
                    res.ID= Convert.ToInt32(reader["id_sala"]);
                    if (!Convert.IsDBNull(reader["color_sala"])) res.Color = Convert.ToString(reader["color_sala"]);
               
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
                List<Sala> res = (List<Sala>)this.dataReaderToList(reader);
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
                    string where = " activo_sala = " + this.PARAMETERPREFIX + "activo_sala ";
                    string query = getQuery(where);
                    command.CommandText = query;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_sala", true, command));
                }

                DbDataReader reader = command.ExecuteReader();
                List<Sala> res = (List<Sala>)this.dataReaderToList(reader);
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
                Sala objVO = (Sala)obj;

                string where = " id_sala = " + this.PARAMETERPREFIX + "id_sala";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Sala res = null;
                if (reader.Read())
                    res = (Sala)this.dataReaderToObject(reader);
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
                Sala objVO = (Sala)obj;
                string where = " id_sala = " + this.PARAMETERPREFIX + "id_sala";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.ID, command));

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
                Sala objVO = (Sala)obj;
                string query = "insert into sala "
                    + " (descripcion_sala, activo_sala, color_sala)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_sala," + this.PARAMETERPREFIX + "activo_sala," + this.PARAMETERPREFIX + "color_sala)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_sala", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_sala", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_sala", objVO.Color, command));

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
                Sala objVO = (Sala)obj;
                string query = "update sala "
                    + "  set "
                    + "  descripcion_sala = " + this.PARAMETERPREFIX + "descripcion_sala"
                    + " ,activo_sala = " + this.PARAMETERPREFIX + "activo_sala"
                    + " ,color_sala = " + this.PARAMETERPREFIX + "color_sala"
                    + " where"
                    + " id_sala = " + this.PARAMETERPREFIX + "id_sala";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_sala", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_sala", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_sala", objVO.Color, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.ID, command));

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
                Sala objVO = (Sala)obj;
                string query = "delete from sala "
                    + " where"
                    + " id_sala = " + this.PARAMETERPREFIX + "id_sala";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sala", objVO.ID, command));

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
                System.Collections.Generic.List<Sala> res = new System.Collections.Generic.List<Sala>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Sala)dataReaderToObject(reader));
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
