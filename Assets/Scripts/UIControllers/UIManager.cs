using UIManager;
using UnityEngine;

namespace EnglishWordReminder
{
	public class UIManager : UISystem
	{
		[Header("Screens")]
		[SerializeField] private BoxesUIScreen s_Boxes;
		[SerializeField] private WordUIScreen s_Word;
		[SerializeField] private UIScreen s_Definition;
		[SerializeField] private ExitUIScreen s_Exit;

		protected override void Start()
		{
			base.Start();
		}

		protected override void GetAllScreens()
		{
			_screensList.Add(s_Boxes);
			_screensList.Add(s_Definition);
		}

		protected override void InitUI()
		{
			s_Boxes.InitUI(this);
			s_Word.InitUI(this);
			s_Exit.InitUI(this);
		}

		internal void ShowWord(DBWord word)
		{
			if (word != null)
			{
				s_Word.Show();
			}

			else
			{
				ShowAddWordScreen();
			}
		}

		internal void ShowAddWordScreen()
		{
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				SwitchPrevScreen();
			}
		}

		private void ShowExitPage()
		{
			SwitchTo(s_Exit);
		}
	}
}
