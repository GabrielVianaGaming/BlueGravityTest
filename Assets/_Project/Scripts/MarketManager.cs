using System.Collections;
using TMPro;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    [SerializeField] private PlayerEquips _playerEquips;
    [SerializeField] private ItemSetupBody[] _itemSetupBody;
    [SerializeField] private ItemSetupHood[] _itemSetupHood;
    [SerializeField] private TextMeshProUGUI _noCoinMessage;
    [SerializeField] private TextMeshProUGUI _itemPurchased;

    private void Start()
    {
        foreach (var body in _itemSetupBody) body.SetItems();
        foreach (var hood in _itemSetupHood) hood.SetItems();
    }

    public void BuyItemHood(ItemSetupHood itemHood)
    {
        if (_playerEquips.CharCoins < itemHood.Item.Value)
        {
            StartCoroutine(ShowNoCoinMessage());
        }
        else
        {
            StartCoroutine(ShowItemPurchasedMessage());
            
            _playerEquips.CharCoins -= itemHood.Item.Value;
            _playerEquips.SetCoins();
            _playerEquips.SetItemBuyHood(itemHood.Item);
        }
    }
    
    public void BuyItemBody(ItemSetupBody itemBody)
    {
        if (_playerEquips.CharCoins < itemBody.Item.Value)
        {
            StartCoroutine(ShowNoCoinMessage());
        }
        else
        {
            StartCoroutine(ShowItemPurchasedMessage());
            
            _playerEquips.CharCoins -= itemBody.Item.Value;
            _playerEquips.SetCoins();
            _playerEquips.SetItemBuyBody(itemBody.Item);
        }
    }

    private IEnumerator ShowNoCoinMessage()
    {
        _noCoinMessage.alpha = 100f;
        
        yield return new WaitForSeconds(2F);
        
        _noCoinMessage.alpha = 0f;
    }   
    
    private IEnumerator ShowItemPurchasedMessage()
    {
        _itemPurchased.alpha = 100f;
        
        yield return new WaitForSeconds(2F);
        
        _itemPurchased.alpha = 0f;
    }
}
