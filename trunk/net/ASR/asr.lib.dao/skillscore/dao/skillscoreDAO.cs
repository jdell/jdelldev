using System;
using System.Data.Common;
using asr.lib.dao._template;
using asr.lib.vo;
using System.Collections.Generic;

namespace asr.lib.dao.skillscore.dao
{	
	internal class skillscoreDAO:objectDAO
	{
        protected override string getQuery(string conditionWhere)
        {
            string query = "select * from skillscore c"
                + " INNER JOIN skill s ON c.id_skill = s.id_skill"
                + " INNER JOIN client cl ON c.id_client= cl.id_client";
            if (!String.IsNullOrEmpty(conditionWhere.Trim())) query += string.Format(" where {0}", conditionWhere);
            //query += " order by description_skillscore asc";
            
            return query;
        }

        protected override object dataReaderToObject(System.Data.Common.DbDataReader reader)
		{			
			try
			{
				SkillScore res = null;
				if (reader!=null)
				{
                    res = new SkillScore();
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

                    res.Score = SkillScore.TipoFromName(Convert.ToString(reader["score_skillscore"]));
                    res.Skill = new Skill();
                    res.Skill.ID = Convert.ToInt32(reader["id_skill"]);
                    res.Skill.Description = Convert.ToString(reader["description_skill"]);
                    res.ID = Convert.ToInt32(reader["id_skillscore"]);
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
                List<SkillScore> res = (List<SkillScore>)this.dataReaderToList(reader);
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
                SkillScore objVO = (SkillScore)obj;

                string where = " c.id_skillscore = " + this.PARAMETERPREFIX + "id_skillscore";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_skillscore", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                SkillScore res = null;
                if (reader.Read())
                    res = (SkillScore)this.dataReaderToObject(reader);
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
                SkillScore objVO = (SkillScore)obj;
                string where = " c.id_skillscore = " + this.PARAMETERPREFIX + "id_skillscore";
                string query = getQuery(where);

                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_skillscore", objVO.ID, command));

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
                SkillScore objVO = (SkillScore)obj;
                string query = "insert into skillscore "
                    + " (id_skill, id_client, score_skillscore)"
                    + " values "
                    + " ({0}id_skill, {0}id_client, {0}score_skillscore)";

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
                SkillScore objVO = (SkillScore)obj;
                string query = "update skillscore "
                    + "  set "
                    + " id_skill = {0}id_skill"
                    + ",id_client = {0}id_client"
                    + ",score_skillscore = {0}score_skillscore"
                    + " where"
                    + " id_skillscore = {0}id_skillscore";

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
                SkillScore objVO = (SkillScore)obj;
                string query = "delete from skillscore "
                    + " where"
                    + " id_skillscore = {0}id_skillscore";

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
                System.Collections.Generic.List<SkillScore> res = new System.Collections.Generic.List<SkillScore>();
                if (reader != null)
                {
                    while (reader.Read()) 
                        res.Add((SkillScore)dataReaderToObject(reader));
                    reader.Close();
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }	
        }


        public List<SkillScore> doGetAll(DbCommand command, Client obj)
        {
            try
            {
                Client objVO = (Client)obj;
                string where = " c.id_client = " + this.PARAMETERPREFIX + "id_client";
                string query = getQuery(where);
                command.CommandText = query;
                command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.ID, command));

                DbDataReader reader = command.ExecuteReader();
                List<SkillScore> res = (List<SkillScore>)this.dataReaderToList(reader);
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
                string query = "delete from skillscore "
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

        protected override void doSetParameter(ref DbCommand command, object obj, tDAOAction daoAction)
        {
            try
            {
                SkillScore objVO = (SkillScore)obj;

                if ((daoAction == tDAOAction.INSERT) || (daoAction == tDAOAction.UPDATE))
                {
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_skill", objVO.Skill.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_client", objVO.Client.ID, command));
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.String, "" + this.PARAMETERPREFIX + "score_skillscore", SkillScore.NameFromTipo(objVO.Score), command));
                  
                    if (daoAction== tDAOAction.INSERT)
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id", command));
                    else
                        command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_skillscore", objVO.ID, command));
                }
                else
                    command.Parameters.Add(this.CreateParameter(System.Data.DbType.Int32, "" + this.PARAMETERPREFIX + "id_skillscore", objVO.ID, command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
