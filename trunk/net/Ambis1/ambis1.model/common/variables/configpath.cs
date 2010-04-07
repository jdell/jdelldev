using System;

namespace ambis1.model.common.variables
{	
	public abstract class configpath
	{

        public static string DIRECTORY = Environment.CurrentDirectory;
        
		public static string FILE = "config.xml";
		
		public static string GetFullPath()
		{
			return System.IO.Path.GetFullPath(string.Format("{0}{1}{2}", DIRECTORY, System.IO.Path.DirectorySeparatorChar,FILE));
		}
	}
}
