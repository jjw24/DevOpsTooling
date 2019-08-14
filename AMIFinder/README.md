The purpose of developing this plugin for Wox
=========================================
1. Retrieve a list of owned AMIs with description
2. Learn something

Using Wox plugin (src/Wox/Plugins/Wox.Plugin.AMIFinder) to retrieve a list of AMIs that the user owns in the specified region.

This is intended as a demonstration and learning piece for using .Net to launch PowerShell scripts, then retrieve output from the script and do something with it.

The plugin needs to be run with Wox, so src code is copied over from the forked branch: https://github.com/jjw24/Wox


What is Wox?
============
It is a windows launcher similar to Alfred for Mac OS.

It is used to quickly launch anything ranging from programs, websites, web searches to a variety of OS operations and more.

It has a plugin system so a variety of plugins can be added to launch different processes.

Why use AMIFinder with Wox
==========================
- Imagine doing everything that you can quickly and efficiently with a simple interface and keyboard shortcut to 
  - find the right AMI and launch an EC2 instance from it,
  - set up your AWS environment, 
  - manage your instances, 
  - manage S3 buckets and objects,  
  - manage local profiles and create new IAM users.

Anything you can do wih AWS PowerShell tool, you will be able to do via this Wox plugin. The beauty is that you can assign shortcut to the plugin so you can do something like open Wox quicklaunch interface and type in 'launch-ec2' and it will run the scripts to do their thing. No need to open PowerShell, quick and easy. For the technical minded users, they can tweak the PS scripts that the plugin runs, and for the non-technical minded users, they do not need to deal with any scripting or code, just use keyboard shortcuts to get things spun up in AWS.

*For now, the plugin will do the below:

What does this plugin do?
=========================
Currently it will get a list of AMIs that you own in the specified region. It will display AMI descriptions, image created date and age, with the future possibility to manage them directly without needing to go into your AWS portal or CLI, ultimately, without your hands needing to leave the keyboard.

Using the AMIFinder plugin:
===========================
Download the Wox-AMIFinder-JJW24.exe(https://github.com/jjw24/DevOpsTooling/raw/AMIFinder/Wox-AMIFinder-JJW24.exe)

Double click to set up and run.

Once launched you will see an input box in black and grey color . To dismiss it, press keyboard ESC key.

Before you go ahead to get your AMI list, you need to go to Wox settings and set your profile and region where you want to retrieve the list from. Do this by right clicking on the Wox icon and select settings. 

Once the menu is opened, go to 'Plugins' and click on AMIFinder and set your AWS profile and region. 

Please note your profile (from the AWS store) needs to have access to describe/access AMIs, otherwise none will be returned.

Type in your profile and region and click apply(apparently Wox does not prompt to notify success after clicking apply button, so once you have clicked apply you are golden). Once set, close the settings menu and on you keyboard press ALT + Space (the default shortcut to bring up Wox search box). In the search box type get-ami, you should then after a couple of seconds see the list of your AMIs for the set region.

Good-to-knows:
==============
The PS that the plugin runs are located at: src/Wox/Plugins/Wox.Plugin.AMIFinder/Commands

Due to importing module AWSPowerShell, it takes a around 5 seconds to retrieve the list of AMIs. Will look into improving this in the future.

It is assumed you have latest PowerShell 5 environment with PackageManagement module installed (required to use Get-PackageProvider)

PS scripts are run with PowerShell 5 or below. Future may breakout so there is an option to run with the PowerShell 6
