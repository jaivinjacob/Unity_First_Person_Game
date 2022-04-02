# Unity_First_Person_Game
A first person(perspective) game that is made in unity. The project itself is incomplete, but you can get a thing or two useful from this or some inspiration at the least.


## How to get started

_Sorry for the poor management of files, outsourcing was not on the list when I created the game(sort of)._

There are two charatcers in the scene, __Samurai__, which is the playable character and an __enemy npc__ which he can interact with.

1. list of animations used: under __Assets/__ folder
   - __samurai@Dying.fbx__ (death animation for main character and npc)
   - __samurai@Receive Uppercut To The Face.fbx__ (animation when damage taken/given)
   -  __samurai@Standing Idle.fbx__(standing animation for main character)
   -  __samurai@Walking.fbx__(animation played when movement keys are pressed)
   -  __enemy idle.fbx__(idle animation for enemy)
   -  __enemy.fbx__(the enemy character itself)
   -  __punch.fbx__(animation played when attacked - press mouse1)

2. list of scipt files
   - __SimpleCameraController.cs__ - used to control camera movement in the scene a.k.a freelook. (under Assets/Scripts/)

    All other scripts are located under __Assets/__ folder.
   - __crouchButtonScript.cs__ - used to crouch(reduce the height of player collider) when the assigned key is pressed
   - __Enemy.cs__ - script for npc. used to take damage and die.
   - __FixedTouchField.cs__ - convert half of the screen to touch based camera control(touch input)
   - __flashLight.cs__ - a simple script to turn on and off flashlight, which is a utility in the players hand
   - __joybuttonScript.cs__ - conrtol character via button inputs
   - __mouseLook.cs__ - freelook with mouse
   - __playerCombat.cs__ - script for performing attacks
   - __playermvnt.cs__ - control player movement via keyboard input

Navigate to __Assets/Joystick Pack/Documentation.pdf__ to see the official and full documentation of the joy stick pack I have used.