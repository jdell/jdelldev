using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tipoterapia.dao
{	
	internal class tipoterapiaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tipoterapia e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tipoterapia asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TipoTerapia res = null;
				if (reader!=null)
				{
                    res = new TipoTerapia();
                    res.Descripcion = Convert.ToString(reader["descripcion_tipoterapia"]);
                    res.ID = Convert.ToInt32(reader["id_tipoterapia"]);
                    res.Cobrable = Convert.ToBoolean(reader["cobrable_tipoterapia"]);
                    res.Codigo = lib.vo.TipoTerapia.CodigoFromName(Convert.ToString(reader["codigo_tipoterapia"]));
                    res.Color = Convert.ToString(reader["color_tipoterapia"]);
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
                List<TipoTerapia> res = (List<TipoTerapia>)this.dataReaderToList(reader);
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
                TipoTerapia objVO = (TipoTerapia)obj;

                string where = " id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TipoTerapia res = null;
                if (reader.Read())
                    res = (TipoTerapia)this.dataReaderToObject(reader);
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
                TipoTerapia objVO = (TipoTerapia)obj;
                string where = " id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.ID, command));

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
                TipoTerapia objVO = (TipoTerapia)obj;
                string query = "insert into tipoterapia "
                    + " (descripcion_tipoterapia, cobrable_tipoterapia, codigo_tipoterapia, color_tipoterapia)"
                    + " values "
                    + string.Format(" ({0}descripcion_tipoterapia, {0}cobrable_tipoterapia, {0}codigo_tipoterapia, {0}color_tipoterapia)", this.PARAMETERPREFIX);
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipoterapia", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "cobrable_tipoterapia", objVO.Cobrable, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_tipoterapia", lib.vo.TipoTerapia.NameFromCodigo(objVO.Codigo), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_tipoterapia", objVO.Color, command));

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
                TipoTerapia objVO = (TipoTerapia)obj;
                string query = "update tipoterapia "
                    + "  set "
                    + "  descripcion_tipoterapia = " + this.PARAMETERPREFIX + "descripcion_tipoterapia"
                    + " ,cobrable_tipoterapia = " + this.PARAMETERPREFIX + "cobrable_tipoterapia"
                    + " ,codigo_tipoterapia = " + this.PARAMETERPREFIX + "codigo_tipoterapia"
                    + " ,color_tipoterapia = " + this.PARAMETERPREFIX + "color_tipoterapia"
                    + " where"
                    + " id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tipoterapia", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "cobrable_tipoterapia", objVO.Cobrable, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "codigo_tipoterapia", lib.vo.TipoTerapia.NameFromCodigo(objVO.Codigo), command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "color_tipoterapia", objVO.Color, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.ID, command));

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
                TipoTerapia objVO = (TipoTerapia)obj;
                string query = "delete from tipoterapia "
                    + " where"
                    + " id_tipoterapia = " + this.PARAMETERPREFIX + "id_tipoterapia";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipoterapia", objVO.ID, command));

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
                System.Collections.Generic.List<TipoTerapia> res = new System.Collections.Generic.List<TipoTerapia>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((TipoTerapia)dataReaderToObject(reader));
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
