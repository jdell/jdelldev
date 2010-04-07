using System;
using System.Data.Common;
using ambis1.model.dao._template;
using ambis1.model.vo;
using System.Collections.Generic;

namespace ambis1.model.dao.typeofmembership.dao
{	
	internal class typeofmembershipDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from typeofmembership c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by numofmonths_typeofmembership asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				TypeOfMembership res = null;
				if (reader!=null)
				{
                    res = new TypeOfMembership();
                    res.NumOfMonths= Convert.ToInt32(reader["numofmonths_typeofmembership"]);
                    res.ID = Convert.ToInt32(reader["id_typeofmembership"]);
                    res.IndividualPrice = Convert.ToSingle(reader["individualprice_typeofmembership"]);
                    if (!Convert.IsDBNull(reader["teamprice_typeofmembership"])) res.TeamPrice = Convert.ToSingle(reader["teamprice_typeofmembership"]);
                    if (!Convert.IsDBNull(reader["familyprice_typeofmembership"])) res.FamilyPrice = Convert.ToSingle(reader["familyprice_typeofmembership"]);
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
                List<TypeOfMembership> res = (List<TypeOfMembership>)this.dataReaderToList(reader);
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
                TypeOfMembership objVO = (TypeOfMembership)obj;

                string where = " c.id_typeofmembership = " + this.PARAMETERPREFIX + "id_typeofmembership";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_typeofmembership", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                TypeOfMembership res = null;
                if (reader.Read())
                    res = (TypeOfMembership)this.dataReaderToObject(reader);
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
                TypeOfMembership objVO = (TypeOfMembership)obj;
                string where = " c.id_typeofmembership = " + this.PARAMETERPREFIX + "id_typeofmembership";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_typeofmembership", objVO.ID, command));

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
                TypeOfMembership objVO = (TypeOfMembership)obj;
                string query = "insert into typeofmembership "
                    + " (numofmonths_typeofmembership, individualprice_typeofmembership, teamprice_typeofmembership, familyprice_typeofmembership)"
                    + " values "
                    + " ({0}numofmonths_typeofmembership, {0}individualprice_typeofmembership, {0}teamprice_typeofmembership, {0}familyprice_typeofmembership)";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.INSERT);
            
                command.ExecuteNonQuery();
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
                TypeOfMembership objVO = (TypeOfMembership)obj;
                string query = "update typeofmembership "
                    + "  set "
                    + "  individualprice_typeofmembership = {0}individualprice_typeofmembership "
                    + " ,numofmonths_typeofmembership = {0}numofmonths_typeofmembership"
                    + " ,teamprice_typeofmembership = {0}teamprice_typeofmembership"
                    + " ,familyprice_typeofmembership = {0}familyprice_typeofmembership"
                    + " where"
                    + " id_typeofmembership = {0}id_typeofmembership";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.UPDATE);

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
                TypeOfMembership objVO = (TypeOfMembership)obj;
                string query = "delete from typeofmembership "
                    + " where"
                    + " id_typeofmembership = {0}id_typeofmembership";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.DELETE);
            
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
                System.Collections.Generic.List<TypeOfMembership> res = new System.Collections.Generic.List<TypeOfMembership>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((TypeOfMembership)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        protected override void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction)
        {
            try
            {
                TypeOfMembership objVO = (TypeOfMembership)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "numofmonths_typeofmembership", objVO.NumOfMonths, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "individualprice_typeofmembership", objVO.IndividualPrice, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "teamprice_typeofmembership", objVO.TeamPrice, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "familyprice_typeofmembership", objVO.FamilyPrice, command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_typeofmembership", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_typeofmembership", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
