using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdmobController : MonoBehaviour {

    public static AdmobController _admobController;
    public string AdUnit;

    public enum bannerSizes {
        banner,
        IABBanner, 
        leaderboard, 
        mediumRectangle, 
        smartBanner
    };
    public bannerSizes bannerSize;

    public enum bannerPositions
    {
        bottom,
        bottomLeft,
        bottomRight,
        top,
        topLeft,
        topRight
    }
    public bannerPositions bannerPosition;

    void Awake()
    {
        if (_admobController != null)
            Destroy(gameObject);

        else
            _admobController = this;
    }

	// Use this for initialization
	void Start () {
        BannerView bannerView = new BannerView(AdUnit, AdSizeSet(), AdPositionSet());
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
	}

    AdSize AdSizeSet()
    {
        AdSize result = null;

        switch(bannerSize)
        {
            case bannerSizes.banner:
                result = AdSize.Banner;
                break;
            case bannerSizes.IABBanner:
                result = AdSize.IABBanner;
                break;
            case bannerSizes.leaderboard:
                result = AdSize.Leaderboard;
                break;
            case bannerSizes.mediumRectangle:
                result = AdSize.MediumRectangle;
                break;
            case bannerSizes.smartBanner:
                result = AdSize.SmartBanner;
                break;
        }

        return result;
    }

    AdPosition AdPositionSet()
    {
        AdPosition result = AdPosition.Top;

        switch(bannerPosition)
        {
            case bannerPositions.bottom:
                result = AdPosition.Bottom;
                break;

            case bannerPositions.bottomLeft:
                result = AdPosition.BottomLeft;
                break;

            case bannerPositions.bottomRight:
                result = AdPosition.BottomRight;
                break;

            case bannerPositions.top:
                result = AdPosition.Top;
                break;

            case bannerPositions.topLeft:
                result = AdPosition.TopLeft;
                break;

            case bannerPositions.topRight:
                result = AdPosition.TopRight;
                break;
        }

        return result;
    }
}
