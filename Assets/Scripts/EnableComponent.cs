using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableComponent : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] effect;
    private ParticleSystem effectPlay;
    void Start()
    {
        effect[0].Stop();
        effect[1].Stop();
        effect[2].Stop();
        effect[3].Stop();
        effect[4].Stop();
        effectPlay = effect[Random.Range(0, effect.Length)];
    }
    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                effectPlay.Play();
            }
    }
}
