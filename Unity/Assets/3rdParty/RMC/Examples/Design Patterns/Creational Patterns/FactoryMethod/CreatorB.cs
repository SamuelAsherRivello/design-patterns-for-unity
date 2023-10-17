using UnityEngine;

namespace RMC.Examples.DesignPatterns.CreationalPatterns.FactoryMethod
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