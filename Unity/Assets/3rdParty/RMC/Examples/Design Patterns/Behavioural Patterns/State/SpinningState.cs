using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.State
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class SpinningState : State
	{
		public SpinningState(StateReceiver stateReceiver) : base(stateReceiver) { }

		public override void Update(float deltaTime)
		{
			_stateReceiver.transform.Rotate(new Vector3(0, -deltaTime * 100, 0));
		}
	}
}