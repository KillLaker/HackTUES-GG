using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float speed;
private bool Is_grounded;
public LayerMask Ground_layer;
public Animator Player_animation;
public BoxCollider2D duljina;
public Rigidbody2D rb;
private float movex;
public float movey;


 private void Update()
    {
        CheckGrounded();
        Rotating();
        Jump();
        MoveAnimation();
         movex = Input.GetAxisRaw("Horizontal") * speed;
        transform.position += new Vector3(movex * Time.deltaTime, 0f, 0f);

    }

   
    void Rotating()
    {
     if(movex<0)
     {
         GetComponent<SpriteRenderer>().flipX=true;
     }
    else if(movex>0)
        {
            GetComponent<SpriteRenderer>().flipX=false;
        }
    }

    private void CheckGrounded()
    {
          Is_grounded = Physics2D.Raycast(duljina.bounds.center,
            Vector2.down, duljina.bounds.extents.y + 0.5f, Ground_layer);
    }

    void Jump()
    {
        if((Input.GetKeyDown(KeyCode.W) ||Input.GetKeyDown(KeyCode.Space)) && Is_grounded)
        {
         rb.velocity=Vector2.up * movey;
        }
    }

    void MoveAnimation()
    {
      if(movex!=0)
      {
          Player_animation.SetBool("Running", true);
      }
      else Player_animation.SetBool("Running", false);
    }



}
