using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateKey : MonoBehaviour
{
    [SerializeField]
    private GameObject key;
    [System.NonSerialized]
    public static CreateKey instance;

    private float mapDepth;
    private float mapWidth;
    private float mapMag;

    private float pickUpKey;
    private int picknum;

    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }

    private void Start() {
        pickUpKey=Random.value * 6 + 4;
        pickUpKey = Mathf.RoundToInt(pickUpKey);

        mapDepth = CreateCubeMap.instance.GetDepth();
        mapWidth = CreateCubeMap.instance.GetWidth();
        mapMag = CreateCubeMap.instance.GetMagnification();
        //spicknum = 0;

        CreateKeyAll();

    }


    private void CreateKeyAll() {
        for(int i = 0; i < pickUpKey; i++){
            Vector3 pos = new Vector3(Random.value * (mapDepth - 5) * mapMag + 5, 25, Random.value * (mapWidth - 5) * mapMag + 5);
            GameObject obj = Instantiate(key,pos,Quaternion.identity);
            obj.transform.SetParent(transform);                //キューブを子オブジェクトにする

        }
    }
}
