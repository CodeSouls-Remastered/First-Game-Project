using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundEasteregg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        TextManager.instance.DiplayCongrats();
        this.GetComponent<MeshRenderer>().enabled = false;
        Destroy(this, 0);
        GameObject portal = GameObject.Find("Portal");
        portal.GetComponent<MeshRenderer>().enabled = true;
    }

}