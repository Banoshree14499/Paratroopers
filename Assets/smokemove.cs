using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokemove : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 18f || transform.position.x < -18f)
        {
            Destroy(gameObject);
        }
    }
}
