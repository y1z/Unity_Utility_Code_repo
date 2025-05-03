using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;

/// <summary>
/// This Script depends on StringUtil
/// </summary>
public static class EDebugCol
{
    static public Color currentColor = Color.white;

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void resetColor()
    {
        currentColor = Color.white;
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Log(object msg)
    {
        Debug.Log(StringUtil.addColorToString(msg.ToString(), currentColor));
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Log(object msg, Object context)
    {
        Debug.Log(StringUtil.addColorToString(msg.ToString(), currentColor), context);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message)
    {
        Debug.LogWarning(StringUtil.addColorToString(message.ToString(), currentColor));
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarning(object message, Object context)
    {
        Debug.LogWarning(StringUtil.addColorToString(message.ToString(), currentColor), context);
    }

    /*
    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(string format, params object[] args)
    {
        Debug.LogWarningFormat(format, args);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogWarningFormat(Object context, string format, params object[] args)
    {
        Debug.LogWarningFormat(context, format, args);
    }*/

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogError(object msg)
    {
        Debug.LogError(StringUtil.addColorToString(msg.ToString(), currentColor));
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogError(object msg, Object context)
    {
        Debug.LogError(StringUtil.addColorToString(msg.ToString(), currentColor), context);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogAssertion(object msg, Object context)
    {
        Debug.LogAssertion(StringUtil.addColorToString(msg.ToString(), currentColor), context);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogAssertion(object msg)
    {
        Debug.LogAssertion(StringUtil.addColorToString(msg.ToString(), currentColor));
    }

    /*
    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception)
    {
        Debug.LogException(exception);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void LogException(System.Exception exception, Object context)
    {
        Debug.LogException(exception, context);
    }*/

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition)
    {
        Debug.Assert(condition);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, Object context)
    {
        Debug.Assert(condition, context);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, object message)
    {
        Debug.Assert(condition, StringUtil.addColorToString(message.ToString(), currentColor));
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void Assert(bool condition, object message, Object context)
    {
        Debug.Assert(condition, StringUtil.addColorToString(message.ToString(), currentColor), context);
    }

    /*
    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void AssertFormat(bool condition, string format, params object[] args)
    {
        Debug.AssertFormat(condition, format, args);
    }

    [System.Diagnostics.Conditional("UNITY_EDITOR")]
    public static void AssertFormat(bool condition, Object context, string format, params object[] args)
    {
        Debug.AssertFormat(condition, context, format, args);
    }
*/
}
