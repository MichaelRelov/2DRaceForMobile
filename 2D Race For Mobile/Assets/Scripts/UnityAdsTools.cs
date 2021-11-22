using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsTools : MonoBehaviour, IAdsShowed, IUnityAdsListener
{
    private const string GAME_ID_IOS = "4460218";
    private const string INTERSTITIAL_IOS = "Interstitial_iOS";
    private const string REWARDED_IOS = "Rewarded_iOS";

    private const string GAME_ID_ANDR = "4460219";
    private const string INTERSTITIAL_ANDR = "Interstitial_Android";
    private const string REWARDED_ANDR = "Rewarded_Android";

    
    private Action _onRewardedSuccess;

    private void Start()
    {
        Advertisement.Initialize(GAME_ID_IOS);
    }

    public void ShowInterstitial()
    {
        Advertisement.Show(INTERSTITIAL_IOS);
    }

    public void ShowRewarded(Action OnSuccess)
    {
        _onRewardedSuccess = OnSuccess;
        Advertisement.Show(REWARDED_IOS);
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log(message);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        _onRewardedSuccess?.Invoke();
        _onRewardedSuccess = null;
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log($"Placement ready {placementId}");
        
    }
}
