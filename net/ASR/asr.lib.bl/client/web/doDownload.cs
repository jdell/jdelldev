using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client.web
{
    public class doDownload : asr.lib.bl._template.generalActionBL
    {
        Client _client;
        public doDownload(Client client)
        {
            _client = client;
        }
        new public Client execute()
        {
            return (Client)base.execute();
        }
        protected override object accion()
        {
            if (_client == null)
                throw new _exceptions.common.NullReferenceException(typeof(Client), this.GetType().Name);

            //  Send data to server
            string postData =
                string.Format("ent={0}&fn={1}&client={2}",
                "accounting", "download", _client.ID);

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] buffer = encoding.GetBytes(postData);

            System.Net.HttpWebRequest httpRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(_common.cache.UrlASRBridge);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/x-www-form-urlencoded";
            httpRequest.ContentLength = buffer.Length;

            // Get request stream
            System.IO.Stream newStream = httpRequest.GetRequestStream();

            // Send the data.
            newStream.Write(buffer, 0, buffer.Length);

            // Close stream
            newStream.Close();

            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            System.Net.HttpWebResponse httpResponse = (System.Net.HttpWebResponse)httpRequest.GetResponse();

            System.IO.Stream streamResponse = httpResponse.GetResponseStream();


            /*** Beg-Test ***/
            //System.IO.StreamReader streamRead = new System.IO.StreamReader(streamResponse);
            //Char[] readBuffer = new Char[256];
            //int count = streamRead.Read(readBuffer, 0, 256);

            //while (count > 0)
            //{
            //    // get string
            //    String resultData = new String(readBuffer, 0, count);

            //    // Write the data 
            //    Console.WriteLine(resultData);

            //    // Read from buffer
            //    count = streamRead.Read(readBuffer, 0, 256);
            //}
   
            //streamRead.Close();            
            /*** End-Test ***/
            //  Search for the ARecords
            asr.lib.dao.accountrecord.fachada accountFacade = new asr.lib.dao.accountrecord.fachada();
            asr.lib.dao.activity.fachada activityFacade = new asr.lib.dao.activity.fachada();
         
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(streamResponse);
            string uri = xmlDoc.BaseURI;

            System.Xml.XmlNodeList nodeList = xmlDoc.GetElementsByTagName("accountingrecord",uri);
            foreach (System.Xml.XmlNode node in nodeList)
            {
                AccountRecord accountrecord = new AccountRecord();
                accountrecord.Date = Convert.ToDateTime(node["date_accountrecord", uri].InnerText);
                accountrecord.Description = Convert.ToString(node["description_accountrecord", uri].InnerText);
                accountrecord.Amount = Convert.ToSingle(node["amount_accountrecord", uri].InnerText);
                accountrecord.Reference = Convert.ToString(node["reference_accountrecord", uri].InnerText);
                accountrecord.Incoming = Convert.ToBoolean(node["incoming_accountrecord", uri].InnerText=="1"?"True":"False");
                accountrecord.Activity = new Activity();
                accountrecord.Activity.ExternalId= Convert.ToInt32(node["id_activity", uri].InnerText);
                accountrecord.Client = _client;
                accountrecord.ExternalId = Convert.ToInt32(node["id_accountrecord", uri].InnerText);

                //Beg-Lookfor Activity
                Activity tmpActivity = activityFacade.doGetByExternalId(accountrecord.Activity);
                if (tmpActivity == null)
                {
                    accountrecord.Activity.Client = _client;
                    accountrecord.Activity.Description = accountrecord.Description;
                    tmpActivity = activityFacade.doGetByDescriptionAndClient(accountrecord.Activity);

                    if (tmpActivity == null)
                    {
                        accountrecord.Activity.Description = accountrecord.Description;
                        accountrecord.Activity.Income = accountrecord.Incoming;

                        tmpActivity = activityFacade.doAdd(accountrecord.Activity);
                    }
                    else
                    {
                        tmpActivity.Description = accountrecord.Description;
                        tmpActivity.Income = accountrecord.Incoming;

                        activityFacade.doUpdate(tmpActivity);
                    }
                }
                else
                {
                    tmpActivity.Description = accountrecord.Description;
                    tmpActivity.Income = accountrecord.Incoming;

                    activityFacade.doUpdate(tmpActivity);
                }
                accountrecord.Activity = tmpActivity;
                //End-Lookfor Activity

                AccountRecord tmpAccountRecord = accountFacade.doGetByExternalId(accountrecord);
                if (tmpAccountRecord == null)
                {
                    //Insert
                    accountFacade.doAdd(accountrecord);
                }
                else
                {
                    //Update
                    tmpAccountRecord.Activity = accountrecord.Activity;
                    tmpAccountRecord.Amount = accountrecord.Amount;
                    tmpAccountRecord.Client = accountrecord.Client;
                    tmpAccountRecord.Date= accountrecord.Date;
                    tmpAccountRecord.Description = accountrecord.Description;
                    tmpAccountRecord.Incoming = accountrecord.Incoming;
                    tmpAccountRecord.Reference = accountrecord.Reference;

                    accountFacade.doUpdate(tmpAccountRecord);
                }

            }

            streamResponse.Close();
            // Close response
            httpResponse.Close();

            return _client;
        }
    }
}
