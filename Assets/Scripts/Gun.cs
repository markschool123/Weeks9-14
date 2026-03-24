using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int ammo;
    public int maxAmmo;     
    public UnityEvent OnFire;
    public bool isReloading;
    public float reloadTime = 3;
    void Start()
    {
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        ammo--;
        OnFire.Invoke();

        if (ammo==0)
        {
            StartCoroutine(Reloading());
        }
    }

    IEnumerator Reloading()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
       
        isReloading=false;
        ammo = maxAmmo;
    }

    
    public void OnShoot(InputAction.CallbackContext context)
    {

    }




}