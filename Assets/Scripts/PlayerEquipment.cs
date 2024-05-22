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
            hairObject.spriteName = item.spriteSheetName;
            hairObject.LoadSprites();
            hairObject.gameObject.SetActive(true);
        }
        else if(item.itemType == ItemType.Hat)
        {
            hatObject.spriteName = item.spriteSheetName;
            hatObject.LoadSprites();
            hatObject.gameObject.SetActive(true);
        }
        else if(item.itemType == ItemType.Suit)
        {
            suitObject.spriteName = item.spriteSheetName;
            suitObject.LoadSprites();
            suitObject.gameObject.SetActive(true);
        }
    }
}
