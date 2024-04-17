using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class Logger : MonoBehaviour
{
    public UnityEvent<string> onMessageLogged;
    
    public void Log(string message)
    {
        message = $"{DateTime.Now}\n{message}";
        Debug.Log(message);
        onMessageLogged?.Invoke(message);
    }
}
