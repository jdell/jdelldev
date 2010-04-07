using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Security.Cryptography;

namespace tool.amazon.LowestPrice.common
{
    abstract class sign
    {
        #region SignIn
        public static string getSignedUrl(string keyWords, string merchantId)
        {
            return getSignedUrl(keyWords, merchantId, 0);
        }
        public static string getSignedUrl(string keyWords, string MerchantId, int page)
        {
            string accessKeyId = Properties.Settings.Default.AWSAccessKeyId;
            string merchantId = MerchantId;//Properties.Settings.Default.MerchantId;
            string operation = Properties.Settings.Default.Operation;
            string responseGroup = Properties.Settings.Default.ResponseGroup;
            string searchIndex = Properties.Settings.Default.SearchIndex;
            string secretKey = Properties.Settings.Default.SecretKey;
            string service = Properties.Settings.Default.Service;
            string sort = Properties.Settings.Default.Sort;
            string url = Properties.Settings.Default.URL;
            string version = Properties.Settings.Default.Version;
            string timeStamp = DateTime.Now.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

            SortedDictionary<string, string> parameters = new SortedDictionary<string, string>();

            parameters.Add("AWSAccessKeyId", accessKeyId);
            parameters.Add("MerchantId", merchantId);
            parameters.Add("Operation", operation);
            parameters.Add("ResponseGroup", responseGroup);
            parameters.Add("SearchIndex", searchIndex);
            parameters.Add("Service", service);
            parameters.Add("Keywords", keyWords);
            parameters.Add("Version", version);
            parameters.Add("Timestamp", timeStamp);
            if (page > 0) parameters.Add("ItemPage", page.ToString());

            // Build Signature without "awsSignature" oarameter first!
            string signature = BuildSignature(secretKey, parameters);

            // Add back to the uri
            parameters.Add("Signature", signature);

            return ConstructSignedURL(url, parameters);
        }

        public static string ConstructSignedURL(string url, SortedDictionary<string, string> parameters)
        {
            StringBuilder signedUrl = new StringBuilder();

            signedUrl.AppendFormat("{0}", url);
            bool first = true;
            foreach (KeyValuePair<string, string> var in parameters)
            {
                signedUrl.AppendFormat("{2}{0}={1}", var.Key, var.Key=="Keywords"?var.Value.Replace(" ", "%20"):PrepareUrlEncode(var.Value), (first ? "?" : "&"));
                first = false;
            }

            return signedUrl.ToString();
        }

        private static string PrepareUrlEncode(string val)
        {
            if (HttpUtility.UrlEncode(val).IndexOf('%') != -1)
            {
                String[] strs = HttpUtility.UrlEncode(val.Trim()).Split(new char[] { '%' });
                StringBuilder retEncodedVAl = new StringBuilder(strs[0]);
                for (int k = 1; k < strs.Length; k++)
                {
                    retEncodedVAl.Append('%');
                    retEncodedVAl.Append(strs[k].Substring(0, 2).ToUpper() + strs[k].Substring(2, strs[k].Length - 2)); // ASCII Key A, B, C, D, E, F to upper case
                }

                return retEncodedVAl.ToString();
            }
            else
            {
                return HttpUtility.UrlEncode(val.Trim());
            }
        }

        private static string BuildSignature(string secretKey, SortedDictionary<string, string> parameters)
        {            
            string sortedParams =
                "GET\n" +
                "webservices.amazon.com\n" +
                "/onca/xml\n";
            bool first = true;
            foreach (KeyValuePair<string, string> var in parameters)
            {
                sortedParams += String.Format("{2}{0}={1}", var.Key.Trim(), var.Key == "Keywords" ? var.Value.Replace(" ", "%20") : PrepareUrlEncode(var.Value), (first ? "" : "&")).Trim();
                first = false;
            }
            
            return CalculateHMAC(secretKey, sortedParams.ToString());
        }

        internal static string CalculateHMAC(String secretKey, String parametersToHash)
        {
            UTF8Encoding ae = new UTF8Encoding();
            HMACSHA256 signature = new HMACSHA256(ae.GetBytes(secretKey));
            return Convert.ToBase64String(signature.ComputeHash(ae.GetBytes(parametersToHash.ToCharArray())));
        }
        #endregion
    }
}
