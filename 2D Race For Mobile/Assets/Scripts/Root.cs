using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private Transform _UIRoot;
    private MainController _mainController;

    void Awake()
    {
        var playerData = new PlayerData();
        playerData.State.Value = GameState.Start;
        _mainController = new MainController(playerData, _UIRoot);
        
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
        _mainController = null;
    }
}
