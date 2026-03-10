using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Angularvelocity : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float anularSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, anularSpeed, 0);
        }
        else
        {
            rb.angularVelocity = new Vector3(0, 0, 0);
            //rb.angularVelocity.Normalize();
        }
    }
}
