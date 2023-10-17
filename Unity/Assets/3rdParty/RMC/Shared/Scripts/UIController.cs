using TMPro;
using UnityEngine;

namespace RMC.Shared
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class UIController : MonoBehaviour
	{
		[SerializeField]
		private UIConfigData _uiConfigData = null;

		[SerializeField]
		private TextMeshProUGUI _leftText = null;

		[SerializeField]
		private TextMeshProUGUI _rightText = null;

		protected void Awake()
		{
			OnValidate();
		}

		protected void OnValidate()
		{
			if (_uiConfigData == null)
			{
				return;
			}

			_leftText.text = _uiConfigData.LeftText;
			_rightText.text = _uiConfigData.RightText;
		}
	}
}