using System;

namespace ambis1.model.dao._common
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
