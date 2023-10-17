using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.Command
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Command : ICommand
	{
		public CommandReceiver _commandReceiver;

		public Command (CommandReceiver commandReceiver)
		{
			_commandReceiver = commandReceiver;
		}

		public virtual void Execute ()
		{

		}

		public virtual void Undo()
		{

		}
	}
}