using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverAction_SunMoon : MonoBehaviour
{
    public GameObject sunDrop;
    public GameObject moonDrop;

    void Start() {
        sunDrop.SetActive(true);
        moonDrop.SetActive(false);
    }
    public void swapToMoon(){
        sunDrop.SetActive(false);
        moonDrop.SetActive(true);
    }
    public void swapToSun(){
        sunDrop.SetActive(true);
        moonDrop.SetActive(false);
    }
}
