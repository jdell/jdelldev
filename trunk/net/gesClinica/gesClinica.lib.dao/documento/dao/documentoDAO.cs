using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.documento.dao
{	
	internal class documentoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from documento e"
            + " left join tipodocumento td on e.id_tipodocumento = td.id_tipodocumento";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by titulo_documento asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Documento res = null;
				if (reader!=null)
				{
                    res = new Documento();
                    res.ID = Convert.ToInt32(reader["id_documento"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_documento"]);
                    res.Titulo = Convert.ToString(reader["titulo_documento"]);
                    res.Fecha = Convert.ToDateTime(reader["fecha_documento"]);
                    res.Content = (byte[])reader["content_documento"];
                    
                    System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["info_documento"], false);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    res.Info = (System.IO.FileInfo)formatter.Deserialize(ms);
                    ms.Close();

                    res.TipoDocumento = new TipoDocumento();
                    res.TipoDocumento.ID = Convert.ToInt32(reader["id_tipodocumento"]);
                    res.TipoDocumento.Descripcion = Convert.ToString(reader["descripcion_tipodocumento"]);
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
                List<Documento> res = (List<Documento>)this.dataReaderToList(reader);
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
                Documento objVO = (Documento)obj;

                string where = " id_documento = " + this.PARAMETERPREFIX + "id_documento";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_documento", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Documento res = null;
                if (reader.Read())
                    res = (Documento)this.dataReaderToObject(reader);
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
                Documento objVO = (Documento)obj;
                string where = " id_documento = " + this.PARAMETERPREFIX + "id_documento";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_documento", objVO.ID, command));

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
                Documento objVO = (Documento)obj;
                string query = "insert into documento "
                    + " (descripcion_documento, titulo_documento, fecha_documento, content_documento, info_documento, id_tipodocumento)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_documento, " + this.PARAMETERPREFIX + "titulo_documento, " + this.PARAMETERPREFIX + "fecha_documento, " + this.PARAMETERPREFIX + "content_documento, " + this.PARAMETERPREFIX + "info_documento, " + this.PARAMETERPREFIX + "id_tipodocumento)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_documento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "titulo_documento", objVO.Titulo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_documento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "content_documento", objVO.Content, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.TipoDocumento.ID, command));

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                formatter.Serialize(ms, objVO.Info);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "info_documento", ms.GetBuffer(), command));
                ms.Close();

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
                Documento objVO = (Documento)obj;
                string query = "update documento "
                    + "  set "
                    + "  descripcion_documento = " + this.PARAMETERPREFIX + "descripcion_documento"
                    + " ,titulo_documento = " + this.PARAMETERPREFIX + "titulo_documento"
                    + " ,fecha_documento = " + this.PARAMETERPREFIX + "fecha_documento"
                    + " ,content_documento = " + this.PARAMETERPREFIX + "content_documento"
                    + " ,info_documento = " + this.PARAMETERPREFIX + "info_documento"
                    + " ,id_tipodocumento = " + this.PARAMETERPREFIX + "id_tipodocumento"
                    + " where"
                    + " id_documento = " + this.PARAMETERPREFIX + "id_documento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_documento", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "titulo_documento", objVO.Titulo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_documento", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "content_documento", objVO.Content, command));

                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tipodocumento", objVO.TipoDocumento.ID, command));

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                formatter.Serialize(ms, objVO.Info);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "info_documento", ms.GetBuffer(), command));
                ms.Close();
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_documento", objVO.ID, command));

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
                Documento objVO = (Documento)obj;
                string query = "delete from documento "
                    + " where"
                    + " id_documento = " + this.PARAMETERPREFIX + "id_documento";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_documento", objVO.ID, command));

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
                System.Collections.Generic.List<Documento> res = new System.Collections.Generic.List<Documento>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Documento)dataReaderToObject(reader));
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
