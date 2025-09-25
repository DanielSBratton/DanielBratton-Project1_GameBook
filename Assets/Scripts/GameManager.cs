using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject titleScreen;
    public GameObject startButton;
    public GameObject dialogBox;
    public TMP_Text dialogText;

    public int stage = 0;
    public int dialogIndex = 0;
    public string[] dialog;
    public bool inDialog = false;
    public bool progressed = false;

    private void Start()
    {
        Dialog("start");
        dialogBox.SetActive(false);
    }

    public void Dialog(string location)
    {
        dialogBox.SetActive(true);
        player.GetComponent<Player>().moveable = false;

        switch (location)
        {
            case "Airfield":
                if ( stage <= 1 )
                {
                    dialog = new string[]
                    {
                        "Pilot: There's a stir around town...\nContinue>",
                        "Pilot: Ground is supposedly giving way all 'round it.\nLeave>"
                    };
                    stage = 2;
                }
                else if ( stage == 2 )
                {
                    dialog = new string[]
                    {
                        "Pilot: Nothing here but an desserted airfield.\nLeave>"
                    };
                }
                else if ( stage == 3)
                {
                    dialog = new string[]
                    {
                        "Pilot: You know, this was going to be an international airport. *sigh*\nLeave>"
                    };
                }
                else if (stage == 4)
                {
                    dialog = new string[]
                    {
                        "You: It's more than a rumor...\nContinue>",
                        "Pilot: Seriously?\nContinue>",
                        "You: Serious.\nContinue>",
                        "Pilot: Well alright then, I take it you came here for a reason?\nContinue>",
                        "You: We gotta get out of here...\nContinue>",
                        "Pilot: ...and just how do you plan on doing that?\nContinue>",
                        "You: We build a plane...\nContinue>",
                        "You: ...and you fly it.\nContine>",
                        "Pilot: *chuckles* ...I like your thinking, and I think we can find some parts around.\nContinue>",
                        "You: You're on board then?\nContinue>",
                        "Pilot: You think I'll pass up the chance to show I still got it?\nContinue>",
                        "You: I'll see what I can scrounge up.\nContinue>",
                        "Pilot: I'll do the same here.\nLeave>"
                    };
                    stage = 5;
                }
                else if (stage == 5)
                {
                    dialog = new string[]
                    {
                        "Pilot: I think we need a few more parts.\nleave>"
                    };
                }
                else if (stage == 6)
                {
                    dialog = new string[]
                    {
                        "Pilot: Hey, there we are! Looks like you found enough parts to finish this up!\nContinue>",
                        "You: All thanks to the people of the town!\nContinue>",
                        "Pilot: Good man, let's put it together then!\nContinue>",
                        "*Some time later...*\nContinue>",
                        "You: Alright, that should about do it!\nContinue>",
                        "Pilot: Impressive what you can make in a tight spot.\nContinue>",
                        "You: It ain't much, but it should do the trick.\nContinue>",
                        "Mayor: You really think this'll work?\nContinue>",
                        "You: Do we have a choice?\nContinue>",
                        "Mayor: ...\nContinue>",
                        "Mechanic: Come on! Have some faith, I'm sure this will work!\nContinue>",
                        "Manager: I guess it beats going down with the store...\nContinue>",
                        "Handyman: Quite the handy work you two got there!\nContinue>",
                        "Pilot: Oh please, he did most of the assembly!\nContinue>",
                        "Farmer: I thought it was a crazy plan, but hard work, is honest work son.\nContinue>",
                        "You: Don't give me all the credit, I couldn't have done it without you guys!\nEscape>",
                        "Thank you for playing!\nTo be continued..."
                    };
                    stage = 7;
                }
                    break;
            case "TownHall":
                if (stage == 0)
                {
                    dialog = new string[]
                    {
                        "Mayor: We've got somethin' real bad happening in town.\nContinue>",
                        "Mayor: I don't have many details yet, but from what I've 'eard...\nContinue>",
                        "Mayor: ...things around town are starting to fall into the ground.\nContinue>",
                        "Mayor: Go see if you can find out more about the situation.\nLeave>"
                    };
                    stage = 1;
                }
                else if (stage == 1)
                {
                    dialog = new string[]
                    {
                        "Mayor: You find anything yet?\nContinue>",
                        "You: Not yet.\nLeave>"
                    };
                }
                else if (stage == 2)
                {
                    dialog = new string[]
                    {
                        "Mayor: So, you figure out what's up with the ground?\nContinue>",
                        "You: Yeah, something about a spill in the river...\nContinue>",
                        "You: ...stuff's getting into the banks and turning the ground soft!\nContinue>",
                        "Mayor: Really?\nContinue>",
                        "Mayor: Hmm......\nContinue>",
                        "Mayor: Well you're a bright one, you got any ideas to get us out of this mess?\nContinue>",
                        "You: We could use that airstrip to get out of here...\nContinue>",
                        "Mayor:...and leave our town behind? You do realize this town is people's lives right?\nContinue>",
                        "You: Well of course I do, but that sinking won't stop, there won't be a town left...\nContinue>",
                        "You: ...and us with it if we don't get out of here, we're surrounded.\nContinue>",
                        "Mayor: Hmm, You got a point there, an' the roads are out...\nContinue>",
                        "Mayor: Ok, let's say we go with your plan to use the airstrip.\nContinue>",
                        "Mayor: That airfield hasn't been used in years...\nContinue>",
                        "Mayor: ...we don't have a plane to take off with!\nContinue>",
                        "You: T-Then we make one! I'll build one!\nContinue>",
                        "Mayor: What? *cackles*...\nContinue>",
                        "Mayor: That's ridiculous! You really think you can make a plane? With what parts!?\nContinue>",
                        "Mayor: Come back with a real plan!\nLeave>"
                    };
                    stage = 3;
                }
                else if (stage == 3 )
                {
                    dialog = new string[]
                    {
                        "Mayor: Not you again...\nLeave>"
                    };
                }
                else if (stage == 4 )
                {
                    dialog = new string[]
                    {
                        "You: I will make that plane.\nContinue>",
                        "Mayor: Good luck finding a pilot.\nLeave>"
                    };
                }
                else if (stage == 5 )
                {
                    dialog = new string[]
                    {
                        "Mayor: You can't all be serious.\nContinue>",
                        "You: Come along and you don't have to sink with the town.\nContinue>",
                        "Mayor: ...\nContinue>",
                        "Mayor: ....\nContinue>",
                        "Mayor: Fine, fine, but only if you make a darn good airplane.\nContinue>",
                        "You: You'll see.\nLeave>"
                    };
                    stage = 6;
                }
                else if (stage == 6 )
                {
                    dialog = new string[]
                    {
                        "Mayor: I still don't know how you talked us all into this...\nLeave>"
                    };
                }
                    break;
            case "Mechanic":
                if ( stage <= 1 )
                {
                    dialog = new string[]
                    {
                        "Mechanic: Have you heard the hub-bub around town?\nContinue>",
                        "Mechanic: Things on the edge of town are sinking into the ground.\nContinue>",
                        "Mechanic: I think there's something in the soil, a solvent of some kind.\nContinue>",
                        "Mechanic: Whatever it is, it seems to be disolving the ground, making it like quicksand, but it spreads.\nContinue>",
                        "You: You don't say? Shouldn't we do something about it?\nContinue>",
                        "Mechanic: Need to be sure what we're dealing with first.\nContinue>",
                        "You: I should go tell the mayor.\nLeave>"
                    };
                    stage = 2;
                }
                else if ( stage == 2 )
                {
                    dialog = new string[]
                    {
                        "Mechanic: Let me know if you need anything!\nLeave>"
                    };
                }
                else if ( stage == 3 )
                {
                    dialog = new string[]
                    {
                        "You: That 'solvent' isn't stopping.\nContinue>",
                        "Mechanic: It would seem so, you may be right then.\nContinue>",
                        "Mechanic: We need a plan...\nContinue>",
                        "You: How about a plane?\nContinue>",
                        "Mechanic: You know we don't have a an-\nContinue>",
                        "Mehcanic: Wait... *chuckles* you aren't thinking what I think you are...\nContinue>",
                        "You: We can make one.\nContinue>",
                        "Mechanic: Well I'll be, if Mr. Pilot thinks we can, then I'll help you.\nLeave>"
                    };
                    stage = 4;
                }
                else if ( stage == 4 )
                {
                    dialog = new string[]
                    {
                        "Mechanic: Let me know what Mr. Pilot thinks.\nLeave>"
                    };
                }
                else if ( stage == 5 )
                {
                    dialog = new string[]
                    {
                        "You: 'Mr. Pilot' is in.\nContinue>",
                        "Mechanic: You don't say...\nContinue>",
                        "Mechanic: ...of course he wants an excuse to fly again.\nContinue>",
                        "Mechanic: Alright, I'm game. When you're ready I'll meet you at the airfield with some supplies.\nContinue>",
                        "You: Awesome! I'll see you there!\nLeave>"
                    };
                    stage = 6;
                }
                else if ( stage == 6)
                {
                    dialog = new string[]
                    {
                        "Mechanic: Oh man, I'm excited!\nContinue>",
                        "You: And here I thought you were hesitatant about this plan.\nContinue>",
                        "Mechanic: ...\nLeave>"
                    };

                }
                    break;
            case "GeneralStore":
                if ( stage <= 1 )
                {
                    dialog = new string[]
                    {
                        "Manager: I don't know what has gotten into people these days...\nContinue>",
                        "Manager: ...they think something got in the water and it's gonna make town sink!\nContinue>",
                        "Manager: Anyways, are you going to buy something?\nLeave>"
                    };
                    stage = 2;
                }
                else if ( stage == 2 )
                {
                    dialog = new string[]
                    {
                        "Manager: Store's always open to a paying customer.\nLeave>"
                    };
                }
                else if ( stage == 3 )
                {
                    dialog = new string[]
                    {
                        "You: The town is going to sink, and we need to get out before it takes us with it.\nContinue>",
                        "Manager: You think I'm going to believe you?\nContinue>",
                        "You: You can ask almost anyone in town...\nContinue>",
                        "Manager: Let's say it is true, what do we do?\nContinue>",
                        "Manager: Run around like our heads are cut off?\nContinue>",
                        "You: We can fly.\nContinue>",
                        "Manager: When pigs do!\nLeave>"
                    };
                    stage = 4;
                }
                else if ( stage == 4 )
                {
                    dialog = new string[]
                    {
                        "You: We'll make a plane.\nContinue>",
                        "Manager: You're really stuck on that idea...\nLeave>"
                    };
                }
                else if ( stage == 5 )
                {
                    dialog = new string[]
                    {
                        "You: We're doing it.\nContinue>",
                        "Manager: This again? Listen, if you want to buy some parts for it, you certainly can.\nContinue>",
                        "You: Right, I will.\nContinue>",
                        "Manager: Glad to hear it. If you crash it's not on me.\nLeave>"
                    };
                    stage = 6;
                }
                else if ( stage == 6 )
                {
                    dialog = new string[]
                    {
                        "Manager: ...got everything?\nContinue>",
                        "You: Now I do!\nLeave>"
                    };
                }
                    break;
            case "Handyman":
                if ( stage <= 1 )
                {
                    dialog = new string[]
                    {
                        "Handyman: Hey there! Looking to get something fixed?\nContinue>",
                        "You: No, I actually wanted to ask what's got the town riled up.\nContinue>",
                        "Handyman: Oh well, let's see here...\nContinue>",
                        "Handyman: Oh that's it! Something got into the river from up stream.\nContinue>",
                        "Handyman: Now the ground is giving out on the edge of town...\nContinue>",
                        "Handyman: ...even caused a couple pipes to burst.\nContinue>",
                        "Handyman: Good think we have a water tower.\nContinue>",
                        "You: Thanks for the info!\nContinue>",
                        "Handyman: Come back any time!\nLeave>"
                    };
                    stage = 2;
                }
                else if ( stage == 2 )
                {
                    dialog = new string[]
                    {
                        "Handyman: Something need fixing?\nContinue>",
                        "You: Not right now.\nLeave>"
                    };
                }
                else if ( stage == 3 )
                {
                    dialog = new string[]
                    {
                        "You: I'm back with a plan!\nContinue>",
                        "Handyman: A plan for what? You gonna fix the ground?\nContinue>",
                        "You: No, we'll build a plane and get out of here before it's too late.\nContinue>",
                        "Handyman: Don't we need a pilot?\nContinue>",
                        "You: I'll find one.\nLeave>"
                    };
                    stage = 4;
                }
                else if ( stage == 4 )
                {
                    dialog = new string[]
                    {
                        "Handyman: You aren't thinking of piloting yourself, are you?\nLeave>"
                    };
                }
                else if ( stage == 5 )
                {
                    dialog = new string[]
                    {
                        "You: We have a pilot, the old airfield owner!\nContinue>",
                        "Handyman: I didn't know he was ever a pilot, I suppose that makes some sense.\nContinue>",
                        "Handyman: I'm still skeptical, but I want to see what you can put together.\nContinue>",
                        "Handyman: I'll give you a hand when you want to double down and build this plane.\nContinue>",
                        "You: Thanks for the offer, I'll let you know when!\nLeave>"
                    };
                    stage = 6;
                }
                else if ( stage == 6 )
                {
                    dialog = new string[]
                    {
                        "Handyman: Need a last minute repair?\nLeave>"
                    };
                }
                    break;
            case "Farm":
                if ( stage <= 1 )
                {
                    dialog = new string[]
                    {
                        "Farmer: Hey there son, looking for work?\nContinue>",
                        "You: Not sure there will be much left to work soon.\nContinue>",
                        "Farmer: Ah, you mean the sinking...\nContinue>",
                        "You: What can you tell me about it?\nContinue>",
                        "Farmer: Well, not many know this, but...\nContinue>",
                        "Farmer: ...there's some crazy scientist, has his lab upstream from our little town.\nContinue>",
                        "Farmer: You see how that river splits and goes alll the way around the town?\nContinue>",
                        "Farmer: Well, I think he spilled something...\nContinue>",
                        "Farmer: ...an' that something is making the ground abnormally soft.\nContinue>",
                        "Farmer: Wouldn't be the first time his work hurt the town...\nContinue>",
                        "Farmer: ...best stay back from the outskirts...\nLeave>"
                    };
                    stage = 2;
                }
                else if ( stage == 2 )
                {
                    dialog = new string[]
                    {
                        "Farmer: Here for more stories?\nContinue>",
                        "You: Not right now.\nLeave>"
                    };
                }
                else if ( stage == 3 )
                {
                    dialog = new string[]
                    {
                        "You: We need to get out here, you and I know this town is going under... literally.\nContinue>",
                        "Farmer: How do you plan on that? Roads are out, so we can't drive off.\nContinue>",
                        "You: We'll take off from the airfield.\nContinue>",
                        "Farmer: W-what, you mean like a plane...\nContinue>",
                        "Farmer: ...I would have got a cropduster eventually.\nContinue>",
                        "Farmer: You know, this town was expected to be the next big city, it was good land.\nContinue>",
                        "Farmer: Until that mad scientist's experiment, big accident...\nContinue>",
                        "You: What happened!?\nContinue>",
                        "Farmer: Oh all you need to know is it made all the developers pull out...\nLeave>"
                    };
                    stage = 4;
                }
                else if ( stage == 4 )
                {
                    dialog = new string[]
                    {
                        "Farmer: That scientist's experiment did a number on this town, and my farm...\nLeave>"
                    };
                }
                else if ( stage == 5 )
                {
                    dialog = new string[]
                    {
                        "Farmer: You do know there aren't any planes here right?\nContinue>",
                        "You: We're going to build that plane, can you help?\nContinue>",
                        "Farmer: Tell you what son, if you're willing to put in the hard work...\nContinue>",
                        "Farmer: ...I can see what parts I can give you.\nContinue>",
                        "You: Great! I'll put in the hard work.\nLeave>"
                    };
                    stage = 6;
                }
                else if ( stage == 6)
                {
                    dialog = new string[]
                    {
                        "Farmer: I can tell you all the stories you want once we're out of this mess.\nLeave>"
                    };
                }
                    break;
            case "start":
                dialog = new string[]
                {
                    "Start>"
                };
                break;
        }

        dialogText.text = dialog[dialogIndex];
        inDialog = true;
    }

    private void FixedUpdate()
    {
        if ( inDialog && (Keyboard.current.spaceKey.isPressed || Keyboard.current.enterKey.isPressed || Keyboard.current.escapeKey.isPressed || Mouse.current.leftButton.isPressed) )
        {
            if ( !progressed && (stage < 7 || !(dialogIndex == dialog.Length)) )
            {
                dialogIndex++;
                if ( dialogIndex == dialog.Length )
                {
                    inDialog = false;
                    dialogText.text = string.Empty;
                    dialog = new string[] { };
                    dialogIndex = 0;
                    dialogBox.SetActive(false);
                    startButton.SetActive(false);
                    titleScreen.SetActive(false);
                    player.GetComponent<Player>().moveable = true;
                }
                else
                {
                    dialogText.text = dialog[dialogIndex];
                }
                progressed = true;
            }
        }
        else
        {
            progressed = false;
        }

        if ( stage == 7 && dialogIndex + 1 >= dialog.Length)
        {
            titleScreen.SetActive(true);
            inDialog = false;
        }
    }
}
