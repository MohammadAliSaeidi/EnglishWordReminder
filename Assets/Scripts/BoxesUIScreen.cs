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

		internal void InitUI()
		{
			b_EveryDay.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every day word");
					GetRandomWordFromBox(WordBox.EveryDay);

				});

			b_EveryThreeDay.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every three day word");
					GetRandomWordFromBox(WordBox.EveryThreeDay);
				});

			b_EveryWeek.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every week word");
					GetRandomWordFromBox(WordBox.EveryWeek);
				});

			b_EveryMonth.onClick.AddListener(
				delegate
				{
					Debug.Log("Get Every month word");
					GetRandomWordFromBox(WordBox.EveryMonth);
				});
		}

		private void GetRandomWordFromBox(WordBox wordBox)
		{
			// get file where word is related to the work box (a box that has some word cards)
		}
	}
}
