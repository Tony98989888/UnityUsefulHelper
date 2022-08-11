using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class TestEventManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.StartListening("Test", TestEvent);
    }

    private void OnDisable()
    {
        EventManager.StopListening("Test", TestEvent);
    }

    private void TestEvent(object arg0)
    {
        Debug.Log(arg0.GetType());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            EventManager.TriggerEvent("Test", "Fuck");
        }
    }
}