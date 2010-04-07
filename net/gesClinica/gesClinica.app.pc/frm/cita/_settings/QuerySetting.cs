using System;
using System.Collections.Generic;
using System.Text;

namespace gesClinica.app.pc.frm.cita._settings
{
    [Serializable()]
    class QuerySetting: repsol.util.setting.userpreferences
    {
        public QuerySetting(repsol.util.setting.userpreferences userPreferences)
        {
            this.Location = userPreferences.Location;
            this.Size = userPreferences.Size;
        }

        private lib.vo.filtro.FiltroCita _filtroCita;

        public lib.vo.filtro.FiltroCita FiltroCita
        {
            get { return _filtroCita; }
            set { _filtroCita = value; }
        }
    }
}
