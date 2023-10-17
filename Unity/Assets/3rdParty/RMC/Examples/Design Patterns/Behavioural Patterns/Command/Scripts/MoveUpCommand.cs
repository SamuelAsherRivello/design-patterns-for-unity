using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.Command
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class MoveUpCommand : Command
	{
		public MoveUpCommand(CommandReceiver commandReceiver) : base(commandReceiver) { }

		private Vector3 _positionDelta = new Vector3(0, .5f, 0);
		public override void Execute ()
		{
			_commandReceiver.transform.position += _positionDelta;
		}

		public override void Undo()
		{
			_commandReceiver.transform.position -= _positionDelta;
		}
	}
}