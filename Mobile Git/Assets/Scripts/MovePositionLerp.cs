using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionLerp : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float lerpDuration = 0;

    private Vector3 startingPosition;
    private bool isMovingTowardsPlayer = false;

    private float sumTimePassed = 0f;

    void Start()
    {
        startingPosition = transform.position;
        isMovingTowardsPlayer = true;
    }

    void Update()
    {
        sumTimePassed += Time.deltaTime;

        if(isMovingTowardsPlayer)
        {
            transform.position = Vector3.Lerp(startingPosition, targetTransform.position, sumTimePassed/lerpDuration);
            if (sumTimePassed >= lerpDuration)
                isMovingTowardsPlayer = false;
        }
    }
}
