using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool isMuted = false;
    bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;
            AudioListener.volume = isMuted ? 0 : 1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;
            if (isPaused)
                AudioListener.pause = true;
            else
                AudioListener.pause = false;
        }
    }
}
