using UnityEngine;

public class RevealEasteregg : MonoBehaviour
{
    
    [SerializeField]
    GameObject obj_to_destroy;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Bullet"){
            Destroy(obj_to_destroy, 0.2f);
        }
    }
}
