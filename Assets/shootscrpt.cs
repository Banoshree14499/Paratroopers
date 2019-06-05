using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shootscrpt : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 dir;
    public GameObject smoke;
    bool foradded = false;
    public static int score=0;
    
   

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void FixedUpdate()
    {
        if (spawnbullet.shooting == true&& foradded==false)
        {
            dir = Quaternion.AngleAxis(rot.angle, Vector3.forward) * Vector3.right;
            rb.AddForce(dir * 2000f);
            spawnbullet.shooting = false;
            spawnbullet.Empty = true;
            foradded = true;
        }
        if(transform.position.y>6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Cloud"))
        {
            Destroy(collision.gameObject);
            Instantiate(smoke, transform.position, smoke.transform.rotation);
            score += 100;
            
            
        }
        if(collision.CompareTag("Attacker"))
        {
            Destroy(collision.gameObject);
            Instantiate(smoke, transform.position, smoke.transform.rotation);
            score += 500;
           

        }
    }
}
