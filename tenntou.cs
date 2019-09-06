using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenntou : MonoBehaviour
{

    public GameObject tenntou1;
    public GameObject tenntou2;
    public GameObject tenntou3;
    public float tenntou1_A = 0;
    public float tenntou2_A = 0;
    public float tenntou3_A = 0;
    public bool X;
    // Use this for initialization
    void Start()
    {
        tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 0 / 255);
        tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 0 / 255);
        tenntou3.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 0 / 255);
    }

    // Update is called once per frame
    void Update()
    {
        tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou1_A / 255);
        Debug.Log(tenntou1.GetComponent<SpriteRenderer>().color);
        tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou2_A / 255);
        Debug.Log(tenntou2.GetComponent<SpriteRenderer>().color);
        tenntou3.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou3_A / 255);
        Debug.Log(tenntou3.GetComponent<SpriteRenderer>().color);

        tenntou1_A += 1f;
         
        if(tenntou1_A >= 255)
        {
            tenntou2_A += 1f;

        }

        if (tenntou2_A >= 255)
        {
            tenntou3_A += 1f;
        }


    
    }
}
