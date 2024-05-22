using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningCrate : MonoBehaviour
{
    [SerializeField]
    private GameObject coinEffectPrefab;
    [SerializeField]
    private int minValue,maxValue;

    public void MiningCoin()
    {
        int RNG = Random.Range(minValue,maxValue);
        Inventory.Instance.GoldUpdate(RNG);
        CoinEffect coin = Instantiate(coinEffectPrefab, gameObject.transform).GetComponent<CoinEffect>();
        coin.StartEffect(RNG);
    }
}
