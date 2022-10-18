using UIManager;
using UnityEngine;

namespace EnglishWordReminder
{
	public class GameManager : UISystem
	{
		[Header("Screens")]
		[SerializeField] private UIScreen s_Boxes;
		[SerializeField] private UIScreen s_Definition;

		protected override void GetAllScreens()
		{
			_screensList.Add(s_Boxes);
			_screensList.Add(s_Definition);
		}
	}
}
