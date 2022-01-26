using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartMotion();
    }

    public void StartMotion()
    {
        //GetComponent identifies the object
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //add motion to the ball at StartMotion in random direction
        //How to prevent values that cause low values of y or x?
        //using || doesn't work
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-3f, 3f);

        //ball moves along vector at a certain velocity
        Vector3 forceVector = new Vector3(x, y, 0);

        rigidbody.velocity = new Vector3(0, 0, 0);
        rigidbody.AddForce(forceVector.normalized * speed);

    }

    // Update is called once per frame
    void Update()
    {

    }
}


////reset game is the ball passes a player and goes off screen
//if (transform.position.x > 10 || transform.position.x < -10)
//{

//}