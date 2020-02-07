using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float RunSpeed = 4;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }
    void Run(){
        float velocityX;
        velocityX = Input.GetAxisRaw("Horizontal") * RunSpeed ;
        Vector2 newVelocity = new Vector2(velocityX, myRigidbody.velocity.y);
        myRigidbody.velocity = newVelocity;
    }
}
