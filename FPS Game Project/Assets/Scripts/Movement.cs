using UnityEngine;

public class Movement : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 x_axis_move = transform.forward;
        Vector3 z_axis_move = transform.right;
        if (Input.GetKey("w")){
            GetComponent<Rigidbody>().AddForce(x_axis_move * 470 * Time.deltaTime);
        }
        if (Input.GetKey("s")){
            GetComponent<Rigidbody>().AddForce(x_axis_move * -470 * Time.deltaTime);
        }
        if (Input.GetKey("a")){
            GetComponent<Rigidbody>().AddForce(z_axis_move * -470 * Time.deltaTime);
        }
        if (Input.GetKey("d")){
            GetComponent<Rigidbody>().AddForce(z_axis_move * 470 * Time.deltaTime);
        }
    }
}
