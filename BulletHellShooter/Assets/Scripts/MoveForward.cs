using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
    float moveHorizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
    float moveVertical = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow
    float moveUpDown = 0f;
    // Optional: Use another input for moving up and down (e.g., Space for up, Left Shift for down)
    if (Input.GetKey(KeyCode.Space))
    {
        moveUpDown = 1f; // Move up
    }
    else if (Input.GetKey(KeyCode.LeftShift))
    {
        moveUpDown = -1f; // Move down
    }
    // Create a movement vector based on input
    Vector3 movement = new Vector3(moveHorizontal, moveUpDown, moveVertical);
    // Move the fairy
    transform.Translate(movement * speed * Time.deltaTime);
    }
}

