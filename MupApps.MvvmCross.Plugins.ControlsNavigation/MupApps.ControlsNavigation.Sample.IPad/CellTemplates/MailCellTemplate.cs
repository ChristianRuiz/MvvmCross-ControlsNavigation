using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MupApps.ControlsNavigation.Sample.IPad
{
	public partial class MailCellTemplate : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("MailCellTemplate", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("MailCellTemplate");

		public MailCellTemplate (IntPtr handle) : base (handle)
		{
		}

		public static MailCellTemplate Create ()
		{
			return (MailCellTemplate)Nib.Instantiate (null, null) [0];
		}
	}
}

