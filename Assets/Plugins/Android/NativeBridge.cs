﻿using UnityEngine;

#if UNITY_ANDROID
public class NativeBridge
{

    
    public static string RetreiveData()
    {
        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        // Retrieve the UnityPlayerActivity object ( a.k.a. the current context )
        AndroidJavaObject unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");

        // Retrieve the "Bridge" from our native plugin.
        // ! Notice we define the complete package name.              
        AndroidJavaObject bridge = new AndroidJavaObject("com.naren.retrieve.Retrieve");

        object[] parameters = new object[1];
        parameters[0] = unityActivity;


        // Call PrintString in bridge, with our parameters.
        return bridge.Call<string>("RetrieveUnityData", parameters);
    }
}
#endif
