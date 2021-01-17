using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 10f;
    void Start()
    {
        Rigidbody2D _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        _rigidbody.velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
