using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOrotate : MonoBehaviour
{
    [SerializeField] private float cycleLength;
    void Start()
    {
        transform.DORotate(new Vector3(0,-360,0), cycleLength * 0.5f, RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear);
    }
}
