using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            Destroy(gameObject);
        }
        if (col.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
