using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyLeft;
    [SerializeField]
    KeyCode keyRight;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyLeft))
            GetComponent<Rigidbody>().velocity = v3Force;
        if (Input.GetKey(keyRight)) 
            GetComponent<Rigidbody>().velocity = -v3Force;
    }
}
