using System;

namespace ambis1.model.dao._common.plain
{
	internal interface PlainAction
	{
		object execute(DAOFactory factory);
	}
}
