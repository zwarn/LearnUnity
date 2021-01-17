using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerForce : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float jumpSpeed = 100f;

    public GameObject bullet;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            delta.y += jumpSpeed;
        }

        _rigidbody.AddForce(delta);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(Instantiate(bullet, transform.position, Quaternion.identity), 2);
        }
    }
}