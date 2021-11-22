using UnityEngine;
using System;

public class MainController : BaseController
{
    private readonly PlayerData _model;
    private readonly Transform _UIRoot;
    private readonly IAdsShowed _adsShowed;
    private readonly IAnalytics _analytics;
    private BaseController _current;

    public MainController(PlayerData model, Transform UIRoot, IAdsShowed adsShowed, IAnalytics analytics)
    {
        _model = model;
        _UIRoot = UIRoot;
        _adsShowed = adsShowed;
        _analytics = analytics;
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
                break;
            case GameState.Start:
                _analytics.TrackEvent("game laundh", null);
                _current = new MenuController(_model, _UIRoot, _adsShowed);
                break;
            case GameState.Game:
                _analytics.TrackEvent("game start", null);
                _current = new GameController(_model, _UIRoot);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }
    }
}
