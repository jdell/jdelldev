using System;
using System.Data.Common;
using gesClinica.lib.dao._template;
using gesClinica.lib.vo;
using System.Collections.Generic;

namespace gesClinica.lib.dao.tarifa.dao
{	
	internal class tarifaDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from tarifa e";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by descripcion_tarifa asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Tarifa res = null;
				if (reader!=null)
				{
                    res = new Tarifa();
                    res.Activo = Convert.ToBoolean(reader["activo_tarifa"]);
                    res.Descripcion = Convert.ToString(reader["descripcion_tarifa"]);
                    res.ID = Convert.ToInt32(reader["id_tarifa"]);
                    res.Descuento = Convert.ToInt32(reader["descuento_tarifa"]);
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
                List<Tarifa> res = (List<Tarifa>)this.dataReaderToList(reader);
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
                    string where = " activo_tarifa = " + this.PARAMETERPREFIX + "activo_tarifa ";
                    string query = getQuery(where);
                    command.CommandText = query;
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_tarifa", true, command));
                }

                DbDataReader reader = command.ExecuteReader();
                List<Tarifa> res = (List<Tarifa>)this.dataReaderToList(reader);
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
                Tarifa objVO = (Tarifa)obj;

                string where = " id_tarifa = " + this.PARAMETERPREFIX + "id_tarifa";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Tarifa res = null;
                if (reader.Read())
                    res = (Tarifa)this.dataReaderToObject(reader);
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
                Tarifa objVO = (Tarifa)obj;
                string where = " id_tarifa = " + this.PARAMETERPREFIX + "id_tarifa";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.ID, command));

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
                Tarifa objVO = (Tarifa)obj;
                string query = "insert into tarifa "
                    + " (descripcion_tarifa, descuento_tarifa, activo_tarifa)"
                    + " values "
                    + " (" + this.PARAMETERPREFIX + "descripcion_tarifa, " + this.PARAMETERPREFIX + "descuento_tarifa, " + this.PARAMETERPREFIX + "activo_tarifa)";
                    //+ "; select " + this.PARAMETERPREFIX + "id=SCOPE_IDENTITY()";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "descuento_tarifa", objVO.Descuento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tarifa", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_tarifa", objVO.Activo, command));
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
                Tarifa objVO = (Tarifa)obj;
                string query = "update tarifa "
                    + "  set "
                    + "  descripcion_tarifa = " + this.PARAMETERPREFIX + "descripcion_tarifa"
                    + " ,descuento_tarifa = " + this.PARAMETERPREFIX + "descuento_tarifa"
                    + " ,activo_tarifa = " + this.PARAMETERPREFIX + "activo_tarifa"
                    + " where"
                    + " id_tarifa = " + this.PARAMETERPREFIX + "id_tarifa";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "descuento_tarifa", objVO.Descuento, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "descripcion_tarifa", objVO.Descripcion, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "activo_tarifa", objVO.Activo, command));
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.ID, command));

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
                Tarifa objVO = (Tarifa)obj;
                string query = "delete from tarifa "
                    + " where"
                    + " id_tarifa = " + this.PARAMETERPREFIX + "id_tarifa";

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_tarifa", objVO.ID, command));

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
                System.Collections.Generic.List<Tarifa> res = new System.Collections.Generic.List<Tarifa>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Tarifa)dataReaderToObject(reader));
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
