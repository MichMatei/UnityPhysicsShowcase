using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMaterials : MonoBehaviour
{
    public GameObject ice;
    public GameObject rock;
    public GameObject sphereBouncy;
    public Transform icePositon;
    public Transform rockPosition;
    public Transform sphereBouncylocation;

    public Rigidbody icey;
    public Rigidbody Rockey;
    public Rigidbody sphereBouncey;

    bool resetPositions = false;

    private void OnTriggerEnter(Collider other)
    {
        resetPositions = true;
    }

    private void OnTriggerExit(Collider other)
    {
        resetPositions = false;
    }

    private void Update()
    {
        //if the "R" key is pressed and the boolean variable is true, the transforms of the objects will be reset
        if(Input.GetKey(KeyCode.R) && resetPositions == true)
        {
            ice.transform.position = icePositon.transform.position;
            ice.transform.rotation = icePositon.transform.rotation;
            icey.velocity = Vector3.zero;
            icey.angularVelocity = Vector3.zero;

            rock.transform.position = rockPosition.transform.position;
            rock.transform.rotation = rockPosition.transform.rotation;
            Rockey.velocity = Vector3.zero;
            Rockey.angularVelocity = Vector3.zero;

            sphereBouncy.transform.position = sphereBouncylocation.transform.position;
            sphereBouncy.transform.rotation = sphereBouncylocation.transform.rotation;
        }
    }
}
