using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class ItemsObject : ScriptableObject
{
    public string prefabName;
    public Sprite sprite;
    public int value;
    public string spriteSheetName;
    public ItemType itemType;
}

public enum ItemType {Hat = 0, Hair = 1, Suit = 2};
