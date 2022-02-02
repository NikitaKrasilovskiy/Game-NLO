using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class NLOController : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private Rigidbody LeftLegRb;
    [SerializeField] private Rigidbody RightLegRb;
    [SerializeField] private float speed = 25;
    [SerializeField] private float rotationMultiplayer = 0.8f;
    [SerializeField] private Slider SliderLeft;
    [SerializeField] private Slider SliderRight;
    [SerializeField] private TextMeshProUGUI TextLeft;
    [SerializeField] private TextMeshProUGUI TextRight;
    [SerializeField] private TextMeshProUGUI TextVisota;
    [SerializeField] private Collider posiciaNLO;
    public AudioSource explosion;
    private Vector3 visota;

    void Start()
    {
        SliderLeft.maxValue = speed;
        SliderRight.maxValue = speed;
        sceneLoader = FindObjectOfType<SceneLoader>();
        Cursor.visible = false;
    }
    void FixedUpdate()
    {
        Vector3 minForce = Vector3.up * speed * rotationMultiplayer;
        Vector3 maxForce = Vector3.up * speed;

        Vector3 leftForce = Vector3.zero;
        Vector3 rightForce = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            leftForce = minForce;
            rightForce = maxForce;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            leftForce = maxForce;
            rightForce = minForce;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            leftForce = maxForce;
            rightForce = maxForce;
        }

        LeftLegRb.AddRelativeForce(leftForce);
        RightLegRb.AddRelativeForce(rightForce);

        SliderLeft.value = leftForce.y;
        SliderRight.value = rightForce.y;

        visota = posiciaNLO.transform.position;
        TextVisota.text = (Mathf.Round(visota.y) - 2) + " M";

        TextRight.text = rightForce.y + " Wt";
        TextLeft.text = leftForce.y + " Wt";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            explosion.Play();
            sceneLoader.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("Friend"))
        {
            sceneLoader.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}