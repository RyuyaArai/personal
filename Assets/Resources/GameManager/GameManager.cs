using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int KeyCount;
    public Text textComponent;

    private void Start(){
        KeyCount=0;
    }

    public void AddKeyCount(){
        KeyCount++;
        textComponent.text = "KeyCount : "+ KeyCount;
    }

    public int GetCount(){
        return KeyCount;
    }

    public void SceneReset(){
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene){
        SceneManager.LoadScene(nextScene);
    }

}
