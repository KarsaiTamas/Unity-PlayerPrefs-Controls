using System.Collections.Generic;
using UnityEngine;

public static class Controls
{
    //You set up your default keycodes here 
     static KeyCode Up = KeyCode.W;
     static KeyCode Down = KeyCode.S;
     static KeyCode Left = KeyCode.A;
     static KeyCode Right = KeyCode.D;
     static KeyCode Run = KeyCode.LeftShift;
     static KeyCode Roll = KeyCode.Space;
     static KeyCode Interact = KeyCode.F;
     static KeyCode PrimaryAttack = KeyCode.Mouse0;

    public static Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();
    //Add into the Dictionary your keycodes
    public static void ControlsStart()
    {
        keys.Add("Up", Up);
        keys.Add("Down", Down);
        keys.Add("Left", Left);
        keys.Add("Right", Right);
        keys.Add("Roll", Roll);
        keys.Add("Run", Run);
        keys.Add("Interact", Interact);
        keys.Add("PrimaryAttack", PrimaryAttack);
    }
    //Maybe this could be done better
    //But here we just reset the keys in the Dictionary
    //and save it in PlayerPrefs
    public static void ResetToDefault()
    {
        keys["Up"]= Up;
        keys["Down"]= Down;
        keys["Left"]= Left;
        keys["Right"]= Right;
        keys["Run"]= Run;
        keys["Interact"]= Interact;
        keys["PrimaryAttack"]= PrimaryAttack;
        foreach (var item in keys) PlayerPrefs.SetInt(item.Key,(int) item.Value);        
        
    }
}
