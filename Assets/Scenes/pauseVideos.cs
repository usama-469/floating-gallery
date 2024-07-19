using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Video;

public class pauseVideos : MonoBehaviour
{
    public List<VideoPlayer> videoPlayersCubes; // List of VideoPlayer components to preload


    public void PauseVideo()
    {
        foreach (VideoPlayer vp in videoPlayersCubes)
        {
            if (vp != null)
            {
                vp.Pause();
            }
        }
    }

    public void ResumeVideo()
    {
        foreach (VideoPlayer vp in videoPlayersCubes)
        {
            if (vp != null)
            {
                vp.Play();
            }
        }
    }
}

