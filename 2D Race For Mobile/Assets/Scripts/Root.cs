using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Transform _UIRoot;
    [SerializeField] private UnityAdsTools _ads;
    private MainController _mainController;

    void Awake()
    {
        var analytics = new UnityAnalyticsHandler();
        var playerData = new PlayerData();
        playerData.State.Value = GameState.Start;
        _mainController = new MainController(playerData, _UIRoot, _ads, analytics);
        
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
        _mainController = null;
    }
}
