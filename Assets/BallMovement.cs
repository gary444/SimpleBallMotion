using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = gameObject.transform.position;
        
        TriggerMovement();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TriggerMovement();
        }
    }

    void TriggerMovement()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        gameObject.transform.position = startPos;

        Vector3 force = Vector3.left;
        GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
    }
}
