using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tool.amazon.LowestPrice
{
    class Item:IDisposable
    {
        String _asin = string.Empty;

        public String ASIN
        {
            get { return _asin; }
            set { _asin = value; }
        }
        String _urlLink = string.Empty;

        public String UrlLink
        {
            get { return _urlLink; }
            set { _urlLink = value; }
        }
        Single _eGMPrice = 0;

        public Single EGMPrice
        {
            get { return _eGMPrice; }
            set { _eGMPrice = value; }
        }
        Single _lowestPrice = 0;

        public Single LowestPrice
        {
            get { return _lowestPrice; }
            set { _lowestPrice = value; }
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose();
        }

        #endregion
    }
}
