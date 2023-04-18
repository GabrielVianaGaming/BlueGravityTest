using UnityEngine;

[CreateAssetMenu(fileName = "ItemCharacter", menuName = "Item/ItemCharacterHood")]
public class ItemHood : ScriptableObject
{
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _value;
    [SerializeField] private int _id;
    
    public Sprite Sprite => _sprite;
    public int Value => _value;
}
