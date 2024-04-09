using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Dialog : MonoBehaviour
{
    //dialogue
    public static string[] playerDialog = new string[]{ 
        "???: Ugh... What Happened", 
        "???: Where am I?", 
        "???: Last thing I remember I was fighting Dark Lord Kilgore",
        "???: I should try to find a way out of this room",
        ""
    };
    public static string[] doorDialog = new string[]{
        "???: Huh a door.",
        "???: Maybe if I yell for help, someone might hear me.",
        "???: *Inhales*", 
        "???: LeT mE oUt Of HeRe!!!",
        "...",
        "????: Oh my goodness!",
        "????: Is someone stuck in there?",
        "????: Hang on, let me unlock the door for you.",
        "(Unlocking door noises)",
        ""
    };
    public static string[] maidDialog = new string[]{
         
    };
    public static string[] currentDialog = null;
    private static int playerIndex = 0;

    private static TMPro.TextMeshProUGUI textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<TMPro.TextMeshProUGUI>();
        currentDialog = playerDialog;
        ShowText();
        // Debug.Log(playerDialog[playerIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
            playerIndex += 1;
             textbox.text = currentDialog[playerIndex];
            if(currentDialog[playerIndex] == "") {
                Global.isDialogShowing=false; 
                if (Enumerable.SequenceEqual(doorDialog, currentDialog)) {
                    NPC_Maid_Jane_PlayerController.move = true;
                }
            }
        }

    }

    public static void ShowText() {
        playerIndex = 0;
        textbox.text = currentDialog[playerIndex];
        Global.isDialogShowing = true;
    }
}
