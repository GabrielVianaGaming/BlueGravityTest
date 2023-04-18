using UnityEngine;

public class MarketAreaDetection : MonoBehaviour
{
    [SerializeField] private GameObject _marketButton;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) _marketButton.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other) => _marketButton.SetActive(false);
}
