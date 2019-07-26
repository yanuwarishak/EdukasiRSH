using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBtnControl : MonoBehaviour
{

    public float gazeTime = 2f;
    private float timer = 0f;
    private bool gazedAt = false;
    public WorldSpaceVideo WorldSpaceVideo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() 
    {

        if (gazedAt == true)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                WorldSpaceVideo.PlayPause();
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
