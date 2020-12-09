### Pathfinder
This is a test app for testing Navmeshes for FFXI, you can also dump zone collision data to obj and build the navmeshes for zones.

Pathfinder will ask you to Download the Navmeshes i have uploaded to Github.

it will do this when you first start the app, it will not do it if you already have the navmeshes in "dumped navmeshes" folder.

Please run pathfinder as Admin and make sure you are fully logged into FFXI.

Navmeshes will load when you zone or first load the app, you can click unload and load at any time.


#### Powered by EliteMMO Network
[![EliteMMO Network, your source for cheat, hacks, tutorials and more!!!](http://www.elitemmonetwork.com/img/468_60_FFXI.gif)](http://www.elitemmonetwork.com)

Pathfinder uses the EliteMMO API provided by Wiccaan at EliteMMO Network. Without his hard work and generosity in keeping the EliteAPI free to use, progress on this program would not be possible. 

#### Project Status
Development has slowed, and mostly happens on the my days off.

#### Features
* Dump zone collision data to obj files.
* Build navmeshes using FFXINAV.dll
* Test Navmeshes


#### FFXINAV DLL

* CanSeeDestination
* Unload
* Initialize // needs path to log config file (Default_Config.conf which is included)
* Load  // loads the navmesh 
* LoadOBJFile
* DumpNavMesh
* GetLogMessage
* FindPath
* FindRandomPath
* FindClosestPath // this prevents exploits with navmesh / impassible terrain
* IsValidPosition // can be used to make a grid for A star pathfinding. (if you didn't want to use recast detour to find a path).
* GetDistanceToWall //this is distance to navmesh edge
* GetRotation
* IsNavMeshEnabled
* PathPoints
* NavMeshSettings //Lets you change the NavMesh settings before building a new mesh
* GetWaypoints //returns the waypoints in the path
* EnableNearestPoly 

### navmesh settings all meshes are dumped with.


        float m_tileSize = 64;         <<<< this can be changed for small zones.
	float m_cellSize = 0.20f;
	float m_cellHeight = 0.010f;
	float m_agentHeight = 1.8f;    
	float m_agentRadius = 0.7f;     <<<< if you make this too big it will break the mesh. 0.7f has been tested on most zones.
	float m_agentMaxClimb = 0.5f;   <<<< this might need changing for some zones. max climb changes from 0.3f to 0.5f, trial and error
	float m_agentMaxSlope = 45.0f;
	float m_regionMinSize = 8;
	float m_regionMergeSize = 20;
	float m_edgeMaxLen = 12.0f;
	float m_edgeMaxError = 1.3f;
	float m_vertsPerPoly = 6.0f;
	float m_detailSampleDist = 6.0f;
	float m_detailSampleMaxError = 1.0f;
	
	


#### Requirements
* Ashita or Windower
* [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
* Visual C++ Redistributable Packages for Visual Studio 2013  
* Visual C++ Redistributable Packages for Visual Studio 2015  

**Note:** You can use the EliteMMO system checker tool to check for missing packages:  
* http://www.elitemmonetwork.com/forums/viewtopic.php?f=28&t=329. 

**Important:** *Make sure you're using the X86 version of the Visual Studio C++ Redistributables even if you have a 64 bit operating system.*
    
#### Special Thanks!


* Devi Ltti for his zone.dat list and fixes to Vultures collision mesh extraction tool.

* Vulture for his collision mesh extraction tool.

* Atom0s and EliteMMO for producing the current memory reading api.

* The DarkStar project for providing invaluable insight into the underlying workings of the game. 
	
	
#### Path Test To Points Of Interest Tab
To test a navmesh

* Load Points of interest 
* Select Point of interest
* Hit start
 


#### Dat Tab

Here you can dump the zone collision data to an obj file,

* Click Load Zones  

this zone dat list is provided by Devi Ltti (Thanks Devi) and converted to xml by me.
 
* you can Select a zone to dump or click dump all map dats.
 you will notice some zones are commented out in the zonelist.xml file, this is because you can not dump them with pathfinder.exe.
If i can't export the zone.dat using pathfinder.exe then i use Noesis to export the zone to obj file. To export maps so they are compatible with FFXINAV.dll please use the following settings.

Output type = obj.
Advanced Export Options:

-rotate 180 0 -90 -fbxsmoothgroups -fbxtexrelonly -fbxtexext .tga

You can download Noesis from the link below.
https://richwhitehouse.com

to pathfind with meshes made with the files from noesis using FFXINAV.dll you need to set 

#  FindPath(start,end,True).


#### NavMesh Tab

here you can build navmeshes using FFXINAV.dll

the settings you see are the default settings i have dumped all the zones for. 
some zones you may need to change MaxClimb, for example zone 271 maxclimb is 0.3


#### FAQ

##### Using Pathfinder.exe how do export a navmesh from FFXINAV.dll?.
    
* Pathfinder.exe -> Navmesh tab -> click select a obj file to build and dump a navmesh, or
       Pathfinder.exe - > Navmesh tab -> click dump all zone.obj file navmeshes --- this is buggy and will crash, if it does just restart it.
       
       
##### How do I edit the navmesh that was built with FFXINAV.dll in RecastDemo.exe?.
    
       1. Place the zone.obj file in  RecastDemo/Meshes/
       2. Place the navmesh.nav in the same folder as RecastDemo.exe "RecastDemo"
       3. Rename "navmesh.nav" to "all_tiles_navmesh.bin"
       4. open RecastDemo.exe-> on the right hand side click -> choose sample -> Tile Mesh
          Input Mesh -> select the .obj file you want to edit.
       5. once the .obj is loaded on screen -> scroll down and click load. you will see the mesh load on screen as "blue"
       6. to remove tiles, on the left hand side click "Create Tiles" then on the mesh click Shift+ left mouse button.
       7. to rebuild the tile click on the part of the mesh with left mouse button.
       8. you can create off-mesh links with the tool on the left hand side. 
       9. when you are finished click save from the tool menu on the right hand side.
       10.It will save as "all_tiles_navmesh.bin" you will need to rename this to "ZoneName.nav".   
       
##### I am unable to load my zone.obj with FFXINAV.dll or RecastDemo.exe to build a mesh, what can I do?.
    
* I have no idea. you can see if the DSP was able to build a navmesh and try and use theres. 
      the only problem with DSP navmeshes is there is no object data on the meshes, rocks,trees etc.   
      
##### Pathfinder.exe wont load up or it loads up but only says refresh?.
   
* You need to be logged into FFXI with ashita or windower
      Right click Pathfinder.exe and run as Admin. 
      also you need to be logged into ffxi for it to work.
      Wiccaan made a System checker to see of your machine is missing any required files typically
      needed to run applications that use EliteMMO.api. you can download hit system checker here.
      
      http://www.elitemmonetwork.com/forums/download/file.php?id=66
      
      
##### In pathfinder when I click load zones -> select zonelist.xml, nothing happens or I get an error?. 
   
* you may need to edit zonelist.xml and change the path to where you have final fantasy xi installed.

Zonelist.xml is a custom XML I made to get the location of all the zone.dats using the list provided by Devi Ltti, you will see some are commented out, this is because I have been unable to export that zone to obj file. Or build a navmesh with the exported obj.

##### How do i deal with doors? the navmesh wont go past them?.
   
* if this happens, you can open the obj file in blender and delete the door, or you can open the obj and navmesh in recastdemo and add an offmesh connection.


##### My character will not stop running. What should I do?
* Rest the app. 

       


