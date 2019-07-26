using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtnExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            Application.Quit ();
        }
    }
}
