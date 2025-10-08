using UnityEngine;

public class StopCage : MonoBehaviour
{
    public float stopY = 0f;    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (transform.position.y <= stopY)
        {
            rb.isKinematic = true;      
            rb.linearVelocity = Vector3.zero; 
            rb.angularVelocity = Vector3.zero;
        }
    }
}

