using UnityEngine;

namespace RMC.Examples.DesignPatterns.CreationalPatterns.SingletonPattern.SingletonMonoBehaviour
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class SingletonMonoBehaviourExample : MonoBehaviour
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