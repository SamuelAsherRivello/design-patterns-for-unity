using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.BehavioralPatterns.Memento
{
	/// <summary>
	/// Without violating encapsulation, capture and externalize an object's internal 
	/// state so that the object can be restored to this state later.
	/// See <a href="https://www.dofactory.com/net/memento-design-pattern">docs</a>.
	/// </summary>
	public class MementoDemo : MonoBehaviour
	{
		[SerializeField]
		private PlayerOriginator _playerOriginator = null;

		private Caretaker _caretaker;

		protected void Awake()
		{
			_caretaker = new Caretaker(_playerOriginator);
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				_playerOriginator.Randomize();
			}

			if ((Input.GetKeyDown(KeyCode.S)))
			{
				_caretaker.Save();
				Debug.Log("Saved Memento");
			}

			if ((Input.GetKeyDown(KeyCode.R)))
			{
				_caretaker.Restore();
				Debug.Log("Restored Memento");
			}
		}
	}
}