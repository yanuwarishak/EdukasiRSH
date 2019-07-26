using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour
{
    public Material PlayButtonMaterial;
    public Material PauseButtonMaterial;
    public Renderer PlayButtonRenderer;
    // Start is called before the first frame update
    
    void Awake() {
       var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPause()
    {
        var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();   
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            PlayButtonRenderer.material = PlayButtonMaterial;
        } else
        {
            videoPlayer.Play();
            PlayButtonRenderer.material = PauseButtonMaterial;
        }
    }
}
