using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemySpeed;

    Rigidbody _rigidBody;

    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        _rigidBody.velocity = Vector3.forward * -enemySpeed;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        this.gameObject.SetActive(false);
    }

    void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
