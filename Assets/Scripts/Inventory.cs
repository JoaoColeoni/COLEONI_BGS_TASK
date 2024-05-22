using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance { get; private set; }
    public PlayerEquipment playerEquipment;
    public int gold = 100;
    public TMP_Text goldTxt;
    public ItemsObject[] allItems;
    public ItemTag itemTagPrefab;
    public GameObject hatsList, hairsList, suitsList;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        foreach (ItemsObject item in allItems)
        {
            Transform auxParent = null;
            if(item.itemType == ItemType.Hat)
            {
                auxParent = hatsList.transform;
            }
            else if(item.itemType == ItemType.Hair)
            {
                auxParent = hairsList.transform;
            }
            else if(item.itemType == ItemType.Suit)
            {
                auxParent = suitsList.transform;
            }

            ItemTag tag = Instantiate(itemTagPrefab, auxParent).GetComponent<ItemTag>();
            tag.InitiateTag(item);
        }
    }

    public void GoldUpdate(int value)
    {
        gold += value;
        goldTxt.text = gold.ToString();
    }
}
