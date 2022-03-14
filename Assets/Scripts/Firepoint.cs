using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Firepoint : MonoBehaviour
{
    public float speed;
  
    
    
  
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right * speed;
            
            //new Vector2(+speed, 0);
        
        Destroy(gameObject, 3f);
        
            
        

        
    }
}
