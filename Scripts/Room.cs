using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject camera;
    


    void Start() // Start is called before the first frame update
    { 
   
    }
    
    void Update()  // Update is called once per frame
    { 
    
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }

    }
}
