using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle: MonoBehaviour
{
    private Rigidbody2D rigbod;
    public Vector2 parPosition;
    public Vector2 magnetPosition;
    public float speed;
    public GameObject magnet;
   

    // Start is called before the first frame update
    void Start()
    {
        rigbod = GetComponent<Rigidbody2D>();
        speed = 10f;
        parPosition = this.transform.position;
        rigbod.velocity = transform.position * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mathf.Abs(this.rigbod.velocity.x + this.rigbod.velocity.y) < 2)
        {
            Destroy(this.gameObject);
            magnetPosition = magnet.transform.position;
            parPosition = this.transform.position;
            transform.LookAt(magnet.transform);
            rigbod.velocity = transform.forward * speed;

    }
 
    //if (this.rigbod.velocity.y < 2f)
    //{
    //  Destroy(this.gameObject);
    //}

}
    
}
// void ApplyForce(Rigidbody rigbod)
// {
//    Vector2 pforce = rigbod.transform.position - transform.position;
//   rigbod.AddForce(pforce.normalized);
//  rigbod.AddForce(pforce * speed);
// }

// pforce.Normalized;
//rigbod.AddForce(pforce, ForceMode2D.Force);

// rigbod.AddForce(0, 0, speed, ForceMode.Impulse);
//m_Rigidbody.AddForce(transform.up * m_Thrust)

//m_Rigidbody.AddForce(m_NewForce, ForceMode2D.Force);

// m_Rigidbody.AddForce(m_NewForce, ForceMode2D.Impulse);
//m_ModeSwitching = ModeSwitching.Impulse;
//  void ApplyForce(Rigidbody body)
//{
//  Vector3 direction = body.transform.position - transform.position;
//body.AddForceAtPosition(direction.normalized, transform.position);
//}
//}