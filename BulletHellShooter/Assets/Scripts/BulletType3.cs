using UnityEngine;
using System.Collections;

/// <summary>
/// Class <c>BulletType3</c> specifies the speed of the bullet type 3,
///  its instantiation point and frequency (to be fired), and its destruction rate.
/// </summary>

public class BulletType3 : MonoBehaviour {

    public GameObject bulletType3;
    public Transform firePoint;
    public float bulletSpeed = 60f;
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
        BulletCounter.Instance.BulletFired();

        Destroy(bullet, 2f);
        StartCoroutine(NotifyBulletDestroyedAfterDelay(2f));
    }

        private IEnumerator NotifyBulletDestroyedAfterDelay(float delay) {
        yield return new WaitForSeconds(delay);
        BulletCounter.Instance.BulletDestroyed();
    }
}
