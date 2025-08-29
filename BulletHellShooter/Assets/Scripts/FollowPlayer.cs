using UnityEngine;

/// <summary>
/// Class <c>FollowPlayer</c> allows the main Camera to follow the movement of the game character
/// </summary>

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(8,0,-4);

    void Start() {
        
    }

    void LateUpdate() {
        transform.position = player.transform.position + offset;
    }
}