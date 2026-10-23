using System;
using System.Collections.ObjectModel;

namespace Filmetrics.My;

[Serializable]
internal class NewInstanceEventArgs : EventArgs
{
	public ReadOnlyCollection<string> CommandLineArgs;

	public NewInstanceEventArgs(ReadOnlyCollection<string> A_0)
	{
		CommandLineArgs = A_0;
	}
}
