using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string linkVideo;

    public void OpenVideo(){
        Application.OpenURL(linkVideo);
    }
}
