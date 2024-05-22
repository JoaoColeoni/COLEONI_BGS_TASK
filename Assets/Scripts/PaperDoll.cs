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
    
    public void LoadSprites()
    {
        spriteArray = Resources.LoadAll<Sprite>(spriteName);
    }

    void Update()
    {
        if(!gameObject.activeSelf)
            return;

        String[] aux = doolRenderer.sprite.name.Split("_");
        myRenderer.sprite = spriteArray[int.Parse(aux[aux.Length - 1])];
    }
}
