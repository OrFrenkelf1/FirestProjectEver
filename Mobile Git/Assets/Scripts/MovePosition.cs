using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovePosition : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    //[SerializeField] private AnimationCurve Curve;
    [SerializeField] private float duration;
    [SerializeField] private Ease aaa;

    void Start()
    {
        transform.DOMove(targetTransform.position, duration);//
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
