# maxwellsdemons
Dungeon Crawler about a demon collecting atoms based on the works of James Clerk Maxwell.

This is a very early stage project. Implemented right now:
Basic:
  - Movement
  - Dialogue
  - Item collection
  - Menus
  - Movement between scenes

# To Do
# Characters
## Maxwell - Main Character
  - Functionality
    - Walk
    - Jump
    - Attack
    - Collect Atoms
    - Talk to npcs
    - Enter buildings
    - Die
    - Heal
    - Play minigames
    - Have companion
    - Dialogue
  - Art
    - Idle
    - Walk
    - Jump
    - Attack
    - Roll
    - Cast Spells
    - Heal
    - Fire
    - Push
    - Arrow
    - Look up (Dialogue)
    - Happy Dance
    - Death
    - Sad look
    - Dialogue Sprites
    - Interact button
## Zoska - Scientist
  - Functionality
    - Make/Break Atoms
    - Dialogue
    - Art
    - Hal - Historian
    - Functionality
    - Log atoms found
    - Learn about atoms
    - Lore
    - Dialogue
  - Art
## Newt - Collector/Companion
  - Functionality
    - Dialogue
    - Follow Player
    - Attack Enemies
    - Collect Atoms
  - Art
## Curio - Quest Giver
  - Functionality
    - Pick up randomly generated quests
      - Make this more like the stardew guild quests?
    - Dialogue
  - Art
## Bob - Shopkeeper
  - Functionality
    - Buy:
      - Weapons
      - Sheilds
      - Spells
      - Potions
      - Upgrades
    - Dialogue
  - Art
## Hal - Museum Curator
  - Functionality
    - Atom Log
    - Atom History
    - Molecule History
  - Art
## Atomy - Pet/Companion
  - Functionality
    - Dialogue
    - Follow Player
    - Attack Enemies
    - Collect Atoms
  - Art
Enemies - Enemies
- Functionality
  - Dialogue
  - Attack Player
  - Eat atoms/molecules
  - Spawn in dungeon
- Art

# Buildings
## Town
- Functionality
  - Enter different buildings/caverns
  - Talk to npcs
- Art
  - Buildings
  - River
  - Invisible walls
## Home
- Functionality
  - Sleep
  - Save
  - Place Furniture
- Art
  - Building
  - Furniture
  - Invisible walls
## Lab
- Functionality
  - Make/Break Atoms
- Art
  - Building
  - Invisible walls
## Museum
- Functionality
  - Log atoms found
  - Learn about atoms
  - Lore
- Art
  - Building
  - Invisible walls
## Bursar
- Functionality
  - Buy:
    - Weapons
    - Sheilds
    - Spells
    - Potions
    - Upgrades
- Art
  - Building
  - Invisible walls
## Quest Shop
- Functionality
  - Pick up randomly generated quests
- Art
  - Building
  - Invisible walls
## Caverns
- Functionality
  - Randomly generated rooms
  - Spawn Enemies
  - Spawn Atoms
- Art
  - Tilemaps

# Menus
## Start
- Functionality
  - New Game
  - Start Game
  - Options
  - Credits
  - Quit
  - Background showing off player
- Art
  - Title
  - All buttons
  - Background
## Pause
- Functionality
  - Resume
  - Stats
  - Inventory
  - Quests
  - Save
  - Load
  - Options
  - Return to Town
    - Dungeon Only
  - Quit to Menu
- Art
## Options
  - Functionality
    - Volume
    - Brightness
    - Difficulty
    - Keybinds
  - Art

# Characters
- Max - Main Character
- Zoska - Scientist
- Hal - Historian
- Newt - Collector/Companion
- Curio - Quest Giver
- Bob - Shopkeeper
- Atomy - Pet/Companion

# Locations
## Cave
This is max’s home which you can customize with things you buy from the demon bursar:
  - Paint
  - Furniture
  - Extra rooms
works on a grid system with different items taking up different amounts of space

## Town
The town is filled with buildings you can go into specifically
	
## Lab
You can combine atoms to create new molecules

## Museum
You can talk to Hal the Historian to find out interesting facts about the elements you collect and different scientists. This is also where you fill up the periodic table. Once a row of the periodic table is filled you complete the level.

## Bursar
Here you can exchange molecules for money and go to different shops for paint, furniture, expansions, windows/doors, new weapons, etc…

## Quest Shop
Curio gives you different quests for atoms, molecules, items/people lost is the caverns, etc…

