using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace tool.amazon.LowestPrice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                this.dgResults.DataSource = getData(this.txtKeywords.Text, this.txtMarketPlaceID.Text);
                chkLowestPrice_CheckedChanged(null, null);

                if ((this.dgResults.DataSource!=null) && (!dgResults.Columns.Contains("Link")))
                {
                    DataGridViewLinkColumn dc = new DataGridViewLinkColumn();
                    dc.DataPropertyName = "UrlLink";
                    dc.Name = "Link";
                    dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgResults.Columns.Add(dc);

                    this.dgResults.Columns["UrlLink"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        DataView getData(string keyWords, string merchantId)
        {
            DataView res = null;

            string signedUrl = common.sign.getSignedUrl(keyWords, merchantId);
            XElement elements = getXElements(sendRequest(signedUrl));

            int totalPages = getTotalPages(elements);    
            if (totalPages > 0)
            {
                DataTable dt = new DataTable();
                setColumns(dt);

                foreach (Item item in getItems(elements, merchantId)) addItem(dt, item);

                for (int i = 2; i <= totalPages; i++)
                {
                    signedUrl = common.sign.getSignedUrl(keyWords, merchantId, i);
                    elements = getXElements(sendRequest(signedUrl));

                    foreach (Item item in getItems(elements, merchantId)) addItem(dt, item);
                }
                res = new DataView(dt);
            }
            
            
            return res;
        }

        void setColumns(DataTable dt)
        {
            foreach (System.Reflection.PropertyInfo property in typeof(Item).GetProperties())
                dt.Columns.Add(property.Name, property.PropertyType);
        }
        void addItem(DataTable dt, Item item)
        {
            DataRow dr = dt.NewRow();
            foreach (System.Reflection.PropertyInfo property in typeof(Item).GetProperties())
                dr[property.Name] = property.GetValue(item, null);
            dt.Rows.Add(dr);
        }

        Int32 getTotalPages(XElement elements)
        {
            string nameSpace = elements.Name.Namespace.ToString();
            IEnumerable<XElement> totalPages = from ele in elements.Elements(getXName(nameSpace, "Items"))
                                               select ele.Element(getXName(nameSpace, "TotalPages"));

            return Convert.ToInt32(totalPages.FirstOrDefault().Value);
        }

        List<Item> getItems(XElement elements, string MerchanId)
        {
            List<Item> res = new List<Item>();

            string merchantId = MerchanId;//Properties.Settings.Default.MerchantId;

            string nameSpace = elements.Name.Namespace.ToString();
            IEnumerable<XElement> items = elements.Elements(getXName(nameSpace, "Items")).Elements(getXName(nameSpace, "Item"));

            foreach (XElement xitem in items)
            {
                if (xitem.HasElements)
                {
                    Item item = new Item();
                    item.ASIN = xitem.Element(getXName(nameSpace, "ASIN")).Value;
                    item.UrlLink = xitem.Element(getXName(nameSpace, "DetailPageURL")).Value;

                    Single tempPrice = 0;
                    Single.TryParse(xitem.Element(getXName(nameSpace, "OfferSummary"))
                        .Element(getXName(nameSpace, "LowestNewPrice"))
                        .Element(getXName(nameSpace, "FormattedPrice")).Value.Replace("$","")
                        , out tempPrice);
                    item.LowestPrice = tempPrice;

                    IEnumerable<XElement> xprice = from offer in xitem.Element(getXName(nameSpace, "Offers")).Elements(getXName(nameSpace,"Offer"))
                                                         where offer.Element(getXName(nameSpace, "Merchant")).Element(getXName(nameSpace, "MerchantId")).Value == merchantId
                                                   select offer.Element(getXName(nameSpace, "OfferListing")).Element(getXName(nameSpace, "Price")).Element(getXName(nameSpace, "FormattedPrice"));

                    tempPrice = 0;
                    if ((xprice!=null) && (xprice.FirstOrDefault()!=null)) Single.TryParse(xprice.FirstOrDefault().Value.Replace("$", ""), out tempPrice);
                    item.EGMPrice = tempPrice;

                    res.Add(item);
                }
            }

            return res;
        }

        HttpWebResponse sendRequest(string signedUrl)
        {
            try
            {
                Uri url = new Uri(signedUrl);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "GET";
                request.ContentLength = 0;
                request.ContentType = "text/xml";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        XElement getXElements(HttpWebResponse response)
        {
            Stream xmlData = response.GetResponseStream();

            StreamReader reader = new StreamReader(xmlData);
            XElement elements = System.Xml.Linq.XElement.Parse(reader.ReadToEnd());
            reader.Close();

            return elements;
        }

        string getXName(string nameSpace, string nodeName)
        {
            return string.Format("{{{0}}}{1}", nameSpace, nodeName);
        }

        private void dgResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if ((e.RowIndex != -1) && (e.ColumnIndex == dgResults.Columns["Link"].Index) && (dgResults[e.ColumnIndex, e.RowIndex].Value!=null))
                {
                    System.Diagnostics.Process.Start(Convert.ToString(dgResults[e.ColumnIndex, e.RowIndex].Value));                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkLowestPrice_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = (DataView)this.dgResults.DataSource;
                if (dv != null)
                {
                    if (this.rbShowISNOTlowest.Checked)
                        dv.RowFilter = "EGMPrice<>LowestPrice";
                    else if (this.rbShowISlowest.Checked)
                        dv.RowFilter = "EGMPrice=LowestPrice";
                    else
                        dv.RowFilter = string.Empty;
                }
                this.gboxResult.Text = string.Format("Records: {0}", this.dgResults.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgResults.RowHeadersVisible = false;

                this.WindowState = FormWindowState.Maximized;
                this.txtMarketPlaceID.Text = Properties.Settings.Default.MerchantId;

                this.txtKeywords.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btSearch_Click(null, null);
        }


        public bool ShouldQuote(object self)
        {
            if (self == null)
            {
                return false;
            }

            string value = self.ToString();
            return value.Contains("\"")
                || value.Contains("\n")
                || value.Contains("\r")
                || value.Contains(",");
        }

        private string createColumnHeader(DataTable dt)
        {
            List<char> res = new List<char>();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i > 0) res.Add('\t');
                res.AddRange(Convert.ToString(dt.Columns[i].ColumnName));

            }
            return new string(res.ToArray());
        }

        private string createDetail(DataRow dr)
        {
            List<char> res = new List<char>();
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {
                if (i > 0) res.Add('\t');
                string str = Convert.ToString(dr[i]);
                if (ShouldQuote(str))
                {
                    str = str.Replace("\"", "\"\"");
                    str = str.Replace("\r\n", "\n");
                    str = String.Concat("\"", str, "\"");
                }


                res.AddRange(str);
            }
            //res.Add('\n');
            return new string(res.ToArray());
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writerTarget = null;
            try
            {
                SaveFileDialog fSave = new SaveFileDialog();
                fSave.Filter = "Text |.txt";
                if (fSave.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fSave.FileName;
                    writerTarget = new System.IO.StreamWriter(fileName, false);

                    DataView dv = (DataView)this.dgResults.DataSource;
                    if (dv != null)
                    {
                        DataTable dt = dv.ToTable();

                        // Column Header
                        writerTarget.WriteLine(createColumnHeader(dt));
                        foreach (DataRow dr in dt.Rows)
                        {
                            writerTarget.WriteLine(createDetail(dr));
                        }
                    }
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writerTarget != null) writerTarget.Close();
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

    }
}
