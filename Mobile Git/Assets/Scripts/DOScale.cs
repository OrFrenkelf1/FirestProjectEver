using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOScale : MonoBehaviour
{
    [SerializeField] private float cycleLength;
    void Start()
    {
        transform.DOScale(new Vector3(1, 1, 0), cycleLength).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
        transform.DORotate(new Vector3(0, 0, 50), cycleLength * 0.5f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        transform.DOMove(new Vector3(0, 20, 0), cycleLength).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

}
