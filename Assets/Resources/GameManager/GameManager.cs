using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int KeyCount;
    public Text textComponent;
    public GameObject inductionText;

    private void Start(){
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate=60;
        KeyCount=0;
    }

    private void Update(){
        if(KeyCount==3){
        inductionText.SetActive(true);
        }
    }

    public void AddKeyCount(){
        KeyCount++;
        textComponent.text = "KeyCount : "+ KeyCount;
    }

    public void SceneReset(){
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }

    public void ChangeScene(string nextScene){
        SceneManager.LoadScene(nextScene);
    }
}