## Caverns Entrance
This is where your companions hang out along with the other young demons delegated to gathering atoms. You can choose the level of the caverns that you want to descend to.

## Caverns
- Level 1: First row of the periodic table. Nothing here can kill you but the bugs can pick up molecules then disappear so you have to get to the molecules fairly fast. Two chambers, the initial one and one that is discovered after max notices that there isn’t any helium in the chamber only hydrogen which occurs after he goes to the five big stones in the room to collect the hydrogen. He then notices a crack in the wall which breaks open revealing the second larger chamber which holds all the helium. You notice that the entrance was blocked by what looks like the same material the bugs are making their hives out of.
- Level 2: Second row of the periodic table. Things can hurt you now but will generally ignore you. Eight chambers, four normal chamber and four more hidden by the ‘sap’ the bugs use to build.
- Level 3: Third row of the periodic table. Things can hurt you and will try to steal you atoms if you get to close. Gain Newt as a companion at completion. Eight chambers, six open two blocked
- Level 4: Fourth row of the periodic table. Things will actively try to steal your atoms but will run away after stealing them. 18 chambers, 10 open 8 blocked or discovered through side quests
- Level 5: Fifth row of the periodic table. Things will actively try to steal your atoms and will attack more than once. 18 chambers, 12 open 6 blocked or discovered through side quests
- Level 6: Sixth row of the periodic table. Things will actively try to kill you. 32 chambers, 14 open, 18 blocked or discovered through side quests
- Level 7: Seventh row of the periodic table. Things will actively try to kill you. Gain Atomy as a companion at completion. 32 chambers, 16 open 16 blocked or discovered through side quests

# Enemies
- Worker bugs - young
- Worker bugs - mature
- Centibugs
- Atomflies
- Drones
- Soldier bugs
- Bug-Hubs

# Mini-games
## Energy Gates
You stand between two doors one blue and one red. Small particles will come towards the doors you need to let the red particles through the red door and the blue particles through the blue door but not the other way around. This will fill an energy meter. Once the energy meter is filled you exit the mini game.

# Stats
## Health
- Is depleted when taking damage or creating molecules.
- Can be restored by items or by playing the energy mini-game.
- If completely depleted then energy mini-game must be played until fully regained.
## Attack
- Increased by equipping better weapons/spells or by leveling up
## Defense
- increased by equipping defense spells or by leveling up
## Effects
- effects that deal extra damage and inflict status conditions

# Start Screen
- New Game: Erase all saved data and restart game
- Continue: Bring up last save data if correct game starts from that save data

# Pause menu
- Stats: the stats of you and your companions as well as what equipment is currently equipped
- Inventory:
  - Equipment: what types of equipment (weapons, spells, quest items) you have
  - Atoms: type and number of atoms you have collected
  - Molecules: The type and number of molecules that you have and information about each molecule
  - Currency: The amount of money you have
- Quests: Active and finished quests
- Settings: Volume, brightness
- Save: Save your game
- Exit (If in Dungeon): Exit the current dungeon if in one
- Quit to Start Screen: Screen asking if you want to quit and saying any save data will be lost if yes exit to the start screen

# Labs
Zoska: asks if you want to create or destroy molecules. 
- If create: enter creation screen where you choose atoms from the ones you have in your inventory to combine. This also uses a certain amount of your energy bar depending on what the molecule is. 
- If destroy: you choose what molecule to destroy from your inventory. This gives you back the atoms from the molecules and some energy.

# Museum
Hal: asks if you want to learn about atoms, molecules or scientists
- If atoms he takes you to the periodic table
  - If you have new atoms he will add them to the table
	- If a new row is filled he prompts you to talk to newt
  - Otherwise he will prompt you to pick an element and give you a brief history about the element
- If molecules he will take you to a menu with all the elements you have discovered and prompt you to pick one then give history and details about that specific molecule
- If scientists he will take you to a menu with different scientists that are unlocked as you progress through the game mostly through quests and tell you information about the scientist you choose

# Bursar
- Exchange: exchange atoms and molecules in to money and vice versa
- Paint Shop: Different paint and wallpapers for your cave
- Flooring Shop: Different flooring for your cave
- Furniture Shop: Different furniture for you cave
- Weapon Shop: Different pitchforks for attack
- Spell Shop: Different stat spells and status effects for you and your weapons
- Bank: Store items, money, atoms, and molecules
	
# Quest Shop
Curio: gives you a list of all quests available to take you can only have 5 at a time
- if you finished a quest he will give you your reward

