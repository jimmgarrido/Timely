using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using Timely.Models;
using Timely.Helpers;
using Timely.Cells;

namespace Timely
{
	public partial class AlarmsViewController : UITableViewController
    {
        public AlarmsViewController (IntPtr handle) : base (handle)
        {
			
        }

		public async override void ViewDidLoad()
		{
			base.ViewDidLoad();

			await DatabaseHelper.InitDatabase();

			var source = new AlarmsTableSource(TableView)
			{
				AlarmsList = new List<Alarm>()
			};

			TableView.Source = source;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}
	}

	public class AlarmsTableSource : UITableViewSource
	{
		public List<Alarm> AlarmsList { get; set; }

		UITableView tableView;
		string cellId = "alarmcell";

		public AlarmsTableSource(UITableView table)
		{
			tableView = table;
			DatabaseHelper.AlarmsChanged += DatabaseHelper_AlarmsChanged;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = (AlarmCell) tableView.DequeueReusableCell(cellId);
			var item = AlarmsList[indexPath.Row];

			cell.AlarmName = item.Name;
			cell.AlarmTime = item.Time;

			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return AlarmsList.Count;
		}

		void DatabaseHelper_AlarmsChanged(object sender, EventArgs e)
		{
			AlarmsList = DatabaseHelper.AlarmsList;
			tableView.ReloadData();
		}

	}
}