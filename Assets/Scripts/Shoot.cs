using UnityEngine;

public class Shoot : MonoBehaviour
{
    float speed = 5f;
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the bullet in the opposite direction facing up
        transform.position += -transform.up * speed * Time.deltaTime;
        //delete the bullet after 4 seconds
        Destroy(bulletPrefab, 4f);

    }
}
