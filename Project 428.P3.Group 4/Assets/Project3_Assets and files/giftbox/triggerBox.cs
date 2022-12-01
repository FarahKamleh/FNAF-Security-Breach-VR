using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBox : MonoBehaviour
{
    public GameObject bonnie;
    public GameObject it;
    void triggered() {
        GetComponent<Animation>().Play();
        Vector3 newV = new Vector3 (it.transform.position.x, it.transform.position.y, it.transform.position.z);
        GameObject bonnied_ = Instantiate(bonnie, newV, it.transform.rotation);
        bonnied_.transform.localScale += new Vector3(0.02f,0.02f,0.02f);
        // bonnied_.GetComponent<Rigidbody>().velocity = new Vector3(transform.localEulerAngles.x, 5, transform.localEulerAngles.z);
    }
}
