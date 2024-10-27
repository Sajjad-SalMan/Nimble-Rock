using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class AdsInitializer : MonoBehaviour, IUnityAdsInitializationListener
{
    public static AdsInitializer instance;
    public static bool adIsReady;

    [SerializeField] RewardedAdsButton rewardedAds;

    [SerializeField] string _androidGameId;
    [SerializeField] string _iOSGameId;
    [SerializeField] bool _testMode = true;
    private string _gameId;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        InitializeAds();
    }

    public void InitializeAds()
    {
        _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSGameId
            : _androidGameId;
        Advertisement.Initialize(_gameId, _testMode, this);
    }
    public void OnInitializationComplete()
    {
        adIsReady = true;
        rewardedAds.LoadAd();
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {

    }
}
