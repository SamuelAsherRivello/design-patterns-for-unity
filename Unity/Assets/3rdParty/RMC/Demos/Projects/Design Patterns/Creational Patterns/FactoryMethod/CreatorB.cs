using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.FactoryMethod
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class CreatorB : Creator
	{
		public override Product FactoryMethod()
		{
			return new ProductB();
		}
	}
}