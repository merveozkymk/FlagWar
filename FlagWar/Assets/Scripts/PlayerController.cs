using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public float speed;
    private Vector2 movement;
    public AnimationClip deathAnimation;
    public GameObject PlayerPoint;
    public GameObject Controller;

    void Update()
    {
        Move();
        walkAnim();
        Flip();
    }

    void Move()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    private void walkAnim()
    {
        if (movement.x !=0 || movement.y !=0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
    void Flip()
    {
        Vector3 theScale = transform.localScale;

        if (Input.GetKeyDown(KeyCode.A))
        {
            theScale.x = -0.18f;
            transform.localScale = theScale;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            theScale.x = 0.18f;
            transform.localScale = theScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            animator.SetBool("IsDeath", true);
            GetComponent<HealthController>().HealthBar();
            Die();
        }

        if (col.tag == "EnemyBird")
        {
            animator.SetBool("IsDeath", true);
            GetComponent<HealthController>().HealthBar();
            Die();
        }
    }
    void Die()
    {
        GetComponent<Animator>().Play(deathAnimation.name);
        Invoke("DisableCharacter", deathAnimation.length);
    }

    void DisableCharacter()
    {
        if (GetComponent<HealthController>().health <= 0)
        {
            Controller.GetComponent<PanelController>().LostPanelControl();
        }
        transform.position = PlayerPoint.transform.position;
        animator.SetBool("IsDeath", false);
        Destroy(GameObject.FindGameObjectWithTag("Enemy"));
    }
}

