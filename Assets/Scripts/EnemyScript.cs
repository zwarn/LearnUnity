using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float force = 100f;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Equals("leefa"))
        {
            Rigidbody2D rigidbody = other.gameObject.GetComponent<Rigidbody2D>();
            Vector3 away = other.gameObject.transform.position - gameObject.transform.position;
            away = away.normalized * force;
            rigidbody.AddForce(away);
        }
    }
}
