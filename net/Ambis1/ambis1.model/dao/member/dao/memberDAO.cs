using System;
using System.Data.Common;
using ambis1.model.dao._template;
using ambis1.model.vo;
using System.Collections.Generic;

namespace ambis1.model.dao.member.dao
{	
	internal class memberDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from member c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by id_member asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Member res = null;
				if (reader!=null)
				{
                    res = Member.getNewMember(Member.TypeFromName(Convert.ToString(reader["type_member"])));
                    res.Address = Convert.ToString(reader["address_member"]);
                    res.Cell = Convert.ToString(reader["cell_member"]);
                    res.City = Convert.ToString(reader["city_member"]);
                    res.DateOfBirth= Convert.ToDateTime(reader["dob_member"]);
                    res.Email = Convert.ToString(reader["email_member"]);
                    res.FirstName = Convert.ToString(reader["firstName_member"]);
                    res.ID = Convert.ToInt32(reader["id_member"]);
                    res.LastName = Convert.ToString(reader["lastname_member"]);
                    res.MiddleName = Convert.ToString(reader["middleName_member"]);
                    if (!Convert.IsDBNull(reader["parent_member"]))
                    {
                        res.Parent = new Team();
                        res.Parent.ID = Convert.ToInt32(reader["parent_member"]);
                    }
                    res.Phone = Convert.ToString(reader["phone_member"]);
                    res.Number = Convert.ToInt32(reader["number_member"]);
                    res.State = Convert.ToString(reader["state_member"]);
                    res.ZipCode = Convert.ToString(reader["zipcode_member"]);

                    if (!Convert.IsDBNull(reader["photo_member"]))
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["photo_member"]);
                        if (ms.Length > 0) res.Photo = System.Drawing.Image.FromStream(ms);
                    }

                    //Added on 01/27/2010
                    if (!Convert.IsDBNull(reader["comments_member"])) res.Comments = Convert.ToString(reader["comments_member"]);
                    if (!Convert.IsDBNull(reader["emergencycontactName_member"])) res.EmergencyContactName = Convert.ToString(reader["emergencycontactName_member"]);
                    if (!Convert.IsDBNull(reader["emergencycontactPhone_member"])) res.EmergencyContactPhone = Convert.ToString(reader["emergencycontactPhone_member"]);
                    if (!Convert.IsDBNull(reader["emergencycontactRelationship_member"])) res.EmergencyContactRelationship = Convert.ToString(reader["emergencycontactRelationship_member"]);
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
                List<Member> res = (List<Member>)this.dataReaderToList(reader);
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
                Member objVO = (Member)obj;

                string where = " c.id_member = " + this.PARAMETERPREFIX + "id_member";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Member res = null;
                if (reader.Read())
                    res = (Member)this.dataReaderToObject(reader);
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
        public Member doGetByNumber(DbCommand command, object obj)
        {
            try
            {
                Member objVO = (Member)obj;

                string where = " c.number_member = " + this.PARAMETERPREFIX + "number_member";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "number_member", objVO.Number, command));

                DbDataReader reader = command.ExecuteReader();
                Member res = null;
                if (reader.Read())
                    res = (Member)this.dataReaderToObject(reader);
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
                Member objVO = (Member)obj;
                string where = " c.number_member = " + this.PARAMETERPREFIX + "number_member";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "number_member", objVO.Number, command));

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
                Member objVO = (Member)obj;
                string query = "insert into member "
                    + " (comments_member, emergencycontactName_member, emergencycontactPhone_member, emergencycontactRelationship_member, firstName_member, middleName_member, lastName_member, number_member, dob_member, address_member, city_member, state_member, zipcode_member, phone_member, email_member, photo_member, parent_member, cell_member, type_member)"
                    + " values "
                    + " ({0}comments_member, {0}emergencycontactName_member, {0}emergencycontactPhone_member, {0}emergencycontactRelationship_member, {0}firstName_member, {0}middleName_member, {0}lastName_member, {0}number_member, {0}dob_member, {0}address_member, {0}city_member, {0}state_member, {0}zipcode_member, {0}phone_member, {0}email_member, {0}photo_member, {0}parent_member, {0}cell_member, {0}type_member)";

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
                Member objVO = (Member)obj;
                string query = "update member "
                    + "  set "
                    + "  firstName_member = {0}firstName_member"
                    + " ,middleName_member = {0}middleName_member"
                    + " ,lastName_member = {0}lastName_member"
                    //+ " ,number_member = {0}number_member"
                    + " ,dob_member = {0}dob_member"
                    + " ,address_member = {0}address_member"
                    + " ,city_member = {0}city_member"
                    + " ,state_member = {0}state_member"
                    + " ,zipcode_member = {0}zipcode_member"
                    + " ,phone_member = {0}phone_member"
                    + " ,email_member = {0}email_member"
                    + " ,photo_member = {0}photo_member"
                    + " ,parent_member = {0}parent_member"
                    + " ,cell_member = {0}cell_member"
                    + " ,type_member = {0}type_member"
                    + " ,comments_member = {0}comments_member"
                    + " ,emergencycontactName_member = {0}emergencycontactName_member"
                    + " ,emergencycontactPhone_member = {0}emergencycontactPhone_member"
                    + " ,emergencycontactRelationship_member = {0}emergencycontactRelationship_member"
                    + " where"
                    + " id_member = {0}id_member";

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
                Member objVO = (Member)obj;
                string query = "delete from member "
                    + " where"
                    + " id_member = {0}id_member";

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
                System.Collections.Generic.List<Member> res = new System.Collections.Generic.List<Member>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Member)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }

        public object doGetAll(DbCommand command, tMEMBER[] types)
        {
            try
            {
                string where = "1=0 ";
                foreach (tMEMBER type in types)
	            {
                    where += string.Format(" OR c.type_member = {0}{1}", this.PARAMETERPREFIX, Member.NameFromType(type));// + "type_member");
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, string.Format("{0}{1}", this.PARAMETERPREFIX, Member.NameFromType(type)), Member.NameFromType(type), command));
                }
                
                string query = getQuery(where);
                command.CommandText = query;
                
                DbDataReader reader = command.ExecuteReader();
                List<Member> res = (List<Member>)this.dataReaderToList(reader);
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
        public object doGetAll(DbCommand command, Member parent)
        {
            try
            {
                string where = " c.parent_member = " + this.PARAMETERPREFIX + "parent_member";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_member", parent.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Member> res = (List<Member>)this.dataReaderToList(reader);
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
        protected override void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction)
        {
            try
            {
                Member objVO = (Member)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "address_member", objVO.Address, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cell_member", objVO.Cell, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "city_member", objVO.City, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "dob_member", objVO.DateOfBirth, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "email_member", objVO.Email, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "firstName_member", objVO.FirstName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "lastName_member", objVO.LastName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "middleName_member", objVO.MiddleName, command));
                    if (objVO.Parent!=null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_member", objVO.Parent.ID, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "parent_member", Convert.DBNull, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "phone_member", objVO.Phone, command));

                    if (objVO.Photo != null)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        objVO.Photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "photo_member", ms.GetBuffer(), command));
                    }
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "photo_member", Convert.DBNull, command));
                
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "number_member", objVO.Number, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "state_member", objVO.State, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "type_member", Member.NameFromType(objVO.TypeOfMember), command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "zipcode_member", objVO.ZipCode, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "comments_member", objVO.Comments, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "emergencycontactName_member", objVO.EmergencyContactName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "emergencycontactPhone_member", objVO.EmergencyContactPhone, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "emergencycontactRelationship_member", objVO.EmergencyContactRelationship, command));
                    
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_member", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
