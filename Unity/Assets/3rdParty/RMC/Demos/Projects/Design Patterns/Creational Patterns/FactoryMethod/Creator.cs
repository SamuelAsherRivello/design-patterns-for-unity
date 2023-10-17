using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.FactoryMethod
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