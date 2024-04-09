using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Maid_Jane_PlayerController : MonoBehaviour
{
    public static bool move = false;
    public float speed = -0.01f;
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
        }
        
    }
}
