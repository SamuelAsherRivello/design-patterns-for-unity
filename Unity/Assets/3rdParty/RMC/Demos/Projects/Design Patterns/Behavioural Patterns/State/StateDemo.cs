using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.State
{
	/// <summary>
	/// Allow an object to alter its behavior when its internal state changes. 
	/// The object will appear to change its class.
	/// See <a href="https://www.dofactory.com/net/state-design-pattern">docs</a>.
	/// </summary>
	public class StateDemo : MonoBehaviour
	{
		[SerializeField]
		private StateReceiver _stateReceiver = null;

		private Context _context;

		protected void Awake()
		{
			_context = new Context();
			_context.AddState(new HoveringState(_stateReceiver));
			_context.AddState(new SpinningState(_stateReceiver));

			_context.Hover();
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				_context.Hover();
			}

			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				_context.Spin();
			}

			_context.Update(Time.deltaTime);
		}
	}
}