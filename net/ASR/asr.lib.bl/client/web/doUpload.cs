using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client.web
{
    public class doUpload : asr.lib.bl._template.generalActionBL
    {
        Client _client;
        public doUpload(Client client)
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

            //  Search for the ARecords
            asr.lib.dao.accountrecord.fachada accountFacade = new asr.lib.dao.accountrecord.fachada();
            foreach (vo.AccountRecord accountRecord in accountFacade.doGetAll(_client))
	        {
                if (accountRecord.ExternalId != null)
                    continue;

                //  Send data to server
                string postData =
                    string.Format("ent={0}&fn={1}&date={2}&description={3}&amount={4}&reference={5}&incoming={6}&activity={7}&client={8}&external={9}",
                    "accounting", "upload", accountRecord.Date, accountRecord.Activity.Description, accountRecord.Amount, accountRecord.Reference, accountRecord.Incoming, accountRecord.Activity.ID, accountRecord.Client.ID, accountRecord.ID);

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
                System.IO.StreamReader streamRead = new System.IO.StreamReader(streamResponse);
                Char[] readBuffer = new Char[256];
                int count = streamRead.Read(readBuffer, 0, 256);

                while (count > 0)
                {
                    // get string
                    String resultData = new String(readBuffer, 0, count);

                    // Write the data 
                    Console.WriteLine(resultData);

                    // Read from buffer
                    count = streamRead.Read(readBuffer, 0, 256);
                }

                streamRead.Close();
                streamResponse.Close();

                // Close response
                httpResponse.Close();
	        } 

            return _client;
        }
    }
}
