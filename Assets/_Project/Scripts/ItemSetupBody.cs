using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSetupBody : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _value;
    [SerializeField] private ItemBody _item;
    [SerializeField] private int _id;
    
    public ItemBody Item => _item;

    public void SetItems()
    {
        _image.sprite = Item.Sprite;
        _value.text = $"Coins {Item.Value.ToString()}";
        _id = Item.ID;
    }
}
