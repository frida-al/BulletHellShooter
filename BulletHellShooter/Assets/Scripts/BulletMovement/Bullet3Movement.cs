using UnityEngine;

/// <summary>
/// Class <c>Bullet3Movement</c> specifies the movement of the bullet type 3,
/// which is represented by a tan(X) function, with an amplitud of 1.7 and
/// a frequency of 4.
/// </summary>
public class Bullet3Movement : MonoBehaviour
{
    public float amplitude = 1f;
    public float frequency = 4f;

    private Vector3 startPosition;

    void Start() {
        startPosition = transform.position;
        
    }

    void Update() {
        transform.Translate(Vector3.forward * 60f * Time.deltaTime);


        float newY = startPosition.y + Mathf.Tan(Time.time * frequency) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);        
    }
}
