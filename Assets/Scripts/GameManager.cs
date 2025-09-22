using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

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

    public void Dialog(string location)
    {
        dialogBox.SetActive(true);
        player.GetComponent<Player>().moveable = false;

        switch (location)
        {
            case "Airfield":
                if (stage == 0)
                {
                    titleScreen.SetActive(true);
                    dialog = new string[] { "Thank you for playing!  To be continued..." };
                }
                break;
            case "TownHall":
                if (stage == 0)
                {
                    dialog = new string[] { "Town meetings every Saturday!" };
                }
                break;
            case "Mechanic":
                if (stage == 0)
                {
                    dialog = new string[] { "No gas." };
                }
                break;
            case "GeneralStore":
                if (stage == 0)
                {
                    dialog = new string[] { "Closed for self care day" };
                }
                break;
            case "Handyman":
                if (stage == 0)
                {
                    dialog = new string[] { "Out repairing something." };
                }
                break;
            case "Farm":
                if (stage == 0)
                {
                    dialog = new string[] { "Zzzzzz" };
                }
                break;
        }

        dialogText.text = dialog[dialogIndex];
    }

    private void FixedUpdate()
    {

        if (Keyboard.current.spaceKey.isPressed || Keyboard.current.enterKey.isPressed || Keyboard.current.escapeKey.isPressed || Mouse.current.leftButton.isPressed)
        {
            if (dialogIndex == 0)
            {
                dialogText.text = string.Empty;
                dialogBox.SetActive(false);
                startButton.SetActive(false);
                titleScreen.SetActive(false);
                player.GetComponent<Player>().moveable = true;
            }
            else
            {
                dialogIndex--;
                dialogText.text = dialog[dialogIndex];
            }
        }
    }
}
