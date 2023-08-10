using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MuseumPortalScipt : MonoBehaviour
{
    //Takes you to scene Mueseum 
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }
} 