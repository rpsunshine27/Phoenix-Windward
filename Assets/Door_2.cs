using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // If the player collided with the door
        if (other.gameObject.tag == "Player" || other.gameObject.tag ==  "NPC: Maid Jane")
        {
            // Load the next scene
            // The buildIndex is from the Build Settings
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            int nextScene = currentScene + 1;
            SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
        }
    }
}