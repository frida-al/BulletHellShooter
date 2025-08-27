using UnityEngine;

public class BulletType1 : MonoBehaviour
{
    public GameObject bulletType1;
    public float bulletSpeed = 20f;
    public Transform firePoint;
    public float fireEvery = 0.05f;

    private float nextFireTime = 0f;

    void Update() {
        if (Input.GetKey(KeyCode.A) && Time.time >= nextFireTime) {
            FireBullet();
            nextFireTime = Time.time + fireEvery;
        }
        
    }

    void FireBullet() {
        GameObject bullet = Instantiate(bulletType1, firePoint.position, firePoint.rotation);

    }
}
