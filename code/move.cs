using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{   Vector3 vec2; 
    trigger j=new trigger();
  
     public Rigidbody2D r2;
    public Animator anim;
     bool jump =true;
    // Start is called before the first frame update
    void Start()
    {
         r2 = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {    Debug.Log(jump);
            if(jump)
            {Debug.Log("cảứng");
                jump=false; 
                r2.AddForce(Vector2.up * 430f);
                   
            }

        }
        else if(Input.GetMouseButtonDown(0))
         { 
              Debug.Log("cảm ứng");
            if(jump)
            {
                jump=false; 
                  r2.AddForce(Vector2.up * 430f);
                   
            }

        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        jump=true;  
    }
}
