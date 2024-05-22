using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperDoll : MonoBehaviour
{
    public SpriteRenderer doolRenderer;
    public SpriteRenderer myRenderer;
    public string spriteName;
    private Sprite[] spriteArray;
    void Start()
    {
        spriteArray = Resources.LoadAll<Sprite>(spriteName);
    }

    void Update()
    {
        String[] aux = doolRenderer.sprite.name.Split("_");
        myRenderer.sprite = spriteArray[int.Parse(aux[aux.Length - 1])];
    }
}
