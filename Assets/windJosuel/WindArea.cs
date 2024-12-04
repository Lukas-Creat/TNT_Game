using UnityEngine;

public class WindArea : MonoBehaviour
{
    public Vector2 windForce; // Dire��o e for�a do vento

    private void OnTriggerStay2D(Collider2D other)
    {
        // Verifica se o objeto tem um Rigidbody2D para aplicar a for�a
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb != null && other.CompareTag("Player"))
        {
            // Aplica a for�a do vento ao Rigidbody2D
            rb.AddForce(windForce, ForceMode2D.Force);
        }
    }
}
