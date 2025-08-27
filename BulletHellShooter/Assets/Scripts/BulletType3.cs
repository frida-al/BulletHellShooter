using UnityEngine;

public class BulletType3 : MonoBehaviour
{
    public GameObject bulletType3;
    public float bulletSpeed = 20f;
    public Transform firePoint;
    public float fireEvery = 0.05f;

    private float nextFireTime = 0f;

    void Update() {
        if (Input.GetKey(KeyCode.D) && Time.time >= nextFireTime) {
            FireBullet();
            nextFireTime = Time.time + fireEvery;
        }
        
    }

    void FireBullet() {
        GameObject bullet = Instantiate(bulletType3, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb !=null){
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}
