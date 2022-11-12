using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSpawn : MonoBehaviour
{
    // the game objects involved
    public GameObject RedButton;
    public GameObject Flashlight;

    // for position, rotation, and scale
    public Vector3 fPosition;
    public Quaternion fRotation;
    public Vector3 fScale;

    // Start is called before the first frame update
    void Start()
    {
        // copy the initial position, rotation, and scale of the disabled flashlight in the scene
        fPosition = Flashlight.transform.position;
        fRotation = Flashlight.transform.rotation;
        fScale = Flashlight.transform.localScale;

        // move initial curry out of the way
        // Curry.transform.position = new Vector3(150, 150, 150);

    }

    // if collision occurs
    void OnTriggerEnter(Collider collision)
    {
        // create new flashlight in flashlight charger
        GameObject SpawnedFlashlight = Instantiate(Flashlight, fPosition, fRotation);
    }
}
