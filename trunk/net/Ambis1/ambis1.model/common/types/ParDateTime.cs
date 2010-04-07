using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.model.common.types
{
    public class ParDateTime: ParObject
    {
        public ParDateTime()
        {
        }
        
        public ParDateTime(DateTime fecha)
        {
            this.Desde = fecha;
            this.Hasta= fecha;
        }

        public Nullable<DateTime> Desde
        {
            get
            {
                return (Nullable<DateTime>)this.Objeto1;
            }
            set
            {
                this.Objeto1 = value;
            }
        }
        public Nullable<DateTime> Hasta
        {
            get
            {
                return (Nullable<DateTime>)this.Objeto2;
            }
            set
            {
                this.Objeto2 = value;
            }
        }
    }
}
