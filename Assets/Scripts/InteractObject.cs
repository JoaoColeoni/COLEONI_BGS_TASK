using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    public GameObject menuObject;
    bool onRange;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            onRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            onRange = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(onRange && Input.GetKeyDown("e"))
        {
            menuObject.SetActive(true);
        }
    }
}
