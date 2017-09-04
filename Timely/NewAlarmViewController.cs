using Foundation;
using System;
using UIKit;

using Timely.Helpers;
using Timely.Models;

namespace Timely
{
    public partial class NewAlarmViewController : UITableViewController
    {
        public NewAlarmViewController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			DatePicker.TimeZone = NSTimeZone.SystemTimeZone;
		}

		async partial void DoneBtn_TouchUpInside(UIButton sender)
		{
			var refSecs = DatePicker.Date.SecondsSinceReferenceDate;
			var time = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			var actual = time.AddSeconds(refSecs).ToLocalTime();
			//var time = DateTime.SpecifyKind(DatePicker.Date., DateTimeKind.Utc).ToLocalTime();
			System.Diagnostics.Debug.WriteLine(actual);

			var newAlarm = new Alarm { Name = "New Alarm", Time = actual };
			await DatabaseHelper.AddAlarmAsync(newAlarm);

			DismissViewController(true, null);
		}

		partial void CancelBtn_TouchUpInside(UIButton sender)
		{
			DismissViewController(true, null);
		}
	}
}