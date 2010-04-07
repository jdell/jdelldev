using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.estadoevento.dao
{	
	internal class estadoeventoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from estadoevento e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				EstadoEvento res = null;
				if (reader!=null)
				{
                    res = new EstadoEvento();
                    res.Color = Convert.ToString(reader["color_estadoevento"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_estadoevento"]);
                    res.ID= Convert.ToInt32(reader["id_estadoevento"]);
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
                List<EstadoEvento> res = (List<EstadoEvento>)this.dataReaderToList(reader);
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
                EstadoEvento objVO = (EstadoEvento)obj;

                string where = " id_estadoevento = " + this.PARAMETERPREFIX + "id_estadoevento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                EstadoEvento res = null;
                if (reader.Read())
                    res = (EstadoEvento)this.dataReaderToObject(reader);
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
                EstadoEvento objVO = (EstadoEvento)obj;
                string where = " id_estadoevento = " + this.PARAMETERPREFIX + "id_estadoevento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.ID, command));

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
                EstadoEvento objVO = (EstadoEvento)obj;
                string query = "insert into estadoevento "
                    + " (descripcion_estadoevento, color_estadoevento)"
                    + " values "
                    + string.Format(" ({0}descripcion_estadoevento, {0}color_estadoevento)",this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadoevento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_estadoevento", objVO.Color, command));

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
                EstadoEvento objVO = (EstadoEvento)obj;
                string query = "update estadoevento "
                    + "  set "
                    + "  descripcion_estadoevento = " + this.PARAMETERPREFIX + "descripcion_estadoevento"
                    + " ,color_estadoevento = " + this.PARAMETERPREFIX + "color_estadoevento"
                    + " where"
                    + " id_estadoevento = " + this.PARAMETERPREFIX + "id_estadoevento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_estadoevento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_estadoevento", objVO.Color, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.ID, command));

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
                EstadoEvento objVO = (EstadoEvento)obj;
                string query = "delete from estadoevento "
                    + " where"
                    + " id_estadoevento = " + this.PARAMETERPREFIX + "id_estadoevento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_estadoevento", objVO.ID, command));

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
                System.Collections.Generic.List<EstadoEvento> res = new System.Collections.Generic.List<EstadoEvento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((EstadoEvento)dataReaderToObject(reader));
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
