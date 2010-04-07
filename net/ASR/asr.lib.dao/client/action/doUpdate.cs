using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client.action
{
    class doUpdate : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Client _client = null;
        public doUpdate(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                _client = (Client)clientDAO.doUpdate(factory.Command, _client);

                employment.dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();
                customer.dao.customerDAO customerDAO = new asr.lib.dao.customer.dao.customerDAO();
                if ((_client.EmploymentHistory != null) && (_client.EmploymentHistory.Count > 0))
                {
                    List<Employment> oldEmploymentHistory = employmentDAO.doGetAll(factory.Command, _client);
                    if (oldEmploymentHistory.Count == 0)
                    {
                        foreach (Employment employment in _client.EmploymentHistory)
                        {
                            employment.Client = _client;

                            if (customerDAO.doGet(factory.Command, employment.Customer) == null)
                                employment.Customer.ID = (long)customerDAO.doAdd(factory.Command, employment.Customer);

                            employmentDAO.doAdd(factory.Command, employment);
                        }
                    }
                    else
                    {
                        oldEmploymentHistory.Sort();
                        foreach (Employment employment in _client.EmploymentHistory)
                        {
                            employment.Client = _client;

                            if (customerDAO.doGet(factory.Command, employment.Customer) == null)
                                employment.Customer.ID = (long)customerDAO.doAdd(factory.Command, employment.Customer);

                            int index = oldEmploymentHistory.BinarySearch(employment);
                            if (index > -1)
                            {
                                employmentDAO.doUpdate(factory.Command, employment);
                                oldEmploymentHistory.RemoveAt(index);
                            }
                            else
                                employmentDAO.doAdd(factory.Command, employment);
                        }
                        foreach (Employment employment in oldEmploymentHistory)
                            employmentDAO.doDelete(factory.Command, employment);
                    }
                }
                else
                {
                    employmentDAO.doDeleteAll(factory.Command, _client);
                }

                skillscore.dao.skillscoreDAO skillscoreDAO = new asr.lib.dao.skillscore.dao.skillscoreDAO();
                if ((_client.SkillScore != null) && (_client.SkillScore.Count > 0))
                {
                    List<SkillScore> oldSkillScore = skillscoreDAO.doGetAll(factory.Command, _client);
                    if (oldSkillScore.Count == 0)
                    {
                        foreach (SkillScore skillscore in _client.SkillScore)
                        {
                            skillscore.Client = _client;
                            skillscoreDAO.doAdd(factory.Command, skillscore);
                        }
                    }
                    else
                    {
                        oldSkillScore.Sort();
                        foreach (SkillScore skillscore in _client.SkillScore)
                        {
                            skillscore.Client = _client;
                            int index = oldSkillScore.BinarySearch(skillscore);
                            if (index > -1)
                            {
                                skillscoreDAO.doUpdate(factory.Command, skillscore);
                                oldSkillScore.RemoveAt(index);
                            }
                            else
                                skillscoreDAO.doAdd(factory.Command, skillscore);
                        }
                        foreach (SkillScore skillscore in oldSkillScore)
                            skillscoreDAO.doDelete(factory.Command, skillscore);
                    }
                }
                else
                {
                    skillscoreDAO.doDeleteAll(factory.Command, _client);
                }

                return _client;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
