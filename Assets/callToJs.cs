using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class callToJs : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void aFunctionImplementedInJavaScriptLibraryFile(string str);

    void Start()
    {
        aFunctionImplementedInJavaScriptLibraryFile("A string from C# side!");
    }
}
