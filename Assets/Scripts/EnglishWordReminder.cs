using System.Collections.Generic;
using UnityEngine;

namespace EnglishWordReminder
{
	public class EnglishWordReminder : MonoBehaviour
	{
		public Queue<WordBox> WordBoxes;

		#region Singleton

		private static EnglishWordReminder _instance = null;
		public static EnglishWordReminder Instance { get { return _instance; } }

		private void Singleton()
		{
			if (_instance != null && _instance != this)
			{
				Destroy(this.gameObject);
			}
			else
			{
				_instance = this;
			}
			DontDestroyOnLoad(_instance);
		}

		#endregion

		private void Awake()
		{
			Singleton();
		}

		public void Start()
		{
			WordBoxes = new Queue<WordBox>();

			WordBoxes.Enqueue(new WordBox(WordBoxType.EveryDay));
			WordBoxes.Enqueue(new WordBox(WordBoxType.EveryWeek));
			WordBoxes.Enqueue(new WordBox(WordBoxType.EveryThreeDay));
			WordBoxes.Enqueue(new WordBox(WordBoxType.EveryMonth));

			foreach (var wordBox in WordBoxes)
			{
				wordBox.FillWithRandomWordsFromDatabase();
			}
		}
	}
}
