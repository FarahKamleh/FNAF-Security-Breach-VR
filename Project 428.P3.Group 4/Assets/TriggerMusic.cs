using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    // audio to trigger
    public AudioSource Theme;
    // public AudioSource lightSound;

    // lights to trigger
    public Light GFLight;
    public Light GCLight;
    public Light RWLight;
    public Light MGLight;
    public Light CLight;
    public Light ceilingLight;

    // Start is called before the first frame update
    void Start()
    {
        // make sure the song is not playing at the start
        Theme.Stop();
        // lightSound.Stop();

        // turn off lights at start
        GFLight.enabled = false;
        GCLight.enabled = false;
        RWLight.enabled = false;
        MGLight.enabled = false;
        CLight.enabled = false;
        ceilingLight.enabled = false;
    }

    // when pulled down, start playing theme and turn on lights
    public void EverythingOn() {

        // turn on lights
        // lightSound.Play();
        GCLight.enabled = true;
        MGLight.enabled = true;

        // call function to delay
        // StartCoroutine(ExampleCoroutine());

        // lightSound.Play();
        GFLight.enabled = true;
        RWLight.enabled = true;

        // call function to delay
        // StartCoroutine(ExampleCoroutine());

        // lightSound.Play();
        CLight.enabled = true;
        ceilingLight.enabled = true;

        // activate the song
        Theme.Play();
    }

    // when pulled back up, stop playing theme
    public void EverythingOff() {

        // turn off lights again
        GFLight.enabled = false;
        GCLight.enabled = false;
        RWLight.enabled = false;
        MGLight.enabled = false;
        CLight.enabled = false;
        ceilingLight.enabled = false;

        // deactivate the song
        Theme.Stop();
        // lightSound.Stop();
    }

    // function to delay
    // IEnumerator ExampleCoroutine()
    // {
    //     // delay five seconds
    //     yield return new WaitForSeconds(5);
    // }
}
