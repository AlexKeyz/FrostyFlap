using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public AudioSource ad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MusicControl.isOn == true)
        {
            ad.enabled = true;
        }
        if (MusicControl.isOn == false)
        {
            ad.enabled = false;
        }
    }
}
