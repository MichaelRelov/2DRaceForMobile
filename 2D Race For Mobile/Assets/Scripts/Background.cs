using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private float _leftBorder;
    [SerializeField] private float _rigthBorder;
    [SerializeField] private float _relativeSpeed;

    public void Move(float value)
    {
        transform.position += Vector3.right * value * _relativeSpeed;
        var position = transform.position;

        if(position.x <= _leftBorder)
        {
            transform.position = new Vector3(_rigthBorder - (_leftBorder - position.x), position.y, position.z);
        }
        else if(position.x >= _rigthBorder)
        {
            transform.position = new Vector3(_leftBorder + (_rigthBorder - position.x), position.y, position.z);
        }
    }
}
