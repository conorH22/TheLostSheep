using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
//weather scene manager  handles  load  all the weather effect scene from the menu scene
public class WeatherSceneManager : MonoBehaviour
{     // public transform for  the buttons listed below
    public Transform mainMenu,Play, Exit
        ;
    // load scene method with string name
    public void LoadScene(string name)
    {   // scene manager loadsscene with the scene names in the 3d weather effects application
        SceneManager.LoadScene(name);

    }
    // similar method same functionality as LoadGame
    public void LoadGame(string name)
    {
        SceneManager.LoadScene(name);

    }
    // method quits game, exit button from menu scene when exit button pressed quits application
    public void QuitGame()
    {
        Application.Quit();
    }
   
}
