// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Timely
{
	[Register ("NewAlarmViewController")]
	partial class NewAlarmViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton CancelBtn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIDatePicker DatePicker { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton DoneBtn { get; set; }

		[Action ("CancelBtn_TouchUpInside:")]
		partial void CancelBtn_TouchUpInside (UIKit.UIButton sender);

		[Action ("DoneBtn_TouchUpInside:")]
		partial void DoneBtn_TouchUpInside (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CancelBtn != null) {
				CancelBtn.Dispose ();
				CancelBtn = null;
			}

			if (DatePicker != null) {
				DatePicker.Dispose ();
				DatePicker = null;
			}

			if (DoneBtn != null) {
				DoneBtn.Dispose ();
				DoneBtn = null;
			}
		}
	}
}
