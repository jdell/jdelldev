using System;

namespace gesClinica.lib.dao._common.plain
{
	internal interface PlainAction
	{
		object execute(DAOFactory factory);
	}
}
