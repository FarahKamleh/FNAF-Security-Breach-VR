using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    // audio to trigger
    public AudioSource Theme;

    // lights to trigger
    public Light GFLight;
    public Light GCLight;
    public Light RWLight;
    public Light MGLight;
    public Light CLight;

    // Start is called before the first frame update
    void Start()
    {
        // make sure the song is not playing at the start
        Theme.Stop();

        // turn off lights at start
        GFLight.enabled = false;
        GCLight.enabled = false;
        RWLight.enabled = false;
        MGLight.enabled = false;
        CLight.enabled = false;
    }

    // when pulled down, start playing theme
    public void EverythingOn() {

        // activate the song
        Theme.Play();

        // turn on lights 
        GFLight.enabled = true;
        GCLight.enabled = true;
        RWLight.enabled = true;
        MGLight.enabled = true;
        CLight.enabled = true;
    }

    // when pulled back up, stop playing theme
    public void EverythingOff() {

        // deactivate the song
        Theme.Stop();

        // turn off lights again
        GFLight.enabled = false;
        GCLight.enabled = false;
        RWLight.enabled = false;
        MGLight.enabled = false;
        CLight.enabled = false;
    }
}
