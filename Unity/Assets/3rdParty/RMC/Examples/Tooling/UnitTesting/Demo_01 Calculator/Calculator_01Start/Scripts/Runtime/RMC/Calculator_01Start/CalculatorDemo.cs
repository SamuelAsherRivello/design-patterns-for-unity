using UnityEngine;

namespace RMC.Calculator_01Start
{
	/// <summary>
	/// 
	/// </summary>
	public class CalculatorDemo : MonoBehaviour
	{
		public Calculator Calculator { get { return _calculator; } }
		
		[SerializeField]
		private Calculator _calculator = new Calculator();
		
		protected void Start()
		{
			_calculator = new Calculator();
			Debug.Log("01 calculator.Add(10, 5) = " + _calculator.Add(10, 5));
			Debug.Log("01 calculator.Subtract(9, 4) = " + _calculator.Add(9, 4));
		}
	}
}