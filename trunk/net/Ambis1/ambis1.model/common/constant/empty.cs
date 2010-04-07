using System;

namespace ambis1.model.common.constants
{
	public abstract class empty
	{
		public static readonly DateTime DATETIME = DateTime.MinValue;
		public static readonly Int32 ID = Int32.MinValue;
		public static readonly String CODE = string.Empty;

        public static bool IsEmpty(Int32 id)
        {
            return ID.CompareTo(id) == 0;
        }
        public static bool IsEmpty(DateTime date)
        {
            return DATETIME.CompareTo(date) == 0;
        }
        public static bool IsEmpty(String code)
        {
            return CODE.CompareTo(code) == 0;
        }
	}
}
