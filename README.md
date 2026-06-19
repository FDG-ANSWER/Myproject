# Robot Escape
## Student Information
**Student Name:** Sihan Huang  
**Student ID:** 2617639  
**Module:** Game Programming  
**Project Type:** Unity 2D Platform Game Vertical Slice  
## GitHub Repository
Repository link:https://github.com/FDG-ANSWER/Myproject
Final visible commit:
```text
13fafb7 - Upload Unity project
Project Description
Robot Escape is a 2D Unity platform game vertical slice. The player controls a robot character through a platform level, collects energy cores, avoids patrol enemies and laser traps, and reaches the exit door to complete the level.
The game focuses on demonstrating a clear playable experience with movement, jumping, collectibles, hazards, enemy behaviour, win and lose conditions, and UI feedback.
Game Objective
The main objective is to collect the required energy cores and then reach the exit door.
The player must avoid patrol enemies and laser traps. If the player touches an enemy or laser trap, the Game Over panel appears and the level can be restarted.
The exit door only completes the level after the required number of energy cores has been collected.
How to Open the Unity Project
Download or clone this repository.
Open Unity Hub.
Click Add project from disk.
Select the project folder.
Open the project using the correct Unity version.
Open the main scene from the Assets folder.
Press Play in the Unity Editor.
The repository contains the main Unity project folders:
Assets
Packages
ProjectSettings
.gitignore
Unnecessary Unity folders such as Library, Temp, Obj, and Logs are not included.
How to Run the Playable Build
The playable build is submitted separately as:
2617639_CW2_FinalGameBuild.zip
To run the game:
Download the zip file.
Unzip the file.
Open the build folder.
Run the .exe file.
Keep the .exe file and the accompanying _Data folder in the same folder.
Do not remove the Data folder, because it is required for the game to run correctly.
Main Features
2D player movement
Jumping
Camera follow system
Energy core collectibles
Energy core counter
Patrol enemy behaviour
Laser trap hazards
Exit door condition
Game Over panel
Win panel
Restart button
Next Level button
Collision and trigger interactions
Basic game state management
Main Scripts and Systems
The main systems/scripts created for this project include:
Player movement system
Camera follow system
GameManager script
PatrolEnemy script
EnergyCore script
ExitDoor script
LaserTrap script
Main Menu UI system
Game Over UI system
Win Panel UI system
Restart button logic
Next Level button logic
Collision and trigger interaction system
Energy core collection counter
Level completion logic
Development Summary
The project started as a simple 2D movement prototype. The first goal was to make the player move and jump correctly.
After that, I added a camera follow system to improve the player experience. I then added collectible energy cores to give the player a clear objective.
The project became more complete after adding patrol enemies and laser traps as hazards. These systems created a lose condition and made the game more challenging.
Later, I added the exit door logic so that the player could only complete the level after collecting enough energy cores.
In the final stage, I added UI panels such as Game Over and Win panels, as well as Restart and Next Level button logic.
Testing
The game was tested in Unity Play Mode. The following areas were tested:
Player movement
Jumping
Camera follow
Energy core collection
Enemy collision
Laser trap collision
Exit door condition
Game Over panel
Win panel
Restart button
Next Level button
Complete playthrough from start to finish
No major game-breaking issues are currently known after testing.
Known Issues and Limitations
The game is a small playable vertical slice, not a full game.
The level content is limited.
Enemy AI is simple and uses patrol behaviour.
Camera movement could be improved with smoother movement and better boundaries.
Visual and audio polish could be improved.
More levels, animations, sound effects, and enemy types could be added in the future.
External Assets, Templates, Tutorials, and AI Declaration
AI Support
I used ChatGPT and DeepSeek as AI support during development.
AI support helped with:
Writing and improving the camera-following script
Explaining the overall Unity C# script structure
Adding clear comments to scripts
Understanding how the GameManager, enemy, energy core, exit door, laser trap, and UI panels work together
Improving documentation and report writing
The AI output I used included:
A camera script for following the player
Script structure suggestions
Code comments
Explanations of the main gameplay systems
Documentation support
I adapted the AI suggestions to fit my own Unity scene, object names, tags, colliders, UI panels, and gameplay requirements. I also tested the scripts in Unity and made changes where needed.
Build Information
Build platform:
Windows PC
Playable build submitted as:
2617639_CW2_FinalGameBuild.zip
Demo / Presentation
The demo will show:
Player movement and jumping
Camera follow
Energy core collection
Patrol enemy hazard
Laser trap hazard
Game Over and Restart
Exit door condition
Win panel / level completion
Thanks to the nonamed creators in the webs of the material：
craftpix.net
aigei.com
