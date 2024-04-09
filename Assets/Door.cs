using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // If the player collided with the door
        if (other.gameObject.tag == "Player")
        {
            Dialog.currentDialog = Dialog.doorDialog;
            Dialog.ShowText();
        }
    }
}
