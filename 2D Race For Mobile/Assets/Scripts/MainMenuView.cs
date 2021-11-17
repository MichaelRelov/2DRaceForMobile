using UnityEngine;
using System;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    public Action OnStartButtonClick;

    private void Awake()
    {
        _startButton.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        OnStartButtonClick?.Invoke();
        Debug.Log("Click");
    }
}
