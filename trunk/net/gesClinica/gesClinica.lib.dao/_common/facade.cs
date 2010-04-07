using System;

namespace gesClinica.lib.dao._common
{
	
	
	public abstract class facade
	{
		internal DAOFactory factory;
		
		public facade()
		{
			factory = new DAOFactory();
		}

	}
}
