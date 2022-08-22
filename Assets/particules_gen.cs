using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particules_gen : MonoBehaviour
{
    public GameObject particle;
    public float radius;
    public float slowdown;
    //private Rigidbody2D rigbod;
    //public Vector2 director;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject o = Instantiate(particle, transform);
        o.transform.parent = this.transform;
        o.transform.localPosition = Random.insideUnitCircle * radius;
        

    }
   
}


// rb.velocity = new Vector3(0, 10, 0);
//isMoving = true;