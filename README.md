Ad-Network-Package-for-Unity
============================

This is a simple Unity Package to get AdMob and Chartboost ads into your Apps.

1. Just drag the 2 prefabs in the Ad Networks Prefabs folder into your scene 
2. Fill out the relevent App Id's and signatures on the scripts attached to the prefabs
3. Check the Demo scene and DemoCUI.cs script to see how to call a Chartbost ad or to show and hide the AdMob banners

### Android ###
No more steps needed to work

### iOS ###
1. In xcode navigate to Build Phases-> Link Binary with Libaries, click the + and add the following if they are not added
* AdSupport
* AudioToolbox
* AVFoundation
* CoreGraphics
* CoreTelephony
* MessageUI
* StoreKit
* SystemConfiguration

2. Add the -ObjC linker flag to your Other Linker Flags in Build Settings.


Contact: support@salusgames.com
