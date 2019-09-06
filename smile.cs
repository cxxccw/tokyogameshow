using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smile : MonoBehaviour {
    public bool SmileON;
    public GameObject Smile_e;
    public float Smile_A = 0;
    public bool X;
    // Use this for initialization
    void Start () {
        Smile_e.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Smile_A / 255);
    }
	
	// Update is called once per frame
	void Update () {
        Smile();
    }

    void SmileStart()
    {
        SmileON = true;

        Debug.Log("笑顔エフェクトSTART");
    }

    void Smile()
    {
        if (SmileON)
        {
           Smile_e.GetComponent<SpriteRenderer>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f, Smile_A / 255);

            Debug.Log(Smile_e.GetComponent<SpriteRenderer>().color);
        }
        Smile_A += 1.5f;
    }

}
