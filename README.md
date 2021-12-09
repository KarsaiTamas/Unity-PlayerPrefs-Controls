# Unity-PlayerPrefs-Controls
<br>Flexible and extendable controls setup.</br>
<br>Just put GetControls.cs onto a GameObject.</br>
<br>And put a ControlUISetter.cs onto a Button for each Control which you need.</br>
<br>Set the control string to the same which you set for Controls.ControlsStart</br>
<br>f.e if you have keys.Add("Up", Up); than make a button put on a ControlUISetter and in the Inspector change control to: Up</br>
<br>It's case and white space sensitive.</br>
<br>After that drag and drop every button which has ControlUISetter on, into the GetControls GameObject's inspector UISetters, so it can handle the scripts</br>
<br>You don't have to make these buttons into GetConrols children. It just needs the scripts from the buttons.</br>
<br>For GetControls you can make 1 button to reset the key bindings, which you can use ResetControls for it.</br>
