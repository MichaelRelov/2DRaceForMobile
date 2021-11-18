using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InputSwipeView : BaseInputView
{
    private Vector3 _pos;

    private void Start()
    {
        //Cursor.visible = false;
        _pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _pos += new Vector3(CrossPlatformInputManager.GetAxis("Mouse X") * Time.deltaTime * 1000, CrossPlatformInputManager.GetAxis("Mouse Y") * Time.deltaTime * 1000, 0);
        Transform tr = GetComponent<RectTransform>();
        tr.position = _pos;
    }
}
