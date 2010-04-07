using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolToSendEmails.smallmvc
{
    internal class customerDAO
    {
        public List<customerVO> GetAll()
        {
            System.Data.Common.DbProviderFactory factory = null;
            System.Data.Common.DbConnection connection = null;
            System.Data.Common.DbCommand command = null;

            try
            {
                List<customerVO> res = new List<customerVO>();

                System.Configuration.ConnectionStringSettings wholeConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ToolToSendEmails.Properties.Settings.mas90"];

                factory = System.Data.Common.DbProviderFactories.GetFactory(wholeConnectionString.ProviderName);
                connection = factory.CreateConnection();
                connection.ConnectionString = wholeConnectionString.ConnectionString;
                command = connection.CreateCommand();

                connection.Open();

                command.CommandText = "SELECT * FROM OPENQUERY(MAS90, 'SELECT * FROM AR1_CustomerMaster') AR1_CustomerMaster WHERE (EmailAddress <> '')";
                System.Data.Common.DbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customerVO customer = new customerVO();

                    if (!Convert.IsDBNull(reader["CustomerName"])) customer.Name = Convert.ToString(reader["CustomerName"]);
                    if (!Convert.IsDBNull(reader["EmailAddress"])) customer.Email = Convert.ToString(reader["EmailAddress"]);

                    res.Add(customer);
                }

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((connection != null) && (connection.State == System.Data.ConnectionState.Open)) connection.Close();
            }
        }
    }
}
