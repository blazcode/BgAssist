# BgAssist
BgAssist is designed to complement [BgInfo](https://docs.microsoft.com/en-us/sysinternals/downloads/bginfo) in virtual desktop environments.

BgAssist improves virtual deskop end user experience by maintaining a consistent desktop background appearance and giving users administrator defined customization options. When BgAssist.exe is launched on session creation, it listens for system display changes and triggers BgInfo to update the Desktop Background. The user's desktop background will automatically adjust when the client window resizes/resolution changes. Addtionally, administrators can provide multiple BgInfo configuration files, allowing users choose their wallpaper either for color preference, functionality, or accessibility needs. The executable is written to use mininmal system resources, consuming only ~12 MB RAM and nearly zero CPU per session.

BgAssist will trigger desktop background refreshes on:
* BgAssist startup
* Display settings changes/screen resize
* User background selection change

### Example display change refresh

![Example display change refresh](https://github.com/blazcode/BgAssist/blob/master/Screenshots/Example-DisplayChange.GIF)

### Example user background change

![Example user background change](https://github.com/blazcode/BgAssist/blob/master/Screenshots/Example-ChangeWallpaper.GIF)

Actual useful information redacted from BgInfo for example.

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
1. To persist user selected background configuration, capture the the following registry key with the appropriate profile roaming technology: HKEY_CURRENT_USER\Software\BgAssist

## Using BgAssist
Once BgAssist is triggered to run, the application will read the configuration (BgAssist-Config.exe.config) and fire BgInfo64. If no user selected configuration is found, BgAssist will use the deafult configuration defined by the administrator. Otherwise, the user selected configuration will be used.

BgAssist will launch silently in the background, leaving an icon in the System Tray that an end user can interact with. Right-clicking the icon will show the menu:

![BgAssist](https://github.com/blazcode/BgAssist/blob/master/Screenshots/BgAssist-System-Tray.png)

Double clicking the System Tray icon will launch the Desktop Background window where the user can choose a background, manually refresh their background, or view the BgAssist log file.

![BgAssist System Tray](https://github.com/blazcode/BgAssist/blob/master/Screenshots/BgAssist.png)
