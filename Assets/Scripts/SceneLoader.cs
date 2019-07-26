using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //String name of Scene, specified in Inspector
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneName);  
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
