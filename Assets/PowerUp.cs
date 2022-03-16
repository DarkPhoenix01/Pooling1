using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int PowerUpSpeed;

    Rigidbody _rigidBody;

    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        _rigidBody.velocity = Vector3.forward * -PowerUpSpeed;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider.tag=="Player")
        {
            this.gameObject.SetActive(false);              
        }

        if(collision.collider.tag=="Map")
        {
            this.gameObject.SetActive(false);              
        }
            
    }

    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
