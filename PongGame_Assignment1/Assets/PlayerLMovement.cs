using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLMovement : MonoBehaviour
{
    public float speed = 0.3f;
    public Vector3 speedOfMovement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Limit motion based on position on the y axis
        //y position is based on position of the top and bottom of frame
        //factor in height of paddle

        if (Input.GetKey(KeyCode.W) && transform.position.y < 3.50f)
        {
            transform.Translate(new Vector3(0, speed, 0));
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -3.50f)
        {
            transform.Translate(new Vector3(0, -speed, 0));
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x > -8f)
        {
            transform.Translate(new Vector3(-speed/2, 0, 0));
        }


        if (Input.GetKey(KeyCode.D) && transform.position.x < -2f)
        {
            transform.Translate(new Vector3(speed/2, 0, 0));
        }





        //if (Input.GetKey(KeyCode.A))
        //{
        //transform.Translate(new Vector3(-speed, 0, 0));
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //transform.Translate(new Vector3(speed, 0, 0));
        //}

    }
}
