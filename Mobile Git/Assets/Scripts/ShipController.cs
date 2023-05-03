using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    [SerializeField] private float speed;

    
    void Update()
    {
        Vector3 currentAccelration = Vector3.zero;
        //Input.acceleration;
        currentAccelration = Input.gyro.userAcceleration;

        currentAccelration.z *= -1;
        transform.Translate(currentAccelration * (Time.deltaTime * speed));

        
    }
}
