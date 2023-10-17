
using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.State
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class State : IState
	{
		protected StateReceiver _stateReceiver;

		public virtual void EnterState() { }
		public virtual void ExitState() { }

		public State(StateReceiver stateReceiver)
		{
			_stateReceiver = stateReceiver;
		}

		public virtual void Update(float deltaTime) { }
	}
}