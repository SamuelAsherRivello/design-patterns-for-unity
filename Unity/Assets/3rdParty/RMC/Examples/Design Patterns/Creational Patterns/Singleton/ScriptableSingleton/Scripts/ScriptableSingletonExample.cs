using UnityEngine;

namespace RMC.Examples.DesignPatterns.CreationalPatterns.SingletonPattern.ScriptableSingleton
{
	/// <summary>
	/// Ensure a class has only one instance and provide a global point of access to it.
	/// See <a href="https://www.dofactory.com/net/singleton-design-pattern">docs</a>.
	/// </summary>
	public class ScriptableSingletonExample : MonoBehaviour
	{
		protected void Start()
		{
			// Singleton ScriptableObject
			// -- Writes to local path
			MyScriptableSingleton.instance.Log();
			MyScriptableSingleton.instance.IncrementSomeCounter();
			MyScriptableSingleton.instance.Log();
		}
	}
}