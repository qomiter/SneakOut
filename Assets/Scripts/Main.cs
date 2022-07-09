using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Vector2 direction;
    [SerializeField] float power = 5.0f;
    [SerializeField] Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        // init rigidbody
        rb = GetComponent<Rigidbody2D>();
        // init animation
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        // get controler input
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //sword strike
        if (Input.GetButtonDown("Fire1"))
        {
            //create a new strike
            anim.Play("sword");
        }

        //move rigid body
        rb.AddForce(direction * power);
        
        // stop movement
        if (direction.magnitude < 0.1f)
        {
            rb.velocity = new Vector2(0, 0);
        }
        
    }
}
