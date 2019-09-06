using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public bool cloudright = true;
    public bool cloudleft ;
    public bool cloudup ;
    public bool clouddown ;

    public float x = -50;
    public float y =　0;



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
        if (cloudright)
        {
            x = x + speedx;
            y = y - speedy;
            this.transform.position = new Vector3(x , y, -10.0f);

            if (x >Midx)
            {
                cloudright = false;

                cloudleft = true;
            }
        }
        if (cloudleft)
        {
            x = x + speedx;
            y = y + speedy;
            this.transform.position = new Vector3(x, y, -10.0f);
            if (x > Maxx)
            {
                cloudleft = false;

                cloudup = true;
            }
        }
        if (cloudup)
        {
            x = x - speedx;
            y = y + speedy;
            this.transform.position = new Vector3(x, y, -10.0f);
            if (x < Midx)
            {
                cloudup = false;

                clouddown = true;
            }
        }
        if (clouddown)
        {
            x = x - speedx;
            y = y - speedy;
            this.transform.position = new Vector3(x, y, -10.0f);
            if (x < Minx)
            {
                clouddown = false;

                cloudright = true;
            }
        }

    }
    
  
}
