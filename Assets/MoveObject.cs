using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private float Cameraz;
    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
        Cameraz = mainCamera.WorldToScreenPoint(transform.position).z;
    }
    private void OnMouseDrag()
    {
        Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Cameraz);
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);
        Vector3 Pos = new Vector3(NewWorldPosition.x, 1, NewWorldPosition.y);
        transform.position = Pos;
    }
}
