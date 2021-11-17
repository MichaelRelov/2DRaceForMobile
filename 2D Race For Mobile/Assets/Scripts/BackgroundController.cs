using UnityEngine;

public class BackgroundController
{
    private ResourcePath _backgroundResource = new ResourcePath() { PathResource = "Prefabs/background" };
    private readonly PlayerData _model;
    private readonly TapeBackgroundView _background;
    private SubscriptionProperty<float> _leftMove;
    private SubscriptionProperty<float> _rightMove;

    public BackgroundController(PlayerData model, SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove)
    {
        _model = model;
        _leftMove = leftMove;
        _rightMove = rightMove;
        var prefab = ResourceLoader.LoadPrefab(_backgroundResource);
        var go = GameObject.Instantiate(prefab);
        _background = go.GetComponent<TapeBackgroundView>();

        leftMove.SubscribeOnChange(OnLeftMove);
        rightMove.SubscribeOnChange(OnRightMove);
    }

    private void OnLeftMove(float value)
    {
        _background.Move(value);
    }

    private void OnRightMove(float value)
    {
        _background.Move(value);
    }
}
