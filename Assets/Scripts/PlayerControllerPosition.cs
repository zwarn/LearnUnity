using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerPosition : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;
    
    void Update()
    {
        Vector3 delta = Vector3.zero;
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            delta.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            delta.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            delta.y += jumpSpeed * Time.deltaTime;
        }

        gameObject.transform.position += delta;
    }
}
