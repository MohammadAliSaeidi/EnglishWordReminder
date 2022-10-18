using UIManager;
using UnityEngine;

namespace EnglishWordReminder
{
	public class UIManager : UISystem
	{
		[Header("Screens")]
		[SerializeField] private BoxesUIScreen s_Boxes;
		[SerializeField] private UIScreen s_Definition;

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
			s_Boxes.InitUI();
		}
	}
}
