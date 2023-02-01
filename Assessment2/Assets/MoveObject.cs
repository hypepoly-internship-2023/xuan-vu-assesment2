using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float Cameraz;
    private float Cameray;
    private Camera mainCamera;
    Vector3 cubePos;
    void Start()
    {
        mainCamera = Camera.main;
        Cameraz = mainCamera.WorldToScreenPoint(transform.position).z;
        Debug.LogError(Cameray.ToString() + "");
    }
    private void OnMouseDrag()
    {
        Debug.LogError(Input.mousePosition.ToString()+"A");
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Cameraz);
        //Debug.LogError(screenPosition.ToString() + "C");
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);
        Vector3 Pos = new Vector3(NewWorldPosition.x, 1, NewWorldPosition.y * 1.1f);
        Debug.LogError(NewWorldPosition.ToString() + "D");
        transform.position = Pos;
    }
}
