**This game is a FPS shooter game here i have implementedd several features :**
    1.End Goal being able to complete all the levels here i have added two levels
    2.The Player has gun pickup at the start of every level and added many pickup items for the player to utilize.
    3.The mag pickup increases the ammo and health can pickup will increase the health and extra life pickup will add another life.
    4.If all the lives are depleted then the player will be defeated and the game over state will be displayed.
    5.A score total is also kept track of which increments when we defeat an enemy or collect some gold.
The various states implemented in the game are:
    1.Main Menu State:
        Here the first scene in the game where the player can choose to start or quit the game.
    2.Level 1:
       It is the first scene after the New game is selected in the main menu by the void newGame() funciton call it will be started.The first level has one extra life and 3 enemies and gold.It also has a locked door which also has a key when picked up will be displayed on to the screen.With the key being taken to the locked door we can move to the next level. 
    3.Floor Complete State:
       The floor complete state was used to retrive information from the GlobalScore, GlobalHealth, GlobalComplete scripts and display them in the UI and also takes timer value and dsiplays the time.
    4.Respawn or LevelRecycle State:
       Intermediate state which will only be displayed when the player loses and has some more lives in him.It will be helping the player to restart from the beginning in turn reducing the lives of the player.
    5.Level 2
       The level 2 has slight increase in difficulty and added more enemies and changed the level map and also implements every other feature in the level 1 on the complete of level 2 victory or Gameover state are decided.
    6.Victory State
       This is a scene after the complete of the level 2 it will be triggered by the floorComplete() script and when player successfully reaches the end of the level it will be triggered.
    7.GameOver State
       This state is reached when all the lives of the player are depleted and has no more lives this will end the game by displaying a message on to the canvas.
Scripts:
    1.DoorOpenFirst:It is the script used to animate the doors of the levels locked and the unlocked which uses the animations in unity.
    2.PlayerCasting:It is the script used to implement the RayCasting which we have used for the implementation of the action sequences with the enemies.
    3.RemoveFlash:It is a script which was used to remove unnecessary flash panel which will be rendered it is the part of the debugging process.
    4.SoldierAI:It is the script which was used to define the Enenmy AI the game which defines the damage done by the enemy and all the other properties of the enemy.
    5.EnemyDeath:This script was used to define the health of the enemy and make our game increase the score when enemy is dead.
    6.ExtraLife:This script was used to increment the lives when extralife was taken by the player.
    7.FullHealthCollect:This script was used to increment the health of the player when taken a food can in the level.
    8.GoldCollect:This script was used to increment the score upon collecting the gold in the level.
    9.MainMenuControl:This script was used to add functionality to the buttons which are used in the MainMenuScene and implement the corresponding functions of the buttons.
    10.FloorTimer:This is used to implement the timer in the game and to keep track of the time.
    11.GlobalComplete:This keeps track of the no.of enemies the player has killed and sends that to the floorcomplete state and also initiates the nextFloor variable which helps for the navigation between the scenes.
    12.GlobalHealth, GlobalLife, GlobalScore:All these implement the health, lives, scores for the player and render them to the screen.
    13.RecycleLevel:whenever the player dies this resets the score and enemycount for the player and helps player navigate to the level after death of the player.
    14.GlobalAmmo:Keeps track of the overall ammo collected and kept by the player.
    15.HandgunFire:This script was used to implement the raycasting to implement the hand gun firing for both player and enemy alike.
    16.FloorComplete:This script helps the player to navigate from one level to other upon the completion of the level in the sense reaching the end of the level and helps for the navigation of the entire game between the scenes.
    17.FirstKeyA:This script takes care of the task of the unlocking the locked door and help player navigate through it.
Packs used:
    1.DigitalKonstruct pack(for food can)
    2.Medeival gold pack(for gold)
    3.Futuristic soldier pack(for the soldier)
    4.Survival pack(for basic eminity prefabs)
    5.Mega Fantasy props pack(for the tables and barrels)
    6.Models(for the key)
    These packs are imported from the asset store for the usage of the perfabs.
