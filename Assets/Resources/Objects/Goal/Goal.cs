using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public GameManager gm;
    private string nextScene;

    private void Update(){
        if(gm.GetCount()==3){
            goal.SetActive(true);
        }   
    }
    

    private void OnTriggerEnter(Collider other){
        

    }
}