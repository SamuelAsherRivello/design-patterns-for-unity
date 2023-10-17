using UnityEngine;

namespace RMC.Calculator_02Complete
{
	/// <summary>
	/// 
	/// </summary>
	public class CalculatorDemo : MonoBehaviour
	{
		public Calculator Calculator { get { return _calculator; } }

		[SerializeField] 
		private Calculator _calculator = null;
		
		protected void Start()
		{
			_calculator = new Calculator();
			Debug.Log("02 calculator.Add(10, 5) = " + _calculator.Add(10, 5));
			Debug.Log("02 calculator.Subtract(9, 4) = " + _calculator.Subtract(9, 4));
		}
	}
}