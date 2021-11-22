using UnityEngine;

public class GameController : BaseController
{
    private readonly PlayerData _model;
    private Transform _UIRoot;
    private SubscriptionProperty<float> _leftMove;
    private SubscriptionProperty<float> _rightMove;

    public GameController(PlayerData model, Transform UIRoot)
    {
        _model = model;
        _UIRoot = UIRoot;
        _leftMove = new SubscriptionProperty<float>();
        _rightMove = new SubscriptionProperty<float>();

        var background = new BackgroundController(_model, _leftMove, _rightMove);
        var car = new CarController();
        var input = new InputController(_model, _leftMove, _rightMove, _UIRoot);
    }
}
