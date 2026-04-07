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
    public Vector2 movement;
    public float speed = 5;

    void Start()
    {
        //fill up the ammo at the start
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        //make the player rotate with the mouse for aiming
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos.z = 0;
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;

        //move the player through input
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }
    //player moves when WASD is pressed
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    //called by player when the mouse is clicked
    public void OnAttack(InputAction.CallbackContext context)
    {
       

        if (context.performed)
        {
         

            Shoot();
        }


    }


    public void Shoot()
    {   //only shoot if youre not reloading and ammo is in the chamber
        if (!isReloading && ammo > 0)
        {
            isShooting = true;
            ammo--;
            //invoke the event, this spawns the bullet
            onFire.Invoke();    
            Debug.Log("FIRE!");

            //start the reload coroutine when the mag is empty
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
    {   //blocks the shooting when reloading
        isReloading = true;
        // wait for the reload time to complete.
        yield return new WaitForSeconds(reloadTime);
       //refill ammo to begin shooting again
        isReloading=false;
        ammo = maxAmmo;
    }

    
   




}