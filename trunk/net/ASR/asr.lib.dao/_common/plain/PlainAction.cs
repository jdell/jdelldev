using System;

namespace asr.lib.dao._common.plain
{
	internal interface PlainAction
	{
		object execute(DAOFactory factory);
	}
}
