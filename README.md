# BgAssist
BgAssist improves VDI end user experiences by detecting system display changes and triggering BgInfo to execute, refreshing the users desktp background. Addtionally, BgAssist allows users to customize their desktop experience by allowing them to choose from many administrator defined configurations. BgAssist is written to use mininmal system resources, consuming only ~12 MB RAM and nearly zero CPU per session.

BgAssist will fire BgInfo on:
* BgAssist startup
* Display settings changes/screen resize

## Setup
1. Donwload latest release, extract files onto gold image i.e. C:\BgAssist
1. Download [BgInfo](https://docs.microsoft.com/en-us/sysinternals/downloads/bginfo) and extract BgInfo64.exe into the same directory as BgAssist
    1. **Note:** BgAssist is only compatibile with BgInfo64.exe
1. Run BgAssist-Config.exe.
   
   ![BgAssist Config](https://github.com/blazcode/BgAssist/blob/master/Screenshots/BgAssist-Config.png)
   
    1. Set BgInfo64.exe path.
    1. Set default BgInfo configuration file path. If there are multiple .bgi configuration files in the same directory, users will be able to choose a customized default. **Important:** DO NOT put spaces in .bgi configuration file names.
    1. Set BgInfo switches as desired; [reference](https://docs.microsoft.com/en-us/sysinternals/downloads/bginfo).
    1. Save BgAssist configuration.
1.  Create BgAssist.exe shortcut in *"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp"* or use other method to run executable at user login
1. To persist user selected background configuration, capture the the following registry key with appropriate profile roaming technology: HKEY_CURRENT_USER\Software\BgAssist

## Using BgAssist
Once BgAssist is triggered to run, the application will read the configuration (BgAssist-Config.exe.config) and fire BgInfo64. If no user selected configuration is found, BgAssist will use the deafult configuration defined by the administrator. Otherwise, the user selected configuration will be used.

BgAssist will launch silently in the background, leaving an icon in the System Tray that an end user can interact with. Right-clicking the icon will show the menu:

![BgAssist](https://github.com/blazcode/BgAssist/blob/master/Screenshots/BgAssist-System-Tray.png)

Double clicking the System Tray icon will launch the Desktop Background window where the user can choose a background, manually refresh their background, or view the BgAssist log file.

![BgAssist System Tray](https://github.com/blazcode/BgAssist/blob/master/Screenshots/BgAssist.png)


