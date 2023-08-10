using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PortalScipt : MonoBehaviour
{
    //Takes you to scene Main Menu Scene 
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
} 