using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Counter
    {
        public Counter()
        {
        }
        public Counter(int year, Serie serie)
        {
            _year = year;
            _serie = serie;
        }
        private int _id = asr.lib.common.constantes.vacio.ID;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _year = DateTime.Now.Year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private Serie _serie = null;

        public Serie Serie
        {
            get { return _serie; }
            set { _serie = value; }
        }
        private Int32 _number = 0;

        public Int32 Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
