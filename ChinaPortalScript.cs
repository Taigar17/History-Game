using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChinaPortalScript : MonoBehaviour
{
    //Takes you to scene Early China 
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
