using UnityEngine;

namespace RMC.Examples.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public interface IShape
	{
		Transform Transform { get; }
		void DrawMe();
	}
}