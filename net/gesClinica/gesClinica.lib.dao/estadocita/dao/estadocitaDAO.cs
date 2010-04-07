using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.estadocita.dao
{	
	internal class estadocitaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from estadocita e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				EstadoCita res = null;
				if (reader!=null)
				{
                    res = new EstadoCita();
                    res.Color = Convert.ToString(reader["color_estadocita"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_estadocita"]);
                    res.ID = Convert.ToInt32(reader["id_estadocita"]);
                    if (!Convert.IsDBNull(reader["generarecibo_estadocita"])) res.GeneraRecibo = Convert.ToBoolean(reader["generarecibo_estadocita"]);
                    if (!Convert.IsDBNull(reader["avion_estadocita"])) res.Avion = Convert.ToBoolean(reader["avion_estadocita"]);
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
                List<EstadoCita> res = (List<EstadoCita>)this.dataReaderToList(reader);
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
                EstadoCita objVO = (EstadoCita)obj;

                string where = " id_estadocita = " + this.PARAMETERPREFIX + "id_estadocita";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                EstadoCita res = null;
                if (reader.Read())
                    res = (EstadoCita)this.dataReaderToObject(reader);
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
                EstadoCita objVO = (EstadoCita)obj;
                string where = " id_estadocita = " + this.PARAMETERPREFIX + "id_estadocita";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.ID, command));

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
                EstadoCita objVO = (EstadoCita)obj;
                string query = "insert into estadocita "
                    + " (descripcion_estadocita, color_estadocita, generarecibo_estadocita, avion_estadocita)"
                    + " values "
                    + string.Format(" ({0}descripcion_estadocita, {0}color_estadocita, {0}generarecibo_estadocita, {0}avion_estadocita)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadocita", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_estadocita", objVO.Color, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "generarecibo_estadocita", objVO.GeneraRecibo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "avion_estadocita", objVO.Avion, command));

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
                EstadoCita objVO = (EstadoCita)obj;
                string query = "update estadocita "
                    + "  set "
                    + "  descripcion_estadocita = " + this.PARAMETERPREFIX + "descripcion_estadocita"
                    + " ,color_estadocita = " + this.PARAMETERPREFIX + "color_estadocita"
                    + " ,generarecibo_estadocita = " + this.PARAMETERPREFIX + "generarecibo_estadocita"
                    + " ,avion_estadocita = " + this.PARAMETERPREFIX + "avion_estadocita"
                    + " where"
                    + " id_estadocita = " + this.PARAMETERPREFIX + "id_estadocita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadocita", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_estadocita", objVO.Color, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "generarecibo_estadocita", objVO.GeneraRecibo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "avion_estadocita", objVO.Avion, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.ID, command));

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
                EstadoCita objVO = (EstadoCita)obj;
                string query = "delete from estadocita "
                    + " where"
                    + " id_estadocita = " + this.PARAMETERPREFIX + "id_estadocita";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadocita", objVO.ID, command));

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
                System.Collections.Generic.List<EstadoCita> res = new System.Collections.Generic.List<EstadoCita>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((EstadoCita)dataReaderToObject(reader));
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
