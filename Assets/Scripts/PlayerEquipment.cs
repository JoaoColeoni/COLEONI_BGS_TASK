using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{
    public PaperDoll hatObject, hairObject, suitObject;

    public void EquipItem(ItemsObject item)
    {
        if(item.itemType == ItemType.Hair)
        {
            hairObject.spriteName = item.prefabName;
            hairObject.gameObject.SetActive(true);
            hairObject.LoadSprites();
        }
        else if(item.itemType == ItemType.Hat)
        {
            hatObject.spriteName = item.prefabName;
            hatObject.gameObject.SetActive(true);
            hatObject.LoadSprites();
        }
        else if(item.itemType == ItemType.Suit)
        {
            suitObject.spriteName = item.prefabName;
            suitObject.gameObject.SetActive(true);
            suitObject.LoadSprites();
        }
    }
}
