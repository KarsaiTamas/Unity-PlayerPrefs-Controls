using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public enum ControlKey
{
    Up,
    Down,
    Left,
    Right,
    Interact
}

[System.Serializable]
public class KeyHolder
{
    public ControlKey keyName;
    public KeyCode keyBinding;
    
    public KeyHolder(ControlKey keyName, KeyCode keyBinding)
    {
        this.keyName = keyName;
        this.keyBinding = keyBinding;
    }
}
public class Controls: MonoBehaviour
{
    //You need this to do UI interactions
    [HideInInspector]
    public static List<ControlUI> uISetters = new List<ControlUI>();
    public Transform uiControlsParent;
    public List<KeyHolder> defaultKeys;
    public ControlUI controlUIPrefab;

    public static Dictionary<ControlKey, KeyCode> keys = new Dictionary<ControlKey, KeyCode>();

    void Start()
    {
        Setup();
    }
    private void Setup()
    {
        foreach (var item in defaultKeys)
        {
            keys.Add(item.keyName, (KeyCode)PlayerPrefs.GetInt(item.keyName.ToString(), (int)item.keyBinding));
            var conUI=  Instantiate(controlUIPrefab, uiControlsParent);
            conUI.KeyBoundtext.text = keys[item.keyName].ToString().Equals("Return")? 
                "Enter": keys[item.keyName].ToString();
            conUI.KeyNametext.text = item.keyName.ToString();
            conUI.control = item.keyName;
            uISetters.Add(conUI);
        }
    }
    public void ResetControls()
    { 
        keys.Clear();
        foreach (var item in defaultKeys)
        {
            keys.Add(item.keyName, item.keyBinding);
        }
        foreach (var item in keys) PlayerPrefs.SetInt(item.Key.ToString(), (int)item.Value);

        foreach (var item in uISetters)
        {
            item.KeyBoundtext.text = keys[item.control].ToString().Equals("Return") ?
                "Enter" : keys[item.control].ToString();
            item.errorMessage.SetActive(false);
        }

    } 
    public static void FlagDublicates()
    {
        foreach (var item in uISetters)
        {
            int i = 0;
            foreach (var item2 in keys)
            {
                if (item2.Value==keys[item.control]) i++;
                item.errorMessage.SetActive(i > 1);
            }
        }
    }
    
}
