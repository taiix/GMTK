using UnityEngine;

public class CollectingController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NanoPickup"))
        {
            Destroy(collision.gameObject);
        }
    }
}
