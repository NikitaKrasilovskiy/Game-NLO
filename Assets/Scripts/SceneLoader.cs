using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{    IEnumerator SceneWait(int buildIndex)
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(buildIndex);
    }
    public void LoadScene(int buildIndex)
    {
        StartCoroutine(SceneWait(buildIndex));
    }
}