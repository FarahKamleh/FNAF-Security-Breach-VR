using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWFB : MonoBehaviour
{
    // Update is called once per frame
    private bool Toggle;
    // Start is called before the first frame update
    void Start()
    {
        Toggle = true;
    }

    // Update is called once per frame
    void Update()
    {
        // print(transform.localPosition.x);
        if (transform.localPosition.x < -17.0f) {
            Toggle = true;
        }
        if (transform.localPosition.x > -12.5f) {
            Toggle = false;
        }
        if (Toggle) { 
            transform.Translate(Vector3.back * -1 * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, 90, 0);
        } else {
            transform.Translate(Vector3.forward * Time.deltaTime);
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
    }
}
