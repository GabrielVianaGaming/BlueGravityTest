using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSetupBody : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private ItemBody _item;
    
    private void Start() => SetItems();

    private void SetItems()
    {
        _image.sprite = _item.Sprite;
        _value.text = $"Coins {_item.Value.ToString()}";
    }
}
