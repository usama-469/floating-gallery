using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class preLoaderVid : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign the VideoPlayer component in the inspector
    private bool isPrepared = false;


    void Start()            //will delete it later
    {

    }

    public void PrepareVidToPlay()
    {
        // Preload the video at the start
        
            videoPlayer.Prepare();
            videoPlayer.prepareCompleted += OnVideoPrepared;



        
        

    }
    public void OnVideoPrepared(VideoPlayer vp)
    {
        isPrepared = true;
        Debug.Log("Video prepared: " + vp.url);
        PlayVideo();
    }

    private void PlayVideo()
    {
        if (isPrepared)
        {
            videoPlayer.Play();
            Debug.Log("video is being playeed");
        }
    }

    public void StopVideo()
    {
        videoPlayer.Stop();
        isPrepared = false; Debug.Log("video is stopped");
    }

}
