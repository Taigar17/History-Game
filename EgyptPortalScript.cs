using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EgyptPortalScript : MonoBehaviour
{
    //Takes you to scene Egypt Scene 
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
