using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDestroy : MonoBehaviour
{
    [SerializeField] private GameObject targetImageToDestroy;
    void Update()
    {
         if (Input.touchCount > 0)
         {
             Touch touch = Input.GetTouch(0);

             if (touch.phase == TouchPhase.Began)
             {
                 if (targetImageToDestroy != null)
                 {
                     Destroy(targetImageToDestroy);
                 }
             }
         }
        
    }
}
