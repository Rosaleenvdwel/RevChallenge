using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has collided with the stone gate
        if (other.CompareTag("Player"))
        {
            // Load the second scene
            SceneManager.LoadScene("nextStage");
        }
    }
}

