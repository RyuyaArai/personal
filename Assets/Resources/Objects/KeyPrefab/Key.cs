using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameManager gm;
    public GameObject door;

    private void Start(){
        GameObject managerObject = GameObject.Find("GameManager");
        gm = managerObject.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            gm.AddKeyCount();
            Destroy(door);
            Destroy(gameObject);
        }
    }
}
