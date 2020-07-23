using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{   public int speed;
    public GameObject uitext;
    float lifetime=10;
    public GameObject hieuung;
    

    // Start is called before the first frame update
    void Start()
    {
        uitext.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left*speed*Time.deltaTime);
         lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {   Debug.Log("da");
             Destroy(gameObject);
        }      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Instantiate(hieuung,transform.position,Quaternion.identity); 
        Time.timeScale = 1; 
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
       
    }
}
