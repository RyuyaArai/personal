using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody=GetComponent<Rigidbody>();
        rigidbody.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            rigidbody.velocity = transform.forward * speed;;
        }
        if(Input.GetKey(KeyCode.A)){
            rigidbody.velocity = -transform.right * speed;
        }
        if(Input.GetKey(KeyCode.S)){
            rigidbody.velocity = -transform.forward * speed;;
        }
        if(Input.GetKey(KeyCode.D)){
            rigidbody.velocity = transform.right * speed;;
        }
    }
}
