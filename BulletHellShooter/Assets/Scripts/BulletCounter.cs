using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Class <c>BulletCounter</c> handles the logic behind the bullet counter in the UI, incrementing each time a 
/// bullet is instantiated and decrementing when it is destroyed. It updates the TextMeshPro accordingly, in 
/// real time.
/// </summary>

public class BulletCounter : MonoBehaviour
{
    public static BulletCounter Instance;
    public TextMeshProUGUI counter;
    public int currentBulletCount = 0;

    private void Awake() {
        if (Instance == null)
            Instance = this;
        else
        Destroy(gameObject);
    }

    public void BulletFired() {
        currentBulletCount ++;
        UpdateUI();
    }

    public void BulletDestroyed() {
        currentBulletCount --;
        UpdateUI();
    }

    private void UpdateUI() {
        if (counter != null){
            counter.text = "Bullets " + currentBulletCount;
        }
    }
}
