using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Boxes : MonoBehaviour
{


    //references each box sprite renderer for collisions. Unity event for ammo and speed boost
    public SpriteRenderer box;
    public SpriteRenderer box1;
    public SpriteRenderer box2;
    public SpriteRenderer box3;
    public SpriteRenderer player;
    public Gun gun;
    public UnityEvent onPickup;
    public UnityEvent onSpeedPickup;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        // check if the player is touching the box, invoke the event. null makes sure that the other boxes can be picked up as well.
       if (box != null && player.bounds.Intersects(box.bounds))
        {
            onPickup.Invoke();
            Destroy(box.gameObject);
            
  
        }
        if (box1 != null && player.bounds.Intersects(box1.bounds))
        {
            onSpeedPickup.Invoke();
            Destroy(box1.gameObject);

        }
        if (box2 != null && player.bounds.Intersects(box2.bounds))
        {
            onPickup.Invoke();
            Destroy(box2.gameObject);

        }
        if (box3 != null &&  player.bounds.Intersects(box3.bounds))
        {
            onSpeedPickup.Invoke();
            Destroy(box3.gameObject);

        }






    }
    public void AmmoReload()
    {
        gun.ammo += 1;
        
    }

    public void SpeedBoost()
    {
        gun.speed += 1; ;
    }
}
