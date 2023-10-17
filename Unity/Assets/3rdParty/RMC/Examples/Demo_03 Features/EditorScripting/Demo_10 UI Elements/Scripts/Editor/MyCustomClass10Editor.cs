using UnityEditor;
using UnityEngine.UIElements;

namespace RMC.Projects.Features.EditorScripting.Demo_10_UIElements
{
	/// <summary>
	/// 
	/// </summary>
	[CustomEditor(typeof(MyCustomClass10))]
	public class MyCustomClass10Editor : Editor
	{
		private const string BasePath = "Assets/Demos/RMC/Projects/Features/EditorScripting/Demo_10_UIElements/UIElements/";
		private const string LayoutPath = BasePath + "Layouts/MyCustomClass10EditorLayout.uxml";
		private const string StylePath = BasePath + "Styles/MyCustomClass10EditorStyle.uss";
		
		private MyCustomClass10 _target;
		private VisualTreeAsset _visualTreeAsset;
		private VisualElement _visualElement;
		
		protected void OnEnable()
		{
			_target = (MyCustomClass10) target;
			
			_visualElement = new VisualElement();
			
			_visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(LayoutPath);

			StyleSheet styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(StylePath);
			_visualElement.styleSheets.Add(styleSheet);

		}

		public override VisualElement CreateInspectorGUI()
		{
			_visualElement.Clear();

			_visualTreeAsset.CloneTree(_visualElement);

			// Query Single Element
			_visualElement.Q<VisualElement>(name: "ResetButton").RegisterCallback<MouseUpEvent>(e =>
			{
				_target.CurrentPosition.x = 0;
				_target.CurrentPosition.y = 0;
				_target.CurrentPosition.z = 0;
			}, TrickleDown.TrickleDown);
			
			// Query Single Element
			_visualElement.Q<VisualElement>(name: "RandomizeButton").RegisterCallback<MouseUpEvent>(e =>
			{
				_target.CurrentPosition.x = UnityEngine.Random.Range(0, 100);
				_target.CurrentPosition.y = UnityEngine.Random.Range(0, 100);
				_target.CurrentPosition.z = UnityEngine.Random.Range(0, 100);
			}, TrickleDown.TrickleDown);

			// Query Multiple Elements
			_visualElement.Query<VisualElement>(className: "Button").ForEach(DecorateButton);
			
			return _visualElement;
		}

		private void DecorateButton(VisualElement visualElement)
		{
			(visualElement as Button).text = (visualElement as Button).text + "!";
		}
	}
}