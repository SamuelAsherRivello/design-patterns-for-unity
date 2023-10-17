using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.FactoryMethod
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class CreatorA : Creator
	{
		public override Product FactoryMethod()
		{
			return new ProductA();
		}
	}
}