# Hackathon2017VRGame

<p align="center">
  <b>Hackathon2017VRGame</b><br>
  <a>YouTube Video Presentation & Demo: https://youtu.be/QPoTa5yRss</a>
  <br><br>
</p>
John Chen and I's submission for the WSU 5th annual Hackathon: Crimson Code 2017.
We created a "Fruit Ninja"-like VR game developed with Unity and written in C#.

Developed on a VR-ready machine with Unity and C# in Visual Studio with and for the HTC Vive VR Headset.

####Project Proposal 
* A family-friendly virtual reality game for the HTC Vive VR Headset
  * Fast paced
  * Highly interactive
  * Takes advantage of both “hand” controllers (Dual-wielding)
* Player tries to slice as many fruit as possible

####Steps Taken 
* Unity: Manipulated 3D assests
  * SteamVR plugin: to ensure compatibility with target device (HTC Vive)
* Visual Studio: C# code handled logic
  * Four different fruit assets being inside a random array
  * ”SpawnScript” will shoot out fruit assets every second using vector3D
  * “CollisionScript” will be called when the katana collides with fruit at a certain velocity.

####Collision & Gameplay Video Demo
* Please see YouTube link above
