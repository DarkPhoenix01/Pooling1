using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    
    public int bulletSpeed;

    public Rigidbody _rigidBody;

    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        _rigidBody.velocity = Vector3.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        this.gameObject.SetActive(false);
    }
}