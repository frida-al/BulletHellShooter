using UnityEngine;

public class Bullet2Movement : MonoBehaviour {
    private float speed; 
    public void SetSpeed(float bulletSpeed) {
        speed = bulletSpeed; 
    }
    void Update() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
