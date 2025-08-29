using UnityEngine;
using System.Collections;

/// <summary>
/// Class <c>BulletType2</c> specifies the speed of the bullet type 2,
/// its instantiation point and frequency (to be fired), and its destruction rate.
/// It also contains the movement pattern of this bullet.
/// </summary>

public class BulletType2 : MonoBehaviour {
    
    public GameObject bulletType2;
    public Transform firePoint;
    public int numberOfBullets = 5; 
    public float spreadAngle = 30f; 
    public float bulletSpeed = 60f; 
    public float fireEvery = 0.05f;

    private float nextFireTime = 0f;

    void Update() {
        if (Input.GetKey(KeyCode.S) && Time.time >= nextFireTime){
            FireBullet();
            nextFireTime = Time.time + fireEvery;
        }
    }

    public void FireBullet() {
        float angleStep = spreadAngle / (numberOfBullets - 1);
        float startAngle = -spreadAngle / 2; 
        for (int i = 0; i < numberOfBullets; i++) {
            float angle = startAngle + (i * angleStep);
            Quaternion bulletRotation = Quaternion.Euler(angle, 90, 0);
            GameObject bullet = Instantiate(bulletType2, firePoint.position, bulletRotation);
            BulletCounter.Instance.BulletFired();


            bullet.GetComponent<Bullet2Movement>().SetSpeed(bulletSpeed);
            Destroy(bullet, 2f);
            StartCoroutine(NotifyBulletDestroyedAfterDelay(2f));
        }
    }

    private IEnumerator NotifyBulletDestroyedAfterDelay(float delay) {
        yield return new WaitForSeconds(delay);
        BulletCounter.Instance.BulletDestroyed();
    }
}
