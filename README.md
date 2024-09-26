# DEV-CON-1
The GDD for our first Development Contract (Mohawk College, GAME-10016-02) as well as the files/code/etc.

## DEV-CON 1: THE GDD ZONE 

**Vision:**

The player would control a little fire sprite making it's way up a chimney, collecting soot. The fire sprite can move left and right, but can't jump - instead, they can travel on gusts of air (using the space bar). This mechanic would likely fit best in a simplistic platformer, with puzzle potential. 

**Goals:**

*QUESTION:* In what ways is an "air draft propulsion" concept enjoyable?

*WHY:* If we added a form of propulsion that was not easily able to be calculated the same way a traditional platformer-type jump can, in what ways could this be enjoyable (outside of how enjoyable regular platform jumping is)? Would this add an interesting level of difficulty? Would it be novel enough to last over multiple levels? Would this create a constraint that might encourage interesting level design?

**Mechanics:**

The game would have players platforming upwards (think *Doodle Jump*, *Kid Icarus*, etc.) towards an end goal. The PC can move left and right but can't jump, and are instead pushed upwards by gusts of air (space bar). The PC collects soot, which acts as a key-and-gate system per level - collect all the soot, and you can exit to the next level. The "innovate mechanic" in this instance is the air draft propulsion mechanic.

*Priority:* - Working updraft Mechanic - Baseline Platforming (left and right movement, working platforms) - K&G mechanic in regards to soot collection - Follow Cam.

*Bonus:* - Looping fire sprite animation - "Woosh" sound when activating wind gust - Multiple levels - Other razzle dazzle!

*Instructions:* Left Key and Right Key for left and right movement, Spacebar for an air gust!

**Sources:**

Code provided by Mark Shannelly during Applications of Game Engines. "PlayerFollow" script used for camera tracking of the player, and "Player" script used for 2D movement.

Base Assets:

-[2D Dungeon Pixel Art Tileset by Zhivko Minchev](https://assetstore.unity.com/packages/2d/environments/2d-dungeon-pixel-art-tileset-171343)
-[Free 2D Mega Pack by Brackeys](https://assetstore.unity.com/packages/2d/free-2d-mega-pack-177430#content)

Bonus Assets:

-[RPG Essentials Sound Effects - FREE! by leohpaz](https://assetstore.unity.com/packages/audio/sound-fx/rpg-essentials-sound-effects-free-227708)
-[Pixel FX - Fire by Admurin](https://assetstore.unity.com/packages/vfx/pixel-fx-fire-221146)


**Rough Notes:**
*(This is for our rough notes taken during meetings/class/etc. as it relates to the contract. As such, optimal formatting is not a priority here - copy and paste as you like!)*

- CONTROLLING AIR FLOW FOR THE FIRE? Still left and right to move, but space controls an airdraft?
- Space is negative gravity
- Follow cam
- Box on each platform that is not affected by gravity (so you dont shoot up when the draft is below a platform)

- Rocket LAUNCH
- Propulsion via weapon...Pogo stick?
- gun/rocket launcher etc
- Breakable platforms
- Dissolving, breaking apart Physics
- 2D or 3D?
- Kid icarus upwards momentum 


- Player movement/weapons/the world?

- Weather? Moon physics, etc. Weather platform, changing temp? Water, the sun, ice, etc
- Area is hot, so you need to find water bottles around the map?
- Grappling hook? jetpack?
- Water = movement? The sun makes a (plant) character bigger or smaller based on exposure 
- Resource/fuel = upward propulsion through level
- Main mechanic = heat? Moving fire attempting to access wood 

- Fire moving up, getting fuel 
- Doodle jump-like
- Unity fire, log assets, etc
- Can fire destroy the past platforms?
- Going up a chimney, getting soot?
- Unity

- What is the question:

- Can we “spice up” movement?
- Can we innovate on movement? 
