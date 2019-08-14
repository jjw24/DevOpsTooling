The purpose of developing this plugin for Wox
=========================================
1. Retrieve a list of AMIs with description
2. Learn something

Using Wox plugin (src/Plugins/Wox.Plugin.AMIFinder) to retrieve a list of AMIs that the user owns in the specified region.

This is intended as a demonstration and learning piece for using .Net to launch PowerShell scripts, then retrieve output from the scripts and do something with it.

The plugin needs to be run with Wox, so src code is copied over from the forked branch: https://github.com/jjw24/Wox/tree/dev

What is Wox?
============
It is a Windows launcher similar to Alfred for Mac OS.

It is used to quickly launch anything ranging from programs, websites, web searches to a variety of OS operations and more.

It has a plugin system so a variety of plugins can be added to launch different processes.

Why use AMIFinder with Wox
==========================
- Imagine doing everything that you can quickly and efficiently with a simple interface and keyboard shortcuts to 
  - find the right AMI and launch an EC2 instance from it,
  - set up your AWS environment, 
  - manage your instances, 
  - manage S3 buckets and objects,  
  - manage local profiles and create new IAM users.

Anything you can do wih AWS PowerShell tool, you will be able to do via this Wox plugin. The beauty is that you can assign shortcut to the plugin so you can do something like open Wox quick-launch interface and type in 'launch-ec2' and it will run the scripts to do their thing. No need to open PowerShell, quick and easy. For the technical minded users, they can tweak the PS scripts that the plugin runs, and for the non-technical minded users, they do not need to deal with any scripting or code, just use keyboard shortcuts to get things spun up in AWS.

*For now, the plugin will demonstrate the below:

What does this plugin do?
=========================
Currently it will get a list of AMIs that you own in the specified region. It will display AMI descriptions, image created date and age, with the future possibility to manage them directly without needing to go into your AWS portal or CLI, ultimately, without your hands needing to leave the keyboard.

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

7. Type in your profile and region and click apply(apparently Wox does not prompt to notify success after clicking apply button, so once you have clicked apply you are golden). 

8. Once set, close the settings menu and on you keyboard press ALT + Space (the default Windows hotkey to bring up Wox search box). In the search box type '**get-ami**', you should then after a couple of seconds see the list of your AMIs for the set region.

**Loading the AMI list:**
![image](https://user-images.githubusercontent.com/26427004/62990783-86f0b200-be90-11e9-809f-8e3538e4c9e1.png)

**Result:**
![image](https://user-images.githubusercontent.com/26427004/62990855-d46d1f00-be90-11e9-9064-73c3c3321997.png)

To dismiss/hide the launcher window, press keyboard ESC key (it will continue to pull the list in the background. To bring the window back to foreground, press the hotkey ALT + Space again).

Good-to-knows:
==============
- The PS that the plugin runs are located at: src/Plugins/Wox.Plugin.AMIFinder/Commands

- Due to importing module AWSPowerShell, it takes a around 5 seconds to retrieve the list of AMIs. Will look into improving this in the future.

- It is assumed you have latest PowerShell 5 environment with PackageManagement module installed (required to use Get-PackageProvider)

- The plugin can run PowerShell 5 or below scripts, in the future, may extend it with an option to run with the PowerShell 6 or any version.

PLEASE NOTE:
All credits for Wox launcher go to the code owners at https://github.com/Wox-launcher/Wox

My forked branch is at https://github.com/jjw24/Wox

As this AMIFinder plugin (src/Plugins/Wox.Plugin.AMIFinder) is for demo and learning purposes, it will be extracted out later on as a stand-alone plugin that is either kept here or be spun off as a new repo, and the rest of the source code in this folder will be removed.
