using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBack : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        other.transform.position = new Vector3(0, 59.8f, -25.45f);
    }
}
