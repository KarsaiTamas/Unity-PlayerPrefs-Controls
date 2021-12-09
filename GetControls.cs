using System.Collections.Generic;
using UnityEngine;

public class GetControls : MonoBehaviour
{
    //You need this to do UI interactions
    public List<ControlUISetter> uISetters = new List<ControlUISetter>();
    
    void Start()
    {
        //Set up the default controls
        Controls.ControlsStart();
        List<string> keys = new List<string>();
        //Add them to a list so we can work with it
        foreach (var item in Controls.keys)
        {
            keys.Add(item.Key);
        }
        //Get the saved keys from the player Prefs
        foreach (var item in keys)
        {
            
            Controls.keys[item]= (KeyCode)PlayerPrefs.GetInt(item,(int)Controls.keys[item]);
        }
        //Set the UI up to match the controls
        foreach (var item in uISetters)
        {

            item.text.text = Controls.keys[item.control].ToString();
            item.errorMessage.SetActive(false);
        }
    }
    public void ResetControls()
    {
        Controls.ResetToDefault();
        foreach (var item in uISetters)
        {

            item.text.text = Controls.keys[item.control].ToString();
            item.errorMessage.SetActive(false);
        }
        
    }

    
}
