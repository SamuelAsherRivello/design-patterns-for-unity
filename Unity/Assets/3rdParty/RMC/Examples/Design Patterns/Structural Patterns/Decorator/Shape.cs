using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Shape : MonoBehaviour, IShape
	{
		public Transform Transform { get { return transform; } }

		public void DrawMe()
		{
			
		}
	}
}