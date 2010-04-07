using System;

namespace gesClinica.lib.common.constantes
{
	public abstract class vacio
	{
		public static readonly DateTime FECHA = DateTime.MinValue;
		public static readonly int ID = -1;
		public static readonly string CODIGO = string.Empty;

        public static bool IsEmpty(int id)
        {
            return ID.CompareTo(id) == 0;
        }
	}
}
