using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    [SerializeField]
    private Transform charaLookAtPosition;
    [SerializeField]
    private Vector3 forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forward = charaLookAtPosition.forward;
    }
}
