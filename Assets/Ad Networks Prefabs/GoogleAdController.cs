using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class GoogleAdController : MonoBehaviour {

	static GameObject googleAdBannerObject;	

	public string adUnitId;
	public bool adTop;
	public bool adBottom; 

	private static BannerView bannerView;

	void Awake()
	{
		//check if GoogleAdBannerObject Exits
		if(googleAdBannerObject)
		{
			//it does so destory this object
			Destroy(gameObject);
		}
		else
		{
			//else make set GoogleAdbannerObject to this object and dont destroy on load
			googleAdBannerObject = gameObject;
			DontDestroyOnLoad(gameObject);
		}	
	}


	// Use this for initialization
	void Start () 
	{	
		
		if(adTop)
		{
			// Create a banner
			bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top);
			// Create an empty ad request.
			AdRequest request = new AdRequest.Builder().Build();
			// Load the banner with the request.
			bannerView.LoadAd(request);
		}
		if(adBottom)
		{
			// Create a banner
			bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
			// Create an empty ad request.
			AdRequest request = new AdRequest.Builder().Build();
			// Load the banner with the request.
			bannerView.LoadAd(request);
		}
	}

	public static void HideBanner()
	{
		bannerView.Hide();
	}

	public static void ShowBanner()
	{
		bannerView.Show();
	}
}
