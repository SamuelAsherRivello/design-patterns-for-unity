using UnityEngine;

namespace RMC.Shared
{
	[CreateAssetMenu(fileName = "UIConfigData",
		menuName = UnityDesignPatternsConstants.CreateAssetMenuPath + "Create New UIConfigData",
		order = UnityDesignPatternsConstants.CreateAssetMenuOrder)]

	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class UIConfigData : ConfigData
	{
		public string LeftText {  get { return _leftText; } }
		public string RightText { get { return _rightText; } }

		[SerializeField]
		private string _leftText = "";

		[SerializeField]
		private string _rightText = "";

	}
}