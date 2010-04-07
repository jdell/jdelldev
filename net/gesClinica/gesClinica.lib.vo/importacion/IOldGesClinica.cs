using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.lib.vo.importacion
{
    public interface IOldGesClinica<T>
    {
        T ToNewGesClinica();
    }
}
