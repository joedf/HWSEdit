using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HWSEdit
{
	public class UpgradeTreeView : TreeView
	{
		protected int _Class = -1;
		public int Class
		{
			get
			{
				return _Class;
			}
			set
			{
				_Class = value;
				changeClass();
			}
		}

		private const int WM_LBUTTONDBLCLK = 0x0203;

		protected override void WndProc(ref Message m)
		{
			// Workaround for a bug in Windows that causes the checkbox to incorrectly change visual states when double-clicked
			if (m.Msg == WM_LBUTTONDBLCLK)
			{
				TreeViewHitTestInfo hit = HitTest(new System.Drawing.Point(m.LParam.ToInt32()));
				if (hit != null && hit.Location == TreeViewHitTestLocations.StateImage)
				{
					m.Result = IntPtr.Zero;
					return;
				}
			}

			base.WndProc(ref m);
		}

		
		protected void changeClass()
		{
			//catActive.Clear();
			//catPassive.Clear();

			if (Class == 1)
			{

			}
		}
	}
}
