using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.State
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public interface IState
	{
		void EnterState();
		void Update(float deltaTime);
		void ExitState();
	}
}