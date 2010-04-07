using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    [Serializable()]
    public class SkillScore : IComparable<SkillScore>
    {
        private int _id = asr.lib.common.constantes.vacio.ID;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private Skill _skill = null;

        public Skill Skill
        {
            get { return _skill; }
            set { _skill = value; }
        }
        private Client _client = null;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }
        private tSCORE _score = tSCORE.GOOD;

        public tSCORE Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public static tSCORE TipoFromName(string name)
        {
            return (tSCORE)System.Enum.Parse(typeof(tSCORE), name);
        }
        public static string NameFromTipo(tSCORE tipo)
        {
            return System.Enum.GetName(typeof(tSCORE), tipo);
        }


        #region Miembros de IComparable<SkillScore>

        public int CompareTo(SkillScore other)
        {
            return this.ID.CompareTo(other.ID);
        }

        #endregion
    }
}
