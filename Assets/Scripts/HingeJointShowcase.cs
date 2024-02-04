using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeJointShowcase : MonoBehaviour
{
    public Rigidbody sphere;

    public Transform planePosition;
    public Transform spherePosition;
    bool canMove = false;

    private void OnTriggerEnter(Collider other)
    {
        canMove = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        //code below adds a force to the sphere in different directions depending on the input of the user
        if (Input.GetKey(KeyCode.UpArrow) && canMove == true)
        {
            sphere.AddForce(0f, 0f, 9.81f);
        }
        else if(Input.GetKey(KeyCode.DownArrow) && canMove == true)
        {
            sphere.AddForce(0f, 0f, -9.81f);
        }
        else if(Input.GetKey(KeyCode.RightArrow) && canMove == true)
        {
            sphere.AddForce(9.81f, 0f, 0f);
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && canMove == true)
        {
            sphere.AddForce(-9.81f, 0f, 0f);
        }
        //if the "R" key is pressed and the boolean variable is true, the transforms of the objects will be reset
        else if (Input.GetKey(KeyCode.R) && canMove == true)
        {
            sphere.transform.position = spherePosition.transform.position;
            sphere.transform.rotation = spherePosition.transform.rotation;
            sphere.velocity = Vector3.zero;
            sphere.angularVelocity = Vector3.zero;
        }
    }
}
