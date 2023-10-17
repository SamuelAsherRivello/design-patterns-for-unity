using UnityEditor;
using UnityEngine;

namespace RMC.Calculator_02Complete
{
	/// <summary>
	/// This custom editor affects the Inspector of the <see cref="CalculatorDemo"/>.
	/// See https://docs.unity3d.com/Manual/editor-CustomEditors.html
	/// </summary>
	[CustomEditor(typeof(RMC.Calculator_02Complete.CalculatorDemo))]
	public class CalculatorDemoEditor : Editor
	{
		public override void OnInspectorGUI()
		{
			// 1. Add something custom
			GUILayout.Label ("This is a Label in a Custom Editor");
			
			// 2. Then render the standard stuff
			//base.OnInspectorGUI();
		}
	}
}