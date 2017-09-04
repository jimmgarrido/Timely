// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Timely.Cells
{
	[Register ("AlarmCell")]
	partial class AlarmCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel NameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UISwitch OnSwitch { get; set; }

		[Outlet]
		UIKit.UILabel RepeatLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UILabel TimeLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}

			if (OnSwitch != null) {
				OnSwitch.Dispose ();
				OnSwitch = null;
			}

			if (TimeLabel != null) {
				TimeLabel.Dispose ();
				TimeLabel = null;
			}

			if (RepeatLabel != null) {
				RepeatLabel.Dispose ();
				RepeatLabel = null;
			}
		}
	}
}
