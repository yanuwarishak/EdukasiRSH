using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRActivator : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(ActivatorVR("cardboard"));
    }

    public IEnumerator ActivatorVR(string VRACTIVE)
    {
        XRSettings.LoadDeviceByName(VRACTIVE);
        yield return null;
        XRSettings.enabled = true;
    }

}
