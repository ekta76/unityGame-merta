using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTutorial : MonoBehaviour
{
    private bool levelCompleted = false;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
