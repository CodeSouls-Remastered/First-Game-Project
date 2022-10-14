using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    
    [SerializeField]
    GameObject obj_to_destroy;
    void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "Bullet"){
            Destroy(obj_to_destroy, 0.2f);
        }
    }
}
