using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Timely.Models;

namespace Timely.Helpers
{
	public static class DatabaseHelper
	{
		public static event EventHandler AlarmsChanged;

		public static List<Alarm> AlarmsList { get; set; }
		static SQLiteAsyncConnection connection;

		public static async Task InitDatabase()
		{
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var dbPath = Path.Combine(documents, "..", "Library", "alarms.sqlite");

			connection = new SQLiteAsyncConnection(dbPath);
			await connection.CreateTableAsync<Alarm>();

			RefreshAlarmsAsync();
		}

		static async Task RefreshAlarmsAsync()
		{
			AlarmsList = await connection.Table<Alarm>().ToListAsync();
			AlarmsChanged?.Invoke(null, null);
		}

		public static async Task AddAlarmAsync(Alarm alarm)
		{
			//alarmsList.Add(alarm);
			await connection.InsertAsync(alarm);
			await RefreshAlarmsAsync();

		}
	}
}
