Ad-Network-Package-for-Unity
============================

This is a simple Unity Package to get AdMob and Chartboost ads into your Apps.

1. Drag the Chartboost prefab in the Chartboost folder and the Google Ads prefab in the GoogleMobileAds folder into your first scene
2. Fill out the fields on the Google Ads prefab and click Chartboost -> Edit Settings and fill out the Chartboost info.
3. For a example go to the Examples folder and open the ChartboostExample scene.

###Android###
No more steps needed to work

###iOS###
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