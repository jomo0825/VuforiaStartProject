using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public AudioClip clipToPlay;

    private AudioSource asource;

    void Awake()
    {
        asource = GetComponent<AudioSource>();
        if (asource == null)
        {
            asource = gameObject.AddComponent<AudioSource>();
        }
        asource.spatialBlend = 0;
    }

    public void OnButtonClicked() {
        if (clipToPlay != null && asource != null)
        {
            asource.clip = clipToPlay;
            asource.Play();
        }
    }
}
