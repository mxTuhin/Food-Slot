using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rows : MonoBehaviour
{
    private int randomValue;

    private float timeInterval;

    public bool rowStopped;

    public string stoppedSlot;
    
    // Start is called before the first frame update
    void Start()
    {
        rowStopped = true;
        GameControl.HandlePulled += StartRotating;

    }

    private void StartRotating()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;
        for (int i = 0; i < 30; ++i)
        {
            if(transform)
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
