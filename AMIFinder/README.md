The purpose of this Wox plugin
=============================
To retrieve a list of Amazon Machine Images that the user owns in the region.

This plugin needs to be run with Wox. 

Most recent build with Wox included: [Wox-AMIFinder-JJW24.exe](https://github.com/jjw24/DevOpsTooling/raw/master/AMIFinder/Wox-AMIFinder-JJW24.exe)

What is Wox?
============
[Wox](https://github.com/Wox-launcher/Wox) is a Windows launcher similar to Alfred for Mac OS.

It is used to quickly launch anything ranging from applications, websites, web searches to OS commands and more.

It has a plugin system so a variety of plugins can be added to launch different processes.

What does this plugin do?
=========================
Currently it will get a list of AMIs that you own in the specified region. It will display AMI descriptions, image created date and age.

Using the AMIFinder plugin:
===========================
1. Download the [Wox-AMIFinder-JJW24.exe](https://github.com/jjw24/DevOpsTooling/raw/master/AMIFinder/Wox-AMIFinder-JJW24.exe)

2. Double click to set up and run.

3. Once launched you will see an input box in black and grey color.
![image](https://user-images.githubusercontent.com/26427004/62990333-e8b01c80-be8e-11e9-8c36-f722e5cffd9b.png)

4. Before you go ahead to get your AMI list, you need to go to Wox settings and set your profile and region where you want to retrieve the list from. Do this by right clicking on the Wox icon and select settings. 
![image](https://user-images.githubusercontent.com/26427004/62990527-b5ba5880-be8f-11e9-87c9-79914d87f92c.png)

5. Once the menu is opened, go to 'Plugins' and click on AMIFinder and set your AWS profile and region. 
![image](https://user-images.githubusercontent.com/26427004/62990626-fb772100-be8f-11e9-846f-5f39693b7093.png)

6. Please note your profile (from the AWS store) needs to have access to describe/access AMIs, otherwise none will be returned.

7. Type in your profile, region and click 'Apply' (apparently Wox does not prompt to notify success after clicking apply button, so once you have clicked 'Apply' you are golden). 

8. Once set, close the settings menu and on your keyboard press ALT + Space (the default Wox hotkey to bring up Wox search box). In the search box type '**get-ami**', you should then after a couple of seconds see the list of your AMIs for the set region.

**Loading the AMI list:**
![image](https://user-images.githubusercontent.com/26427004/62990783-86f0b200-be90-11e9-809f-8e3538e4c9e1.png)

**Result:**
![image](https://user-images.githubusercontent.com/26427004/62990855-d46d1f00-be90-11e9-9064-73c3c3321997.png)

To dismiss/hide the launcher window, press keyboard ESC key (it will continue to pull the list in the background. To bring the window back to foreground, press the hotkey ALT + Space again).


Building this project in Visual Studio
======================================
Thhis project can not be built or started on its own. It needs to be included into the [Wox](https://github.com/jjw24/Wox) solution to be compiled and run.

1. Clone the [Wox repo](https://github.com/jjw24/Wox)
2. Open the solution in Visual Studio and add this project to the Plugins folder
2. Open up Project Depencies and set Wox to include this project

Good-to-knows:
==============
- The PS that the plugin runs are located at: [Wox.Plugin.AMIFinder/Commands](https://github.com/jjw24/DevOpsTooling/tree/master/AMIFinder/Wox.Plugin.AMIFinder/Commands)

- Due to importing module AWSPowerShell, it takes a around 5 seconds to retrieve the list of AMIs. Will look into improving this in the future.

- It is assumed you have latest PowerShell 5 environment with PackageManagement module installed (required to use Get-PackageProvider)

- The plugin can run PowerShell 5 or below scripts, in the future, may extend it with an option to run with the PowerShell 6 or any version.

PLEASE NOTE:
All credits for Wox launcher go to the code owners at https://github.com/Wox-launcher/Wox

My forked branch is at https://github.com/jjw24/Wox
