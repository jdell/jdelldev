﻿using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class Skill : IComparable<Skill>
    {
        private int _id = asr.lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _description = string.Empty;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string ToString()
        {
            return Description;
        }

        #region Miembros de IComparable<Skill>

        public int CompareTo(Skill other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}