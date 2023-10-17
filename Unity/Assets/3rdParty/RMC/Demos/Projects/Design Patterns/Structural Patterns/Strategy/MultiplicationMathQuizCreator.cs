
namespace RMC.Projects.UnityDesignPatterns.Patterns.StructuralPatterns.Strategy
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class MultiplicationMathQuizCreator : IMathQuizCreator 
	{
		public string CreateQuizTitle ()
		{
			return "Multiplication Quiz";
		}
		
		public string CreateQuiz ()
		{
			return "What is 3 x 2?";
		}
	}
}