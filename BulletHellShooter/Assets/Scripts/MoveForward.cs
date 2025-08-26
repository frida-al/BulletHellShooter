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
    float moveHorizontal = Input.GetAxis("Horizontal"); 

    Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
    transform.Translate(movement * speed * Time.deltaTime);
    }
}

