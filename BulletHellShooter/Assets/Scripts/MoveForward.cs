using UnityEngine;

/// <summary>
/// Class <c>MoveForward</c> allows the character to move in the horizontal axis
/// </summary>

public class MoveForward : MonoBehaviour
{
    
    public int speed;

    void Start()
    {
        
    }

    void Update() {
    float moveHorizontal = Input.GetAxis("Horizontal"); 

    Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
    transform.Translate(movement * speed * Time.deltaTime);
    }
}

