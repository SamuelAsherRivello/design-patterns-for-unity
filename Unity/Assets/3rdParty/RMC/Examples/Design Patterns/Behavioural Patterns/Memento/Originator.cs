using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.Memento
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public abstract class Originator : MonoBehaviour
	{
		public abstract Memento CreateMemento();
		public abstract void RestoreMemento(Memento memento);
	}
}