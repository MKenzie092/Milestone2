using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public void NewLevelButton(string newlevel)
    {
        SceneManager.LoadScene(newlevel);
    }
    public void ExitGameButton()
    {
        Application.Quit();
    }
}
