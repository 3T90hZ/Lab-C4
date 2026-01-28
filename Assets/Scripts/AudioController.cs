using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
        }
    }
}
