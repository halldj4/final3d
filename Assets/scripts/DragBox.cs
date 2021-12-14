using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragBox : MonoBehaviour
{
    private Vector3 offset = new Vector3(0,0,5.0f);

    private float ZCoord = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = ZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
   
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }
}
