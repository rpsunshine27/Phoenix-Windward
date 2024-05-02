using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Dialog : MonoBehaviour
{
    public GameObject square;
    //dialogue
    public static string[] playerDialog = new string[]{ 
        "???: Ugh... What Happened", 
        "???: Where am I?", 
        "???: Last thing I remember I was fighting Dark Lord Kilgore",
        "???: I should try to find a way out of this room.",
        ""
    };
    public static string[] doorDialog = new string[]{
        "???: Huh a door. But it's locked.", 
        "???: And magic might not work on it.",
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
        "???: Oof!",
        "????: Oh my! I am terribly sorry miss!",
        "????: That door always gets jammed.",
        "???: It's fine, I actually should be thanking you for help me.",
        "???: Who are you anyway?",
        "Jane: My name is Jane Havelock. I'm a maid here.",
        "Jane: Might I ask who you are?",
        "Phoenix: The name's Phoenix Windward, like the game.",
        "(Cricket noises)",
        "Jane: What game?",
        "Phoenix: Um...",
        "Phoenix: Nevermind about that. Could you tell where I am?",
        "Jane: That is Lord Kilgore's castle of course!",
        "Phoenix: ...",
        "Phoenix: You mean...Your...DARK LORD KILGORE'S MAID?!?", 
        "Jane: Wait... so your not the new maid?",
        "Phoenix: Why would you think I'm the new maid?!?",
        "Jane: Well to be fair you are in a supply closet.",
        "Phoenix: Really? I guess that makes sense.", 
        "Phoenix: But it's the biggest supply closet I've ever seen.",
        "Jane: If your not the new maid...who are you really?",
        "Phoenix: I am Phoenix Windard, a general a part of the Resistance.",
        "Phoenix: And too bad for you but I can't let anyone get in the way.",
        "Jane: Wait I don't think-",
        "...",
        "Jane: -your magic is going to work.",
        "Phoenix: My magic...What happened?",
        "Phoenix: Wait a sec... how do you know I have magic?",
        "Jane: I...um...", 
        "Jane: It's not safe to talk here. Come with me.",
        "Jane: So Kilgore doesn't hear.",
        "Phoenix: *nods* Ok.",
        "Jane: There's a secret trap door in the back.",
        "Jane: I'll meet you on the other side.",
        ""
         };
    public static string[] maidDialog2 = new string[]{
        "Jane: There's a secret trap door in the back",
        "Jane: I'll meet you on the other side.",
        ""
         }; 
    public static string[] maidDialog3 = new string[]{
        "Jane: There you are!",
        "Jane: Follow me, and try your best not to make any noise.",
        "Phoenix: *Nods*",
        ""

        
         
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
        square.active = Global.isDialogShowing;
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // square.active=true;
            Debug.Log("Return key was pressed.");
            playerIndex += 1;
             textbox.text = currentDialog[playerIndex];
            if(currentDialog[playerIndex] == "") {
                // square.active=false;
                Global.isDialogShowing=false; 
                if (Enumerable.SequenceEqual(doorDialog, currentDialog)) {
                    NPC_Maid_Jane_PlayerController.move = true;
                }
            }
        }

    }

    public static void ShowText() {
    //  square.active=true;   
        playerIndex = 0;
        textbox.text = currentDialog[playerIndex];
        Global.isDialogShowing = true;
    }
}
