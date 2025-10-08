using UnityEngine;

public class DropCage : MonoBehaviour
{
    public Rigidbody cage; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))  
        {
            cage.isKinematic = false; 
        }
    }
}
