using UnityEngine;

public class Bullet1Movement : MonoBehaviour
{
    public float amplitude = 1.5f;
    public float frequency = 1.5f;

    private Vector3 startPosition;

    void Start() {
        startPosition = transform.position;
        
    }

    void Update() {
        transform.Translate(Vector3.forward * 60f * Time.deltaTime);

        float newY = startPosition.y + Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        
    }
}
