using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    
    public void QuitToMenu()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
