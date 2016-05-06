# Server Manager

![alt tag](http://i65.tinypic.com/359h251.png)

Server manager made by me. It's a program made in C# to control executable servers, the main purpose of this program is to organize if you've many servers, by hiding the windows and also restarting the servers automaticaly if they crash.

I'm releasing this mostly because it is working well, though it's one of the projects I'm not going to continue due to I don't have the need of such program anymore. Though feel free to create pull requests to contriube on finishing the software. 

# Download

###Version 0.3
https://github.com/blt950/Server-Manager/releases/download/0.3/Server.Manager.0.3.zip

# Config file

In order for the program to start you need a servers.cfg file in the same directory as the .exe of manager. It's not the best solution, though I never got that far to implement it as independent GUI. The servers.cfg is read line by line, and this is an example and buildup:

```ID|Display name|Path to EXE|EXE name|Target vars if any```

servers.cfg comes with the release zip, though here is an example of the file:

```
1|Garry's Mod - HL2RP #1|E:\Srcds\steamapps\common\GarrysModDS|srcds.exe|-console -game garrysmod -maxplayers 16 +map gm_construct +gamemode cwhl2rp
2|Garry's Mod - HL2RP #2|E:\Srcds\steamapps\common\GarrysModDS|srcds.exe|-console -game garrysmod -maxplayers 16 +map gm_construct +gamemode cwhl2rp
```

# Functions and tips

* In the menu you can hide all the windows by pressing *All Servers->Hide All*
* To bring the console window back (if your server has one), double click on the server name.
* The program checks if a server has crashed each 5 seconds and relauches it if possible
* Everything that happens gets logged in the console window below and in a log file.

# License
GNU GLPv2
