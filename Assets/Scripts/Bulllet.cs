using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bulllet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
   
    public GameObject bulletPrefab;
    public Transform pointer;
    float speed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
        
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, pointer.position, pointer.rotation);
    }
}
