using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
     public float moveSpeed = 5f;
     public float jumpSpeed = 10f;
     public bool isGrounded = false;
     float HorizontalMove = 0f;
     float VerticalMove = 0f;
     public Animator animator;
     private Rigidbody2D RigidBody;

     public bool sniff = false;
     public bool sit = false;

    // Start is called before the first frame update
    void Start()
    {
         RigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         //Jump();
         //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
         HorizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
         VerticalMove = Input.GetAxisRaw("Vertical") * moveSpeed;

         animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
         if (HorizontalMove > 0)
         {
              GetComponent<SpriteRenderer>().flipX = false;
         }
         else if (HorizontalMove < 0)
         {
              GetComponent<SpriteRenderer>().flipX = true;
         }

         if (Input.GetKeyDown(KeyCode.F))
         {
              animator.SetTrigger("DogHeadDownWalk");
         }
         if (Input.GetKeyDown(KeyCode.F) && HorizontalMove == 0)
         {
              animator.SetBool("DownSniff", true);
         }
         if (Input.GetKeyUp(KeyCode.F))
         {
              animator.SetBool("DownSniff", false);
         }
         if (Input.GetKeyDown(KeyCode.R) && HorizontalMove == 0)
         {
              animator.SetBool("UpSniff", true);
         }
         if (Input.GetKeyUp(KeyCode.R))
         {
              animator.SetBool("UpSniff", false);
         }
         if (Input.GetKeyDown(KeyCode.C) && HorizontalMove == 0)
         {
              animator.SetTrigger("Sit");
              sit = true;
         }
         if (Input.GetKeyDown(KeyCode.X) && HorizontalMove == 0 && sit)
         {
              animator.SetTrigger("Lay");
              sit = false;
         }


         Vector3 movement = new Vector3(HorizontalMove, VerticalMove, 0f);
         transform.position += movement * Time.deltaTime;
         //RigidBody.AddForce(movement);
    }

    void Jump()
    {
         if (Input.GetButtonDown("Jump") && isGrounded == true)
         {
              gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
         }
    }
}
