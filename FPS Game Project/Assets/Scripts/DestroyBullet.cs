using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(this.gameObject, 6f);
    }
    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject, 0.01f);
    }
}
