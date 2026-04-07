using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bulllet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
   // get a reference for the empty, get bullet prefab. 
    public GameObject bulletPrefab;
    public Transform pointer;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
        
    }

    public void Shoot()
    {
        //spawn the bullet at the location of the empty. 
        Instantiate(bulletPrefab, pointer.position, pointer.rotation);
       
    }
}
