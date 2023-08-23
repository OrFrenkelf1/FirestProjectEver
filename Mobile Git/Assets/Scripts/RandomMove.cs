using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Vector3 targetPosition;
    public Vector3 targetRotation;

    private float speed = 0.4f;

    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * speed);
        transform.Rotate(targetRotation * speed * Time.deltaTime);
    }
}
