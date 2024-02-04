using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody rb;
    public float xForce;
    public float yForce;
    public float zForce;
    public Vector3 sphereStartPosition;
    public Transform sphere;
    public Transform locationForTheCube;
    public GameObject theCube; 
        
    // Start is called before the first frame update
    void Start()
    {
        sphereStartPosition = transform.position;
        rb.AddForce(xForce * Time.deltaTime, yForce * Time.deltaTime, zForce * Time.deltaTime);
    }

    //OnTriggerEnter function that resets the sphere and cube location and rotation when the sphere hits a trigger
    private void OnTriggerEnter(Collider other)
    {
        sphere.transform.position = sphereStartPosition;
        theCube.transform.rotation = locationForTheCube.transform.rotation;
        theCube.transform.position = locationForTheCube.transform.position;

        //it readds force on the sphere after the velocity has been reset so that the sphere keeps
        //firing in the same way
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        rb.AddForce(xForce * Time.deltaTime, yForce * Time.deltaTime, zForce * Time.deltaTime);
    }
}