using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Game";
	public string sceneToLoad1 = "ahartman_FINAL";

	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
		public void LoadScene ()
	{
		SceneManager.LoadScene(sceneToLoad1);
	}
}
