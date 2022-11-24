using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GregorySound : MonoBehaviour
{
    // game objects involved
    public GameObject Greg;
    public AudioSource Sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // if collision occurs, make sound
    void OnTriggerEnter(Collider collision) {
        
        // when Greg is touched, make a sound
        Sound.Play();
    }
}