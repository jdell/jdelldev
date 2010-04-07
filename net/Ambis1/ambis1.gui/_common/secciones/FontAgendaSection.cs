using System;
using System.Collections.Generic;
using System.Text;

namespace ambis1.gui.pc._common.sections
{
    class FontAgendaSection:ambis1.model.common.types.section
    {
        string _nameFontAgenda;

        public string NameFontAgenda
        {
            get { return _nameFontAgenda; }
            set { _nameFontAgenda = value; }
        }
        string _styleFontAgenda;

        public string StyleFontAgenda
        {
            get { return _styleFontAgenda; }
            set { _styleFontAgenda = value; }
        }
        float _sizeFontAgenda;

        public float SizeFontAgenda
        {
            get { return _sizeFontAgenda; }
            set { _sizeFontAgenda = value; }
        }

        public FontAgendaSection()
        {
            this._name = "fontAgenda";
            this._nameFontAgenda = "Tahoma";
            this._sizeFontAgenda = 8.25F;
            this._styleFontAgenda = "Regular";
        }
    }
}
