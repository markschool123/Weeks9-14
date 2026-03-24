using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float ammo;
    public float maxAmmo = 5;
    public bool isReloading;
    float reloadTime = 3;
    public bool isShooting;
    public UnityEvent onFire;

    void Start()
    {
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos.z = 0;
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;
    }


    public void OnAttack(InputAction.CallbackContext context)
    {
       

        if (context.performed)
        {
         

            Shoot();
        }


    }


    public void Shoot()
    {
        if (!isReloading && ammo > 0)
        {
            isShooting = true;
            ammo--;
            onFire.Invoke();    
            Debug.Log("FIRE!");

            if (ammo == 0)
            {
                StartCoroutine(Reloading());
                isShooting=false;
            }
            else
            {
                isShooting = false;
            }

        }

    }

    IEnumerator Reloading()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
       
        isReloading=false;
        ammo = maxAmmo;
    }

    
   




}