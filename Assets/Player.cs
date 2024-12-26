using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jump = 5.0f;
    private Rigidbody2D rigid;

    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }

        transform.position += moveVelocity * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 0);
            Vector2 jumpVelocity = new Vector2(0, jump);
            rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);
        }
    }

}
