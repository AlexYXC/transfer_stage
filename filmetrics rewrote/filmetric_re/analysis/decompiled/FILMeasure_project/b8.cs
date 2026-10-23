using System.Drawing;
using System.Windows.Forms;

internal class b8 : GroupBox
{
	public override Size GetPreferredSize(Size proposedSize)
	{
		Size preferredSize = base.GetPreferredSize(proposedSize);
		if (AutoSize)
		{
			int num = int.MinValue;
			foreach (Control control in base.Controls)
			{
				if (control.Bottom > num)
				{
					num = control.Bottom;
				}
			}
			preferredSize.Height = checked(base.Bounds.Height - DisplayRectangle.Height + num + base.Padding.Bottom - 10);
		}
		return preferredSize;
	}
}
