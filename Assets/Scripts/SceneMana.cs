using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMana : MonoBehaviour
{
    public string nomScene;
    
    public void changeScene(string nomSceneFunc)
    {
        SceneManager.LoadScene(nomSceneFunc);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Start()
    {
        
    }
}