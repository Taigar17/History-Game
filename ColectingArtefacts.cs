using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectingArtefacts : MonoBehaviour
{
    // This script is used to collect the various artefacts in the game
    // These objects will be obvious to collect as they float
    //Scipt to change on screen score

    public int collectables;
    public AudioSource collectSound;

    public void OnTriggerEnter (Collider other)
    {
        collectSound.Play();
        ScoringScript.theScore += 1;
        Destroy(gameObject);
        Debug.Log("Atefact Collected!");

        //if (Col.gameObject.tag == "Collectable")
        //{
        //collectables = collectables + 1;
        //Changed line below since item respawned when return to level
        //Col.gameObject.SetActive(false); //Disable item
        //}
    }
}
