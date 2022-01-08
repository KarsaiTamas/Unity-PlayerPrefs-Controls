# Unity-PlayerPrefs-Controls
<br>Flexible and extendable controls setup.</br>
<br>Just put GetControls.cs onto a GameObject.</br>
<br>You need to have as many GameObjects with ControlUISetter.cs on them for every key binding you have.</br>
<br>Set every control string in the ControlUISetter to the same value as you set them in the Controls class and inside the ControlsStart function</br>
<br>f.e if you have keys.Add("Up", Up); in the Controls class' ControlsStart function than make a GameObject put a ControlUISetter onto it and in the Inspector change control string to: Up</br>
<br>It's case and white space sensitive.</br>
<br>After that drag and drop every GameObject which has ControlUISetter on it, into the GetControls GameObject's inspector UISetters, so it can handle set the starting values to the Contol keys from the player prefs, and update the UI text for the keys</br>
<br>You don't have to make these buttons into GetConrols children. It just needs the scripts from the GameObjects.</br>
<br>For GetControls you can make 1 button to reset the key bindings, which you can use ResetControls for it.</br>
<br>example of checking 1 of these controls: if(Input.GetKey(Controlls.keys["Up"])){do stuff} </br>
<br>For all of this to work you need a button, which activates the key checking process, a text which writes out what is this button for, and you use the text inside the button to write out which key the player assigned to it.</br>
