using UnityEngine;

namespace RMC.Examples.DesignPatterns.CreationalPatterns.FactoryMethodPattern
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