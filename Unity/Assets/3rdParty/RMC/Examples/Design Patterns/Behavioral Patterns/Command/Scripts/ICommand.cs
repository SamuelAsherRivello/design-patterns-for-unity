using UnityEngine;

namespace RMC.Examples.DesignPatterns.BehavioralPatterns.CommandPattern
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