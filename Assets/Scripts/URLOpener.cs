using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string Skeletonurl;


    public void SkeletonOpen()
    {
        Application.OpenURL(Skeletonurl);
    }

}
