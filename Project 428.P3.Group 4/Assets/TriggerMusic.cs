using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMusic : MonoBehaviour
{
    // audio to trigger
    public AudioSource Theme;

    // Start is called before the first frame update
    void Start()
    {
        // make sure the song is not playing at the start
        Theme.Stop();
    }

    // when pulled down, start playing theme
    public void swapToMoon() {

        // activate the song
        Theme.Play();
    }

    // when pulled back up, stop playing theme
    public void swapToSun() {

        // deactivate the song
        Theme.Stop();
    }
}
