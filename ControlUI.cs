using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlUI : MonoBehaviour
{
    public ControlKey control;
    public Button button;
    public Text KeyBoundText;
    public Text KeyNameText;
    public GameObject errorMessage;
    bool isActive = false;
    private void Start()
    {

        button.onClick.AddListener(() => { ChangeActiveState(); });
        enabled = false;

    }
    public void ChangeActiveState()
    {
        isActive = !isActive;
        enabled = isActive;
        button.interactable = !isActive;
    }

    private void OnGUI()
    {
        if (!isActive) return;

        if (Input.anyKey)
        {
            Event e = Event.current;
            KeyCode key = e.keyCode;
            //This is for all mouse buttons
            //for some reason Event can't get every mouse button
            //also it doesn't even know when I click with the mouse
            //it recognizes it as an event but not as a mouse event
            for (int i = (int)KeyCode.Mouse0; i <= (int)KeyCode.Mouse6; i++)
            {
                if (Input.GetKey((KeyCode)i))
                {
                    Debug.Log(i);
                    key = (KeyCode)i;
                    break;
                }
            }

            if (Controls.keys[control] == key)
            {
                isActive = false;
                button.interactable = !isActive;
                enabled = isActive;
                return;
            }
            
            PlayerPrefs.SetInt(control.ToString(), (int)key);
            Controls.keys[control] = key;
            Controls.FlagDublicates();
            KeyBoundtext.text = key.ToString().Equals("Return")? "Enter":key.ToString();
            isActive = false;
            enabled = isActive;
            button.interactable = !isActive;



        }

    }
}
