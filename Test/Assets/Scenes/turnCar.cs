using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnCar : MonoBehaviour
{
    public float Speed;
    public float Turnspeed;
    private Rigidbody rb;
    public float Grevitymul;
    // start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // update is called once per frame
    void FixedUpdate()
    {
        Turn();
        Accelerate();
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.D) && transform.eulerAngles.z > 255)
        {
            if(Speed > 45)
            {
                Speed = 45;
            }
            // rb.AddTorque(-Vector3.forward * Speed);
            rb.angularVelocity = new Vector3(0, 0, -Speed/10);
        }
        else if (Input.GetKey(KeyCode.A) && transform.eulerAngles.z < 255)
        {
            if (Speed > 45)
            {
                Speed = 45;
            }
            rb.angularVelocity = new Vector3(0, 0, Speed/10);
            // rb.AddTorque(Vector3.forward * Speed);
        }
    }

    void Accelerate()
    {
        if (Input.GetKey(KeyCode.W) && Speed < 45)
        {
            Speed++;
        }
        else if (Input.GetKey(KeyCode.S) && Speed > -45)
        {
            
            Speed--;
        }
        else if(Speed > 0)
        {
            rb.angularVelocity = new Vector3(0, 0, 0);
            Speed = Speed/10;
            Speed--;
        }
        else if(Speed < 0)
        {
            Speed++;
        }

       
    }


    //public float speed;
    //public float turnSpeed;
    //public float gravityMultiplier;

    //private Rigidbody rb;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
    //    Accelerate();
    //    Turn();
    //    Fall();
    //}

    //void Accelerate()
    //{
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        Vector3 forceToAdd = transform.forward;
    //        forceToAdd.y = 0;
    //        rb.AddForce(forceToAdd * speed * 10);
    //    }
    //    else if (Input.GetKey(KeyCode.S))
    //    {
    //        Vector3 forceToAdd = -transform.forward;
    //        forceToAdd.y = 0;
    //        rb.AddForce(forceToAdd * speed * 10);
    //    }

    //    Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
    //    locVel = new Vector3(0, locVel.y, locVel.z);
    //    rb.velocity = new Vector3(transform.TransformDirection(locVel).x, rb.velocity.y, transform.TransformDirection(locVel).z);
    //}

    //void Turn()
    //{
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        rb.AddTorque(-Vector3.up * turnSpeed * 10);
    //    }
    //    else if (Input.GetKey(KeyCode.D))
    //    {
    //        rb.AddTorque(Vector3.up * turnSpeed * 10);
    //    }
    //}

    //void Fall()
    //{
    //    rb.AddForce(Vector3.down * gravityMultiplier * 10);
    //}
}
