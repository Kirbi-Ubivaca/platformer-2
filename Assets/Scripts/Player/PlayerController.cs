using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    bool isGrounded;
    public float speed;
    public float jumpHeight;
    public Transform groundCheck;
 
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetAxis("Horizontal") == 0 && isGrounded)
       {

       }
      Flip();
      if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
      {
          rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
      }
      GrounCheck();
    }
    void Flip()
    {
       if(Input.GetAxis("Horizontal") > 0){
          transform.localRotation = Quaternion.Euler(0, 0, 0); 
       }
       if(Input.GetAxis("Horizontal") < 0){
          transform.localRotation = Quaternion.Euler(0, 180, 0);
       }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")* speed, rb.velocity.y);
    }

    void GrounCheck()
    {
       Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f);
       isGrounded = colliders.Length > 1;
    }
}