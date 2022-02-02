using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanelSound : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void panels()
    {
        panel.SetActive(!panel.activeInHierarchy);
    }
}
