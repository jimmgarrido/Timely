using Foundation;
using System;
using UIKit;

namespace Timely.Cells
{
    public partial class AlarmCell : UITableViewCell
    {
		string _alarmName;
		public string AlarmName
		{
			get { return _alarmName; }
			set
			{
				_alarmName = value;
				NameLabel.Text = _alarmName;
			}
		}

		string _repeatText;
		public string RepeatText
		{
			get { return _repeatText; }
			set
			{
				_repeatText = value;
				RepeatLabel.Text = _repeatText;
			}
		}

		DateTime _alarmTime;
		public DateTime AlarmTime
		{
			get { return _alarmTime; }
			set
			{
				_alarmTime = value;
				TimeLabel.Text = _alarmTime.ToShortTimeString();
			}
		}

		bool _isOn;
		public bool IsOn
		{
			get { return _isOn; }
			set
			{
				_isOn = value;
				OnSwitch.On = _isOn ? true : false;
			}
		}

        public AlarmCell (IntPtr handle) : base (handle)
        {

        }
    }
}