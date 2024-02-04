using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulatingGravity : MonoBehaviour
{
    public Rigidbody firstCube;
    public Rigidbody secondCube;

    bool canManipulate = false;

    private void OnTriggerEnter(Collider other)
    {
        canManipulate = true;
    }


    private void OnTriggerExit(Collider other)
    {
        canManipulate = false;
    }

    void FixedUpdate()
    {
        //following code applies velocity to different axis depending on the input
        //if Up Arrow key is pressed, upward velocity will be applied. Same goes for every input below
        if(Input.GetKey(KeyCode.RightArrow) && canManipulate == true)
        {
            firstCube.velocity = Vector3.right * 9.81f;
            secondCube.velocity = Vector3.right * 9.81f;
        }
        else if(Input.GetKey(KeyCode.LeftArrow) && canManipulate == true)
        {
            firstCube.velocity = Vector3.left * 9.81f;
            secondCube.velocity = Vector3.left * 9.81f;
        }
        else if(Input.GetKey(KeyCode.UpArrow) && canManipulate == true)
        {
            firstCube.velocity = Vector3.up * 9.81f;
            secondCube.velocity = Vector3.up * 9.81f;
        }
        else if(Input.GetKey(KeyCode.DownArrow) && canManipulate == true)
        {
            firstCube.velocity = Vector3.back * 9.81f;
            secondCube.velocity = Vector3.back * 9.81f;
        }
        else if(Input.GetKey(KeyCode.RightShift) && canManipulate == true)
        {
            firstCube.velocity = Vector3.forward * 9.81f;
            secondCube.velocity = Vector3.forward * 9.81f;
        }
    }
}
