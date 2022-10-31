using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class control1 : MonoBehaviour
{

    //private AudioSource audio1;
    //public void start()
    //{
    //    audio1 = GetComponent<AudioSource>();
    //} 
    public void albastrumod ()
    {
        SceneManager.LoadScene("lic1");
    }

    public void rosumod()
    {
        SceneManager.LoadScene("lic2");
    }

    public void verdemod()
    {
        SceneManager.LoadScene("lic3");
    }

    //public void audio ()
    //{
    //    audio1.enabled = !audio1.enabled;
    //}

    public void iesire()
    {
        Application.Quit();
    }
}
