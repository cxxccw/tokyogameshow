using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{

    // Start is called before the first frame update
    public bool windright = true;
    public bool windup;


    public float x = -50;
    public float y = 0;



    public float startx = -50;
    public float starty = 0;
    public float Maxx = 50;
    public float Minx = -50;
    public float Midx = 0;



    public float speedx = 1;
    public float speedy = 1;


    // Start is called before the first frame update
    void Start()
    {



    }
    void Update()
    {
        cloudOn();
    }

    void cloudOn()
    {
        if (windright)
        {
            x = x + speedx;
            y = y - speedy;
            this.transform.position = new Vector3(x, y, -10.0f);

            if (x > Midx)
            {
                windright = false;

                windup = true;
            }
        }
       
        if (windup)
        {
            x = x - speedx;
            y = y + speedy;
            this.transform.position = new Vector3(x, y, -10.0f);
            if (x < Minx)
            {
                windup = false;

                windright = true;
            }
        }
     

    }


}

