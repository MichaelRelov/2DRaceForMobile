using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeTrailEffect : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField] private Transform _position;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("!");
        _position.position += new Vector3(eventData.delta.x, eventData.delta.y, 0);
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
