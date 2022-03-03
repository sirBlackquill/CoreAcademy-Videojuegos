using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 3f;
    public float jump = 8;
    private bool grounded;
    public float h;
    public SpriteRenderer spriterenderer;
    public Sprite LeftSprite;
    public Sprite RightSprite;
    private Firegun firegun;
    // Start is called before the first frame update
    void Start()
    {
        grounded = false;
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        if (h < 0) 
        {
            RotatePlayerLeft(); 
        }
       if (h>0 || Input.GetKey(KeyCode.RightArrow))
        {
            RotatePlayerRight();
        }
      

        if (Input.GetKey(KeyCode.Space) && grounded)
            {
                
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
}
    
    void RotatePlayerLeft()
    {
         
            transform.eulerAngles = new Vector2(0, 180);
        
    
    }
    void RotatePlayerRight()
    {

        transform.eulerAngles = new Vector2(0, 0);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground"){
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
}
