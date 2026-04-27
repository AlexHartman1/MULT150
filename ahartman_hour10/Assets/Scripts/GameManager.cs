using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
    }
    void OnGUI() {
        if (isGameOver){
        Rect rect = new Rect (Screen.width/2 - 100, Screen.height/2 - 50, 200, 75);
        GUI.Box(rect, "Game Over!");
        Rect rect2 = new Rect (Screen.width/2 - 30, Screen.height/2 - 25, 60, 50);
        GUI.Box(rect2, "GG WP!");
		Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2, 240, 30);
        if(GUI.Button(startButton, "Play Again?")){
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
        
       } 

    }
}
