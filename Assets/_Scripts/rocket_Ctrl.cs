using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_Ctrl : MonoBehaviour
{
    Rigidbody RB;

    public float boost_speed;
    public float rotate_speed;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.up * boost_speed * Time.deltaTime);
            RB.AddForce(transform.up * boost_speed * Time.deltaTime, ForceMode.Impulse);
        }
        transform.Rotate(Vector3.forward * Input.GetAxis("Horizontal") * -rotate_speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Portal")
        {

        }
    }
}