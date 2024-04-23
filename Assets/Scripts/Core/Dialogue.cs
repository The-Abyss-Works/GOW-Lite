using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script stores every dialogue conversation in a public Dictionary.*/

public class Dialogue : MonoBehaviour
{

    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //Door
        dialogue.Add("LockedDoorA", new string[] {
            "A large door...",
            "Looks like it has a key hole!"
        });


        dialogue.Add("LockedDoorB", new string[] {
            "Key used!"
        });

        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Father!!",
            "You're Back!",
            "A man Came to Find You...",
            "...I've sent him to the Back Forest",
            "He looked Dangerous"
        });

        dialogue.Add("CharacterAChoice1", new string[] {
            "",
            "",
            "A man?",
        });

        dialogue.Add("CharacterAChoice2", new string[] {
            "",
            "",
            "Where is he?"
        });

        dialogue.Add("CharacterB", new string[] {
            "Hey! You found 80 coins! That means 'npcB' is now being used inside 'Dialogue.cs'!",
            "After my dialogue completes, I'll take 80 coins, or however many you specify in the inspector...",
            "And I'll also give you a new ability!",
            "In this case, how about a generic DOWNWARD SMASH? Simply attack while pressing down in mid-air!"
        });

        dialogue.Add("Start", new string[] {
            "*Sigh*",
            "It's a note?",
            "*It's a Note By Atreus*",
            "...Father, I've Already Went back to the hut",
            "Come soon"
        });

        dialogue.Add("Start2", new string[] {
            "*Hmm*",
            "I feel like something is goingg to happen",
            "Let me Get back to the hut First"
        });

        dialogue.Add("Quest", new string[] {
            "Get Back To Atreus",
        });



    }
}
