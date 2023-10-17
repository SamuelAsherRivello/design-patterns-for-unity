using UnityEngine;

namespace RMC.Examples.DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public abstract class Creator
	{
		public Creator ()
		{
		}

		public abstract Product FactoryMethod();
	}
}