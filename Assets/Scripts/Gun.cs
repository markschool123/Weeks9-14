using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float ammo;
    public float maxAmmo = 5;
    public UnityEvent onFire;
    public bool isReloading;
    public float reloadTime = 3;
    public bool isShooting;
    void Start()
    {
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnAttack(InputAction.CallbackContext context)
    {

        Debug.Log("ATTACK PRESSED");

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