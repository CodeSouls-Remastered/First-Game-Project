using UnityEngine;

public class PlayerScriptController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Ground"){
            GetComponent<Movement>().enabled = true;
            GetComponent<Jump>().enabled = true;
            GetComponent<Shoot>().enabled = true;
        }
    }
    private void OnCollisionStay(Collision other) {
        if (other.collider.tag == "Ground"){
            GetComponent<Jump>().enabled = true;
        }
    }
    private void OnCollisionExit(Collision other) {
        if (other.collider.tag == "Ground"){
            GetComponent<Jump>().enabled = false;
        }
    }
}
