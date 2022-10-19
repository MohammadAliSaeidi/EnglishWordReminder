using System.Collections;
using System.Collections.Generic;
using UIManager;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishWordReminder
{
    public class ExitUIScreen : UIScreen
    {
		[SerializeField] private Button b_Exit;
		[SerializeField] private Button b_Cancel;

		private UIManager uIManager;

		internal void InitUI(UIManager uIManager)
		{
			this.uIManager = uIManager;

			b_Exit.onClick.AddListener(
				delegate
				{
					Application.Quit();
				});

			b_Cancel.onClick.AddListener(
				delegate
				{
					uIManager.SwitchPrevScreen();
				});
		}
	}
}
