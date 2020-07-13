using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public float offset_x;
    Vector3 pos, tpos, tpos1, tpos2;

    // Start is called before the first frame update
    void Start()
    {
        pos=transform.position;
        pos [1]=Mathf.Sin(pos[0]);
        offset_x=pos[0];
        transform.position=(pos);

    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                tpos1 = Camera.main.ScreenToWorldPoint(touch.position);
                tpos2 = Camera.main.ScreenToWorldPoint(touch.position);
            }

           if (touch.phase == TouchPhase.Moved)
           {
               tpos2 = Camera.main.ScreenToWorldPoint(touch.position);
                tpos[0]=((tpos2[0]-tpos1[0])/30)+offset_x;
                if (tpos[0]<(-32))
                {
                    tpos[0]=16;
                }
                if (tpos[0]>(24))
                {
                    tpos[0]=(-24);
                }                
                offset_x=tpos[0];
                tpos[1]=Mathf.Sin(tpos[0]*2);
                tpos[2]=-1;
                print ("IP"+tpos);
                transform.position=(tpos);
           }
        }
    }
}