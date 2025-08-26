using UnityEngine;

public class BulletType1 : MonoBehaviour
{
    public GameObject bulletType1;
    public float bulletSpeed = 20f;
    public Transform firePoint;

    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            FireBullet();
        }
        
    }

    void FireBullet() {
        GameObject bullet = Instantiate(bulletType1, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb !=null){
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}
