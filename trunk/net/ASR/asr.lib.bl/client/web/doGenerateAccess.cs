using System;
using System.Collections.Generic;
using System.Text;
using asr.lib.vo;

namespace asr.lib.bl.client.web
{
    public class doGenerateAccess : asr.lib.bl._template.generalActionBL
    {
        Client _client;
        public doGenerateAccess(Client client)
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

            //  Create Login and Pass
            _client.UserName = _client.FirstName.ToLower() + _client.ID.ToString();
            _client.Password = common.funciones.crypt.MD5(_client.ID.ToString());

            //  Update Client
            asr.lib.dao.client.fachada clientFacade = new asr.lib.dao.client.fachada();
            _client = clientFacade.doUpdateWebAccess(_client);

            //  Send data to server
            string postData =
                string.Format("ent={0}&fn={1}&firstName={2}&lastName={3}&middleName={4}&emailAddress={5}&inactive={6}&comments={7}&dob={8}&company={9}&username={10}&password={11}&external={12}",
                "client", "upload", _client.FirstName, _client.LastName, _client.MiddleName, _client.EmailAddress, _client.Inactive, _client.Comments, common.constantes.vacio.IsEmpty(_client.DateOfBirth) ? "null" : _client.DateOfBirth.ToString(), _client.CompanyName, _client.UserName, _client.Password, _client.ID);

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
            /*
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
            */
            return _client;
        }
    }
}
