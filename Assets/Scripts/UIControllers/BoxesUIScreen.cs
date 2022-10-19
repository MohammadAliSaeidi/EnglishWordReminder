using System.Linq;
using UIManager;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishWordReminder
{
	public class BoxesUIScreen : UIScreen
	{
		[Header("Screen Content")]
		[SerializeField] private Button b_EveryDay;
		[SerializeField] private Button b_EveryThreeDay;
		[SerializeField] private Button b_EveryWeek;
		[SerializeField] private Button b_EveryMonth;

		private UIManager uIManager;

		internal void InitUI(UIManager uIManager)
		{
			this.uIManager = uIManager;

			b_EveryDay.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every day word");
					var word = GetWordFromBox(WordBoxType.EveryDay);
					uIManager.ShowWord(word);
				});

			b_EveryThreeDay.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every three day word");
					var word = GetWordFromBox(WordBoxType.EveryThreeDay);
					uIManager.ShowWord(word);
				});

			b_EveryWeek.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every week word");
					var word = GetWordFromBox(WordBoxType.EveryWeek);
					uIManager.ShowWord(word);
				});

			b_EveryMonth.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every month word");
					var word = GetWordFromBox(WordBoxType.EveryMonth);
					uIManager.ShowWord(word);
				});
		}

		private DBWord GetWordFromBox(WordBoxType wordBoxType)
		{
			DBWord word = null;
			// get file where word is related to the work box (a box that has some word cards)
			var wordsOfBox = EnglishWordReminder.Instance.WordBoxes.Where(wb => wb.WordBoxType == wordBoxType)
														  .FirstOrDefault().Words;

			if (wordsOfBox.Any())
			{
				word = wordsOfBox.Dequeue();
			}

			return word;
		}
	}
}
