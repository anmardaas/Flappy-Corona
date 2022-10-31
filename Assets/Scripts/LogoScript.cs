using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoScript : MonoBehaviour
{
    public float time = 5f;

    void Start()
    {
        StartCoroutine(DinLogoPanaLaIntro()); 
    }

    IEnumerator DinLogoPanaLaIntro()
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("intro");
    }
}
