using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject nextPod;
    public GameObject player;
    void trigger() {
        player.transform.position = nextPod.transform.position;
        player.transform.rotation = nextPod.transform.rotation;
    }
}
