using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kettei_effect : MonoBehaviour
{
    public GameObject tenntou1;
    public GameObject tenntou2;
    public GameObject chara1;
    public float tenntou1_A = 0;
    public float tenntou2_A = 0;
    public float chara1_A = 0;
    public float tenntou1_Aspeed = 0;
    public float tenntou2_Aspeed = 0;
    public float chara1_Aspeed = 0;
    public bool KetteiON;
    public bool X;
    // Use this for initialization

    void Start()
    {
        tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou1_A / 255);
        tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou2_A / 255);
        chara1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, chara1_A / 255);

    }


    // Update is called once per frame

    void Update()
    {
        Kettei();
    }

    void WindMoveStart()
    {
        KetteiON = true;
        Debug.Log("決定START");
    }

    void Kettei()

    {
        if (KetteiON)
        {
            tenntou1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou1_A / 255);
            Debug.Log(tenntou1.GetComponent<SpriteRenderer>().color);
            tenntou2.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, tenntou2_A / 255);
            Debug.Log(tenntou2.GetComponent<SpriteRenderer>().color);
            chara1.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, chara1_A / 255);
            Debug.Log(chara1.GetComponent<SpriteRenderer>().color);

            tenntou1_A += tenntou1_Aspeed;

            if (tenntou1_A >= 255)
            {
                tenntou2_A += tenntou2_Aspeed;

            }


            if (tenntou2_A >= 255)
            {
                chara1_A += chara1_Aspeed;
            }
        }
    }
}
