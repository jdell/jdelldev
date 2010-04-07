using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.anexo.dao
{	
	internal class anexoDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from anexo e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Anexo res = null;
				if (reader!=null)
				{
                    res = new Anexo();
                    res.ID = Convert.ToInt32(reader["id_anexo"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_anexo"]);
                    res.Titulo = Convert.ToString(reader["titulo_anexo"]);
                    res.Fecha = Convert.ToDateTime(reader["fecha_anexo"]);
                    res.Content = (byte[])reader["content_anexo"];
                    res.Cita = new Cita();
                    res.Cita.ID= Convert.ToInt32(reader["id_cita"]);
                    
                    System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["info_anexo"], false);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    res.Info = (System.IO.FileInfo)formatter.Deserialize(ms);
                    ms.Close();
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
                List<Anexo> res = (List<Anexo>)this.dataReaderToList(reader);
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
        public List<Anexo> doGetAll(DbCommand command, Cita cita)
        {
            try
            {
                string where = " id_cita = " + this.PARAMETERPREFIX + "id_cita";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", cita.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Anexo> res = (List<Anexo>)this.dataReaderToList(reader);
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
                Anexo objVO = (Anexo)obj;

                string where = " id_anexo = " + this.PARAMETERPREFIX + "id_anexo";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_anexo", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Anexo res = null;
                if (reader.Read())
                    res = (Anexo)this.dataReaderToObject(reader);
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
                Anexo objVO = (Anexo)obj;
                string where = " id_anexo = " + this.PARAMETERPREFIX + "id_anexo";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_anexo", objVO.ID, command));

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
                Anexo objVO = (Anexo)obj;
                string query = "insert into anexo "
                    + " (descripcion_anexo, titulo_anexo, fecha_anexo, content_anexo, id_cita, info_anexo)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_anexo, " + this.PARAMETERPREFIX + "titulo_anexo, " + this.PARAMETERPREFIX + "fecha_anexo, " + this.PARAMETERPREFIX + "content_anexo, " + this.PARAMETERPREFIX + "id_cita, " + this.PARAMETERPREFIX + "info_anexo)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_anexo", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "titulo_anexo", objVO.Titulo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_anexo", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "content_anexo", objVO.Content, command));

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                formatter.Serialize(ms, objVO.Info);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "info_anexo", ms.GetBuffer(), command));
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
                Anexo objVO = (Anexo)obj;
                string query = "update anexo "
                    + "  set "
                    + "  descripcion_anexo = " + this.PARAMETERPREFIX + "descripcion_anexo"
                    + " ,titulo_anexo = " + this.PARAMETERPREFIX + "titulo_anexo"
                    + " ,fecha_anexo = " + this.PARAMETERPREFIX + "fecha_anexo"
                    + " ,id_cita = " + this.PARAMETERPREFIX + "id_cita"
                    + " ,content_anexo = " + this.PARAMETERPREFIX + "content_anexo"
                    + " ,info_anexo = " + this.PARAMETERPREFIX + "info_anexo"
                    + " where"
                    + " id_anexo = " + this.PARAMETERPREFIX + "id_anexo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_anexo", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "titulo_anexo", objVO.Titulo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "fecha_anexo", objVO.Fecha, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_cita", objVO.Cita.ID, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "content_anexo", objVO.Content, command));

                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                formatter.Serialize(ms, objVO.Info);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "info_anexo", ms.GetBuffer(), command));
                ms.Close();
                
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_anexo", objVO.ID, command));

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
                Anexo objVO = (Anexo)obj;
                string query = "delete from anexo "
                    + " where"
                    + " id_anexo = " + this.PARAMETERPREFIX + "id_anexo";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_anexo", objVO.ID, command));

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
                string query = "delete from anexo "
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
                System.Collections.Generic.List<Anexo> res = new System.Collections.Generic.List<Anexo>();
                if (reader != null)
                {
                     while (reader.Read())
                        res.Add((Anexo)dataReaderToObject(reader));
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
