*The purpose of this AMIFinder:*
It is a Wox plugin (src/Wox/Plugins/Wox.Plugin.AMIFinder).
This is intended as a demonstration and learning piece for using .Net to launch PowerShell scripts, then retrieve output from the scripts and do something with it.
The plugin needs to be run with Wox, so SRC code is copied over from: BRANCH LINK


*What is Wox launcher?*
It is a windows launcher similar to Alfred for Mac OS.
It is used to quickly launch anything that ranges from programs, websites, web searches and etc.
It has a plugin system so a variety of plugins can be added to launch different operations.

Purpose of the AMIFinder plugin:
To get a list of AMIs that you own in a specified region. The list will display AMI descriptions, image created date and age, with the future possibility to manage them directly without needing to go into your AWS portal or CLI, or ultimately, without your hands needing to leave the keyboard.

Using the AMIFinder:
Download the Wox-AMIFinder-JJW24.exe LINK
Double click to set up and run.
Once launched you will see an input box in black and grey color . To dismiss it, press keyboard ESC key.
Before you go ahead to get your AMI list, you need to go to Wox settings and set your profile and region where you want to retrieve the list from. Do this by right clicking on the Wox icon and select settings. 

Once the menu is opened, go to 'Plugins' and click on AMIFinder and set your AWS profile and region. 

Please note your profile (from the AWS store) needs to have access to describe/access AMIs, otherwise none will be returned.

Type in your profile and region and click apply(apparently Wox does not prompt to notify success after clicking apply button, so once you have clicked apply you are golden). Once set, close the settings menu and on you keyboard press ALT + Space (the default shortcut to bring up Wox search box). In the search box type get-ami, you should then after a couple of seconds see the list of your AMIs for the set region.

Good-to-knows:
The PS that the plugin runs are located at:

Due to importing module AWSPowerShell, it takes a around 5 seconds to retrieve the list of AMIs. Will look into improving this in the future.

It is assumed you have latest PowerShell 5 environment with PackageManagement
