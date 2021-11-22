using UnityEngine;

public class MenuController : BaseController
{
    private readonly PlayerData _playerData;
    private readonly IAdsShowed _adsShowed;
    private readonly ResourcePath _menuViewResource = new ResourcePath { PathResource = "Prefabs/MainMenu" };
    private MainMenuView _menuView;

    public MenuController(PlayerData playerData, Transform UIRoot, IAdsShowed ads)
    {
        _playerData = playerData;
        _adsShowed = ads;
        var prefab = ResourceLoader.LoadPrefab(_menuViewResource);
        var go = GameObject.Instantiate(prefab, UIRoot);
        AddGameObject(go);
        _menuView = go.GetComponent<MainMenuView>();
        _menuView.OnStartButtonClick += StartGame;
        _menuView.OnShowRewardedClick += ShowRewarded;
    }

    private void StartGame()
    {
        _playerData.State.Value = GameState.Game;
    }

    private void ShowRewarded()
    {
        _adsShowed.ShowRewarded(() => Debug.Log("Show Rewarded"));
    }

    protected override void OnDispose()
    {
        _menuView.OnStartButtonClick -= StartGame;
        _menuView.OnShowRewardedClick -= ShowRewarded;
        base.OnDispose();
    }
}
