# FPS-Delux

This is an FPS game being made for a programming class for school. 

it has will have basic movement, shooting and granade functions

The game is not done and it will be updated later. The game is functioning so you can move around shoot and
throw granades and try it out but the granades doesn't have an explosion yet

Features

--------

- Basic movement function

- Basic fire and partially grenade functions

- Main- and Pause menu function



Set up

------------

  1.import project

  2.run it in Unity 5.5.1f1





Contribute

----------

You can contribute by adding explosion animation and physics for the granade, online and multiplayer capabilities.
you can also add whatever you think should be in the game



Upcoming features

--------

- Grenade physics will be added

- Network functions will be added on

- more maps will be added



Code example

-------

here some code from characterControll.cs



        float rotationhogervanster = Input.GetAxis ("Mouse X") * mouseSpeed;
		transform.Rotate (0, rotationhogervanster, 0);

		rotationuppner -= Input.GetAxis ("Mouse Y") * mouseSpeed;
		rotationuppner = Mathf.Clamp (rotationuppner, -lasvinkel, lasvinkel);
		Camera.main.transform.localRotation = Quaternion.Euler(rotationuppner, 0, 0);

		// Updatering variabeln
		float speedForward = Input.GetAxis("Vertical") * movementSpeed;
		float speedSideStep = Input.GetAxis("Horizontal") * movementSpeed;


		acceleration += Physics.gravity.y * Time.deltaTime;

		if (cc.isGrounded && Input.GetButton ("Jump")) 
		{
			acceleration = JumpForce;
		}


Support

-------

If you are having issues, please let me know at rasmus.eriksson324@gmail.com



License

-------

The project is licensed under the GNU 3.0 license.
