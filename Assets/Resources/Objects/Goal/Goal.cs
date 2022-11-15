using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public GameManager gm;

    private void Start(){

    }

    private void Update() {
       
    }

    private void OnTriggerEnter(Collider other){
        gm.ChangeScene("End");

    }

}