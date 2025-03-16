using UnityEngine;

public class OpenWebPage : MonoBehaviour
{
    public string url;
    public void OpenNewPage()
    {
        Application.OpenURL(url);
    }
}
