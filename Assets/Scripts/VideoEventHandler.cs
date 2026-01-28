using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEventHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float holdTimeRequired = 2.0f;
    private float holdTimer = 0f;
    private bool triggered = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            holdTimer += Time.deltaTime;
            Debug.Log(holdTimer);

            if (holdTimer >= holdTimeRequired && !triggered)
            {
                triggered = true;
                OnHoldCtrlCompleted();
            }
        }
        else
        {
            holdTimer = 0f;
            triggered = false;
        }
    }

    void OnHoldCtrlCompleted()
    {
        LoadEndScene();
    }

    void Start()
    {
        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;
        videoPlayer.Prepare();
    }

    void OnPrepared(VideoPlayer vp)
    {
        vp.Play();
    }

    void OnVideoEnd(VideoPlayer videoPlayer)
    {
        LoadEndScene();
    }

    void LoadEndScene()
    {
        SceneManager.LoadScene("TheEnd");
    }
}
