using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StarterPortal : MonoBehaviour
{
    //Takes you to scene England
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);
    }
}