using System.Collections.Generic;

namespace EnglishWordReminder
{
	public class WordBox
	{
		public readonly WordBoxType WordBoxType;
		public Queue<DBWord> Words;

		public WordBox(WordBoxType wordBoxType)
		{
			this.WordBoxType = wordBoxType;
		}

		internal void FillWithRandomWordsFromDatabase()
		{
			Words = LocalDatabaseService.Instance.GetWordsForBox(WordBoxType);
		}
	}
}
