using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoctionManganger : MonoBehaviour
{
    private bool startedLocationProcess = false;
    private float timeLeftUntilTimeout = 15f;

    public void StartLocationProcess()
    {
        if (Input.location.isEnabledByUser)
        {
            //startLocationProcess = true;
            Input.location.Start();
        }
        //else
        {
            //Debug.Text
        }
    }

    private void Update()
    {
        if (startedLocationProcess)
        {
            switch (Input.location.status)
            {
                case LocationServiceStatus.Stopped:
                    startedLocationProcess = false;
                    break;
                case LocationServiceStatus.Initializing:
                    startedLocationProcess = false;
                    break;
                case LocationServiceStatus.Running:
                    startedLocationProcess = false;
                    break;
            }
        }
    }
}
