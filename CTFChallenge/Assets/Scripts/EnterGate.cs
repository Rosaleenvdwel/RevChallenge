using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGate : MonoBehaviour
{
    string sceneToLoad;
    bool playerIsClose;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (collision.CompareTag("Player"))
        {
            playerIsClose = true;
            if (currentScene.name == "SampleScene")
            {
                sceneToLoad = "nextStage";
            }
            else 
            {
                sceneToLoad = "SampleScene";
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    
}
