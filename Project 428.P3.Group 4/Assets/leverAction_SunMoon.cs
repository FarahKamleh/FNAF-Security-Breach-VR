using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverAction_SunMoon : MonoBehaviour
{
    public GameObject sunDrop;
    public GameObject moonDrop;

    // particle system
    public ParticleSystem blue;

    // ensure particle system does not play at start
    public bool start = true;

    void Start() {
        sunDrop.SetActive(true);
        moonDrop.SetActive(false);

        // ensure particle system is not on at start 
        blue.Stop();
    }
    public void swapToMoon(){
        sunDrop.SetActive(false);
        moonDrop.SetActive(true);

        // play the particle system
        blue.Play();

        // set start to false
        start = false;
    }
    public void swapToSun(){
        sunDrop.SetActive(true);
        moonDrop.SetActive(false);

        // if not at start
        if (start != true) {
            
            // play the particle system
        blue.Play();
        }
    }
}
