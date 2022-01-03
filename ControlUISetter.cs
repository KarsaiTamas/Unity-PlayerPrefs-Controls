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
            if (Controlls.keys[control]==e.keyCode)
            {
                isActive = false;
                b.interactable = !isActive;
                enabled = isActive;
                return;
            }
            errorMessage.SetActive(Controlls.keys.ContainsValue(e.keyCode));
            PlayerPrefs.SetInt(control,(int) e.keyCode);
            Controlls.keys[control] = e.keyCode;
            text.text = e.keyCode.ToString();
            isActive = false;
            enabled = isActive;
            b.interactable = !isActive;
        }
        
    }
}
