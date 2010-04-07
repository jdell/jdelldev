using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.dao.client.action
{
    class doAdd : asr.lib.dao._common.plain.TransactionalPlainAction
    {

        Client _client = null;
        public doAdd(Client client)
        {
            _client = client;
        }

        #region PlainAction Members

        public object execute(asr.lib.dao._common.DAOFactory factory)
        {
            try
            {
                dao.clientDAO clientDAO = new asr.lib.dao.client.dao.clientDAO();
                _client.ID = Convert.ToInt32(clientDAO.doAdd(factory.Command, _client));

                if ((_client.EmploymentHistory != null) && (_client.EmploymentHistory.Count>0))
                {
                    employment.dao.employmentDAO employmentDAO = new asr.lib.dao.employment.dao.employmentDAO();
                    customer.dao.customerDAO customerDAO = new asr.lib.dao.customer.dao.customerDAO();
                    foreach (Employment employment in _client.EmploymentHistory)
                    {
                        employment.Client = _client;

                        if (customerDAO.doGet(factory.Command, employment.Customer) == null)
                            employment.Customer.ID = (long)customerDAO.doAdd(factory.Command, employment.Customer);

                        employmentDAO.doAdd(factory.Command, employment);
                    }
                }

                if ((_client.SkillScore != null) && (_client.SkillScore.Count > 0))
                {
                    skillscore.dao.skillscoreDAO skillscoreDAO = new asr.lib.dao.skillscore.dao.skillscoreDAO();
                    foreach (SkillScore skillscore in _client.SkillScore)
                    {
                        skillscore.Client = _client;
                        skillscoreDAO.doAdd(factory.Command, skillscore);
                    }
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
