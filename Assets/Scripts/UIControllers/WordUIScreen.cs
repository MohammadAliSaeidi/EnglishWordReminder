using UIManager;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishWordReminder
{
	public class WordUIScreen : UIScreen
	{
		[SerializeField] private Button[] b_Back;

		private UIManager uIManager;

		internal void InitUI(UIManager uIManager)
		{
			this.uIManager = uIManager;

			foreach (var back in b_Back)
			{
				back.onClick.AddListener(
					delegate
					{
						Back();
					});
			}
		}

		private void Back()
		{

		}
	}
}
