using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.receta.dao
{	
	internal class recetaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from receta e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Receta res = null;
				if (reader!=null)
				{
                    res = new Receta();
                    res.Observaciones = Convert.ToString(reader["observaciones_receta"]);
                    res.ID= Convert.ToInt32(reader["id_receta"]);
                    res.Cita = new Cita();
                    res.Cita.ID = Convert.ToInt32(reader["id_cita"]);
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
                List<Receta> res = (List<Receta>)this.dataReaderToList(reader);
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


        public List<Receta> doGetAll(DbCommand command, Cita cita)
        {
            try
            {
                string where = " id_cita = " + this.PARAMETERPREFIX + "id_cita";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", cita.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Receta> res = (List<Receta>)this.dataReaderToList(reader);
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
                Receta objVO = (Receta)obj;

                string where = " id_receta = " + this.PARAMETERPREFIX + "id_receta";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Receta res = null;
                if (reader.Read())
                    res = (Receta)this.dataReaderToObject(reader);
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
                Receta objVO = (Receta)obj;
                string where = " id_receta = " + this.PARAMETERPREFIX + "id_receta";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.ID, command));

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
                Receta objVO = (Receta)obj;
                string query = "insert into receta "
                    + " (observaciones_receta, id_cita)"
                    + " values "
                    + string.Format(" ({0}observaciones_receta, {0}id_cita)",this.PARAMETERPREFIX);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_receta", objVO.Observaciones, command));
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
                Receta objVO = (Receta)obj;
                string query = "update receta "
                    + "  set "
                    + "  observaciones_receta = " + this.PARAMETERPREFIX + "observaciones_receta "
                    + " ,id_cita = " + this.PARAMETERPREFIX + "id_cita"
                    + " where"
                    + " id_receta = " + this.PARAMETERPREFIX + "id_receta";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "observaciones_receta", objVO.Observaciones, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.ID, command));

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
                Receta objVO = (Receta)obj;
                string query = "delete from receta "
                    + " where"
                    + " id_receta = " + this.PARAMETERPREFIX + "id_receta";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_receta", objVO.ID, command));

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

        public void doDeleteAll(DbCommand command, Cita cita)
        {
            try
            {
                string query = "delete from receta "
                    + " where"
                    + " id_cita = " + this.PARAMETERPREFIX + "id_cita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", cita.ID, command));

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

        protected override object dataReaderToList(DbDataReader reader)
        {
            try
            {
                System.Collections.Generic.List<Receta> res = new System.Collections.Generic.List<Receta>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Receta)dataReaderToObject(reader));
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
