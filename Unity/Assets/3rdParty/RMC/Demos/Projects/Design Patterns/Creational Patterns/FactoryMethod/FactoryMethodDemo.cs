using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.FactoryMethod
{
	/// <summary>
	/// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
	/// Factory Method lets a class defer instantiation to subclasses.
	/// See <a href="https://www.dofactory.com/net/factory-method-design-pattern">docs</a>.
	/// </summary>
	public class FactoryMethodDemo : MonoBehaviour
	{
		protected void Awake()
		{
			CreatorA creatorA = new CreatorA();
			CreatorB creatorB = new CreatorB();

			Product product1 = creatorA.FactoryMethod();
			Product product2 = creatorB.FactoryMethod();

			Debug.Log("Product1: " + product1);
			Debug.Log("Product2: " + product2);
		}
	}
}