using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDrive : MonoBehaviour
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
        Move();
        //turn();
        Fall();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * Speed * 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * -Speed * 10);
        }
        //Vector3 localvel = transform.InverseTransformDirection(rb.velocity);
        //localvel.x = 0;
        //rb.velocity = transform.TransformDirection(localvel);

        Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
        locVel = new Vector3(0, locVel.y, locVel.z);
        rb.velocity = new Vector3(transform.TransformDirection(locVel).x, rb.velocity.y, transform.TransformDirection(locVel).z);
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * Turnspeed * 10);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * Turnspeed * 10);
        }
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * Grevitymul * 10);
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