# Caverns Entrance
Newt: Asks if you want to know about the bugs or the cavern levels
  - If bugs he gives you details about all of the enemies you have faced
  - If cavern levels he tells you what kinds of molecules, enemies, and quest items are on each level
- If entering the caverns you are first prompted to pick your level number and then your companion
- The energy mini-game is also accessible here

# Caverns:
Work on a grid system, maps will be predetermined with different areas inside each level were certain atoms and enemies are more likely to show up. New areas are mostly unlocked through quests.

# Items
- Potion: Heals 25% of your energy
- Great Potion: Heals 50% of your energy
- Super Potion: Heals 75% of your energy
- Perfect Potion: Heals 100% of your energy
- Good Stun Spell: Stuns all bugs in your immediate vicinity. Bugs cannot attack but can still move
- Great Stun Spell: Stuns all bugs in the room. Bugs cannot attack but can still move
- Good Freeze Spell: Freezes and causes ice damage to all bugs in your immediate vicinity. Bugs cannot attack or move
- Great Freeze Spell: Freezes and causes ice damage to all bugs in the room. Bugs cannot attack or move
- Good Fire Spell: Causes fire damage to all bugs in your immediate vicinity. May cause burns which cause damage over a set number of seconds
- Great Fire Spell: Causes fire damage to all bugs in the room. May cause burns which cause damage over a set number of seconds
- Good Zap Spell: Causes Electric damage to all bugs in your immediate vicinity.
- Great Zap Spell: Causes Electric damage to all bugs in the room.
- Good Water Spell: Causes water damage to all bugs in your immediate vicinity.
- Great Water Spell: Causes water damage to all bugs in the room.
- Good Plant Spell: Causes plant damage to all bugs in your immediate vicinity. May cause thorns which cause damage over a set number of seconds
- Great Plant Spell: Causes plant damage to all bugs in the room. May cause thorns which cause damage over a set number of seconds
- Good Shield Buff: increases defense by 10%
- Great Shield Buff: increases defense by 25%
- Greater Shield Buff: increases defense by 40%
- Good Weapon Buff: increases attack by 10%
- Great Weapon Buff: increases attack by 25%
- Greater Weapon Buff: increases attack by 40%
- Firecracker: Causes damage to enemy directly in front of you

# Attacks
- Swipe: Causes damage directly in front of you
- Stab: Causes damage directly in front of you. Breaks defense positions
- Swirl: Causes damage in your immediate vicinity
- Shield Up: Shield spell activates and puts defense up for your front and sides

# Quests
## Main Quests
- Find Newt: You exit the energy mini-game and get stopped by an older demon who tells you that Newt hasn’t shown up for work yet and you need to find him
- Get Bag: Newt needs your help to collect atoms since he fell behind and doesn’t want to go back to “older demon” until he has enough so he doesn’t get yelled at, you need to go to his house to get his extra atom pack
- Collecting Atoms: Go into the caverns and collect at least 5 hydrogen and 5 helium atoms
- Find Zoska: “Older Demon” is lazy and doesn’t want to take the atoms you collected to the scientist Zoska himself so he’s making you do it. Go to the labs to meet with Zoska and drop the atoms off
- Find Hal: Zoska has mistaken you for a new collector and wants you to go find Hal the Historian in order to get your periodic table setup.
- Return to Zoska: Now that your periodic table has been set up you need to return to Zoska for your lesson on atom bonding.
- Go to the Caverns: Newt has asked for your help again today so you are going to go back to the caverns
- Get a Pitchfork/Get a Shield: Hal has stopped you from entering the caverns because it is too dangerous on the lower levels and you need to be able to defend yourself. Go to the bursar and get a pitchfork and a shield spell before continuing.
- Go to the Caverns(Part 2): Go back to the cavern entrance and show Hal your new equipment. He lets you into the caverns.
- Catch that Bug!: A worker bug has stolen your atoms chase him and get them back.
- Find Curio: Zoska was doing a favor for her friend but she has been really busy and has asked you to deliver the finished molecule to Curio. Go to the Quest Shop to meet Curio and give her the package.

## Side Quests
- Retrieval Quests: An item/person has been lost in the caverns return it
- Escort Quests: Escort an item or person to some point in the caverns
- Discovery Quests: Explore new areas of the caverns to expand the map
- Collection Quests: Collect a set number of atoms
- Creation Quests: Create a certain molecule
