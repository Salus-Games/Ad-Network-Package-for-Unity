Ad-Network-Package-for-Unity
============================

This is a simple Unity Package to get AdMob and Chartboost ads into your Apps.

1. Drag the Ad Manager prefab in the Salus Games Ad Network folder into your first scene
2. Fill out the fields on the Google Ad Controller Script and click Chartboost -> Edit Settings at the top of Unity and fill out the Chartboost info.
3. If your using Chartboost you will need to include "using ChartboostSDK;" at the top of the scripts that control when to show the Chartboost ads. Check https://answers.chartboost.com/hc/en-us/articles/200780379-Unity-Integrations for the methods you can call with Chartboost.

###Android###
No more steps needed to work

###iOS###
1. In xcode navigate to Build Phases-> Link Binary with Libaries, click the + and add the following if they are not added
    * AdSupport
    * AudioToolbox
    * AVFoundation
    * CoreGraphics
    * CoreTelephony
    * EventKit
    * EventKitUI
    * MessageUI
    * StoreKit
    * SystemConfiguration

2. Add the -ObjC linker flag to your Other Linker Flags in Build Settings.

Contact: support@salusgames.com