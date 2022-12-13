using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public GameManager gm;

    private float mapDepth;
    private float mapWidth;

    private bool isGoalAct;

    private void Start(){
        mapDepth = CreateCubeMap.instance.GetDepth();
        mapWidth = CreateCubeMap.instance.GetWidth();
        isGoalAct = false;
    }

    private void Update() {

       int kCount = GameManager.instance.keyCount;
       int mkCount = GameManager.instance.maxKeyCount;

       if(kCount >= mkCount && isGoalAct == false){
            Vector3 pos = new Vector3(mapWidth / 2, 20,mapDepth / 2);
            GameObject obj = Instantiate(goal, pos, Quaternion.identity);
            isGoalAct = true;
       }
    }

    private void OnTriggerEnter(Collider other){
        gm.ChangeScene("End");

    }
    
    private void OnCollisionEnter(Collision other) {
        gm.ChangeScene("End");
    }

}