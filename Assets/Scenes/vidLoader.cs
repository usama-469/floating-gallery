using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class vidLoader : MonoBehaviour
{
    public List<VideoPlayer> videoPlayers; // List of VideoPlayer components to preload


    void Awake()
    {
        // Ensure all VideoPlayers are attached and preload all videos
        foreach (VideoPlayer vp in videoPlayers)
        {
            if (vp != null)
            {
                vp.Prepare();
                
                StartCoroutine(WaitForPreparation(vp));
                Debug.Log("vid player " + vp + "is ready");
            }
        }
    }

    private IEnumerator WaitForPreparation(VideoPlayer vp)
    {
        while (!vp.isPrepared)
        {
            yield return null;
        }
       
    }
}
