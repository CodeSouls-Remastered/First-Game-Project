using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    void FixedUpdate(){
        if(Input.GetKey("space")){
            rb.AddForce(0, 150 * Time.deltaTime,0, ForceMode.VelocityChange);
        }
    }
}
