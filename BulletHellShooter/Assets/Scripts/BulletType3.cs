using UnityEngine;

public class BulletType3 : MonoBehaviour
{
    public GameObject bulletType3;
    public float bulletSpeed = 20f;
    public Transform firePoint;

    void Update() {
        if (Input.GetKeyDown(KeyCode.D)) {
            FireBullet();
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
