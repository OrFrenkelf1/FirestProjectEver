using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using System;
using UnityEditor.SceneManagement;

public class AnalyticsMangeger : MonoBehaviour
{
    [ContextMenu("Initlaize UGS")]
    async void Start()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("one");
        await UnityServices.InitializeAsync();
        Debug.Log("seacond");
        List<string> consentIdentifers = await AnalyticsService.Instance.CheckForRequiredConsents();
        try
        {

            if (consentIdentifers.Count > 0)
            {
                foreach (string consentIdentifer in consentIdentifers)
                    Debug.Log(consentIdentifer);
            }
            else
            {
                Debug.Log("No need for consent in Analytics");
            }
        }
        catch (ConsentCheckException exception)
        {
            Debug.LogError("Exception with checking contents" + Environment.NewLine + exception.Message);
        }

        
    }
}
