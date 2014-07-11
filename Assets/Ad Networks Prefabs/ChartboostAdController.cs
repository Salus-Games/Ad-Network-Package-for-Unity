using UnityEngine;
using System.Collections;
using Chartboost;

public class ChartboostAdController : MonoBehaviour {

	static GameObject chartboostAdBannerObject;	
	
	public string appID;
	public string appSignature;

	void Awake()
	{
		//check if chartboostAdBannerObject Exits
		if(chartboostAdBannerObject)
		{
			//it does so destory this object
			Destroy(gameObject);
		}
		else
		{
			//else make set chartboostAdBannerObject to this object and dont destroy on load
			chartboostAdBannerObject = gameObject;
			DontDestroyOnLoad(gameObject);
		}	
	}
	
	void Update(){
		if (Input.GetKeyUp(KeyCode.Escape)) {
			if (CBBinding.onBackPressed())
				return;
		}
	}

	void OnEnable() {
		CBBinding.init(appID, appSignature);
		CBBinding.cacheInterstitial(null);
		CBBinding.cacheMoreApps();
	}

	void OnApplicationPause(bool paused) {
		// Manage Chartboost plugin lifecycle
		CBBinding.pause(paused);
	}
	
	void OnDisable() {
		// Shut down the Chartboost plugin
		CBBinding.destroy();
	}
}
