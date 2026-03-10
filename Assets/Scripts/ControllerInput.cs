using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5;
    public Vector2 movement;
    public SpriteRenderer sprite;
    public Sprite[] sprites;



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
        movement = context.ReadValue<Vector2>();
    }
     public void OnPoint(InputAction.CallbackContext context)
    {
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }

    public void ChangeSprite()
    {
        
    }

}

