using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlUISetter : MonoBehaviour
{
    public string control;
    public Button b;
    public Text text;
    public GameObject errorMessage;
    bool isActive =false;
    private void Start()
    {
        b.onClick.AddListener(() => { ChangeActiveState(); });
        enabled = false;

    }
    public void ChangeActiveState()
    {
        isActive = !isActive;
        enabled = isActive;
        b.interactable = !isActive;
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
             
            if (Controls.keys[control]== key)
            {
                isActive = false;
                b.interactable = !isActive;
                enabled = isActive;
                return;
            }
            
            errorMessage.SetActive(Controls.keys.ContainsValue(key));
            PlayerPrefs.SetInt(control,(int)key);
            Controls.keys[control] = key;
            text.text = key.ToString();
            if (text.text.Equals("Return"))
            {
                text.text = "Enter";
            }
            isActive = false;
            enabled = isActive;
            b.interactable = !isActive;

           

        }
        
    }
}
