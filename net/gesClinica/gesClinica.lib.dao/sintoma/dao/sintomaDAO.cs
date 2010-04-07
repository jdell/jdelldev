using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.sintoma.dao
{	
	internal class sintomaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from sintoma e"
            + " left join tiposintoma tf on e.id_tiposintoma = tf.id_tiposintoma";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_sintoma asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Sintoma res = null;
				if (reader!=null)
				{
                    res = new Sintoma();
                    res.TipoSintoma = new TipoSintoma();
                    res.TipoSintoma.ID = Convert.ToInt32(reader["id_tiposintoma"]);
                    res.TipoSintoma.Descripcion = Convert.ToString(reader["descripcion_tiposintoma"]);
                    
                    res.Descripcion = Convert.ToString(reader["descripcion_sintoma"]);
                    res.ID= Convert.ToInt32(reader["id_sintoma"]);
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
                List<Sintoma> res = (List<Sintoma>)this.dataReaderToList(reader);
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

        public object doGetAll(DbCommand command, TipoSintoma tipoSintoma)
        {
            try
            {
                string where = " tf.id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", tipoSintoma.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Sintoma> res = (List<Sintoma>)this.dataReaderToList(reader);
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
                Sintoma objVO = (Sintoma)obj;

                string where = " id_sintoma = " + this.PARAMETERPREFIX + "id_sintoma";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sintoma", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Sintoma res = null;
                if (reader.Read())
                    res = (Sintoma)this.dataReaderToObject(reader);
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
                Sintoma objVO = (Sintoma)obj;
                string where = " id_sintoma = " + this.PARAMETERPREFIX + "id_sintoma  ";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sintoma", objVO.ID, command));

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
                Sintoma objVO = (Sintoma)obj;
                string query = "insert into sintoma "
                    + " (descripcion_sintoma, id_tiposintoma)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_sintoma," + this.PARAMETERPREFIX + "id_tiposintoma)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_sintoma", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.TipoSintoma.ID, command));
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
                Sintoma objVO = (Sintoma)obj;
                string query = "update sintoma "
                    + "  set "
                    + "  descripcion_sintoma = " + this.PARAMETERPREFIX + "descripcion_sintoma"
                    + " ,id_tiposintoma = " + this.PARAMETERPREFIX + "id_tiposintoma"
                    + " where"
                    + " id_sintoma = " + this.PARAMETERPREFIX + "id_sintoma";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_sintoma", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tiposintoma", objVO.TipoSintoma.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sintoma", objVO.ID, command));

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
                Sintoma objVO = (Sintoma)obj;
                string query = "delete from sintoma "
                    + " where"
                    + " id_sintoma = " + this.PARAMETERPREFIX + "id_sintoma";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_sintoma", objVO.ID, command));

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
        public void doDeleteAll(DbCommand command)
        {
            try
            {
                string query = "delete from sintoma ";

                command.CommandText = query;
                
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
                System.Collections.Generic.List<Sintoma> res = new System.Collections.Generic.List<Sintoma>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Sintoma)dataReaderToObject(reader));
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
