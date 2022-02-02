using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private bool paused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(!panel.activeInHierarchy);

            if (paused)
                paused = false;
            else
                paused = true;
        }
        if (paused)
        {
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else
        {
            Cursor.visible = false;
            Time.timeScale = 1f;
        }
    }
}
