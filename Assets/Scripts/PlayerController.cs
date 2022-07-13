using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        // make a change

    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        // setting the right/left keys
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the truck forward at a certain speed in real time with up/down keys
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


        // truck will be turning right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
