using UnityEngine;

/// <summary>
/// Class <c>Bullet1Movement</c> specifies the movement of the bullet type 1,
/// which is represented by a sin(X) function, with an amplitud of 1.7 and
/// a frequency of 6.
/// </summary>

public class Bullet1Movement : MonoBehaviour
{
    public float amplitude = 1.7f;
    public float frequency = 6f;

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
