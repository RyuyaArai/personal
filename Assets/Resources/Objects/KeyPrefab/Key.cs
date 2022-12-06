using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    private GameManager gm;
    [SerializeField]
    private GameObject key;

    private float mapDepth;
    private float mapWidth;
    private float mapMag;

    private float pickUpKey;

    private void Start(){
        GameObject managerObject = GameObject.Find("GameManager");
        gm = managerObject.GetComponent<GameManager>();
        pickUpKey=Random.value * 10 + 2;
        pickUpKey = Mathf.RoundToInt(pickUpKey);

        mapDepth = CreateCubeMap.instance.GetDepth();
        mapWidth = CreateCubeMap.instance.GetWidth();
        mapMag = CreateCubeMap.instance.GetMagnification();

    }

    private void CreateKey(){
        for(int i = 0; i < pickUpKey; i++){
            Vector3 pos = new Vector3(Random.value * (mapDepth - 5) * mapMag + 5, 25, Random.value * (mapWidth - 5) * mapMag + 5);
            Instantiate(key,pos,Quaternion.identity);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "player") {
            gm.AddKeyCount();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player") {
            gm.AddKeyCount();
            Destroy(gameObject);
        }
    }
    
}
