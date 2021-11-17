using UnityEngine;
using System;

public class MainController : BaseController
{
    private readonly PlayerData _model;
    private readonly Transform _UIRoot;
    private BaseController _current;

    public MainController(PlayerData model, Transform UIRoot)
    {
        _model = model;
        _UIRoot = UIRoot;
        _model.State.SubscribeOnChange(GameStateChange);
        //_model.State.Value = GameState.Start;
        GameStateChange(_model.State.Value);
    }

    private void GameStateChange(GameState state)
    {
        _current?.Dispose();
        switch (state)
        {
            case GameState.None:
                Debug.Log("None");
                break;
            case GameState.Start:
                Debug.Log("Start");
                _current = new MenuController(_model, _UIRoot);
                break;
            case GameState.Game:
                Debug.Log("Game");
                _current = new GameController();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }
    }
}
