using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
        }
    }
}
