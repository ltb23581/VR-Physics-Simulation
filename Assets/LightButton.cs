using UnityEngine;

public class LightButton : MonoBehaviour
{
    public Light targetLight;

    void OnTriggerEnter(Collider other)
    {
        targetLight.intensity = 10f; 
    }
}
