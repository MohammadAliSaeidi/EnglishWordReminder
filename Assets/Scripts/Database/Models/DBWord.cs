using SQLite4Unity3d;

namespace EnglishWordReminder
{
	public class DBWord
	{
		[PrimaryKey]
		public string Word { get; set; }
		public int WordBox { get; set; }
	}
}
