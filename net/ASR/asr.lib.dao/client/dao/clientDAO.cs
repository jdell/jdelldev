using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.client.dao
{	
	internal class clientDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from client c";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by lastName_client, firstName_client asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Client res = null;
				if (reader!=null)
				{
                    res = new Client();
                    res.AdditionalContactPhone = Convert.ToString(reader["additionalContactPhone_client"]);
                    res.CellPhoneNumber = Convert.ToString(reader["cellPhoneNumber_client"]);
                    res.Comments = Convert.ToString(reader["comments_client"]);
                    res.EmailAddress = Convert.ToString(reader["emailAddress_client"]);
                    res.EmergencyContact = Convert.ToString(reader["emergencyContact_client"]);
                    res.FirstName = Convert.ToString(reader["firstName_client"]);
                    res.HomeAddress = Convert.ToString(reader["homeAddress_client"]);
                    res.HomeCity = Convert.ToString(reader["homeCity_client"]);
                    res.HomePhoneNumber = Convert.ToString(reader["homePhoneNumber_client"]);
                    res.HomeState = Convert.ToString(reader["homeState_client"]);
                    res.HomeZipCode = Convert.ToString(reader["homeZipCode_client"]);
                    res.ID = Convert.ToInt32(reader["id_client"]);
                    res.Inactive = Convert.ToBoolean(reader["inactive_client"]);
                    res.LastName = Convert.ToString(reader["lastName_client"]);
                    res.MailingAddress = Convert.ToString(reader["mailingAddress_client"]);
                    res.MailingCity = Convert.ToString(reader["mailingCity_client"]);
                    res.MailingState = Convert.ToString(reader["mailingState_client"]);
                    res.MailingZipCode = Convert.ToString(reader["mailingZipCode_client"]);
                    res.MiddleName= Convert.ToString(reader["middleName_client"]);
                    res.PreferredFirstName = Convert.ToString(reader["preferredFirstName_client"]);
                    res.SSN= Convert.ToString(reader["ssn_client"]);
                    if (!Convert.IsDBNull(reader["dateOfBirth_client"]))
                        res.DateOfBirth = Convert.ToDateTime(reader["dateOfBirth_client"]);
                    else
                        res.DateOfBirth = common.constantes.vacio.FECHA;
                    if (!Convert.IsDBNull(reader["creditScore_client"]))
                        res.CreditScore = Convert.ToSingle(reader["creditScore_client"]);
                    if (!Convert.IsDBNull(reader["companyName_client"]))
                        res.CompanyName= Convert.ToString(reader["companyName_client"]);
                    if (!Convert.IsDBNull(reader["photo_client"]))
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["photo_client"]);
                        if (ms.Length > 0) res.Photo = System.Drawing.Image.FromStream(ms);
                    }

                    if (!Convert.IsDBNull(reader["external_client"]))
                        res.ExternalId = Convert.ToInt32(reader["external_client"]);
                    if (!Convert.IsDBNull(reader["username_client"]))
                        res.UserName = Convert.ToString(reader["username_client"]);
                    if (!Convert.IsDBNull(reader["password_client"]))
                        res.Password = Convert.ToString(reader["password_client"]);
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
                List<Client> res = (List<Client>)this.dataReaderToList(reader);
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


        public object doGetAllAccountRecord(DbCommand command)
        {
            try
            {
                string where = " (select count(*) from accountrecord ac where ac.id_client = c.id_client)>0";
                string query = getQuery(where);
                command.CommandText = query;
                
                DbDataReader reader = command.ExecuteReader();
                List<Client> res = (List<Client>)this.dataReaderToList(reader);
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

        public object doGetAllCreditRepair(DbCommand command)
        {
            try
            {
                string where = " c.creditScore_client <> " + this.PARAMETERPREFIX + "creditScore_client";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "creditScore_client", 0, command));

                DbDataReader reader = command.ExecuteReader();
                List<Client> res = (List<Client>)this.dataReaderToList(reader);
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
                Client objVO = (Client)obj;

                string where = " c.id_client = " + this.PARAMETERPREFIX + "id_client";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Client res = null;
                if (reader.Read())
                    res = (Client)this.dataReaderToObject(reader);
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
                Client objVO = (Client)obj;
                string where = " c.id_client = " + this.PARAMETERPREFIX + "id_client";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));

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
                Client objVO = (Client)obj;
                string query = "insert into client "
                    + " (external_client, userName_client, password_client, dateOfBirth_client, firstName_client, lastName_client, middleName_client, homeAddress_client, homeCity_client, homeState_client, homeZipCode_client, preferredFirstName_client, ssn_client, mailingAddress_client, mailingCity_client, mailingState_client, mailingZipCode_client, homePhoneNumber_client, cellPhoneNumber_client, additionalContactPhone_client, emailAddress_client, emergencyContact_client, inactive_client, comments_client, creditScore_client, companyName_client, photo_client)"
                    + " values "
                    + " ({0}external_client, {0}userName_client, {0}password_client, {0}dateOfBirth_client, {0}firstName_client, {0}lastName_client, {0}middleName_client, {0}homeAddress_client, {0}homeCity_client, {0}homeState_client, {0}homeZipCode_client, {0}preferredFirstName_client, {0}ssn_client, {0}mailingAddress_client, {0}mailingCity_client, {0}mailingState_client, {0}mailingZipCode_client, {0}homePhoneNumber_client, {0}cellPhoneNumber_client, {0}additionalContactPhone_client, {0}emailAddress_client, {0}emergencyContact_client, {0}inactive_client, {0}comments_client, {0}creditScore_client, {0}companyName_client, {0}photo_client)";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                doSetParameter(ref command, obj, tDAOAction.INSERT);
            
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
                Client objVO = (Client)obj;
                string query = "update client "
                    + "  set "
                    + "  firstName_client = {0}firstName_client"
                    + " ,lastName_client = {0}lastName_client"
                    + " ,middleName_client = {0}middleName_client"
                    + " ,homeAddress_client = {0}homeAddress_client"
                    + " ,homeCity_client = {0}homeCity_client"
                    + " ,homeState_client = {0}homeState_client"
                    + " ,homeZipCode_client = {0}homeZipCode_client"
                    + " ,preferredFirstName_client = {0}preferredFirstName_client"
                    + " ,ssn_client = {0}ssn_client"
                    + " ,mailingAddress_client = {0}mailingAddress_client"
                    + " ,mailingCity_client = {0}mailingCity_client"
                    + " ,mailingState_client = {0}mailingState_client"
                    + " ,mailingZipCode_client = {0}mailingZipCode_client"
                    + " ,homePhoneNumber_client = {0}homePhoneNumber_client"
                    + " ,cellPhoneNumber_client = {0}cellPhoneNumber_client"
                    + " ,additionalContactPhone_client = {0}additionalContactPhone_client"
                    + " ,emailAddress_client = {0}emailAddress_client"
                    + " ,emergencyContact_client = {0}emergencyContact_client"
                    + " ,inactive_client = {0}inactive_client"
                    + " ,comments_client = {0}comments_client"
                    + " ,creditScore_client = {0}creditScore_client"
                    + " ,companyName_client = {0}companyName_client"
                    + " ,photo_client = {0}photo_client"
                    + " ,dateOfBirth_client = {0}dateOfBirth_client"
                    + " ,external_client = {0}external_client"
                    + " ,userName_client = {0}userName_client"
                    + " ,password_client = {0}password_client"
                    + " where"
                    + " id_client = {0}id_client";

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
                Client objVO = (Client)obj;
                string query = "delete from client "
                    + " where"
                    + " id_client = {0}id_client";

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
                System.Collections.Generic.List<Client> res = new System.Collections.Generic.List<Client>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Client)dataReaderToObject(reader));
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
                Client objVO = (Client)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "firstName_client", objVO.FirstName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "lastName_client", objVO.LastName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "middleName_client", objVO.MiddleName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "homeAddress_client", objVO.HomeAddress, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "homeCity_client", objVO.HomeCity, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "homeState_client", objVO.HomeState, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "homeZipCode_client", objVO.HomeZipCode, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "preferredFirstName_client", objVO.PreferredFirstName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "ssn_client", objVO.SSN, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mailingAddress_client", objVO.MailingAddress, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mailingCity_client", objVO.MailingCity, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mailingState_client", objVO.MailingState, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "mailingZipCode_client", objVO.MailingZipCode, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "homePhoneNumber_client", objVO.HomePhoneNumber, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "cellPhoneNumber_client", objVO.CellPhoneNumber, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "additionalContactPhone_client", objVO.AdditionalContactPhone, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "emailAddress_client", objVO.EmailAddress, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "emergencyContact_client", objVO.EmergencyContact, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "inactive_client", objVO.Inactive, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "comments_client", objVO.Comments, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "creditScore_client", objVO.CreditScore, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "companyName_client", objVO.CompanyName, command));

                    if (objVO.Photo != null)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        objVO.Photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "photo_client", ms.GetBuffer(), command));
                    }
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Binary, "" + this.PARAMETERPREFIX + "photo_client", Convert.DBNull, command));
                

                    if (objVO.DateOfBirth!= DateTime.MinValue)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "dateOfBirth_client", objVO.DateOfBirth, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "dateOfBirth_client", Convert.DBNull, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "userName_client", objVO.UserName, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "password_client", objVO.Password, command));

                    if (objVO.ExternalId != null)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_client", objVO.ExternalId, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "external_client", Convert.DBNull, command));
             

                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
