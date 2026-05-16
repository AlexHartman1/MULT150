using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "Game";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
	public void CampFire ()
	{
		SceneManager.LoadScene("ahartman_hour16");
	}
}
