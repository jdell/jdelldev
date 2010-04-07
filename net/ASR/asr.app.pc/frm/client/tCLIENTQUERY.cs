using System;
using System.Collections.Generic;
using System.Text;

namespace asr.app.pc.frm.client
{
    public enum tCLIENTQUERY
    {
        [lib.common.tipos.EnumDescription("Full Information")]
        FULL_INFORMATION = 1,

        [lib.common.tipos.EnumDescription("Credit Repair Only")]
        CREDIT_REPAIR_ONLY = 2,

        [lib.common.tipos.EnumDescription("Account Record Only")]
        ACCOUNT_RECORD_ONLY = 3
    }
}
