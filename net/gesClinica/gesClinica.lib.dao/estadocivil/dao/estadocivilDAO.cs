using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.estadocivil.dao
{	
	internal class estadocivilDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from estadocivil e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				EstadoCivil res = null;
				if (reader!=null)
				{
                    res = new EstadoCivil();
                    res.Descripcion = Convert.ToString(reader["descripcion_estadocivil"]);
                    res.ID= Convert.ToInt32(reader["id_estadocivil"]);
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
                List<EstadoCivil> res = (List<EstadoCivil>)this.dataReaderToList(reader);
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
                EstadoCivil objVO = (EstadoCivil)obj;

                string where = " descripcion_estadocivil = " + this.PARAMETERPREFIX + "descripcion_estadocivil";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadocivil", objVO.Descripcion, command));

                DbDataReader reader = command.ExecuteReader();
                EstadoCivil res = null;
                if (reader.Read())
                    res = (EstadoCivil)this.dataReaderToObject(reader);
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
                EstadoCivil objVO = (EstadoCivil)obj;
                string where = " id_estadocivil = " + this.PARAMETERPREFIX + "id_estadocivil";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", objVO.ID, command));

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
                EstadoCivil objVO = (EstadoCivil)obj;
                string query = "insert into estadocivil "
                    + " (descripcion_estadocivil)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_estadocivil)";
                   // + "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadocivil", objVO.Descripcion, command));
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
                EstadoCivil objVO = (EstadoCivil)obj;
                string query = "update estadocivil "
                    + "  set "
                    + "  descripcion_estadocivil = " + this.PARAMETERPREFIX + "descripcion_estadocivil"
                    + " where"
                    + " id_estadocivil = " + this.PARAMETERPREFIX + "id_estadocivil";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadocivil", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", objVO.ID, command));

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
                EstadoCivil objVO = (EstadoCivil)obj;
                string query = "delete from estadocivil "
                    + " where"
                    + " id_estadocivil = " + this.PARAMETERPREFIX + "id_estadocivil";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocivil", objVO.ID, command));

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
                System.Collections.Generic.List<EstadoCivil> res = new System.Collections.Generic.List<EstadoCivil>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((EstadoCivil)dataReaderToObject(reader));
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
