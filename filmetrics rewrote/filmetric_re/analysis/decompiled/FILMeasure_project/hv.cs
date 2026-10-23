using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Threading;

internal class hv
{
	public static Image a(ref string A_0)
	{
		return (Image)new ResourceManager("Filmetrics.FMResources", Assembly.GetExecutingAssembly()).GetObject(A_0, Thread.CurrentThread.CurrentUICulture);
	}
}
