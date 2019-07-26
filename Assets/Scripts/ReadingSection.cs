using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ReadingSection : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(DeactivatorVR("none"));
        Screen.fullScreen = true;
    }

    public IEnumerator DeactivatorVR(string VRDeactive)
    {
        XRSettings.LoadDeviceByName(VRDeactive);
        yield return null;
        XRSettings.enabled = false;
    }
}
