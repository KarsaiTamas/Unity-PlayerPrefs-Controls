using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlUISetter : MonoBehaviour
{
    //control string should be the same as what you set in Controls
    public string control;
    //Where you set the controls there is 1 button which if you click you can change that 1 control
    public Button b;
    //This is the text which is inside the button
    public Text text;
    //This is just a pop up message for the player
    public GameObject errorMessage;
    //This checks whether or not you interacted with the control setter
    bool isActive=false;
    private void Start()
    {
    //Gives the button the specific interaction so you don't have to put this on each button
        b.onClick.AddListener(() => { ChangeActiveState(); });
    }
    public void ChangeActiveState()
    {
        isActive = !isActive;
        b.interactable = !isActive;
    }
    //We are using OnGUI to check when the player hits any key
    private void OnGUI()
    {
        if (!isActive) return;
        //We are waiting for any key input
        if (Input.anyKey)
        {
            //Get the event if any happened
            Event e = Event.current;
            //Check if the the keybinding already exists
            //if we trying to set the same value reset the activity and return
            if (Controls.keys[control]==e.keyCode)
            {
                isActive = false;
                b.interactable = !isActive;
                return;
            }
            //Than show the error message if we already have this keybinding set up else where
            errorMessage.SetActive(Controls.keys.ContainsValue(e.keyCode));
            //Save the keybinding to a player pref and to the Controls
            PlayerPrefs.SetInt(control,(int) e.keyCode);
            Controls.keys[control] = e.keyCode;
            //Change the UI to reflect the changes
            text.text = e.keyCode.ToString();
            //Reset the activity
            isActive = false;
            b.interactable = !isActive;
        }
        
    }
}
