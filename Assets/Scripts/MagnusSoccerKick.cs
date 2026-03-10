using UnityEngine;

public class MagnusSoccerKick : MonoBehaviour
{
    [SerializeField] float kickForce;
    [SerializeField] float spinAmount;
    [SerializeField] float magnusStrenght = 0.5f;

    Rigidbody rb;
    bool isShot = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
