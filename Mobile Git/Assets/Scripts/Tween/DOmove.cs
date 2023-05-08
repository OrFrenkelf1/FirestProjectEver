using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOmove : MonoBehaviour
{
    [SerializeField] private float cycleLength;
    void Start()
    {
        transform.DOMove(new Vector3(10, 0, 0), cycleLength).SetEase(Ease.InSine).SetLoops(-1,LoopType.Yoyo);
    }
}
