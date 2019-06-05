using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bugcontrol : MonoBehaviour
{
    public Rigidbody2D self;
    bool dropped = false;
    public static bool fin = false;
  
   
   
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y<=-4f&&dropped==false)
        {
            self.gravityScale = 0f;
            self.velocity = Vector3.zero;
            dropped = true;
        }
        if(transform.position.y<=-4f)
        {
            if (1f < transform.position.x)
            {
                self.velocity = Vector3.left*0.3f;
            }
            else if(-1f>transform.position.x)
            {
                self.velocity = Vector3.right * 0.3f;
            }
            if(1f>transform.position.x&&-1f<transform.position.x)
            {
                Debug.Log("GameOver");
                self.velocity = Vector3.zero;
                bugcontrol.fin = true;
            }
        }
    }
}
