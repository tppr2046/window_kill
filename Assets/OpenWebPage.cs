using UnityEngine;
using System.Runtime.InteropServices;

public class OpenWebPage : MonoBehaviour
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);
#endif

    public void OpenNewPage()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        OpenNewTab("share.html");
#else
        Application.OpenURL("share.html");
#endif
    }
}
