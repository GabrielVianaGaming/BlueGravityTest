using System.Collections;
using TMPro;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    [SerializeField] private PlayerEquips _playerEquips;
    [SerializeField] private ItemHood[] _itemSetupHood;
    [SerializeField] private ItemBody[] _itemSetupBody;
    [SerializeField] private TextMeshProUGUI _noCoinMessage;
    [SerializeField] private TextMeshProUGUI _itemPurchased;
    
    public void BuyItemHood(int itemID)
    {
        if (_playerEquips.CharCoins < _itemSetupHood[itemID].Value)
        {
            StartCoroutine(ShowNoCoinMessage());
        }
        else
        {
            StartCoroutine(ShowItemPurchasedMessage());
            
            _playerEquips.CharCoins -= _itemSetupHood[itemID].Value;
            _playerEquips.SetCoins();
            _playerEquips.SetItemBuyHood(_itemSetupHood[itemID]);
        }
    }
    
    public void BuyItemBody(int itemID)
    {
        if (_playerEquips.CharCoins < _itemSetupBody[itemID].Value)
        {
            StartCoroutine(ShowNoCoinMessage());
        }
        else
        {
            StartCoroutine(ShowItemPurchasedMessage());
            
            _playerEquips.CharCoins -= _itemSetupBody[itemID].Value;
            _playerEquips.SetCoins();
            _playerEquips.SetItemBuyBody(_itemSetupBody[itemID]);
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
