using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomcreate : MonoBehaviour
{   public GameObject bom;
    private float timespaw;
    private int starttime=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(timespaw<=0)
        {
            Instantiate(bom,transform.position,Quaternion.identity);
            timespaw=starttime;
            System.Random rnd = new System.Random();
            starttime = rnd.Next(2, 5);
        }
        else
        {
            timespaw-=Time.deltaTime;
        }
    }
}
