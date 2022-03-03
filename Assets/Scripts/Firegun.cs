using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firegun : MonoBehaviour
{
    public GameObject fireball;
    public float firerate = 0.5f;
    private float nextfire = 0.0f;
    public Transform leftShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.A ) && Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            fire();
            
        }   
    }
 public void fire()
    {   
       
            Instantiate(fireball, transform.position, Quaternion.identity);
      
        
    }

}
