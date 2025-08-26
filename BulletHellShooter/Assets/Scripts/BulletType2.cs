using UnityEngine;

public class BulletType2 : MonoBehaviour
{
    public GameObject bulletType2;
    public float bulletSpeed = 20f;
    public Transform firePoint;

    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            FireBullet();
            FireBullet();
        }
        
    }

    void FireBullet() {
        GameObject bullet = Instantiate(bulletType2, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb !=null){
            rb.velocity = firePoint.forward * bulletSpeed;
        }
    }
}
