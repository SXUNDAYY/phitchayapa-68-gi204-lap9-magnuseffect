using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Torque : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float torqueSpeed;
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
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(Vector3.right*torqueSpeed);
        }
        /*else
        {
            rb.angularVelocity = new Vector3(0, 0, 0);
            //rb.angularVelocity.Normalize();
        }*/
    }
}
