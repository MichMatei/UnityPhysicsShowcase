using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetJointSpring : MonoBehaviour
{
    public Transform startPosition;
    public Transform springCube;
    bool resetPosition = false;

    private void OnTriggerEnter(Collider other)
    {
        resetPosition = true;
    }

    private void OnTriggerExit(Collider other)
    {
        resetPosition = false;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R) && resetPosition == true)
        {
            springCube.transform.position = startPosition.transform.position;
        }
    }
}
