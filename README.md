# Unity-PlayerPrefs-Controls
<br>Flexible and extendable controls setup.</br>
<br>Just put Controls onto a GameObject.</br>
<br>Drag and drop the gameobject into the Controls Inspector  "Ui Controls Parent" which you want to contain the key binding controls.</br>
<br>Open up the Controls script and on the top you can find the ControlKey enum. You can put here any number of control actions which you need f.e. MoveRight.</br>
<br>Than in the Controls Inspector hit the "Default Keys" drop down and you can just add in every one of your keybindings. You have to open up the elements as well.</br>
<br>In the key binding you can just press lets say "W" and it will search in that lish which pops up when you click on the key binding dropdown.(you can do this with any key)</br>
<br>Than make a new gameObject inside a canvas. Put ControlUI onto it, than you going to need 1 button, 3 texts in this</br>
<br>Key Boundtext going to display your pressed key.</br>
<br>Key Nametext going to display your key press action name.</br>
<br>Error Message going to display an error of your choosing. It just enables the gameobject if you have key conflicts.</br>
<br>In Controls you have a script called ResetControls. It will reset your controls to the default which you set in your Controls GameObject</br>

<br>UseCase f.e: if(Input.GetKey(Controls.keys[ControlKey.Up])){ print("you're hitting the Up key"); }</br>
<br>Included some premade prefabs for faster startup</br>
<br>I put the control handler on top of a scroll view so it keeps it's connections with the UI controls parent, so you should put the scroll view into a canvas</br>



