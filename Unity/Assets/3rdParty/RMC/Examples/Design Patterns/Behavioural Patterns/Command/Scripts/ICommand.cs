using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.Command
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}