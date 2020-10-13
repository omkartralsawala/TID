using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class view360 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Book;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        float rotSpeed=10f;
        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        //Book.transform.RotateAround(Vector3.up, -rotX);
        Book.transform.RotateAround(Vector3.back, rotX);//leftright
        Book.transform.RotateAround(Vector3.left, -rotY);//updown
    }
}
