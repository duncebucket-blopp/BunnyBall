using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody rb;

    private void start()
    {
        rb.useGravity = false;
    } 

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.useGravity = false;
            Debug.Log("Collided with Player");
        }
    }

}
