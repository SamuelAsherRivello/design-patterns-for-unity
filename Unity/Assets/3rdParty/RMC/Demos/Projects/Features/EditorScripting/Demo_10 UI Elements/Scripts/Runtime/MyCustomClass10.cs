using UnityEngine;

namespace RMC.Projects.Features.EditorScripting.Demo_10_UIElements
{
	/// <summary>
	///  
	/// </summary>
	public class MyCustomClass10 : MonoBehaviour
	{
		// const/static are never serialized.
		public static Vector3 CurrentPositionDefault  = new Vector3(0,0,0 );
		
		// Publics are serialized automatically. Add [NonSerialized] to force it.
		public int CurrentLevel;
		public Vector3 CurrentPosition;
		
		// Private are NOT serialized automatically. Add [SerializeField] to force it.
		private float _previousHealth;
		private Vector3 _previousPosition;
		
	}
}