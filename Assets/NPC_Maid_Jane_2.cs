using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Maid_Jane_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Dialog.currentDialog = Dialog.maidDialog4;
            Dialog.ShowText();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
