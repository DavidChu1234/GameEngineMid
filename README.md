Singleton will be used for many managers of the game like GameManager, SoundManager, and other similar things as they will become the main script that most objects will reference/call to. For the case of the game it will be a Game and Score manager.

Observer checks for changes in the subscribed object and notifies them when something changes. For this it will be the ScoreManager again

Command turns actions into objects allowing us to perform actions from anywhere without knowing what it is. It will be used for the shoot action that the player will perform.
