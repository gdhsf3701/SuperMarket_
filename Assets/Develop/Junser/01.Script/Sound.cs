using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField]
    AudioClip bgm;
    AudioSource audio;
    public void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = bgm;
        audio.Play();
    }
}
