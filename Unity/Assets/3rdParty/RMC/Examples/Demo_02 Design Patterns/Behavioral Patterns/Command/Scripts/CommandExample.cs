using UnityEngine;

namespace RMC.Examples.DesignPatterns.BehavioralPatterns.CommandPattern
{
	/// <summary>
	/// Encapsulate a request as an object, thereby letting you parameterize clients with 
	/// different requests, queue or log requests, and support undoable operations.
	/// See <a href="https://www.dofactory.com/net/command-design-pattern">docs</a>.
	/// </summary>
	public class CommandExample : MonoBehaviour
	{
		[SerializeField]
		private CommandReceiver _commandReceiver = null;

		private CommandInvoker _commandInvoker;

		protected void Awake()
		{
			_commandInvoker = new CommandInvoker();
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				ICommand command = new MoveUpCommand(_commandReceiver);
				_commandInvoker.AddCommand(command);
				_commandInvoker.Execute();
			}

			if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
			{
				_commandInvoker.Undo();
			}
		}
	}
}