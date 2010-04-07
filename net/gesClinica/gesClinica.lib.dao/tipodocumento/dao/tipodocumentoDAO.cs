using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tipodocumento.dao
{	
	internal class tipodocumentoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tipodocumento e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tipodocumento asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoDocumento res = null;
				if (reader!=null)
				{
                    res = new TipoDocumento();
                    res.Descripcion = Convert.ToString(reader["descripcion_tipodocumento"]);
                    res.ID= Convert.ToInt32(reader["id_tipodocumento"]);
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
                List<TipoDocumento> res = (List<TipoDocumento>)this.dataReaderToList(reader);
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
                TipoDocumento objVO = (TipoDocumento)obj;

                string where = " id_tipodocumento = " + this.PARAMETERPREFIX + "id_tipodocumento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoDocumento res = null;
                if (reader.Read())
                    res = (TipoDocumento)this.dataReaderToObject(reader);
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
                TipoDocumento objVO = (TipoDocumento)obj;
                string where = " id_tipodocumento = " + this.PARAMETERPREFIX + "id_tipodocumento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.ID, command));

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
                TipoDocumento objVO = (TipoDocumento)obj;
                string query = "insert into tipodocumento "
                    + " (descripcion_tipodocumento)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tipodocumento)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipodocumento", objVO.Descripcion, command));
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
                TipoDocumento objVO = (TipoDocumento)obj;
                string query = "update tipodocumento "
                    + "  set "
                    + "  descripcion_tipodocumento = " + this.PARAMETERPREFIX + "descripcion_tipodocumento"
                    + " where"
                    + " id_tipodocumento = " + this.PARAMETERPREFIX + "id_tipodocumento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipodocumento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.ID, command));

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
                TipoDocumento objVO = (TipoDocumento)obj;
                string query = "delete from tipodocumento "
                    + " where"
                    + " id_tipodocumento = " + this.PARAMETERPREFIX + "id_tipodocumento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.ID, command));

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
                System.Collections.Generic.List<TipoDocumento> res = new System.Collections.Generic.List<TipoDocumento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoDocumento)dataReaderToObject(reader));
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
