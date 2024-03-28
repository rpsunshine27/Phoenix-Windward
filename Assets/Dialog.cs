using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    //dialogue
    private string[] playerDialog = new string[]{ 
        "???: Ugh... What Happened", 
        "???: Where am I?", 
        "???: Last thing I remember I was fighting Dark Lord Kilgore"
    };
    private string[] doorDialog = new string[]{
        "???: *Inhales* LET ME OUT OF HERE!!!"
    };
    private string[] maidDialog = new string[]{
        "Phoenix: My name is Phoenix Windward" 
    };
    private string[] currentDialog = null;
    private int playerIndex = 0;

    private TMPro.TextMeshProUGUI textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<TMPro.TextMeshProUGUI>();
        currentDialog = this.playerDialog;
        Debug.Log(playerDialog[playerIndex]);
        textbox.text = playerDialog[playerIndex];
       
        // Debug.Log(playerDialog[playerIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
            playerIndex += 1;
             textbox.text = playerDialog[playerIndex];
        }

    }
}
