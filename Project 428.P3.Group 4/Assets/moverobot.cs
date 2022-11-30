using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class moverobot : MonoBehaviour
{
    // Update is called once per frame
    private bool Toggle;
    void Start() {
        Toggle = true;
    }
    void Update()
    {
        // print(transform.localPosition.x);
        if (transform.localPosition.x < 7.0f) {
            Toggle = true;
        }
        if (transform.localPosition.x > 25.0f) { 
            Toggle = false;
        }
        if (Toggle) { 
            transform.Translate(Vector3.back * -1 * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 90, 0);
        } else {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
        print(Toggle);
    }
}
