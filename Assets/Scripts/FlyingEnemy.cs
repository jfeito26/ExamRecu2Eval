using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    private float currentTime = 0, Xspeed = 1f, Yspeed = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(new Vector2(Xspeed, Mathf.Sin(Time.time) * Yspeed) * Time.deltaTime);
       if(currentTime == 5 )
        {
            //transform.Translate(new Vector2(Xspeed, Mathf.Sin(Time.time) * (-Xspeed)) * Time.deltaTime);
            //transform.Translate(Vector2(Xspeed * (-Xspeed) * Yspeed) *Time.deltaTime);
            //Xspeed = -1f;
            //Xspeed = -Xspeed;
        } 
    }
}
