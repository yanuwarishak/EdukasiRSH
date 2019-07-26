using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrevScene : MonoBehaviour
{
    private float secondsToLoadNextScene = 0.5f;
    private static int lastScene;
    private int mainScene = 0;
    private int currentScene;

    public static Stack<int> sceneStack = new Stack<int>();


    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        BackButtonPressed();
    }

    public void LoadNextScene(int numberOfSceneToLoad)
    {
        StartCoroutine(LoadScene(numberOfSceneToLoad));
    }

    private IEnumerator LoadScene(int numberOfScene)
    {
        SetLastScene(currentScene);

        yield return new WaitForSeconds(secondsToLoadNextScene);
        LoadNewScene(numberOfScene);
    }

    public void BackButtonPressed()
    {
        if (Input.GetKey(KeyCode.Escape) && currentScene > mainScene)
        {
            if (lastScene == 0)
            {
                Application.Quit ();
            }
            else
            {
               LoadLastScene();                    
            }         
        }
    }

    public void LoadNewScene(int sceneToLoad)
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        sceneStack.Push(currentScene);
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LoadLastScene()
    {
        lastScene = sceneStack.Pop();
        SceneManager.LoadScene(lastScene);
    }

    public static void SetLastScene(int makeCurrentSceneTheLastScene)
    {
        lastScene = makeCurrentSceneTheLastScene;
    }

    public static int GetLastScene()
    {
        return lastScene;
    }    

}
