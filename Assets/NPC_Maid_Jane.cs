using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Maid_Jane : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Dialog.currentDialog = Dialog.maidDialog3;
            Dialog.ShowText();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Dialog.currentDialog[Dialog.playerIndex] == "") {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
            }
    }
}
