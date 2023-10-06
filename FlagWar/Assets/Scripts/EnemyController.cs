using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform playerPos;
    public float speed;
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            playerPos.position,
            speed* Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
