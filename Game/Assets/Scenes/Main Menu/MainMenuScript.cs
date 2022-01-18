using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("Scene 1");
    }
    
    public void quitGame(){
        Debug.Log("Game Quit!!!");
        Application.Quit();
    }
}
