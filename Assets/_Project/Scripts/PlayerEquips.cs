using System.Linq;
using TMPro;
using UnityEngine;

public class PlayerEquips : MonoBehaviour
{
    [SerializeField] private ItemHood[] _charHood;
    [SerializeField] private ItemBody[] _charBody;
    [SerializeField] private SpriteRenderer _spriteRendererHood;
    [SerializeField] private SpriteRenderer _spriteRendererBody;
    [SerializeField] private int _charCoins;
    [SerializeField] private TextMeshProUGUI _coinText;
    
    public int CharCoins
    {
        get => _charCoins;
        set => _charCoins = value;
    }

    private void Start()
    {
        SetCoins();
        SetFirstItems();
    }

    public void SetCoins()
    {
        var coins = $"Coins: {CharCoins}";
        _coinText.text = coins;
    }

    private void SetFirstItems()
    {
        var itemHead = _charHood.First();
        var itemBody = _charBody.First();

        _spriteRendererHood.sprite = itemHead.Sprite;
        _spriteRendererBody.sprite = itemBody.Sprite;
    }

    public void SetItemBuyHood(ItemHood itemHood) => _spriteRendererHood.sprite = itemHood.Sprite;

    public void SetItemBuyBody(ItemBody itemBody) => _spriteRendererBody.sprite = itemBody.Sprite;
}
