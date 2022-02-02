using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    IEnumerator StartWait()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("NLO");
    }
    public void start()
    {
        StartCoroutine(StartWait());
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void panels()
    {
        panel.SetActive(!panel.activeInHierarchy);
    }
    public void Exit()
    {
        Application.Quit();
    }
}