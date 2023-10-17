using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.CreationalPatterns.Singleton
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonMonoBehaviourDemo : MonoBehaviour
	{
		protected void Start()
		{
			// Singleton MonoBehaviour
			// -- Call multiple times. Note: It only gets created 1 time
			MySingleton.Instance.SayHelloWorld();
			MySingleton.Instance.SayHelloWorld();
			MySingleton.Instance.SayHelloWorld();
		}
	}
}