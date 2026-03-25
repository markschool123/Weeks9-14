using UnityEngine;

public class Knight : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource SFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FootStep()
    {
        Debug.Log("Step");
        SFX.Play();
    }
}
