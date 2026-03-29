using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject effect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, transform.rotation); // effect
            Destroy(gameObject);
        }
    }
}