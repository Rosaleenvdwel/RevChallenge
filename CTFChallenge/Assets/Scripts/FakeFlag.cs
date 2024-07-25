using System;
using UnityEngine;

public class FakeFlag : MonoBehaviour
{
    void Start()
    {
        string obfuscatedFlag = GetObfuscatedFlag();
        Debug.Log("Some things are buried 6 feet under...");
        Debug.Log("Wizard: " + obfuscatedFlag);
    }

    string GetObfuscatedFlag()
    {
        string flag = "flag{empty}";
        byte[] flagBytes = System.Text.Encoding.UTF8.GetBytes(flag);
        string base64Flag = Convert.ToBase64String(flagBytes);
        return base64Flag;
    }
}

