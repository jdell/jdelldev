using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.employment.dao
{	
	internal class employmentDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from employment c"
                + " INNER JOIN client cl ON c.id_client= cl.id_client"
                + " LEFT JOIN customer cust ON c.id_customer=cust.id_customer"; 
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            query += " order by startDate_employment asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				Employment res = null;
				if (reader!=null)
				{
                    res = new Employment();
                    res.AdditionalCompensation = Convert.ToString(reader["AdditionalCompensation_employment"]);
                    res.BaseSalary = Convert.ToSingle(reader["BaseSalary_employment"]);
                    res.Bonus = Convert.ToSingle(reader["Bonus_employment"]);
                    
                    res.Client = new Client();
                    res.Client.ID = Convert.ToInt32(reader["id_client"]);
                    res.Client.AdditionalContactPhone = Convert.ToString(reader["additionalContactPhone_client"]);
                    res.Client.CellPhoneNumber = Convert.ToString(reader["cellPhoneNumber_client"]);
                    res.Client.Comments = Convert.ToString(reader["comments_client"]);
                    res.Client.EmailAddress = Convert.ToString(reader["emailAddress_client"]);
                    res.Client.EmergencyContact = Convert.ToString(reader["emergencyContact_client"]);
                    res.Client.FirstName = Convert.ToString(reader["firstName_client"]);
                    res.Client.HomeAddress = Convert.ToString(reader["homeAddress_client"]);
                    res.Client.HomeCity = Convert.ToString(reader["homeCity_client"]);
                    res.Client.HomePhoneNumber = Convert.ToString(reader["homePhoneNumber_client"]);
                    res.Client.HomeState = Convert.ToString(reader["homeState_client"]);
                    res.Client.HomeZipCode = Convert.ToString(reader["homeZipCode_client"]);
                    res.Client.ID = Convert.ToInt32(reader["id_client"]);
                    if (!Convert.IsDBNull(reader["inactive_client"])) res.Client.Inactive = Convert.ToBoolean(reader["inactive_client"]);
                    res.Client.LastName = Convert.ToString(reader["lastName_client"]);
                    res.Client.MailingAddress = Convert.ToString(reader["mailingAddress_client"]);
                    res.Client.MailingCity = Convert.ToString(reader["mailingCity_client"]);
                    res.Client.MailingState = Convert.ToString(reader["mailingState_client"]);
                    res.Client.MailingZipCode = Convert.ToString(reader["mailingZipCode_client"]);
                    res.Client.MiddleName = Convert.ToString(reader["middleName_client"]);
                    res.Client.PreferredFirstName = Convert.ToString(reader["preferredFirstName_client"]);
                    res.Client.SSN = Convert.ToString(reader["ssn_client"]);
                    if (!Convert.IsDBNull(reader["dateOfBirth_client"]))
                        res.Client.DateOfBirth = Convert.ToDateTime(reader["dateOfBirth_client"]);
                    if (!Convert.IsDBNull(reader["creditScore_client"]))
                        res.Client.CreditScore = Convert.ToSingle(reader["creditScore_client"]);
                    if (!Convert.IsDBNull(reader["companyName_client"]))
                        res.Client.CompanyName = Convert.ToString(reader["companyName_client"]);
                    if (!Convert.IsDBNull(reader["photo_client"]))
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])reader["photo_client"]);
                        if (ms.Length > 0) res.Client.Photo = System.Drawing.Image.FromStream(ms);
                    }


                    res.ContactTitle = Convert.ToString(reader["ContactTitle_employment"]);

                    res.Customer = new Customer();
                    res.Customer.ID = Convert.ToInt32(reader["id_customer"]);
                    res.Customer.Address= Convert.ToString(reader["address_customer"]);
                    res.Customer.Name = Convert.ToString(reader["name_customer"]);
                    res.Customer.Phone= Convert.ToString(reader["phone_customer"]);
                    res.Customer.State= Convert.ToString(reader["state_customer"]);
                    res.Customer.ZipCode= Convert.ToString(reader["zipCode_customer"]);
                    res.Customer.Fax= Convert.ToString(reader["fax_customer"]);

                    if (!Convert.IsDBNull(reader["EndDate_employment"]))
                        res.EndDate = Convert.ToDateTime(reader["EndDate_employment"]);
                    else
                        res.EndDate = lib.common.constantes.vacio.FECHA;

                    if (!Convert.IsDBNull(reader["EndPay_employment"]))
                        res.EndPay = Convert.ToDateTime(reader["EndPay_employment"]);
                    else
                        res.EndPay = lib.common.constantes.vacio.FECHA;

                    res.Gap = Convert.ToString(reader["Gap_employment"]);
                    res.ID = Convert.ToInt32(reader["id_employment"]);
                    res.MayContact = Convert.ToBoolean(reader["MayContact_employment"]);
                    res.PhoneNumber = Convert.ToString(reader["PhoneNumber_employment"]);
                    res.PositionHeld = Convert.ToString(reader["PositionHeld_employment"]);
                    res.PrimaryResponsibilities = Convert.ToString(reader["PrimaryResponsibilities_employment"]);
                    res.ProvideNotice = Convert.ToBoolean(reader["ProvideNotice_employment"]);
                    res.ReasonForLeaving = Convert.ToString(reader["ReasonForLeaving_employment"]);
                    res.ReasonIfNot = Convert.ToString(reader["ReasonIfNot_employment"]);
                    res.RelationShip = Convert.ToString(reader["RelationShip_employment"]);
                    if (!Convert.IsDBNull(reader["StartDate_employment"]))
                        res.StartDate = Convert.ToDateTime(reader["StartDate_employment"]);
                    else
                        res.StartDate = lib.common.constantes.vacio.FECHA;
                    if (!Convert.IsDBNull(reader["StartPay_employment"]))
                        res.StartPay = Convert.ToDateTime(reader["StartPay_employment"]);
                    else
                        res.StartPay = lib.common.constantes.vacio.FECHA;

                    if (!Convert.IsDBNull(reader["turn_employment"])) res.Shift = Employment.TipoFromName(Convert.ToString(reader["turn_employment"]));
                   
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
                List<Employment> res = (List<Employment>)this.dataReaderToList(reader);
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
                Employment objVO = (Employment)obj;

                string where = " c.id_employment = " + this.PARAMETERPREFIX + "id_employment";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_employment", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                Employment res = null;
                if (reader.Read())
                    res = (Employment)this.dataReaderToObject(reader);
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
                Employment objVO = (Employment)obj;
                string where = " c.id_employment = " + this.PARAMETERPREFIX + "id_employment";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_employment", objVO.ID, command));

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
                Employment objVO = (Employment)obj;
                string query = "insert into employment "
                    + " (turn_employment, id_customer, id_client, startDate_employment, endDate_employment, startPay_employment, endPay_employment, baseSalary_employment, bonus_employment, additionalCompensation_employment, positionHeld_employment, primaryResponsibilities_employment, reasonForLeaving_employment, provideNotice_employment, contactTitle_employment, phoneNumber_employment, relationShip_employment, mayContact_employment, reasonIfNot_employment, gap_employment)"
                    + " values "
                    + " ({0}turn_employment, {0}id_customer, {0}id_client, {0}startDate_employment, {0}endDate_employment, {0}startPay_employment, {0}endPay_employment, {0}baseSalary_employment, {0}bonus_employment, {0}additionalCompensation_employment, {0}positionHeld_employment, {0}primaryResponsibilities_employment, {0}reasonForLeaving_employment, {0}provideNotice_employment, {0}contactTitle_employment, {0}phoneNumber_employment, {0}relationShip_employment, {0}mayContact_employment, {0}reasonIfNot_employment, {0}gap_employment)";

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
                Employment objVO = (Employment)obj;
                string query = "update employment "
                    + "  set "
                    + "  id_customer = {0}id_customer"
                    + " ,id_client = {0}id_client"
                    + " ,startDate_employment = {0}startDate_employment"
                    + " ,endDate_employment = {0}endDate_employment"
                    + " ,startPay_employment = {0}startPay_employment"
                    + " ,endPay_employment = {0}endPay_employment"
                    + " ,baseSalary_employment = {0}baseSalary_employment"
                    + " ,bonus_employment = {0}bonus_employment"
                    + " ,additionalCompensation_employment = {0}additionalCompensation_employment"
                    + " ,positionHeld_employment = {0}positionHeld_employment"
                    + " ,primaryResponsibilities_employment = {0}primaryResponsibilities_employment"
                    + " ,reasonForLeaving_employment = {0}reasonForLeaving_employment"
                    + " ,provideNotice_employment = {0}provideNotice_employment"
                    + " ,contactTitle_employment = {0}contactTitle_employment"
                    + " ,phoneNumber_employment = {0}phoneNumber_employment"
                    + " ,relationShip_employment = {0}relationShip_employment"
                    + " ,mayContact_employment = {0}mayContact_employment"
                    + " ,reasonIfNot_employment = {0}reasonIfNot_employment"
                    + " ,gap_employment = {0}gap_employment"
                    + " ,turn_employment = {0}turn_employment"
                    + " where"
                    + " id_employment = {0}id_employment";

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
                Employment objVO = (Employment)obj;
                string query = "delete from employment "
                    + " where"
                    + " id_employment = {0}id_employment";

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

        public List<Employment> doGetAll(DbCommand command, Client obj)
        {
            try
            {
                Client objVO = (Client)obj;

                string where = " c.id_client = " + this.PARAMETERPREFIX + "id_client";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Employment> res = (List<Employment>)this.dataReaderToList(reader);
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

        public List<Employment> doGetAll(DbCommand command, Customer obj)
        {
            try
            {
                Customer objVO = (Customer)obj;

                string where = " c.id_customer = " + this.PARAMETERPREFIX + "id_customer";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<Employment> res = (List<Employment>)this.dataReaderToList(reader);
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

        public object doDeleteAll(DbCommand command, Client obj)
        {
            try
            {
                Client objVO = (Client)obj;
                string query = "delete from employment "
                    + " where"
                    + " id_client = {0}id_client";

                command.CommandText = string.Format(query, this.PARAMETERPREFIX);
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));
    
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
                System.Collections.Generic.List<Employment> res = new System.Collections.Generic.List<Employment>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((Employment)dataReaderToObject(reader));
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
                Employment objVO = (Employment)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_customer", objVO.Customer.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "startDate_employment", objVO.StartDate, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "startPay_employment", objVO.StartPay, command));                    
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "baseSalary_employment", objVO.BaseSalary, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Single, "" + this.PARAMETERPREFIX + "bonus_employment", objVO.Bonus, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "additionalCompensation_employment", objVO.AdditionalCompensation, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "positionHeld_employment", objVO.PositionHeld, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "primaryResponsibilities_employment", objVO.PrimaryResponsibilities, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "reasonForLeaving_employment", objVO.ReasonForLeaving, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "provideNotice_employment", objVO.ProvideNotice, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "contactTitle_employment", objVO.ContactTitle, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "phoneNumber_employment", objVO.PhoneNumber, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "relationShip_employment", objVO.RelationShip, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Boolean, "" + this.PARAMETERPREFIX + "mayContact_employment", objVO.MayContact, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "reasonIfNot_employment", objVO.ReasonIfNot, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "gap_employment", objVO.Gap, command));

                    if (objVO.EndDate != DateTime.MinValue)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "endDate_employment", objVO.EndDate, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "endDate_employment", Convert.DBNull, command));

                    if (objVO.EndPay != DateTime.MinValue)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "endPay_employment", objVO.EndPay, command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Date, "" + this.PARAMETERPREFIX + "endPay_employment", Convert.DBNull, command));

                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "turn_employment", Employment.NameFromTipo(objVO.Shift), command));

                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_employment", objVO.ID, command));
                
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_employment", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
