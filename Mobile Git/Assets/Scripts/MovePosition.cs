using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovePosition : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float cycleLeangth = 2;
    //[SerializeField] private AnimationCurve Curve;
    //[SerializeField] private float duration;
    //[SerializeField] private Ease aaa;

    void Start()
    {
        transform.DOMove(new Vector3(10,0,0),cycleLeangth).SetEase(Ease.InBounce).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
