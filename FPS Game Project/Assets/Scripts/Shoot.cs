using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet_prefab;
    [SerializeField]
    GameObject origin_point;
    void Update()
    {
        //Debug.Log(GetComponent<Transform>().transform.position);
        float bullet_origin_x = origin_point.transform.position.x;
        float bullet_origin_y = origin_point.transform.position.y;
        float bullet_origin_z = origin_point.transform.position.z;
        if (Input.GetMouseButtonDown(0)){
            GameObject bullet = Instantiate(bullet_prefab, new Vector3 (bullet_origin_x, bullet_origin_y, bullet_origin_z), Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 500000 * Time.deltaTime);
        }
    }
}