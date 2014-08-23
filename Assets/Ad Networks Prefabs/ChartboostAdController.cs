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
		#if UNITY_ANDROID
		if (Input.GetKeyUp(KeyCode.Escape)) {
			if (CBBinding.onBackPressed())
				return;
		}
		#endif
	}
	
	void OnEnable() {
		CBBinding.init(appID, appSignature);
		if(!CBBinding.hasCachedInterstitial(null)){
			CBBinding.cacheInterstitial(null);
		}
		if(!CBBinding.hasCachedMoreApps()){
			CBBinding.cacheMoreApps();
		}
	}
	
	void OnApplicationPause(bool paused) {
		#if UNITY_ANDROID			
		// Manage Chartboost plugin lifecycle
		CBBinding.pause(paused);
		#endif
	}
	
	void OnDisable() {
		#if UNITY_ANDROID
		// Shut down the Chartboost plugin
		CBBinding.destroy();
		#endif
	}
}