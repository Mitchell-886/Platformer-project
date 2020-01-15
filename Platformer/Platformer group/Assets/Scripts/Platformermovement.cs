using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformermovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float jumpspeed = 1.0f;
    bool grounded = false;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 9;
        }
        else
        {
            moveSpeed = 6;
        }

        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump();
            
        }
        float x = Input.GetAxisRaw("Horizontal");
        if(x == 0)
        {
            anim.SetInteger("x", 0);
        }
        else
        {
            anim.SetInteger("x", 1);
        }
        if(velocity.y > 0)
        {
            anim.SetInteger("y", 1);
        }
        else if (velocity.y < 0)
        {
            anim.SetInteger("y", -1);
        }
        else
        {
            anim.SetInteger("y", 0);
        }
        if(x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    public void jump()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpspeed));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0)
        {
            grounded = true;
            anim.SetBool("grounded", grounded);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0)
        {
            grounded = false;
            anim.SetBool("grounded", grounded);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 0)
        {
            grounded = true;
            anim.SetBool("grounded", grounded);
        }
    }

}
