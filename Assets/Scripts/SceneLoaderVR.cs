using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderVR : MonoBehaviour
{

    public float gazeTime = 2f;
    private float timer = 0f;
    private bool gazedAt = false;
    public string sceneName;
    // Start is called before the first frame update
    
    void Start()
    {

    }

    void Update() 
    {
        if (gazedAt == true)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                SceneManager.LoadScene(sceneName);
                timer = 0f;
            }
        }
    }

    public void OnPointerEnter()
    {
        gazedAt = true;
    }

    public void OnPointerExit()
    {
        gazedAt = false;
    }
}
