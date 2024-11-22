using UnityEngine;

public class RecogerCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(collision.gameObject, 0.5f);
        }
    }
}
