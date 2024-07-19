using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class preLoad2 : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign the VideoPlayer component in the inspector
    private bool isPrepared = false;
    private bool isPreloading = false;
    private float timeDel = 1.0f;
    public AudioSource audio22;

 

    private void Awake()
    {
        StartCoroutine(PreloadAndPlayVideo());
    }
    public void PlayVideo()
    {


        //if (isPrepared)
        //{
        //    videoPlayer.Play();
        //}
        //else if (!isPreloading)
        //{
        StartCoroutine(PreloadAndPlayVideo());
        //}

    }

    private IEnumerator PreloadAndPlayVideo()
    {
        if (videoPlayer != null)
        {
            isPreloading = true;
            videoPlayer.Prepare();
            while (!videoPlayer.isPrepared)
            {
                yield return null;
            }
            isPrepared = true;
            isPreloading = false;
            //videoPlayer.Play();
            StartCoroutine(DelayedPlay());
        }
    }

    private IEnumerator DelayedPlay()
    {

        yield return new WaitForSeconds(timeDel); // Adding a 0.5 second delay
        videoPlayer.Play();
        isPrepared = false;
        audio22.Play();

    }




}
