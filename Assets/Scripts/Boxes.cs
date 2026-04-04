using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Boxes : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer box;
    public SpriteRenderer box1;
    public SpriteRenderer box2;
    public SpriteRenderer box3;
    public SpriteRenderer player;
    public bool hit = false;
    public Gun gun;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (player.bounds.Intersects(box.bounds) || player.bounds.Intersects(box1.bounds) || player.bounds.Intersects(box2.bounds) || player.bounds.Intersects(box3.bounds))
        {
            if (!hit)
            {
                hit = true;
                gun.ammo += 1;
            }
        }








    }
}
