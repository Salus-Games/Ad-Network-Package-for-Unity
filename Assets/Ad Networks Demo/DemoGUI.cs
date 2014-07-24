using UnityEngine;
using System.Collections;
using Chartboost;

public class DemoGUI : MonoBehaviour {

	void OnGUI()
	{
		if(GUI.Button(new Rect(0,300,200,30),"Show Chartboost Ad"))
		{
			CBBinding.showInterstitial(null);
			CBBinding.cacheInterstitial(null);
		}
		
		if(GUI.Button(new Rect(0,400,200,30),"Show Chartboost MoreApps"))
		{
			CBBinding.showMoreApps();
			CBBinding.cacheMoreApps();
		}

		if(GUI.Button(new Rect(0,100,200,30),"Hide Google Ad"))
		{
			GoogleAdController.HideBanner();
		}

		if(GUI.Button(new Rect(0,200,200,30),"Show Google Ad"))
		{
			GoogleAdController.ShowBanner();
		}

		
	}
}
