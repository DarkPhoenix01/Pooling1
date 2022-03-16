using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Rigidbody rb;
    public int speed;

    public Transform gun;
    public Transform gun2;
    public Transform gun4;
    public Transform gun3;
    public GameObject prefab;
    public int bulletType=0;

    public bool powerUp=false;

    void Start()
    {
        rb= GetComponent<Rigidbody>();

    }

   
    void Update()
    {
        Vector3 directionX = Input.GetAxis("Horizontal")*Vector3.right;
        
        Vector3 totalSpeed = directionX*speed;

        rb.velocity = totalSpeed;

        if(Input.GetButtonDown("Jump"))
        {
            
            
            GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
            bullet.transform.position = gun.position;
            bullet.SetActive(true);
        }
        
        if(Input.GetButtonDown("Jump"))
        {
            
            
            GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
            bullet.transform.position = gun2.position;
            bullet.SetActive(true);
        }

        if(powerUp==true)
        {
            if(Input.GetButtonDown("Jump"))
            {
            
            
                GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
                bullet.transform.position = gun3.position;
                bullet.SetActive(true);
            }

            if(Input.GetButtonDown("Jump"))
            {
            
            
                GameObject bullet = PoolManager.instance.GetPooledObject(bulletType);
                bullet.transform.position = gun4.position;
                bullet.SetActive(true);
            }
        }

        
        

    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.collider.tag=="PowerUp")
        {
            powerUp=true;
            StartCoroutine(TimeWait());             
        }
            
    }

    public IEnumerator TimeWait()
    {
        yield return new WaitForSeconds(10);
        powerUp=false;
    }
}
