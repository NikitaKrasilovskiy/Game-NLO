using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaylist : MonoBehaviour
{
    [SerializeField] private AudioSource[] clips;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }
    private AudioSource GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource = GetRandomClip();
            audioSource.Play();
        }
    }
}