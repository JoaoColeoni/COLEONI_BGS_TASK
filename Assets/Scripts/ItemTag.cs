using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemTag : MonoBehaviour
{
    private ItemsObject item;
    public TMP_Text nameTxt, valueTxt;
    public Image spriteImg;
    public Button buyBtn, equipBtn;
    public void InitiateTag(ItemsObject itemsObject)
    {
        item = itemsObject;
        nameTxt.text = itemsObject.prefabName;
        valueTxt.text = itemsObject.value.ToString();
        spriteImg.sprite = itemsObject.sprite;
    }

    public void Buy()
    {
        if(Inventory.Instance.gold >= item.value)
        {
            Inventory.Instance.GoldUpdate(-item.value);
            buyBtn.gameObject.SetActive(false);
            equipBtn.gameObject.SetActive(true);
        }
    }

    public void Equip()
    {
        Inventory.Instance.playerEquipment.EquipItem(item);
    }
}
