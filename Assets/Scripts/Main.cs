using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    Vector2 direction;
    [SerializeField] float power = 5.0f; 

    // Start is called before the first frame update
    void Start()
    {
        // init rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // get controler input
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        
        //move rigid body
        rb.AddForce(direction * power);
        
        // stop movement
        if (direction.magnitude < 0.1f)
        {
            rb.velocity = new Vector2(0, 0);
        }
        
    }
}
