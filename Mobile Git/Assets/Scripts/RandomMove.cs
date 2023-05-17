using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(0.26f, 0.35f, 0);
    float speed = 0.4f;
    void Update()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * speed);
    }
}
