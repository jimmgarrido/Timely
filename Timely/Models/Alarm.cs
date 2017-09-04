using System;
using SQLite;

namespace Timely.Models
{
	[Table("Alarms")]
	public class Alarm
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Time { get; set; }

		public Alarm()
		{
			
		}
	}
}
