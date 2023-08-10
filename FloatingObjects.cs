using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotates collectable objects through transform function
        transform.Rotate(0f, 50f * Time.deltaTime, 0f, Space.Self);
        //deltaTime = number of seconds rendered which normalises speed now
    }
}
