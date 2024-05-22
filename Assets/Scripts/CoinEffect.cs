using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinEffect : MonoBehaviour
{
    [SerializeField]
    private float effectSpeed;
    [SerializeField]
    private float timeToDestroy;
    [SerializeField]
    private TMP_Text coinTxt;
    public void StartEffect(int value)
    {
        coinTxt.text = "+" + value.ToString();
        Destroy(gameObject,timeToDestroy);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, effectSpeed, 0);
    }
}
