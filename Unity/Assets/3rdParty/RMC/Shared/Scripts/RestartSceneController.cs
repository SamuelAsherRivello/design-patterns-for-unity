using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.Shared
{
	/// <summary>
	/// Press the Spacebar to restart the scene.
	/// </summary>
	public class RestartSceneController : MonoBehaviour
	{
		protected void Update()
		{
			// Restart Scene		------------------------------------
			if (Input.GetKey(KeyCode.Space))
			{
				Debug.Log("Restarting Scene. KeyCode: " + KeyCode.Space);
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
}