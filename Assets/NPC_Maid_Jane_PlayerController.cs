using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Maid_Jane_PlayerController : MonoBehaviour
{
    public static bool move = false;
    public float speed = -0.1f;
    private int dialogCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (move) {
            transform.position = new Vector2(
                transform.position.x,
                transform.position.y + speed 
            );
            if (transform.position.y <= 2.396174) {
                
            }
        }
        
    } 
    private void OnCollisionEnter2D(Collision2D other)
    {
        // If the player collided with the door
        if (other.gameObject.tag == "Player")
        {move = false;
        if (dialogCount ==0) {
            Dialog.currentDialog = Dialog.maidDialog;
            Dialog.ShowText();
            dialogCount = 1;
        } else {
            Dialog.currentDialog = Dialog.maidDialog2;
            Dialog.ShowText();
        }
        }
    }
}
