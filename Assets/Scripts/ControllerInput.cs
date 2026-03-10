using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5;
    public Vector2 movement;
    public AudioSource sfx;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = movement;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        context.ReadValue<Vector2>(); 
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        Debug.Log("hi" + context.phase);
        if (context.performed==true)
        {
            sfx.Play();
        }
        
        
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    } 
        

}
