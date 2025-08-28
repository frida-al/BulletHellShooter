using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(8,0,-4);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This method is called once per frame
    /// </summary>
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}