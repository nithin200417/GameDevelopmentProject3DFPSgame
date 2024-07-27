# FPS Shooter Game

Welcome to the FPS Shooter Game! This is a first-person shooter game with multiple levels, various pick-up items, and a scoring system. The game is designed to provide an exciting and challenging experience with different states and features.

## Features

1. **End Goal**: Complete all the levels (currently two levels implemented).
2. **Gun Pickup**: Available at the start of every level along with various other pick-up items.
3. **Mag Pickup**: Increases the ammo.
4. **Health Can Pickup**: Increases the health.
5. **Extra Life Pickup**: Adds another life.
6. **Game Over State**: Triggered when all lives are depleted.
7. **Score System**: Increments when an enemy is defeated or gold is collected.

## Game States

1. **Main Menu State**:
   - The first scene in the game where the player can choose to start or quit the game.

2. **Level 1**:
   - Initiated by the `newGame()` function call after selecting "New Game" in the main menu.
   - Features one extra life, three enemies, and gold.
   - Includes a locked door that can be unlocked with a key found within the level.

3. **Floor Complete State**:
   - Retrieves information from `GlobalScore`, `GlobalHealth`, and `GlobalComplete` scripts and displays it in the UI.
   - Displays the time taken to complete the level.

4. **Respawn or Level Recycle State**:
   - Displayed when the player loses a life but has remaining lives.
   - Helps the player restart from the beginning of the level, reducing the player's lives.

5. **Level 2**:
   - Increased difficulty with more enemies and a different level map.
   - Includes features from Level 1.
   - Completion of this level triggers the Victory or Game Over state.

6. **Victory State**:
   - Triggered by the `floorComplete()` script when the player successfully reaches the end of Level 2.

7. **Game Over State**:
   - Reached when all player lives are depleted.
   - Displays a "Game Over" message on the canvas.

## Scripts

1. **DoorOpenFirst**: Animates the doors (locked and unlocked) using Unity animations.
2. **PlayerCasting**: Implements RayCasting for action sequences with enemies.
3. **RemoveFlash**: Removes unnecessary flash panel (debugging process).
4. **SoldierAI**: Defines enemy AI, damage done by the enemy, and other enemy properties.
5. **EnemyDeath**: Defines enemy health and increases the score when an enemy is defeated.
6. **ExtraLife**: Increments lives when an extra life is picked up by the player.
7. **FullHealthCollect**: Increments player health when a food can is collected.
8. **GoldCollect**: Increments score upon collecting gold.
9. **MainMenuControl**: Adds functionality to the buttons in the MainMenuScene.
10. **FloorTimer**: Implements the timer to keep track of the time.
11. **GlobalComplete**: Tracks the number of enemies killed and initiates the `nextFloor` variable for scene navigation.
12. **GlobalHealth**, **GlobalLife**, **GlobalScore**: Implement health, lives, and scores for the player and render them on the screen.
13. **RecycleLevel**: Resets the score and enemy count when the player dies and helps navigate to the level after player death.
14. **GlobalAmmo**: Tracks the overall ammo collected by the player.
15. **HandgunFire**: Implements raycasting for handgun firing for both player and enemy.
16. **FloorComplete**: Helps navigate from one level to another upon level completion.
17. **FirstKeyA**: Unlocks the locked door and helps the player navigate through it.

## Asset Packs Used

1. **DigitalKonstruct Pack**: For food cans.
2. **Medieval Gold Pack**: For gold.
3. **Futuristic Soldier Pack**: For the soldier.
4. **Survival Pack**: For basic enemy prefabs.
5. **Mega Fantasy Props Pack**: For tables and barrels.
6. **Models**: For the key.

These packs are imported from the asset store for the usage of the prefabs.

## Getting Started

To play the game, clone the repository from GitHub, open the project in Unity, and start playing!

Enjoy the game and have fun!

---

Feel free to modify the game and contribute to its development. Pull requests are welcome!
