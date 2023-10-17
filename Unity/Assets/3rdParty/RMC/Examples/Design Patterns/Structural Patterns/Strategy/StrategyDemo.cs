using UnityEngine;

namespace RMC.Projects.UnityDesignPatterns.Patterns.StructuralPatterns.Strategy
{
	/// <summary>
	/// Define a family of algorithms, encapsulate each one, and make them interchangeable.
	/// Strategy lets the algorithm vary independently from clients that use it.
	/// See <a href="https://www.dofactory.com/net/strategy-design-pattern">docs</a>.
	/// </summary>
	public class StrategyDemo : MonoBehaviour
	{
		
		protected void Start()
		{
			MathQuizCreatorContext addition = 
				new MathQuizCreatorContext(new AdditionMathQuizCreator());
			
			Debug.Log("addition1: " + addition.CreateQuizTitle());
			Debug.Log("addition2: " + addition.CreateQuiz());
			
			MathQuizCreatorContext subtraction = 
				new MathQuizCreatorContext(new SubtractionMathQuizCreator());
			
			Debug.Log("subtraction1: " + subtraction.CreateQuizTitle());
			Debug.Log("subtraction2: " + subtraction.CreateQuiz());
			
			MathQuizCreatorContext multiplication = 
				new MathQuizCreatorContext(new MultiplicationMathQuizCreator());
			
			Debug.Log("multiplication1: " + multiplication.CreateQuizTitle());
			Debug.Log("multiplication1: " + multiplication.CreateQuiz());
		}

	}
}