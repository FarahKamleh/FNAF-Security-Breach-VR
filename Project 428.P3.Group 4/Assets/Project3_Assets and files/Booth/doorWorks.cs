using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorWorks : MonoBehaviour
{
    public AudioSource openNoise;
    public AudioSource closeNoise;
    void Start() {
        openNoise.Stop();
        closeNoise.Stop();
    }
    // Update is called once per frame
    void playOpen() {
        openNoise.Play(0);
    }
    void playClose() {
        closeNoise.Play(0);
    }
}
