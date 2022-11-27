using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBox : MonoBehaviour
{
    public GameObject it;
    public GameObject bonnie;
    void triggered() {
        it.GetComponent<Animation>().Play();
        GameObject bonnied_ = Instantiate(bonnie, it.transform.position, it.transform.rotation);
        bonnied_.transform.localScale += new Vector3(0.06f,0.06f,0.06f);
        bonnied_.GetComponent<Rigidbody>().velocity = new Vector3(0,5,0);
    }
}
