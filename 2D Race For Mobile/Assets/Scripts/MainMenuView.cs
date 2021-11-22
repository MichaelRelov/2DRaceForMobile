using UnityEngine;
using System;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _showRewarded;

    public Action OnStartButtonClick;
    public Action OnShowRewardedClick;

    private void Awake()
    {
        _startButton.onClick.AddListener(OnButtonClick);
        _showRewarded.onClick.AddListener(ShowRewarded);
    }

    private void OnButtonClick()
    {
        OnStartButtonClick?.Invoke();
    }

    private void ShowRewarded()
    {
        OnShowRewardedClick?.Invoke();
    }
}
