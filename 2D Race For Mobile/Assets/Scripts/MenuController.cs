using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : BaseController
{
    private readonly PlayerData _playerData;
    private readonly ResourcePath _menuViewResource = new ResourcePath { PathResource = "Prefabs/MainMenu" };
    private MainMenuView _menuView;

    public MenuController(PlayerData playerData, Transform UIRoot)
    {
        _playerData = playerData;
        var prefab = ResourceLoader.LoadPrefab(_menuViewResource);
        var go = GameObject.Instantiate(prefab, UIRoot);
        AddGameObject(go);
        _menuView = go.GetComponent<MainMenuView>();
        _menuView.OnStartButtonClick += StartGame;
    }

    private void StartGame()
    {
        _playerData.State.Value = GameState.Game;
    }

    protected override void OnDispose()
    {
        _menuView.OnStartButtonClick -= StartGame;
        base.OnDispose();
    }
}
