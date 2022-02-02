using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    public AudioSource SoudAudio;
    private void OnCollisionEnter(Collision collision)
    {
        SoudAudio.Play();
    }
}
